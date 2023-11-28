using Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.RestaurantRepo;

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
            return await _dbContext.SaveChangesAsync();
        }
    }
}
