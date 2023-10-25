using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Persistence.Data.User;
using Core.Models.User;

namespace Tischreservierung.Tests.PersonTest.Repository
{
    public class EmployeeRepositoryTest
    {
        private readonly OnlineReservationContext _context;

        public EmployeeRepositoryTest()
        {
            var optionsBuilder = new DbContextOptionsBuilder<OnlineReservationContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            _context = new OnlineReservationContext(optionsBuilder.Options);
        }

        EmployeeRepository TestData()
        {
            List<Employee> employees = new()
            {
                new Employee() { EMail = "test1@gmail.com", RestaurantId = 1, FamilyName = "Mauer"},
                new Employee() { EMail = "test2@gmail.com", RestaurantId = 2, FamilyName = "Bucek"},
                new Employee() { EMail = "test3@gmail.com", RestaurantId = 2, FamilyName = "Luger"},
                new Employee() { EMail = "test4@gmail.com", RestaurantId = 3, FamilyName = "Krikri"},
                new Employee() { EMail = "test5@gmail.com", RestaurantId = 1, FamilyName = "Raa"},
            };

            _context.AddRange(employees);
            _context.SaveChanges();

            return new EmployeeRepository(_context);
        }

        [Fact]
        public async Task GetByRestaurant()
        {
            var repository = TestData();
            var result = await repository.GetByRestaurant(2);
            Assert.NotNull(result);

            var list = result.ToList();

            Assert.Equal(2, list.Count);

            Assert.Equal(2, list[0].RestaurantId);
            Assert.Equal("test2@gmail.com", list[0].EMail);
            Assert.Equal("test3@gmail.com", list[1].EMail);
            Assert.Equal(2, list[1].RestaurantId);
        }
    }
}
