using Core.DTO;
using Core.Models;

namespace Core.Contracts
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<Restaurant>> GetRestaurants();
        Task<Restaurant?> GetRestaurantById(int id);
        Task<IEnumerable<Restaurant>> GetRestaurantsByName(string name, int zipCodeId);
        Task<IEnumerable<Restaurant>> GetRestaurantsByCategories(int[] categories, int zipCodeId);

        Task<Restaurant> InsertRestaurantAsync(DTO_RestaurantPost restaurant);
        void DeleteRestaurant(Restaurant restaurant);
        void UpdateRestaurant(Restaurant restaurant);
        Task Save();
    }
}
