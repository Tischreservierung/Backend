using Microsoft.EntityFrameworkCore;
using Core.Models;
using Core.Contracts;

namespace Persistence.Data.Repositories
{
    public class OpeningTimeRepository : GenericRepository<RestaurantOpeningTime>, IOpeningTimeRepository
    {
        public OpeningTimeRepository(OnlineReservationContext context) : base(context)
        {

        }

        public async Task<IEnumerable<RestaurantOpeningTime>> GetByDay(DayOfWeek day)
        {
            return await _dbSet.Where(oT => oT.Day == day).ToListAsync();
        }

        public async Task<IEnumerable<RestaurantOpeningTime>> GetByDayAndRestaurant(int id, DayOfWeek day)
        {
            return await _dbSet.Where(oT => (((int)oT.Day) + 1) % 7 == ((int)day) && oT.RestaurantId == id).ToListAsync();
        }

        public async Task<IEnumerable<RestaurantOpeningTime>> GetByRestaurant(int id)
        {
            return await _dbSet.Where(oT => oT.RestaurantId == id).ToListAsync();
        }
    }
}
