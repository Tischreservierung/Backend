using Core.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Persistence.Data.RestaurantRepo;

namespace Tischreservierung.Tests.RestaurantTest.Repository
{
    public class OpeningTimeRepositoryTest
    {
        private readonly OnlineReservationContext _context;

        public OpeningTimeRepositoryTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<OnlineReservationContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            _context = new OnlineReservationContext(optionsBuilder.Options);
        }

        OpeningTimeRepository TestData()
        {
            List<RestaurantOpeningTime> openingTimes = new()
            {
                new RestaurantOpeningTime(){ Id = 1, Day = DayOfWeek.Monday, RestaurantId = 2},
                new RestaurantOpeningTime(){ Id = 2, Day = DayOfWeek.Tuesday, RestaurantId = 2},
                new RestaurantOpeningTime(){ Id = 3, Day = DayOfWeek.Tuesday, RestaurantId = 1},
                new RestaurantOpeningTime(){ Id = 4, Day = DayOfWeek.Thursday, RestaurantId = 3},
                new RestaurantOpeningTime(){ Id = 5, Day = DayOfWeek.Friday, RestaurantId = 1},
            };

            _context.AddRange(openingTimes);
            _context.SaveChanges();

            return new OpeningTimeRepository(_context);
        }

        [Fact]
        public async Task GetByDay()
        {
            var repository = TestData();
            var result = await repository.GetByDay(DayOfWeek.Tuesday);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Equal(2, list.Count);

            Assert.Equal(DayOfWeek.Tuesday, list[0].Day);
            Assert.Equal(2, list[0].RestaurantId);
            Assert.Equal(DayOfWeek.Tuesday, list[1].Day);
            Assert.Equal(1, list[1].RestaurantId);
        }

        [Fact]
        public async Task GetByRestaurant()
        {
            var repository = TestData();
            var result = await repository.GetByRestaurant(1);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Equal(2, list.Count);

            Assert.Equal(DayOfWeek.Tuesday, list[0].Day);
            Assert.Equal(1, list[0].RestaurantId);
            Assert.Equal(DayOfWeek.Friday, list[1].Day);
            Assert.Equal(1, list[1].RestaurantId);
        }

        [Fact]
        public async Task GetByRestaurantAndDay()
        {
            var repository = TestData();
            var result = await repository.GetByDayAndRestaurant(2, DayOfWeek.Monday);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Single(list);

            Assert.Equal(DayOfWeek.Monday, list[0].Day);
            Assert.Equal(2, list[0].RestaurantId);
        }
    }
}
