using Microsoft.EntityFrameworkCore;
using Core.Models;
using Core.Contracts;

namespace Persistence.Data.Repositories
{
    public class RestaurantTableRepository : GenericRepository<RestaurantTable>, IRestaurantTableRepository
    {
        public RestaurantTableRepository(OnlineReservationContext context) : base(context)
        {

        }

        public async Task<IEnumerable<RestaurantTable>> GetByRestaurant(int restaurantId)
        {
            return await _dbSet.Where(t => t.RestaurantId == restaurantId).ToListAsync();
        }

        public async Task<IEnumerable<RestaurantTable>> GetByRestaurantAndTableSize(int restaurantId, int seatPlaces)
        {
            return await _dbSet.Where(t => t.RestaurantId == restaurantId && t.SeatPlaces >= seatPlaces).ToListAsync();
        }
    }
}
