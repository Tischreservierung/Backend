using Core.Contracts;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.Repositories;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineReservationContext _dbContext;

        public IRestaurantRepository Restaurants { get; }
        public IRestaurantTableRepository RestaurantTables { get; }
        public IOpeningTimeRepository OpeningTimes { get; }
        public IRestaurantCategoryRepository RestaurantCategories { get; }
        public IZipCodeRepository ZipCodes { get; }
        public IUserRepository Users { get; }
        public IReservationRepository Reservations { get; }
        public IRestaurantPictureRepository RestaurantPictures { get; }

        public UnitOfWork(OnlineReservationContext context)
        {
            _dbContext = context;
            Restaurants = new RestaurantRepository(_dbContext);
            RestaurantTables = new RestaurantTableRepository(_dbContext);
            OpeningTimes = new OpeningTimeRepository(_dbContext);
            RestaurantCategories = new RestaurantCategoryRepository(_dbContext);
            ZipCodes = new ZipCodeRepository(_dbContext);
            Users = new UserRepository(_dbContext);
            Reservations = new ReservationRepository(_dbContext);
            RestaurantPictures = new RestaurantPictureRepository(_dbContext);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }

        protected virtual async ValueTask DisposeAsync(bool disposing)
        {
            if (disposing)
            {
                await _dbContext.DisposeAsync();
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            var entities = _dbContext!.ChangeTracker.Entries()
                .Where(entity => entity.State == EntityState.Added
                                 || entity.State == EntityState.Modified)
                .Select(e => e.Entity)
                .ToArray();

            foreach (var entity in entities)
            {
                ValidateEntity(entity);
            }

            return await _dbContext.SaveChangesAsync();
        }

        private void ValidateEntity(object entity)
        {
            //if (entity is Reservation reservation)
            //{
            //    bool intersects = _dbContext.Reservations
            //        .Where(x => x.CustomerId == reservation.CustomerId &&
            //        x.ReservationDay.Date == reservation.ReservationDay.Date)
            //        .Any(x => x.Intersects(reservation));

            //    if (intersects)
            //    {
            //        throw new ValidationException(
            //            new ValidationResult("Es existiert bereits eine Reservierung zu diesem Zeitpunkt!",
            //                                 new string[] { nameof(reservation.StartTime), nameof(reservation.EndTime) }),
            //            null, null);
            //    }
            //}
        }
    }
}
