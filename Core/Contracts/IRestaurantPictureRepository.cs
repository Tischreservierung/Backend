using Core.Models;

namespace Core.Contracts
{
    public interface IRestaurantPictureRepository : IGenericRepository<RestaurantPicture>
    {
        Task<List<RestaurantPicture>> GetPicturesByRestaurantId(int restaurantId);
        Task<RestaurantPicture?> GetFirstPictureByRestaurantId(int restaurantId);

        void PostPicture(RestaurantPicture pic);
        int CountPicture(int restaurantId);
    }
}
