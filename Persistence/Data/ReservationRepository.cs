using Core.Contracts;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(OnlineReservationContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Reservation>> GetByCustomer(int customerId)
        {
            return await _dbSet.Where(r => r.CustomerId == customerId).ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByCustomerAndDay(int customerId, DateTime day)
        {
            return await _dbSet.Where(r => r.CustomerId == customerId && r.ReservationDay.Date == day.Date).ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByRestaurant(int restaurantId)
        {
            return await _dbSet.Where(r => r.RestaurantId == restaurantId).ToListAsync();
        }

        public async Task<IEnumerable<Reservation>> GetByRestaurantAndDay(int restaurantId, DateTime day)
        {
            return await _dbSet.Where(r => r.RestaurantId == restaurantId && r.ReservationDay.Date == day.Date).ToListAsync();
        }
    }
}
