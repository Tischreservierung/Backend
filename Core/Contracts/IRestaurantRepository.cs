using Core.Dto;
using Core.Models;

namespace Core.Contracts
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        Task<IEnumerable<RestaurantDto>> GetRestaurantsByName(string name, int zipCodeId, DateTime? dateTime);
        Task<IEnumerable<RestaurantDto>> GetRestaurantsByCategories(int[] categories, int zipCodeId, DateTime? dateTime);

        Task<RestaurantViewDto?> GetRestaurantForViewById(int id);

        Task<ReservationViewDto?> GetReservationViewById(int id);

        Task<int> GetRestaurantIdByEmployee(int employeeId);
        void AddCategories(int id, List<int> categories);
        Task<RestaurantEditDto?> GetFull(int restaurantId);
        Task<RestaurantUpdateDto?> GetBasicDataOfRestaurant(int id);
        Task<IEnumerable<Category>> GetCategoriesOfRestaurant(int restaurantId);
        void UpdateCategories(List<Category> categories, int restaurantId);
        Task<IEnumerable<RestaurantPicture>> GetPicturesOfRestaurant(int restaurantId);
        void UpdatePictures(List<RestaurantPicture> pictures, int restaurantId);
    }
}
