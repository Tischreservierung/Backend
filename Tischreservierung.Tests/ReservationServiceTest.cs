using Core.Contracts;
using Core.Dto;
using Core.Models;
using Moq;
using WebApi.Services;

namespace Tischreservierung.Tests
{
    public class ReservationServiceTest
    {
        [Fact]
        public async Task RequestReservation()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.Reservations.Insert(It.IsAny<Reservation>()));

            uow.Setup(x => x.RestaurantTables.GetByRestaurantAndTableSize(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(
                new List<RestaurantTable>()
                {
                    new RestaurantTable() { Id = 1, RestaurantId = 1, SeatPlaces = 4 },
                    new RestaurantTable() { Id = 2, RestaurantId = 1, SeatPlaces = 6 },
                    new RestaurantTable() { Id = 3, RestaurantId = 1, SeatPlaces = 10 }
                });

            uow.Setup(x => x.Reservations.GetByRestaurantAndDay(It.IsAny<int>(), It.IsAny<DateTime>())).ReturnsAsync(new List<Reservation>());

            IReservationService reservationService = new ReservationService(uow.Object);

            var reservation = await reservationService.RequestReservation(new ReservationRequestDto()
            {
                Day = DateTime.Today,
                NumberOfPersons = 4,
                RestaurantId = 1
            }, 1);

            Assert.NotNull(reservation);
            Assert.Equal(DateTime.Today.AddHours(9), reservation!.ReservationDay);
            Assert.Equal(1, reservation.RestaurantTableId);
            Assert.Equal(TimeSpan.FromHours(9), reservation.StartTime);
            Assert.Equal(TimeSpan.FromHours(10.5), reservation.EndTime);
        }

        [Fact]
        public async Task RequestReservation_NoFreeTable()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.Reservations.Insert(It.IsAny<Reservation>()));
            uow.Setup(x => x.RestaurantTables.GetByRestaurantAndTableSize(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(new List<RestaurantTable>());
            uow.Setup(x => x.Reservations.GetByRestaurantAndDay(It.IsAny<int>(), It.IsAny<DateTime>())).ReturnsAsync(new List<Reservation>());

            IReservationService reservationService = new ReservationService(uow.Object);

            var reservation = await reservationService.RequestReservation(new ReservationRequestDto()
            {
                Day = DateTime.Today,
                NumberOfPersons = 4,
                RestaurantId = 1
            }, 1);

            Assert.Null(reservation);
        }

        [Fact]
        public async Task GetReservationOptions_OpeningTimeToShort()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.GetByDayAndRestaurant(It.IsAny<int>(), It.IsAny<DayOfWeek>()))
                .ReturnsAsync(
                new List<RestaurantOpeningTime>()
                {
                    new RestaurantOpeningTime()
                    {
                        Id = 1,
                        RestaurantId = 1,
                        Day = DayOfWeek.Monday,
                        OpeningTime = new TimeSpan(9, 0, 0),
                        ClosingTime = new TimeSpan(10, 0, 0)
                    }
                });

            uow.Setup(x => x.RestaurantTables.GetByRestaurantAndTableSize(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(
                new List<RestaurantTable>()
                {
                    new RestaurantTable() { Id = 1, RestaurantId = 1, SeatPlaces = 4 }
                });

            uow.Setup(x => x.Reservations.GetByRestaurantAndDay(It.IsAny<int>(), It.IsAny<DateTime>())).ReturnsAsync(new List<Reservation>());

            IReservationService reservationService = new ReservationService(uow.Object);


            //var reservationOptions = await reservationService.GetReservationOptions(1, 1, DateTime.Today, TimeSpan.FromHours(9), TimeSpan.FromHours(10), 4);

            //Assert.Empty(reservationOptions);
        }

        [Fact]
        public async Task GetReservationOptions()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.GetByDayAndRestaurant(It.IsAny<int>(), It.IsAny<DayOfWeek>())).ReturnsAsync(
                new List<RestaurantOpeningTime>()
                {
                    new RestaurantOpeningTime()
                    {
                        Id = 1,
                        RestaurantId = 1,
                        Day = DayOfWeek.Monday,
                        OpeningTime = new TimeSpan(9, 0, 0),
                        ClosingTime = new TimeSpan(11, 0, 0)
                    }
                });

            uow.Setup(x => x.RestaurantTables.GetByRestaurantAndTableSize(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(
                new List<RestaurantTable>()
                {
                    new RestaurantTable() { Id = 1, RestaurantId = 1, SeatPlaces = 4 },
                    new RestaurantTable() { Id = 2, RestaurantId = 1, SeatPlaces = 5 },
                    new RestaurantTable() { Id = 3, RestaurantId = 1, SeatPlaces = 8 }
                });

            uow.Setup(x => x.Reservations.GetByRestaurantAndDay(It.IsAny<int>(), It.IsAny<DateTime>())).ReturnsAsync(new List<Reservation>());

            IReservationService reservationService = new ReservationService(uow.Object);

            //var reservationOptions = await reservationService.GetReservationOptions(1, 1, DateTime.Today, TimeSpan.FromHours(9), TimeSpan.FromHours(11), 4);

            /*Assert.Equal(3, reservationOptions.Count());
            Assert.Collection(reservationOptions,
                x => Assert.Equal(TimeSpan.FromHours(9), x.StartTime),
                x => Assert.Equal(TimeSpan.FromHours(9.25), x.StartTime),
                x => Assert.Equal(TimeSpan.FromHours(9.5), x.StartTime));

            Assert.Collection(reservationOptions,
                x => Assert.Equal(TimeSpan.FromHours(10.5), x.EndTime),
                x => Assert.Equal(TimeSpan.FromHours(10.75), x.EndTime),
                x => Assert.Equal(TimeSpan.FromHours(11), x.EndTime));

            Assert.All(reservationOptions, x => Assert.Equal(1, x.RestaurantTableId));
            Assert.All(reservationOptions, x => Assert.Equal(4, x.SeatPlaces));
            Assert.All(reservationOptions, x => Assert.Equal(DateTime.Today, x.Day));*/
        }

        [Fact]
        public async Task GetReservationOptions_IntersectingReservation()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.GetByDayAndRestaurant(It.IsAny<int>(), It.IsAny<DayOfWeek>())).ReturnsAsync(
                new List<RestaurantOpeningTime>()
                {
                    new RestaurantOpeningTime()
                    {
                        Id = 1,
                        RestaurantId = 1,
                        Day = DayOfWeek.Monday,
                        OpeningTime = new TimeSpan(9, 0, 0),
                        ClosingTime = new TimeSpan(12, 0, 0)
                    }
                });

            uow.Setup(x => x.RestaurantTables.GetByRestaurantAndTableSize(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(
                new List<RestaurantTable>()
                {
                    new RestaurantTable() { Id = 1, RestaurantId = 1, SeatPlaces = 4 }
                });

            uow.Setup(x => x.Reservations.GetByRestaurantAndDay(It.IsAny<int>(), It.IsAny<DateTime>())).ReturnsAsync(
                new List<Reservation>()
                {
                    new Reservation() { Id = 1, CustomerId = 1, RestaurantTableId = 1, ReservationDay = DateTime.Today, StartTime = TimeSpan.FromHours(9), EndTime = TimeSpan.FromHours(10.5) }
                });

            IReservationService reservationService = new ReservationService(uow.Object);

            //var reservationOptions = await reservationService.GetReservationOptions(1, 1, DateTime.Today, TimeSpan.FromHours(9), TimeSpan.FromHours(12), 4);

            //Assert.Single(reservationOptions);
        }

        [Fact]
        public async Task GetReservationOptions_OpeningTimeOutsideReservationOffset()
        {
            var uow = new Mock<IUnitOfWork>();
            uow.Setup(x => x.OpeningTimes.GetByDayAndRestaurant(It.IsAny<int>(), It.IsAny<DayOfWeek>()))
                .ReturnsAsync(
                new List<RestaurantOpeningTime>()
                {
                    new RestaurantOpeningTime()
                    {
                        Id = 1,
                        RestaurantId = 1,
                        Day = DayOfWeek.Monday,
                        OpeningTime = new TimeSpan(8, 57, 0),
                        ClosingTime = new TimeSpan(10, 30, 0)
                    }
                });

            uow.Setup(x => x.RestaurantTables.GetByRestaurantAndTableSize(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(
                new List<RestaurantTable>()
                {
                    new RestaurantTable() { Id = 1, RestaurantId = 1, SeatPlaces = 4 }
                });

            uow.Setup(x => x.Reservations.GetByRestaurantAndDay(It.IsAny<int>(), It.IsAny<DateTime>())).ReturnsAsync(new List<Reservation>());

            IReservationService reservationService = new ReservationService(uow.Object);


            //var reservationOptions = await reservationService.GetReservationOptions(1, 1, DateTime.Today, TimeSpan.FromHours(8.5), TimeSpan.FromHours(10.5), 4);

            /*Assert.Single(reservationOptions);

            Assert.All(reservationOptions, x => Assert.Equal(TimeSpan.FromHours(9), x.StartTime));
            Assert.All(reservationOptions, x => Assert.Equal(TimeSpan.FromHours(10.5), x.EndTime));*/
        }
    }
}
