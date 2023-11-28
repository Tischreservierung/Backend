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
                .Include(r => r.Customer)
                .Select(x => ReservationToDto(x))
                .ToListAsync();
        }

        public async Task<IEnumerable<ReservationDto>> GetByRestaurant(int restaurantId)
        {
            return await _dbSet.Where(r => r.RestaurantTable!.RestaurantId == restaurantId)
                .Include(r => r.RestaurantTable!.Restaurant)
                .Include(r => r.Customer)
                .Select(x => ReservationToDto(x))
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
                CustomerName = reservation.Customer!.Name,
                RestaurantName = reservation.RestaurantTable.Restaurant!.Name,
                Persons = reservation.RestaurantTable!.SeatPlaces
            };
        }
    }
}
