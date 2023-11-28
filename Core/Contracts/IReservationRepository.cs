using Core.Models;

namespace Core.Contracts
{
    public interface IReservationRepository : IGenericRepository<Reservation>
    {
        Task<IEnumerable<Reservation>> GetByCustomer(int customerId);
        Task<IEnumerable<Reservation>> GetByCustomerAndDay(int customerId, DateTime day);
        Task<IEnumerable<Reservation>> GetByRestaurant(int restaurantId);
        Task<IEnumerable<Reservation>> GetByRestaurantAndDay(int restaurantId, DateTime day);
    }
}
