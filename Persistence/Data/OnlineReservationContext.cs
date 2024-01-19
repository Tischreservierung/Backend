using Microsoft.EntityFrameworkCore;
using Core.Models;
using Persistence.Seeding;

namespace Persistence.Data
{
    public class OnlineReservationContext : DbContext
    {
        public DbSet<User> Persons => Set<User>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Restaurant> Restaurants => Set<Restaurant>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<RestaurantTable> RestaurantTables => Set<RestaurantTable>();
        public DbSet<RestaurantOpeningTime> RestaurantOpeningTimes => Set<RestaurantOpeningTime>();
        public DbSet<ZipCode> Zipcodes => Set<ZipCode>();
        public DbSet<Reservation> Reservations => Set<Reservation>();

        public DbSet<RestaurantPicture> RestaurantPictures => Set<RestaurantPicture>();
        public DbSet<RestaurantUser> RestaurantUser => Set<RestaurantUser>();

        public OnlineReservationContext(DbContextOptions<OnlineReservationContext> options)
            : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    ZipCode[] zipCodes = ZipCodeCsvReader.Read();
        //    modelBuilder.Entity<ZipCode>().HasData(zipCodes);

        //    Category[] categories = CategoryCsvReader.Read();
        //    modelBuilder.Entity<Category>().HasData(categories);

        //    Restaurant[] restaurants = RestaurantTestDataReader.Read(zipCodes);
        //    modelBuilder.Entity<Restaurant>().HasData(restaurants);

        //    RestaurantOpeningTime[] openingTimes = OpeningTimeTestDataReader.Read();
        //    modelBuilder.Entity<RestaurantOpeningTime>().HasData(openingTimes);

        //    RestaurantTable[] restaurantTables = TableTestDataReader.Read();
        //    modelBuilder.Entity<RestaurantTable>().HasData(restaurantTables);
        //}
    }
}
