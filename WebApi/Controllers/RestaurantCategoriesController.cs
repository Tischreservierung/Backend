using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Core.Contracts;
using Core.Dto;

namespace Tischreservierung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantCategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RestaurantCategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetRestaurantCategories()
        {
            IEnumerable<Category> categories = await _unitOfWork.RestaurantCategories.GetAll();

            IEnumerable<CategoryDto> categoryDtos = categories.Select(x => new CategoryDto()
            {
                Name = x.Name,
                Id = x.Id
            });

            return Ok(categoryDtos);
        }
    }
}
