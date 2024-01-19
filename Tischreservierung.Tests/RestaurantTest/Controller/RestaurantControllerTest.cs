using Microsoft.AspNetCore.Mvc;
using Moq;
using Tischreservierung.Controllers;
using Core.Models;
using Core.Contracts;
using Microsoft.AspNetCore.Http;

namespace Tischreservierung.Tests.RestaurantTest.Controller
{
    public class RestaurantControllerTest
    {
        [Fact]
        public async Task GetAllRestaurants()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.Restaurants.GetAll()).ReturnsAsync(GetRestaurantTestData);
            var restaurantService = new Mock<IRestaurantService>();
            var authentication = new Mock<IUserAuthenticationService>();
            var controller = new RestaurantsController(uow.Object, restaurantService.Object, authentication.Object);

            var actionResult = await controller.GetRestaurants();

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(4, (result.Value as IEnumerable<Restaurant>)!.Count());

            uow.Verify(x => x.Restaurants.GetAll());
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task GetRestaurant()
        {
            int restaurantId = 10;
            Restaurant restaurant = new()
            {
                Id = restaurantId,
                Name = "R1"
            };

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.Restaurants.GetById(restaurantId)).ReturnsAsync(restaurant);
            var restaurantService = new Mock<IRestaurantService>();
            var authentication = new Mock<IUserAuthenticationService>();
            var controller = new RestaurantsController(uow.Object, restaurantService.Object, authentication.Object);

            var actionResult = await controller.GetRestaurant(restaurantId);

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(restaurant, result.Value);

            uow.Verify(x => x.Restaurants.GetById(restaurantId));
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task GetRestaurant_ReturnsNotFound()
        {
            int restaurant = 10;

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.Restaurants.GetById(restaurant)).ReturnsAsync((Restaurant?)null);
            var restaurantService = new Mock<IRestaurantService>();
            var authentication = new Mock<IUserAuthenticationService>();
            var controller = new RestaurantsController(uow.Object, restaurantService.Object, authentication.Object);

            var actionResult = await controller.GetRestaurant(restaurant);

            Assert.IsType<NotFoundResult>(actionResult.Result);
            var result = actionResult.Result as NotFoundResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status404NotFound, result!.StatusCode);

            uow.Verify(x => x.Restaurants.GetById(restaurant));
            uow.VerifyNoOtherCalls();
        }


        [Fact]
        public async Task DeleteRestaurant()
        {
            int restaurantId = 10;
            Restaurant restaurant = new()
            {
                Id = restaurantId,
                Name = "R1"
            };

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.Restaurants.GetById(restaurantId)).ReturnsAsync(restaurant);
            uow.Setup(x => x.Restaurants.Delete(It.IsAny<Restaurant>()));
            var restaurantService = new Mock<IRestaurantService>();
            var authentication = new Mock<IUserAuthenticationService>();
            var controller = new RestaurantsController(uow.Object, restaurantService.Object, authentication.Object);

            var actionResult = await controller.DeleteRestaurant(restaurantId);

            Assert.IsType<NoContentResult>(actionResult);
            var result = actionResult as NoContentResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status204NoContent, result!.StatusCode);

            uow.Verify(x => x.Restaurants.GetById(restaurantId));
            uow.Verify(x => x.Restaurants.Delete(It.IsAny<Restaurant>()));
            uow.Verify(x => x.SaveChangesAsync());
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task DeleteRestaurant_ReturnsNotFound()
        {
            int restaurantId = 10;

            var ouw = new Mock<IUnitOfWork>();
            ouw.Setup(x => x.Restaurants.GetById(restaurantId)).ReturnsAsync((Restaurant?)null);
            var restaurantService = new Mock<IRestaurantService>();
            var authentication = new Mock<IUserAuthenticationService>();
            var controller = new RestaurantsController(ouw.Object, restaurantService.Object, authentication.Object);

            var actionResult = await controller.DeleteRestaurant(restaurantId);

            var result = actionResult as NotFoundResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status404NotFound, result!.StatusCode);

            ouw.Verify(x => x.Restaurants.GetById(restaurantId));
            ouw.VerifyNoOtherCalls();
        }

        private static List<Restaurant> GetRestaurantTestData()
        {
            List<Restaurant> restaurants = new()
            {
                new Restaurant() { Id = 1, Name = "R1" },
                new Restaurant() { Id = 2, Name = "R2" },
                new Restaurant() { Id = 3, Name = "R3" },
                new Restaurant() { Id = 4, Name = "R4" }
            };
            return restaurants;
        }
    }
}