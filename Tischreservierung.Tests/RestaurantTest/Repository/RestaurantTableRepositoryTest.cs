using Core.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.RestaurantRepo;
using Persistence.Data;

namespace Tischreservierung.Tests.RestaurantTest.Repository
{
    public class RestaurantTableRepositoryTest
    {
        private readonly OnlineReservationContext _context;

        public RestaurantTableRepositoryTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<OnlineReservationContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            _context = new OnlineReservationContext(optionsBuilder.Options);
        }

        RestaurantTableRepository TestData()
        {
            List<RestaurantTable> tables = new()
            {
                new RestaurantTable(){ Id = 1, RestaurantId = 1, SeatPlaces = 2},
                new RestaurantTable(){ Id = 2, RestaurantId = 1, SeatPlaces = 4},
                new RestaurantTable(){ Id = 3, RestaurantId = 1, SeatPlaces = 6},
                new RestaurantTable(){ Id = 4, RestaurantId = 2, SeatPlaces = 2},
                new RestaurantTable(){ Id = 5, RestaurantId = 2, SeatPlaces = 5},
            };

            _context.AddRange(tables);
            _context.SaveChanges();

            return new RestaurantTableRepository(_context);
        }

        [Fact]
        public async Task GetByRestaurant()
        {
            var repository = TestData();
            var result = await repository.GetByRestaurant(1);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Equal(3, list.Count);

            Assert.Equal(2, list[0].SeatPlaces);
            Assert.Equal(4, list[1].SeatPlaces);
            Assert.Equal(6, list[2].SeatPlaces);
        }
    }
}
