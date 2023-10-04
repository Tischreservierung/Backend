using Core.DTO;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IReservationService
    {
        public Task<Reservation?> RequestReservation(ReservationRequestDto request);

        public Task<IEnumerable<ReservationOptionDto>> GetReservationOptions(int restaurantId, DateTime day, TimeSpan from, TimeSpan to, int seatPlaces);
    }
}
