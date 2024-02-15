using Microsoft.EntityFrameworkCore;
using Core.Models;
using Core.Contracts;
using Core.Dto;
using Core.DTO;

namespace Persistence.Data.RestaurantRepo
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(OnlineReservationContext context) : base(context)
        {

        }

        public async Task<IEnumerable<RestaurantDto>> GetRestaurantsByName(string name, int zipCodeId, DateTime? dateTime)
        {
            //new RestaurantDto() { Description = "", Name = "", Id = "", Picture = ""}

            return await _dbSet.Where(r => (r.ZipCodeId == zipCodeId || zipCodeId == -1)
            && r.Name.ToLower().Contains(name.ToLower())
            && (dateTime == null || _dbContext.RestaurantOpeningTimes
            .Any(o => ((int)o.Day + 1) % 7 == ((int)dateTime.Value.DayOfWeek) && o.RestaurantId == r.Id)))
                .Select(r => new RestaurantDto()
                {
                    Id = r.Id,
                    Description = r.Description,
                    Name = r.Name,
                    Picture = _dbContext.RestaurantPictures.SingleOrDefault(p => p.Index == 0 && p.Restaurant!.Id == r.Id)
                }).ToListAsync();
        }

        public async Task<IEnumerable<RestaurantDto>> GetRestaurantsByCategories
            (int[] categories, int zipCodeId, DateTime? dateTime)
        {
            return await _dbContext.Restaurants.Where(r => (zipCodeId == -1 || r.ZipCodeId == zipCodeId)
            && (categories.Length == 0 || r.Categories.Any(c => categories.Contains(c.Id)))
            && (dateTime == null || _dbContext.RestaurantOpeningTimes
            .Any(o => ((int)o.Day + 1) % 7 == ((int)dateTime.Value.DayOfWeek) && o.RestaurantId == r.Id)))
                .Select(r => new RestaurantDto()
                {
                    Id = r.Id,
                    Description = r.Description,
                    Name = r.Name,
                    Picture = _dbContext.RestaurantPictures.SingleOrDefault(p => p.Index == 0 && p.Restaurant!.Id == r.Id)
                }).ToListAsync();
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
                    .Select(o => new OpeningTimeDto()
                    {
                        Day = (int)o.Day,
                        OpenFrom = o.OpeningTime.Hours + ":" + o.OpeningTime.Minutes,
                        OpenTo = o.ClosingTime.Hours + ":" + o.ClosingTime.Minutes
                    }).ToArray(),
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

        public async Task<int> GetRestaurantIdByEmployee(int employeeId)
        {
            return await _dbContext.RestaurantUser
                .Where(x => x.UserId == employeeId)
                .Select(x => x.RestaurantId)
                .FirstOrDefaultAsync();
        }

        public void AddCategories(int id, List<int> categories)
        {
            var res = _dbContext.Restaurants.Single(r => r.Id == id);

            res.Categories = _dbContext.Categories.Where(c => categories.Contains(c.Id)).ToList();

            _dbContext.Restaurants.Update(res);

        }

        public async Task<RestaurantEditDto?> GetFull(int restaurantId)
        {
            return await _dbContext.Restaurants.Where(r => r.Id == restaurantId).Select(r => new RestaurantEditDto()
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description,
                Address = r.Address,
                StreetNr = r.StreetNr,
                ZipCode = r.ZipCode!,
                Categories = r.Categories,
                Tables = r.Tables,
                Openings = _dbContext.RestaurantOpeningTimes.Where(o => o.RestaurantId == r.Id).ToList(),
                Pictures = _dbContext.RestaurantPictures.Where(p => p.RestaurantId == r.Id).ToList()
            }).FirstAsync();
        }

        public async Task<RestaurantUpdateDto?> GetBasicDataOfRestaurant(int id)
        {
            return await _dbContext.Restaurants.Where(r => r.Id == id).Select(r => new RestaurantUpdateDto()
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description,
                Address = r.Address,
                StreetNr = r.StreetNr,
                ZipCode = r.ZipCode!
            }).SingleAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesOfRestaurant(int restaurantId)
        {
            return await _dbContext.Restaurants.Where(r => r.Id == restaurantId).Include(r => r.Categories)
                .Select(r => r.Categories).SingleAsync();
        }
    }
}
