using Core.Contracts;
using Core.Dto;
using Core.Models;
using Core.Util;

namespace WebApi.Services
{
    public class ReservationService : IReservationService
    {
        const int reservationDuration = 90;
        const int reservationTimeOffset = 15;

        private readonly IUnitOfWork _unitOfWork;

        public ReservationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Reservation?> RequestReservation(ReservationRequestDto request, int customerId)
        {
            TimeSpan endTime = request.Time + TimeSpan.FromMinutes(reservationDuration);

            RestaurantTable? freeTable = await GetFreeRestaurantTable(request.RestaurantId, request.NumberOfPersons, request.Day, request.Time, endTime);

            if (freeTable == null)
            {
                return null;
            }

            Reservation reservation = new()
            {
                ReservationDay = request.Day,
                StartTime = request.Time,
                EndTime = endTime,
                CustomerId = customerId,
                RestaurantTableId = freeTable.Id
            };

            _unitOfWork.Reservations.Insert(reservation);
            await _unitOfWork.SaveChangesAsync();

            return reservation;
        }

        public async Task<IEnumerable<ReservationOptionDto>> GetReservationOptions(int restaurantId, int customerId, DateTime day, TimeSpan from, TimeSpan to, int seatPlaces)
        {
            List<ReservationOptionDto> reservationOptions = new();

            var openingTimes = await _unitOfWork.OpeningTimes.GetByDayAndRestaurant(restaurantId, day.DayOfWeek);

            foreach (var openingTime in openingTimes)
            {
                int closingTime = openingTime.ClosingTime.TotalMinutes();
                int searchToTime = Math.Min(closingTime, to.TotalMinutes());

                int currentStartTime = openingTime.OpeningTime.TotalMinutes();
                currentStartTime = Math.Max(currentStartTime, from.TotalMinutes());

                if (currentStartTime % reservationTimeOffset != 0)
                {
                    currentStartTime += reservationTimeOffset - currentStartTime % reservationTimeOffset;
                }

                while (currentStartTime + reservationDuration <= searchToTime)
                {
                    TimeSpan startTime = TimeSpan.FromMinutes(currentStartTime);
                    TimeSpan endTime = TimeSpan.FromMinutes(currentStartTime + reservationDuration);

                    RestaurantTable? freeTable = await GetFreeRestaurantTable(restaurantId, seatPlaces, day, startTime, endTime);

                    if (freeTable != null)
                    {
                        reservationOptions.Add(new ReservationOptionDto()
                        {
                            Day = day,
                            StartTime = startTime,
                            EndTime = endTime,
                            Duration = reservationDuration,
                            RestaurantTableId = freeTable.Id,
                            SeatPlaces = freeTable.SeatPlaces
                        });
                    }

                    currentStartTime += reservationTimeOffset;
                }
            }

            return reservationOptions;
        }

        private async Task<RestaurantTable?> GetFreeRestaurantTable(int restaurantId, int seatPlaces, DateTime day, TimeSpan startTime, TimeSpan endTime)
        {
            var restaurantTables = await _unitOfWork.RestaurantTables.GetByRestaurantAndTableSize(restaurantId, seatPlaces);
            var reservations = await _unitOfWork.Reservations.GetByRestaurantAndDay(restaurantId, day);

            return restaurantTables
                .FirstOrDefault(t => reservations
                    .All(r => !ReservationTimeIntersects(r, startTime, endTime)));
        }

        private static bool ReservationTimeIntersects(Reservation reservation, TimeSpan start, TimeSpan end)
        {
            return reservation.StartTime < start && reservation.EndTime > start ||
                        reservation.StartTime < end && reservation.EndTime > end ||
                        reservation.StartTime >= start && reservation.EndTime <= end;
        }
    }
}
