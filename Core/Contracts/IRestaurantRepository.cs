using Core.DTO;
using Core.Models;

namespace Core.Contracts
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        Task<IEnumerable<RestaurantFilterDTO>> GetRestaurantsByName(string name, int zipCodeId, DateTime? dateTime);
        Task<IEnumerable<RestaurantFilterDTO>> GetRestaurantsByCategories(int[] categories, int zipCodeId, DateTime? dateTime);

        Task<Restaurant?> InsertRestaurantAsync(RestaurantPostDto restaurant);

        Task<RestaurantViewDto?> GetRestaurantForViewById(int id);
    }
}
