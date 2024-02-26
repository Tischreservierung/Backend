using Core.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Persistence.Data.Repositories;

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
                new Reservation() { CustomerId = 1, RestaurantTableId = 1 },
                new Reservation() { CustomerId = 1, RestaurantTableId = 2 },
                new Reservation() { CustomerId = 2, RestaurantTableId = 2 },
                new Reservation() { CustomerId = 2, RestaurantTableId = 1 }};

            _context.AddRange(reservations);
            _context.SaveChanges();

            return new ReservationRepository(_context);
        }
    }
}
