using Core.Models;

namespace Core.Contracts
{
    public interface IRestaurantTableRepository : IGenericRepository<RestaurantTable>
    {
        Task<IEnumerable<RestaurantTable>> GetByRestaurant(int restaurantId);

        Task<IEnumerable<RestaurantTable>> GetByRestaurantAndTableSize(int restaurantId, int seatPlaces);
    }
}
