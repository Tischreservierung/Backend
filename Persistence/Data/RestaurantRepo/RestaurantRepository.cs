﻿using Microsoft.EntityFrameworkCore;
using Core.Models;
using Core.Contracts;
using Core.DTO;
using Core.Models.User;

namespace Persistence.Data.RestaurantRepo
{

    public class RestaurantRepository : IRestaurantRepository
    {
        private  readonly OnlineReservationContext _context;

        public RestaurantRepository(OnlineReservationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurants()
        {
            return await _context.Restaurants.ToListAsync();
        }

        public async Task<Restaurant?> GetRestaurantById(int id)
        {
            return await _context.Restaurants.FindAsync(id);
        }
        public async Task<Restaurant?> InsertRestaurantAsync(DTO_RestaurantPost restaurant)
        {
            if (_context.Persons.Count(p => p.EMail == restaurant.Employee!.EMail) != 0)
                return null;

            Restaurant res = new Restaurant()
            {
                Name = restaurant.Name,
                Address = restaurant.Address,
                StreetNr = restaurant.StreetNr,
                ZipCodeId = restaurant.ZipCode!.Id
            };
            if (restaurant.Categories != null)
                res.Categories = _context.Categories.Where(c => restaurant.Categories!.Contains(c)).ToList();

            Employee emp = restaurant.Employee!;
            emp.Restaurant = res;
            RestaurantOpeningTime[] openings = restaurant.Openings!.Select(o => new RestaurantOpeningTime()
            {
                Day = o.Day,
                OpeningTime = new DateTime(2000, 1, 1, Int32.Parse(o.OpenFrom.Split(':')[0])
                , Int32.Parse(o.OpenFrom.Split(':')[1]),0),
                ClosingTime = new DateTime(2000, 1, 1, Int32.Parse(o.OpenTo.Split(':')[0])
                , Int32.Parse(o.OpenTo.Split(':')[1]), 0),
                Restaurant = res


            }).ToArray();

            _context.Restaurants.Add(res);
            await _context.RestaurantOpeningTimes.AddRangeAsync(openings);
            await _context.Employees.AddAsync(emp);
            return res;
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Remove(restaurant);
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Update(restaurant);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurantsByName(string name, int zipCodeId)
        {
            name = name.ToLower();
            if(zipCodeId == -1)
                return await _context.Restaurants.Where(r => r.Name.ToLower().Contains(name)).ToListAsync();

            return await _context.Restaurants.Where(r => r.Name.ToLower().Contains(name) 
                    && r.ZipCodeId == zipCodeId).ToListAsync();
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurantsByCategories(int[] categories, int zipCodeId)
        {


            if (zipCodeId == -1 && (categories == null || categories.Length == 0))
                return await _context.Restaurants.ToListAsync();
            else if (zipCodeId == -1)
                return await _context.Restaurants.Where(r => r.Categories.Any(c =>
                    categories.Contains(c.Id))).ToListAsync();
            else if (categories == null || categories.Length == 0)
                return await _context.Restaurants.Where(r => r.ZipCodeId == zipCodeId).ToListAsync();

            return await _context.Restaurants.Where(r => r.ZipCodeId == zipCodeId && r.Categories.Any(c =>
                    categories.Contains(c.Id))).ToListAsync();
        }

        public async Task<RestaurantViewDto?> GetRestaurantForViewById(int id)
        {
            return await _context.Restaurants.Where(x => x.Id == id).Select(x => new RestaurantViewDto()
            {
                Id = x.Id,
                StreetNr = x.StreetNr,
                Address = x.Address,
                ZipCode = x.ZipCode,
                Openings = _context.RestaurantOpeningTimes.Where(y => y.RestaurantId == x.Id)
                    .Select(o => new DTO_OpeningTime() { Day = o.Day, 
                        OpenFrom = o.OpeningTime.Hour + ":" + o.OpeningTime.Minute, 
                        OpenTo = o.ClosingTime.Hour + ":" + o.ClosingTime.Minute}).ToArray(),
                Name = x.Name,
                Categories = x.Categories.ToArray(),
            }).SingleOrDefaultAsync();
        }
    }
}
