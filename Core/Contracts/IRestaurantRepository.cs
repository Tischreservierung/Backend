using Core.Dto;
using Core.DTO;
using Core.Models;

namespace Core.Contracts
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        Task<IEnumerable<Restaurant>> GetRestaurantsByName(string name, int zipCodeId, DateTime? dateTime);
        Task<IEnumerable<Restaurant>> GetRestaurantsByCategories(int[] categories, int zipCodeId, DateTime? dateTime);
        Task<RestaurantViewDto?> GetRestaurantForViewById(int id);
        Task<ReservationViewDto?> GetReservationViewById(int id);
        Task<int> GetRestaurantIdByEmployee(int employeeId);
    }
}
