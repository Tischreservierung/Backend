using Core.Contracts;
using Core.Dto;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Core.Util;

namespace Persistence.Data
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(OnlineReservationContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ReservationDto>> GetByCustomer(int customerId)
        {
            return await _dbSet.Where(r => r.CustomerId == customerId)
                .Include(r => r.RestaurantTable!.Restaurant)
                .Select(r => new ReservationDto()
                {
                    CustomerId = r.CustomerId,
                    RestaurantId = r.RestaurantTable!.RestaurantId,
                    Day = r.ReservationDay,
                    StartTime = r.StartTime.ToDateTime(),
                    EndTime = r.EndTime.ToDateTime(),
                    RestaurantTableId = r.RestaurantTableId,
                    RestaurantName = r.RestaurantTable.Restaurant!.Name,
                    Persons = r.Persons
                }).OrderBy(r => r.Day.Date)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByCustomerAndDay(int customerId, DateTime day)
        {
            return await _dbSet.Where(r => r.CustomerId == customerId && r.ReservationDay.Date == day.Date).ToListAsync();
        }

        public async Task<IEnumerable<ReservationDto>> GetByRestaurant(int restaurantId)
        {
            return await _dbSet.Where(r => r.RestaurantTable!.RestaurantId == restaurantId)
                .Include(r => r.RestaurantTable!.Restaurant)
                .Select(r => new ReservationDto()
                {
                    CustomerId = r.CustomerId,
                    RestaurantId = r.RestaurantTable!.RestaurantId,
                    Day = r.ReservationDay,
                    StartTime = r.StartTime.ToDateTime(),
                    EndTime = r.EndTime.ToDateTime(),
                    RestaurantTableId = r.RestaurantTableId,
                    RestaurantName = r.RestaurantTable.Restaurant!.Name,
                    Persons = r.RestaurantTable!.SeatPlaces
                }). OrderBy(r => r.Day.Date.Day).ThenBy(r => r.StartTime.TimeOfDay)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByRestaurantAndDay(int restaurantId, DateTime day)
        {
            return await _dbSet.Where(r => r.RestaurantTable!.RestaurantId == restaurantId && r.ReservationDay == day).ToListAsync();
        }

        private static ReservationDto ReservationToDto(Reservation reservation)
        {
            return new ReservationDto()
            {
                CustomerId = reservation.CustomerId,
                RestaurantId = reservation.RestaurantTable!.RestaurantId,
                Day = reservation.ReservationDay,
                StartTime = reservation.StartTime.ToDateTime(),
                EndTime = reservation.EndTime.ToDateTime(),
                RestaurantTableId = reservation.RestaurantTableId,
                RestaurantName = reservation.RestaurantTable.Restaurant!.Name,
                Persons = reservation.RestaurantTable!.SeatPlaces
            };
        }
    }
}
