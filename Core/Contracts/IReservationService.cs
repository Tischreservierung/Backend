using Core.DTO;
using Core.Models;

namespace Core.Contracts
{
    public interface IReservationService
    {
        public Task<Reservation?> RequestReservation(ReservationRequestDto request);

        public Task<IEnumerable<ReservationOptionDto>> GetReservationOptions(int restaurantId, DateTime day, TimeSpan from, TimeSpan to, int seatPlaces, int duration);
    }
}
