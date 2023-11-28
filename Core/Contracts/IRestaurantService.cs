using Core.Dto;
using Core.Models;
using Core.Paging;

namespace Core.Contracts
{
    public interface IRestaurantService
    {
        Task<Restaurant> CreateRestaurant(RestaurantPostDto dto);

        Task<Restaurant?> UpdateRestaurant(RestaurantUpdateDto dto);

        Task<PagedList<RestaurantViewDto>> GetRestaurants(string searchString, int seatPlaces, DateTime day, TimeSpan time, Category[] categories, ZipCode[] zipCodes);
    }
}
