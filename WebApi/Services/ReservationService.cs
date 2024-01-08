using Azure.Core;
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
            TimeSpan endTime = request.Day.TimeOfDay + TimeSpan.FromMinutes(request.Duration);

            RestaurantTable? freeTable = await GetFreeRestaurantTable(request.RestaurantId,
                request.NumberOfPersons, request.Day, request.Day.TimeOfDay, endTime, request.CustomerId);

            if (freeTable == null)
            {
                return null;
            }

            Reservation reservation = new()
            {
                ReservationDay = request.Day,
                StartTime = request.Day.TimeOfDay,
                EndTime = endTime,
                CustomerId = customerId,
                RestaurantTableId = freeTable.Id,
                Persons = request.NumberOfPersons
            };

            _unitOfWork.Reservations.Insert(reservation);
            await _unitOfWork.SaveChangesAsync();

            return reservation;
        }

        public async Task<IEnumerable<ReservationOptionDto>> GetReservationOptions(int restaurantId,int customerId, DateTime day, TimeSpan from, TimeSpan to, int seatPlaces, int duration)
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

                while (currentStartTime + duration <= searchToTime)
                {
                    TimeSpan startTime = TimeSpan.FromMinutes(currentStartTime);
                    TimeSpan endTime = TimeSpan.FromMinutes(currentStartTime + duration);

                    RestaurantTable? freeTable = await GetFreeRestaurantTable(restaurantId, seatPlaces, day, startTime, endTime, customerId);

                    if (freeTable != null)
                    {
                        reservationOptions.Add(new ReservationOptionDto()
                        {
                            Day = day,
                            StartTime = startTime,
                            EndTime = endTime,
                            Duration = duration,
                            RestaurantTableId = freeTable.Id,
                            SeatPlaces = freeTable.SeatPlaces
                        });
                    }

                    currentStartTime += reservationTimeOffset;
                }
            }

            return reservationOptions;
        }

        private async Task<RestaurantTable?> GetFreeRestaurantTable(int restaurantId, int seatPlaces, DateTime day, TimeSpan startTime, TimeSpan endTime, int customerId)
        {
            var restaurantTables = await _unitOfWork.RestaurantTables.GetByRestaurantAndTableSize(restaurantId, seatPlaces);
            var reservations = await _unitOfWork.Reservations.GetByRestaurantAndDay(restaurantId, day);
            var customerReservations = await _unitOfWork.Reservations.GetByCustomerAndDay(customerId,day);

            if (customerReservations.Any(r => ReservationTimeIntersects(r, startTime, endTime)))
                return null;

            return restaurantTables
                .Where(t => reservations.Where(r => t.Id == r.RestaurantTableId)
                    .All(r => !ReservationTimeIntersects(r, startTime, endTime))).FirstOrDefault();
        }

        private static bool ReservationTimeIntersects(Reservation reservation, TimeSpan start, TimeSpan end)
        {
            return (reservation.StartTime < start && reservation.EndTime > start) ||
                        (reservation.StartTime < end && reservation.EndTime > end) ||
                        (reservation.StartTime >= start && reservation.EndTime <= end);
        }

        public async Task<Reservation?> CreateReservationManually(ReservationManualDto manualReservation)
        {
            TimeSpan endTime = manualReservation.Time + TimeSpan.FromMinutes(reservationDuration);
            RestaurantTable? freeTable = await GetFreeRestaurantTable(manualReservation.RestaurantId, manualReservation.NumberOfPersons, manualReservation.Day, manualReservation.Time, endTime);

            if (freeTable == null)
            {
                return null;
            }

            User user = new()
            {
                UserName = manualReservation.UserName
            };

            _unitOfWork.Users.Insert(user);
            await _unitOfWork.SaveChangesAsync();

            Reservation reservation = new()
            {
                ReservationDay = manualReservation.Day,
                StartTime = manualReservation.Time,
                EndTime = endTime,
                CustomerId = user.Id,
                RestaurantTableId = freeTable.Id
            };

            _unitOfWork.Reservations.Insert(reservation);
            await _unitOfWork.SaveChangesAsync();

            return reservation;
        }
    }
}
