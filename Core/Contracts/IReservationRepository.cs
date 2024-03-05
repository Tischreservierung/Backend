using Core.Dto;
using Core.Models;

namespace Core.Contracts
{
    public interface IReservationRepository : IGenericRepository<Reservation>
    {
        Task<IEnumerable<ReservationDto>> GetByCustomer(int customerId);
        Task<IEnumerable<Reservation>> GetByCustomerAndDay(int customerId, DateTime day);
        Task<IEnumerable<ReservationDto>> GetByRestaurant(int restaurantId);
        Task<IEnumerable<Reservation>> GetByRestaurantAndDay(int restaurantId, DateTime day);
        Task<IEnumerable<Reservation>> GetByRestaurantTable(int restaurantTableId);

        Task<bool> RestaurantTableHasReservation(int restaurantTableId);

        Task CancelReservation(int reservation_id);
    }
}
