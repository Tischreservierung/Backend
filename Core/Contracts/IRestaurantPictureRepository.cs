using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IRestaurantPictureRepository
    {
        Task<List<RestaurantPicture>> GetPicturesByRestaurantId(int restaurantId);
        Task<RestaurantPicture?> GetFirstPictureByRestaurantId(int restaurantId);

        void PostPicture(RestaurantPicture pic);
        int CountPicture(int restaurantId);
    }
}
