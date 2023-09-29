using Core.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.RestaurantRepo;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tischreservierung.Tests.RestaurantTest.Repository
{
    public class RestaurantRepositoryTest
    {
        private readonly OnlineReservationContext _context;

        public RestaurantRepositoryTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<OnlineReservationContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            _context = new OnlineReservationContext(optionsBuilder.Options);
        }

        RestaurantRepository TestData()
        {
            List<Restaurant> restaurants = new List<Restaurant>()
            {
                new Restaurant() { Id = 1, ZipCodeId = 1, Name = "Res1" },
                new Restaurant() { Id = 2, ZipCodeId = 2, Name = "Res2"},
                new Restaurant() { Id = 3, ZipCodeId = 1, Name = "Res3"},
            };

            List<RestaurantOpeningTime> openingTimes = new List<RestaurantOpeningTime>()
            {
                new RestaurantOpeningTime(){ Id = 1, Day = 1, RestaurantId =2},
                new RestaurantOpeningTime(){ Id = 2, Day = 2, RestaurantId =2},
                new RestaurantOpeningTime(){ Id = 3, Day = 2, RestaurantId =1},
                new RestaurantOpeningTime(){ Id = 4, Day = 4, RestaurantId =3},
                new RestaurantOpeningTime(){ Id = 5, Day = 5, RestaurantId =1},
            };

            _context.AddRange(restaurants);
            _context.AddRange(openingTimes);
            _context.SaveChanges();

            return new RestaurantRepository(_context);
        }


        [Fact]
        public async Task GetRestaurantByName()
        {
            var repository = TestData();
            var result = await repository.GetRestaurantsByName("Res", 1, new DateTime(2023, 6, 21));
            Assert.NotNull(result);

            var list = result.ToList();
            Assert.Single(list);
            Assert.Equal("Res1", list[0].Name);
            Assert.Equal(1, list[0].ZipCodeId);
        }
    }
}
