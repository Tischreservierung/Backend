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
        private readonly IUserAuthenticationService _authenticationService;

        public ReservationsController(IUnitOfWork unitOfWork, IReservationService reservationService, IUserAuthenticationService userAuthenticationService)
        {
            _unitOfWork = unitOfWork;
            _reservationService = reservationService;
            _authenticationService = userAuthenticationService;
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


        [Authorize]
        [HttpGet("customer")]
        public async Task<ActionResult<IEnumerable<ReservationDto>>> GetReservationsByCustomer()
        {
            Claim? claim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (claim == null)
            {
                return Unauthorized();
            }

            User user = await _authenticationService.GetAuthenticatedUser(claim);

            var reservations = await _unitOfWork.Reservations.GetByCustomer(user.Id);

            return Ok(reservations);
        }

        [Authorize]
        [HttpGet("restaurant")]
        public async Task<ActionResult<IEnumerable<ReservationDto>>> GetReservationsByRestaurant()
        {
            Claim? claim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (claim == null)
            {
                return Unauthorized();
            }

            User user = await _authenticationService.GetAuthenticatedUser(claim);

            int restaurantId = await _unitOfWork.Restaurants.GetRestaurantIdByEmployee(user.Id);

            if (restaurantId == 0)
            {
                return BadRequest();
            }

            var reservations = await _unitOfWork.Reservations.GetByRestaurant(restaurantId);

            return Ok(reservations);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Reservation>> RequestReservation([FromBody] ReservationRequestDto reservationRequest)
        {
            Claim? claim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (claim == null)
            {
                return Unauthorized();
            }

            User user = await _authenticationService.GetAuthenticatedUser(claim);

            Reservation? reservation = await _reservationService.RequestReservation(reservationRequest, user.Id);

            if (reservation == null)
            {
                return BadRequest();
            }

            return CreatedAtAction("GetReservation", new { id = reservation.Id }, reservation);
        }

        [HttpPost("manual")]
        public async Task<ActionResult<Reservation>> CreateReservationManually([FromBody] ReservationManualDto manualReservation)
        {
            Reservation? reservation = await _reservationService.CreateReservationManually(manualReservation);

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
                                                                                     queryParams.SeatPlaces,
                                                                                     queryParams.Duration);

            return Ok(reservationOptions);
        }

    }
}
