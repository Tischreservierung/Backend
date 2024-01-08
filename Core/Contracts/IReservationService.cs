using Core.Dto; 
using Core.Models;

namespace Core.Contracts
{
    public interface IReservationService
    {
        public Task<Reservation?> CreateReservationManually(ReservationManualDto manualReservation);
        public Task<Reservation?> RequestReservation(ReservationRequestDto request, int customerId);

        public Task<IEnumerable<ReservationOptionDto>> GetReservationOptions(int restaurantId, int customerId, DateTime day, TimeSpan from, TimeSpan to, int seatPlaces);
    }
}
