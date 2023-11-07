using Microsoft.AspNetCore.Mvc;
using Moq;
using Tischreservierung.Controllers;
using Core.Models;
using Core.Contracts;
using Microsoft.AspNetCore.Http;

namespace Tischreservierung.Tests.RestaurantTest.Controller
{
    public class OpeningTimeControllerTest
    {
        [Fact]
        public async Task GetOpeningTimesForRestaurant()
        {
            List<RestaurantOpeningTime> times = OpeningTimeTestData();

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.GetByRestaurant(1)).ReturnsAsync(new List<RestaurantOpeningTime>() { times[0], times[1], times[4], times[5] });
            var openingTimeController = new RestaurantOpeningTimesController(uow.Object);

            var actionResult = await openingTimeController.GetRestaurantOpeningTimeForRestaurant(1);

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(4, ((List<RestaurantOpeningTime>)result.Value!).Count);


            uow.Verify(x => x.OpeningTimes.GetByRestaurant(It.IsAny<int>()));
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task GetOpeningTimesForDay()
        {
            List<RestaurantOpeningTime> times = OpeningTimeTestData();

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.GetByDay(DayOfWeek.Thursday)).ReturnsAsync(new List<RestaurantOpeningTime>() { times[4], times[5] });
            var openingTimeController = new RestaurantOpeningTimesController(uow.Object);

            var actionResult = await openingTimeController.GetRestaurantOpeningTimeForDay(4);

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(2, ((List<RestaurantOpeningTime>)result.Value!).Count);


            uow.Verify(x => x.OpeningTimes.GetByDay(It.IsAny<DayOfWeek>()));
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task GetOpeningTimesForRestaurantAndDay()
        {
            List<RestaurantOpeningTime> times = OpeningTimeTestData();

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.GetByDayAndRestaurant(1, DayOfWeek.Thursday)).ReturnsAsync(new List<RestaurantOpeningTime>() { times[4], times[5] });
            var openingTimeController = new RestaurantOpeningTimesController(uow.Object);

            var actionResult = await openingTimeController.GetRestaurantOpeningTimeForRestaurantAndDay(1, 4);

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(2, ((List<RestaurantOpeningTime>)result.Value!).Count);


            uow.Verify(x => x.OpeningTimes.GetByDayAndRestaurant(It.IsAny<int>(), It.IsAny<DayOfWeek>()));
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task PostOpeningTime()
        {
            RestaurantOpeningTime openingTime = new()
            {
                Day = DayOfWeek.Monday,
                ClosingTime = new TimeSpan(18, 0, 0),
                OpeningTime = new TimeSpan(10, 0, 0),
                RestaurantId = 1
            };

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.Insert(openingTime));
            var openingTimeController = new RestaurantOpeningTimesController(uow.Object);

            var actionResult = await openingTimeController.PostRestaurantOpeningTime(openingTime);

            Assert.IsType<CreatedAtActionResult>(actionResult.Result);
            var result = actionResult.Result as CreatedAtActionResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status201Created, result!.StatusCode);
            Assert.Equal(openingTime, result.Value as RestaurantOpeningTime);

            uow.Verify(x => x.OpeningTimes.Insert(openingTime));
            uow.Verify(x => x.SaveChangesAsync());
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task DeleteOpeningTime()
        {
            var uow = new Mock<IUnitOfWork>();

            uow.Setup(x => x.OpeningTimes.GetById(10)).ReturnsAsync(new RestaurantOpeningTime());
            uow.Setup(x => x.OpeningTimes.Delete(It.IsAny<RestaurantOpeningTime>()));
            var openingTimeController = new RestaurantOpeningTimesController(uow.Object);

            var actionResult = await openingTimeController.DeleteRestaurantOpeningTime(10);

            Assert.IsType<NoContentResult>(actionResult);
            var result = actionResult as NoContentResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status204NoContent, result!.StatusCode);

            uow.Verify(x => x.OpeningTimes.GetById(10));
            uow.Verify(x => x.OpeningTimes.Delete(It.IsAny<RestaurantOpeningTime>()));
            uow.Verify(x => x.SaveChangesAsync());
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async void DeleteOpeningTime_ReturnsNotFound()
        {
            int openingTimeId = 10;

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.GetById(openingTimeId)).ReturnsAsync((RestaurantOpeningTime?)null);
            var controller = new RestaurantOpeningTimesController(uow.Object);

            var actionResult = await controller.DeleteRestaurantOpeningTime(openingTimeId);

            var result = actionResult as NotFoundResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status404NotFound, result!.StatusCode);

            uow.Verify(x => x.OpeningTimes.GetById(openingTimeId));
            uow.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task PutRestaurantOpeningTime_IdNotEqual()
        {
            int openingTimeId = -1;
            RestaurantOpeningTime openingTime = OpeningTimeTestData()[0];
            var uow = new Mock<IUnitOfWork>();
            var controller = new RestaurantOpeningTimesController(uow.Object);

            var actionResult = await controller.PutRestaurantOpeningTime(openingTimeId, openingTime);
            var result = actionResult as BadRequestResult;
            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status400BadRequest, result!.StatusCode);
        }

        [Fact]
        public async Task PutRestaurantOpeningTime()
        {
            int openingTimeId = 1;
            RestaurantOpeningTime openingTime = OpeningTimeTestData()[0];

            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.Update(openingTime));
            uow.Setup(x => x.SaveChangesAsync());
            var controller = new RestaurantOpeningTimesController(uow.Object);


            var actionResult = await controller.PutRestaurantOpeningTime(openingTimeId, openingTime);

            var result = actionResult as NoContentResult; 
            
            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status204NoContent, result!.StatusCode);

            uow.Verify(x => x.OpeningTimes.Update(openingTime));
            uow.Verify(x => x.SaveChangesAsync());
            uow.VerifyNoOtherCalls();
        }

        private static List<RestaurantOpeningTime> OpeningTimeTestData()
        {
            List<RestaurantOpeningTime> openingTimes = new()
            {
                new RestaurantOpeningTime() {Id = 1, Day = DayOfWeek.Monday, ClosingTime = new TimeSpan(18, 0, 0), OpeningTime = new TimeSpan(10, 0, 0), RestaurantId = 1 },
                new RestaurantOpeningTime() {Id = 2, Day = DayOfWeek.Sunday, ClosingTime = new TimeSpan(18, 0, 0), OpeningTime = new TimeSpan(10, 0, 0), RestaurantId = 1 },
                new RestaurantOpeningTime() {Id = 3, Day = DayOfWeek.Tuesday, ClosingTime = new TimeSpan(18, 0, 0), OpeningTime = new TimeSpan(10, 0, 0), RestaurantId = 2 },
                new RestaurantOpeningTime() {Id = 4, Day = DayOfWeek.Wednesday, ClosingTime = new TimeSpan(18, 0, 0), OpeningTime = new TimeSpan(10, 0, 0), RestaurantId = 2 },
                new RestaurantOpeningTime() {Id = 5, Day = DayOfWeek.Thursday, ClosingTime = new TimeSpan(12, 0, 0), OpeningTime = new TimeSpan(10, 0, 0), RestaurantId = 1 },
                new RestaurantOpeningTime() {Id = 6, Day = DayOfWeek.Thursday, ClosingTime = new TimeSpan(18, 0, 0), OpeningTime = new TimeSpan(14, 0, 0), RestaurantId = 1 }
            };

            return openingTimes;
        }
    }
}
