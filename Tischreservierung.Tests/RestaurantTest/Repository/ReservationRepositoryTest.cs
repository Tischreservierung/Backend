using Core.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Tischreservierung.Tests.RestaurantTest.Repository
{
    public class ReservationRepositoryTest
    {
        private readonly OnlineReservationContext _context;

        public ReservationRepositoryTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<OnlineReservationContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            _context = new OnlineReservationContext(optionsBuilder.Options);
        }

        ReservationRepository TestData()
        {
            List<Reservation> reservations = new() {
                new Reservation() { CustomerId = 1, RestaurantId = 1, RestaurantTableId = 1 },
                new Reservation() { CustomerId = 1, RestaurantId = 2, RestaurantTableId = 2 },
                new Reservation() { CustomerId = 2, RestaurantId = 1, RestaurantTableId = 2 },
                new Reservation() { CustomerId = 2, RestaurantId = 2, RestaurantTableId = 1 }};

            _context.AddRange(reservations);
            _context.SaveChanges();

            return new ReservationRepository(_context);
        }

        [Fact]
        public async Task GetByCustomer()
        {
            var repository = TestData();
            var result = await repository.GetByCustomer(1);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Equal(2, list.Count);

            Assert.Equal(1, list[0].CustomerId);
            Assert.Equal(1, list[0].RestaurantId);
            Assert.Equal(1, list[1].CustomerId);
            Assert.Equal(2, list[1].RestaurantId);
        }

        [Fact]
        public async Task GetByRestaurant()
        {
            var repository = TestData();
            var result = await repository.GetByRestaurant(2);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Equal(2, list.Count);

            Assert.Equal(1, list[0].CustomerId);
            Assert.Equal(2, list[0].RestaurantId);
            Assert.Equal(2, list[1].CustomerId);
            Assert.Equal(2, list[1].RestaurantId);
        }
    }
}
