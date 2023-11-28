using Microsoft.EntityFrameworkCore;
using Core.Models;
using Core.Contracts;
using Core.Dto;
using Core.Models.User;

namespace Persistence.Data.RestaurantRepo
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(OnlineReservationContext context) : base(context)
        {
            
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
    }
}
