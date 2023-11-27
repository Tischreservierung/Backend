using Microsoft.EntityFrameworkCore;
using Core.Models;
using Core.Contracts;
using Core.DTO;
using Core.Models.User;

namespace Persistence.Data.RestaurantRepo
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(OnlineReservationContext context) : base(context)
        {
            
        }

        public async Task<Restaurant?> InsertRestaurantAsync(RestaurantPostDto restaurant)
        {
            if (_dbContext.Persons.Any(p => p.EMail == restaurant.Employee!.EMail))
                return null;

            Restaurant res = new()
            {
                Name = restaurant.Name,
                Address = restaurant.Address,
                StreetNr = restaurant.StreetNr,
                ZipCodeId = restaurant.ZipCode!.Id,
                Description = restaurant.Description
            };
            if (restaurant.Categories != null)
                res.Categories = _dbContext.Categories.Where(c => restaurant.Categories!.Contains(c)).ToList();

            Employee emp = restaurant.Employee!;
            emp.Restaurant = res;
            RestaurantOpeningTime[] openings = restaurant.Openings!.Select(o => new RestaurantOpeningTime()
            {
                Day = (DayOfWeek)o.Day,
                OpeningTime = new TimeSpan(int.Parse(o.OpenFrom.Split(':')[0]), int.Parse(o.OpenFrom.Split(':')[1]), 0),
                ClosingTime = new TimeSpan(int.Parse(o.OpenTo.Split(':')[0]), int.Parse(o.OpenTo.Split(':')[1]), 0),
                Restaurant = res
            }).ToArray();

            _dbContext.Restaurants.Add(res);
            await _dbContext.RestaurantOpeningTimes.AddRangeAsync(openings);
            await _dbContext.Employees.AddAsync(emp);
            return res;
        }


        public async Task<IEnumerable<Restaurant>> GetRestaurantsByName(string name, int zipCodeId, DateTime? dateTime)
        {
            return await _dbSet.Where(r => (r.ZipCodeId == zipCodeId || zipCodeId == -1) 
            && r.Name.ToLower().Contains(name.ToLower())
            && (dateTime == null || _dbContext.RestaurantOpeningTimes
            .Any(o => ((int)o.Day+1)%7 == ((int)dateTime.Value.DayOfWeek) && o.RestaurantId == r.Id ))).ToListAsync();
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurantsByCategories
            (int[] categories, int zipCodeId, DateTime? dateTime)
        {
            return await _dbContext.Restaurants.Where(r => (zipCodeId == -1 || r.ZipCodeId == zipCodeId)
            && (categories.Length == 0 || r.Categories.Any(c => categories.Contains(c.Id)))
            && (dateTime == null || _dbContext.RestaurantOpeningTimes
            .Any(o => ((int)o.Day + 1) % 7 == ((int)dateTime.Value.DayOfWeek) && o.RestaurantId == r.Id)))
                .ToListAsync();
        }

        public async Task<RestaurantViewDto?> GetRestaurantForViewById(int id)
        {
            return await _dbContext.Restaurants.Where(x => x.Id == id).Select(x => new RestaurantViewDto()
            {
                Id = x.Id,
                StreetNr = x.StreetNr,
                Description = x.Description,
                Address = x.Address,
                ZipCode = x.ZipCode,
                Openings = _dbContext.RestaurantOpeningTimes.Where(y => y.RestaurantId == x.Id)
                    .Select(o => new OpeningTimeDto() { Day = (int)o.Day, 
                        OpenFrom = o.OpeningTime.Hours + ":" + o.OpeningTime.Minutes, 
                        OpenTo = o.ClosingTime.Hours + ":" + o.ClosingTime.Minutes}).ToArray(),
                Name = x.Name,
                Categories = x.Categories.ToArray(),
                Pictures = _dbContext.RestaurantPictures.Where(z => z.RestaurantId == x.Id)
                    .Select(p => new RestaurantPicture()
                    {
                        Picture = p.Picture,
                        Index = p.Index
                    }).ToArray(),
            }).SingleOrDefaultAsync();
        }

        public async Task<ReservationViewDto?> GetReservationViewById(int id)
        {
            return await _dbContext.Restaurants.Where(r => r.Id == id).Select(r => new ReservationViewDto()
            {
                Id = id,
                RestaurantName = r.Name,
                Picture = _dbContext.RestaurantPictures.Where(p => p.RestaurantId == id && p.Index == 0).Select(p => p.Picture).SingleOrDefault(),
                
            }).SingleOrDefaultAsync();
        }
    }
}
