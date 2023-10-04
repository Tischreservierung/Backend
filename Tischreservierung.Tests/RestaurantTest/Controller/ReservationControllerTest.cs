using Core.Contracts;
using Core.DTO;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;

namespace Tischreservierung.Tests.RestaurantTest.Controller
{
    public class ReservationControllerTest
    {
        [Fact]
        public async void GetReservation()
        {
            int reservationId = 10;
            Reservation reservation = new()
            {
                Id = reservationId,
                CustomerId = 1,
                RestaurantTableId = 101,
                RestaurantId = 1,
                ReservationDay = DateTime.Now,
                StartTime = TimeSpan.FromHours(8),
                EndTime = TimeSpan.FromHours(9)
            };

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(x => x.Reservations.GetById(reservationId)).ReturnsAsync(reservation);
            var reservationService = new Mock<IReservationService>();

            var controller = new ReservationsController(unitOfWork.Object, reservationService.Object);

            var actionResult = await controller.GetReservation(reservationId);

            Assert.IsType<OkObjectResult>(actionResult.Result);
            var result = actionResult.Result as ObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(reservation, result.Value);

            unitOfWork.Verify(x => x.Reservations.GetById(reservationId));
            unitOfWork.VerifyNoOtherCalls();
        }

        [Fact]
        public async void GetReservation_ReturnsNotFound()
        {
            int reservationId = 10;

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(x => x.Reservations.GetById(reservationId)).ReturnsAsync((Reservation?)null);
            var reservationService = new Mock<IReservationService>();

            var controller = new ReservationsController(unitOfWork.Object, reservationService.Object);

            var actionResult = await controller.GetReservation(reservationId);

            Assert.IsType<NotFoundResult>(actionResult.Result);
            var result = actionResult.Result as NotFoundResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status404NotFound, result!.StatusCode);

            unitOfWork.Verify(x => x.Reservations.GetById(reservationId));
            unitOfWork.VerifyNoOtherCalls();
        }

        [Fact]
        public async void DeleteReservation()
        {
            int reservationId = 10;
            Reservation reservation = new()
            {
                Id = reservationId,
                CustomerId = 1,
                RestaurantTableId = 101,
                RestaurantId = 1,
                ReservationDay = DateTime.Now,
                StartTime = TimeSpan.FromHours(8),
                EndTime = TimeSpan.FromHours(9)
            };

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(x => x.Reservations.GetById(reservationId)).ReturnsAsync(reservation);
            unitOfWork.Setup(x => x.Reservations.Delete(It.IsAny<Reservation>()));
            var reservationService = new Mock<IReservationService>();

            var controller = new ReservationsController(unitOfWork.Object, reservationService.Object);

            var actionResult = await controller.DeleteReservation(reservationId);

            Assert.IsType<NoContentResult>(actionResult);
            var result = actionResult as NoContentResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status204NoContent, result!.StatusCode);

            unitOfWork.Verify(x => x.Reservations.GetById(reservationId));
            unitOfWork.Verify(x => x.Reservations.Delete(It.IsAny<Reservation>()));
            unitOfWork.Verify(x => x.SaveChangesAsync());
            unitOfWork.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task DeleteReservation_ReturnsNotFound()
        {
            int reservationId = 10;

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(x => x.Reservations.GetById(reservationId)).ReturnsAsync((Reservation?)null);
            var reservationService = new Mock<IReservationService>();

            var controller = new ReservationsController(unitOfWork.Object, reservationService.Object);

            var actionResult = await controller.DeleteReservation(reservationId);

            var result = actionResult as NotFoundResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status404NotFound, result!.StatusCode);

            unitOfWork.Verify(x => x.Reservations.GetById(reservationId));
            unitOfWork.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task GetReservationByCustomer()
        {
            int customerId = 1;
            List<Reservation> reservations = GetReservationTestData();

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(x => x.Reservations.GetByCustomer(customerId))
                .ReturnsAsync(new List<Reservation>() { reservations[0], reservations[1], reservations[2] });
            var reservationService = new Mock<IReservationService>();

            var controller = new ReservationsController(unitOfWork.Object, reservationService.Object);

            var actionResult = await controller.GetReservationsByCustomer(customerId);
            var result = actionResult.Result as ObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(3, (result.Value as IEnumerable<Reservation>)!.Count());

            unitOfWork.Verify(x => x.Reservations.GetByCustomer(It.IsAny<int>()));
            unitOfWork.VerifyNoOtherCalls();
        }

        [Fact]
        public async Task GetReservationByRestaurant()
        {
            int restaurantId = 1;
            List<Reservation> reservations = GetReservationTestData();

            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(x => x.Reservations.GetByRestaurant(restaurantId))
                .ReturnsAsync(new List<Reservation>() { reservations[0], reservations[1], reservations[2] });
            var reservationService = new Mock<IReservationService>();

            var controller = new ReservationsController(unitOfWork.Object, reservationService.Object);

            var actionResult = await controller.GetReservationsByRestaurant(restaurantId);
            var result = actionResult.Result as ObjectResult;

            Assert.NotNull(result);
            Assert.Equal(StatusCodes.Status200OK, result!.StatusCode);
            Assert.Equal(3, (result.Value as IEnumerable<Reservation>)!.Count());

            unitOfWork.Verify(x => x.Reservations.GetByRestaurant(It.IsAny<int>()));
            unitOfWork.VerifyNoOtherCalls();
        }

        private static List<Reservation> GetReservationTestData()
        {
            List<Reservation> reservations = new()
            {
                new Reservation() { CustomerId = 1, RestaurantTableId = 101, RestaurantId = 1, ReservationDay = DateTime.Now, StartTime = TimeSpan.FromHours(8), EndTime = TimeSpan.FromHours(9) },
                new Reservation() { CustomerId = 1, RestaurantTableId = 102, RestaurantId = 1, ReservationDay = DateTime.Now, StartTime = TimeSpan.FromHours(8), EndTime = TimeSpan.FromHours(9) },
                new Reservation() { CustomerId = 1, RestaurantTableId = 102, RestaurantId = 1, ReservationDay = DateTime.Now, StartTime = TimeSpan.FromHours(8), EndTime = TimeSpan.FromHours(9) },
                new Reservation() { CustomerId = 2, RestaurantTableId = 105, RestaurantId = 2, ReservationDay = DateTime.Now, StartTime = TimeSpan.FromHours(8), EndTime = TimeSpan.FromHours(9) },
                new Reservation() { CustomerId = 2, RestaurantTableId = 105, RestaurantId = 2, ReservationDay = DateTime.Now, StartTime = TimeSpan.FromHours(8), EndTime = TimeSpan.FromHours(9) },
                new Reservation() { CustomerId = 3, RestaurantTableId = 106, RestaurantId = 2, ReservationDay = DateTime.Now, StartTime = TimeSpan.FromHours(8), EndTime = TimeSpan.FromHours(9) }
            };

            return reservations;
        }
    }
}
