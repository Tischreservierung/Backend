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
            return await _dbSet.Where(r => r.CustomerId == customerId).Select(x => new ReservationDto()
            {
                CustomerId = x.CustomerId,
                RestaurantId = x.RestaurantId,
                Day = x.ReservationDay,
                StartTime = x.StartTime.ToDateTime(),
                EndTime = x.EndTime.ToDateTime(),
                RestaurantTableId = x.RestaurantTableId,
                CustomerName = x.Customer!.Name,
                RestaurantName = x.Restaurant!.Name,
                Persons = x.RestaurantTable!.SeatPlaces
            }).ToListAsync();
        }

        public async Task<IEnumerable<ReservationDto>> GetByRestaurant(int restaurantId)
        {
            return await _dbSet.Where(r => r.RestaurantId == restaurantId).Select(x => new ReservationDto()
            {
                CustomerId = x.CustomerId,
                RestaurantId = x.RestaurantId,
                Day = x.ReservationDay,
                StartTime = x.StartTime.ToDateTime(),
                EndTime = x.EndTime.ToDateTime(),
                RestaurantTableId = x.RestaurantTableId,
                CustomerName = x.Customer!.Name,
                RestaurantName = x.Restaurant!.Name,
                Persons = x.RestaurantTable!.SeatPlaces
            }).ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByRestaurantAndDay(int restaurantId, DateTime day)
        {
            return await _dbSet.Where(r => r.RestaurantId == restaurantId && r.ReservationDay == day).ToListAsync();
        }
    }
}
