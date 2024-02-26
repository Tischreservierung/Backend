using Core.Contracts;
using Core.Dto;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Core.Util;

namespace Persistence.Data.Repositories
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
                    Persons = r.Persons,
                    SeatPlaces = r.RestaurantTable.SeatPlaces
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
                .Include(r => r.Customer)
                .Select(r => new ReservationDto()
                {
                    CustomerId = r.CustomerId,
                    RestaurantId = r.RestaurantTable!.RestaurantId,
                    Day = r.ReservationDay,
                    StartTime = r.StartTime.ToDateTime(),
                    EndTime = r.EndTime.ToDateTime(),
                    RestaurantTableId = r.RestaurantTableId,
                    CustomerName = r.Customer!.UserName,
                    Persons = r.Persons,
                    SeatPlaces = r.RestaurantTable.SeatPlaces
                }).OrderBy(r => r.Day.Date)
                .ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByRestaurantAndDay(int restaurantId, DateTime day)
        {
            return await _dbSet.Where(r => r.RestaurantTable!.RestaurantId == restaurantId && r.ReservationDay == day).ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByRestaurantTable(int restaurantTableId)
        {
            return await _dbSet.Where(r => r.RestaurantTableId == restaurantTableId).ToListAsync();
        }

        public async Task<bool> RestaurantTableHasReservation(int restaurantTableId)
        {
            return await _dbSet.Where(r => r.ReservationDay >= DateTime.Now).AnyAsync(r => r.RestaurantTableId == restaurantTableId);
        }
    }
}
