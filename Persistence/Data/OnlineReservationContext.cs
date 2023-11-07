﻿using Microsoft.EntityFrameworkCore;
using Core.Models.User;
using Core.Models;

namespace Persistence.Data
{
    public class OnlineReservationContext : DbContext
    {
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Restaurant> Restaurants => Set<Restaurant>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<RestaurantCategory> RestaurantCategories => Set<RestaurantCategory>();
        public DbSet<RestaurantTable> RestaurantTables => Set<RestaurantTable>();
        public DbSet<RestaurantOpeningTime> RestaurantOpeningTimes => Set<RestaurantOpeningTime>();
        public DbSet<ZipCode> Zipcodes => Set<ZipCode>();
        public DbSet<Reservation> Reservations => Set<Reservation>();

        public DbSet<RestaurantPicture> RestaurantPictures => Set<RestaurantPicture>();

        public OnlineReservationContext(DbContextOptions<OnlineReservationContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
