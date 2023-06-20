using Core.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tischreservierung.Tests.RestaurantTest.Repository
{
    public class ZipCodeRepositoryTest
    {
        private readonly OnlineReservationContext _context;

        public ZipCodeRepositoryTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<OnlineReservationContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            _context = new OnlineReservationContext(optionsBuilder.Options);
        }


        [Fact]
        public async Task GetByDistrict()
        {
            var repository = TestData();
            var result = await repository.GetByDistrict("Linz-Land");

            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
            Assert.Equal("Linz-Land", result[0].District);
            Assert.Equal("Linz-Land", result[1].District);
        }

        [Fact]
        public async Task GetByLocation()
        {

            var repository = TestData();
            var result = await repository.GetByLocation("Enns");

            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal("Enns", result[0].Location);
            Assert.Equal("Enns", result[1].Location);
        }

        [Fact]
        public async Task GetByZipCode()
        {

            var repository = TestData();
            var result = await repository.GetByZipCode("4471");

            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal("4471", result[0].ZipCodeNr);
            Assert.Equal("Enns", result[0].Location);
        }

        [Fact]
        public async Task GetByZipCodeAndLocation()
        {
            var repository = TestData();
            var result1 = await repository.GetByZipCodeAndLocation("4470", "Enns");
            var result2 = await repository.GetByZipCodeAndLocation("4470", "Ennsdorf");

            Assert.NotNull(result1);
            Assert.Null(result2);
            Assert.Equal("Enns", result1!.Location);
            Assert.Equal("4470", result1!.ZipCodeNr);
        }


            ZipCodeRepository TestData()
        {
            List<ZipCode> zipCodes = new List<ZipCode>() { new ZipCode() { Id = 1, District = "Linz-Land", Location = "Enns", ZipCodeNr = "4470"},
                    new ZipCode() { Id = 2, District = "Linz-Land", Location = "Ennsdorf", ZipCodeNr = "4481"},
                    new ZipCode() { Id = 3, District = "Linz", Location = "Linz", ZipCodeNr = "4020"},
                    new ZipCode() { Id = 4, District = "Linz-Land", Location = "Enns", ZipCodeNr="4471" }};

            _context.AddRange(zipCodes);
            _context.SaveChanges();

            return new ZipCodeRepository(_context);

        }
    }
}
