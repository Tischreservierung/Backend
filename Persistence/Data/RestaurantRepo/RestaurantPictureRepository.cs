using Core.Contracts;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.RestaurantRepo
{
    internal class RestaurantPictureRepository : GenericRepository<RestaurantPicture>, IRestaurantPictureRepository
    {
        public RestaurantPictureRepository(OnlineReservationContext context) : base(context)
        { 
        
        }

        public int CountPicture(int restaurantId)
        {
            return _dbSet.Count(x => x.RestaurantId == restaurantId);
        }

        public async Task<RestaurantPicture?> GetFirstPictureByRestaurantId(int restaurantId)
        {
            return await _dbSet.Where(x => x.RestaurantId == restaurantId && x.Index == 0).FirstOrDefaultAsync();
        }

        public async Task<List<RestaurantPicture>> GetPicturesByRestaurantId(int restaurantId)
        {
            return await _dbSet.Where(x => x.RestaurantId == restaurantId).ToListAsync();
        }

        public void PostPicture(RestaurantPicture pic)
        {
            _dbSet.Add(pic);
        }
    }
}
