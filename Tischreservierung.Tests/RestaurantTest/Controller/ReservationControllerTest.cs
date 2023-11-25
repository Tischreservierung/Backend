using Core.Contracts;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebApi.Controllers;

namespace Tischreservierung.Tests.RestaurantTest.Controller
{
    public class ReservationControllerTest
    {
        [Fact]
        public async Task GetReservation()
        {
            int reservationId = 10;
            Reservation reservation = new()
            {
                Id = reservationId,
                CustomerId = 1,
                RestaurantTableId = 101,
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
        public async Task GetReservation_ReturnsNotFound()
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
        public async Task DeleteReservation()
        {
            int reservationId = 10;
            Reservation reservation = new()
            {
                Id = reservationId,
                CustomerId = 1,
                RestaurantTableId = 101,
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
    }
}
