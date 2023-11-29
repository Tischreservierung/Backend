namespace Core.Contracts
{
    public interface IUnitOfWork : IAsyncDisposable, IDisposable
    {
        public IRestaurantRepository Restaurants { get; }
        public IRestaurantTableRepository RestaurantTables { get; }
        public IOpeningTimeRepository OpeningTimes { get; }
        public IRestaurantCategoryRepository RestaurantCategories { get; }
        public IZipCodeRepository ZipCodes { get; }
        public IUserRepository Users { get; }
        public IReservationRepository Reservations { get; }
        public IRestaurantPictureRepository RestaurantPictures { get; }


        Task<int> SaveChangesAsync();
    }
}
