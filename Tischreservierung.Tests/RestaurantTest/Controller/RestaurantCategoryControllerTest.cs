using Microsoft.AspNetCore.Mvc;
using Moq;
using Tischreservierung.Controllers;
using Core.Models;
using Core.Contracts;
using Microsoft.AspNetCore.Http;

namespace Tischreservierung.Tests.RestaurantTest.Controller
{
    public class RestaurantCategoryControllerTest
    {
        [Fact]
        public async Task GetRestaurantCategories()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.RestaurantCategories.GetAll()).ReturnsAsync(GetRestaurantCategoryTestData());
            var restaurantCategoryController = new RestaurantCategoriesController(uow.Object);

            var actionResult = await restaurantCategoryController.GetRestaurantCategories();

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(3, ((List<Category>)result.Value!).Count);

            uow.Verify(x => x.RestaurantCategories.GetAll());
            uow.VerifyNoOtherCalls();
        }

        private static List<Category> GetRestaurantCategoryTestData()
        {
            List<Category> restaurantCategories = new()
            {
                new Category() { Id = 1, Name = "Pizza" },
                new Category() { Id = 2, Name = "Pommes" },
                new Category() { Id = 3, Name = "Ita" }
            };
            return restaurantCategories;
        }
    }
}
