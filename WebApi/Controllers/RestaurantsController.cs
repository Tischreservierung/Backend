using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Core.Contracts;
using Core.Dto;

namespace Tischreservierung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRestaurantService _restaurantService;

        public RestaurantsController(IUnitOfWork unitOfWork, IRestaurantService restaurantService)
        {
            _unitOfWork = unitOfWork;
            _restaurantService = restaurantService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestaurants()
        {
            var restaurants = await _unitOfWork.Restaurants.GetAll();

            return Ok(restaurants);
        }

        [HttpGet("name")]
        public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestauntsByName(string name, DateTime? dateTime, int zipCodeId = -1)
        {
            var restaurants = await _unitOfWork.Restaurants.GetRestaurantsByName(name, zipCodeId, dateTime);
            return Ok(restaurants);
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestauntsByCategories
            ([FromQuery] int[] categories, DateTime? dateTime, int zipCodeId = -1)
        {
            var restaurants = await _unitOfWork.Restaurants.GetRestaurantsByCategories(categories, zipCodeId, dateTime);
            return Ok(restaurants);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
        {
            var restaurant = await _unitOfWork.Restaurants.GetById(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            return Ok(restaurant);
        }

        [HttpPost]
        public async Task<ActionResult<Restaurant>> PostRestaurant([FromBody] RestaurantPostDto dto)
        {
            Restaurant restaurant = await _restaurantService.CreateRestaurant(dto);

            await _unitOfWork.SaveChangesAsync();
            return Ok(restaurant.Id);
        }

        [HttpPut]
        public async Task<ActionResult<Restaurant>> UpdateRestaurant([FromBody] RestaurantUpdateDto dto) {
            Restaurant? restaurant = await _restaurantService.UpdateRestaurant(dto);

            if (restaurant == null)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRestaurant(int id)
        {
            var restaurant = await _unitOfWork.Restaurants.GetById(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            _unitOfWork.Restaurants.Delete(restaurant);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("restaurantview/{id}")]
        public async Task<ActionResult<RestaurantViewDto?>> GetRestaurantForView(int id)
        {
            return Ok(await _unitOfWork.Restaurants.GetRestaurantForViewById(id));
        }

        [HttpGet("reservationview/{id}")]
        public async Task<ActionResult<RestaurantViewDto?>> GetReservationView(int id)
        {
            return Ok(await _unitOfWork.Restaurants.GetReservationViewById(id));
        }
    }
}