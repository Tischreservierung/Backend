using Core.Contracts;
using Core.Dto;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApi.QueryParams;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReservationService _reservationService;

        public ReservationsController(IUnitOfWork unitOfWork, IReservationService reservationService)
        {
            _unitOfWork = unitOfWork;
            _reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservation(int id)
        {
            var reservation = await _unitOfWork.Reservations.GetById(id);

            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }


        [HttpGet("customer/{customerId}")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservationsByCustomer(int customerId)
        {
            var reservations = await _unitOfWork.Reservations.GetByCustomer(customerId);

            return Ok(reservations);
        }

        [HttpGet("restaurant/{restaurantId}")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservationsByRestaurant(int restaurantId)
        {
            var reservations = await _unitOfWork.Reservations.GetByRestaurant(restaurantId);

            return Ok(reservations);
        }

        [HttpPost]
        public async Task<ActionResult<Reservation>> RequestReservation([FromBody] ReservationRequestDto reservationRequest)
        {
            Reservation? reservation = await _reservationService.RequestReservation(reservationRequest);

            if (reservation == null)
            {
                return BadRequest();
            }

            return CreatedAtAction("GetReservation", new { id = reservation.Id }, reservation);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await _unitOfWork.Reservations.GetById(id);
            if (reservation == null)
            {
                return NotFound();
            }

            _unitOfWork.Reservations.Delete(reservation);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("restaurant/{restaurantId}/options")]
        public async Task<ActionResult<IEnumerable<ReservationOptionDto>>> GetReservationOptions(int restaurantId, [FromQuery] ReservationOptionQueryParams queryParams)
        {
            var reservationOptions = await _reservationService.GetReservationOptions(restaurantId,
                                                                                     queryParams.Day.Date,
                                                                                     queryParams.From.TimeOfDay,
                                                                                     queryParams.To.TimeOfDay,
                                                                                     queryParams.SeatPlaces);

            return Ok(reservationOptions);
        }

    }
}
