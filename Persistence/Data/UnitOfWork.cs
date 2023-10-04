using Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.RestaurantRepo;
using Persistence.Data.User;

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
        public ICustomerRepository Customers { get; }
        public IEmployeeRepository Employees { get; }
        public IPersonRepository Persons { get; }
        public IReservationRepository Reservations { get; }

        public UnitOfWork(OnlineReservationContext context)
        {
            _dbContext = context;
            Restaurants = new RestaurantRepository(_dbContext);
            RestaurantTables = new RestaurantTableRepository(_dbContext);
            OpeningTimes = new OpeningTimeRepository(_dbContext);
            RestaurantCategories = new RestaurantCategoryRepository(_dbContext);
            ZipCodes = new ZipCodeRepository(_dbContext);
            Customers = new CustomerRepository(_dbContext);
            Employees = new EmployeeRepository(_dbContext);
            Persons = new PersonRepository(_dbContext);
            Reservations = new ReservationRepository(_dbContext);
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

        }

    }
}
