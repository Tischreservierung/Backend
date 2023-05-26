using Core.DTO;
using Core.Models;

namespace Core.Contracts
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        Task<IEnumerable<Restaurant>> GetRestaurantsByName(string name, int zipCodeId);
        Task<IEnumerable<Restaurant>> GetRestaurantsByCategories(int[] categories, int zipCodeId, int day);

        Task<Restaurant?> InsertRestaurantAsync(RestaurantPostDto restaurant);

        Task<RestaurantViewDto?> GetRestaurantForViewById(int id);
    }
}
