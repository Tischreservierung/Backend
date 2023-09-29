using Core.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Persistence.Data.RestaurantRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<RestaurantOpeningTime> openingTimes = new List<RestaurantOpeningTime>()
            {
                new RestaurantOpeningTime(){ Id = 1, Day = 1, RestaurantId =2},
                new RestaurantOpeningTime(){ Id = 2, Day = 2, RestaurantId =2},
                new RestaurantOpeningTime(){ Id = 3, Day = 2, RestaurantId =1},
                new RestaurantOpeningTime(){ Id = 4, Day = 4, RestaurantId =3},
                new RestaurantOpeningTime(){ Id = 5, Day = 5, RestaurantId =1},
            };

            _context.AddRange(openingTimes);
            _context.SaveChanges();

            return new OpeningTimeRepository(_context);
        }

        [Fact]
        public async Task GetByDay()
        {
            var repository = TestData();
            var result = await repository.GetByDay(2);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Equal(2, list.Count);

            Assert.Equal(2, list[0].Day);
            Assert.Equal(2, list[0].RestaurantId);
            Assert.Equal(2, list[1].Day);
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

            Assert.Equal(2, list[0].Day);
            Assert.Equal(1, list[0].RestaurantId);
            Assert.Equal(5, list[1].Day);
            Assert.Equal(1, list[1].RestaurantId);
        }

        [Fact]
        public async Task GetByRestaurantAndDay()
        {
            var repository = TestData();
            var result = await repository.GetByDayAndRestaurant(2,1);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Single(list);

            Assert.Equal(1, list[0].Day);
            Assert.Equal(2, list[0].RestaurantId);
        }
    }
}
