﻿using Core.Dto;
using Core.Models;

namespace Core.Contracts
{
    public interface IReservationService
    {
        public Task<Reservation?> CreateReservationManually(ReservationManualDto manualReservation, int restaurantId);
        public Task<Reservation?> RequestReservation(ReservationRequestDto request, int customerId);

        public Task<IEnumerable<ReservationOptionDto>> GetReservationOptions(int restaurantId, DateTime day, TimeSpan from, TimeSpan to, int seatPlaces, int duration);
    }
}
