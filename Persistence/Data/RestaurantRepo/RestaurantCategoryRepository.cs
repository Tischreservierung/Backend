using Core.Models;
using Core.Contracts;

namespace Persistence.Data.RestaurantRepo
{
    public class RestaurantCategoryRepository : GenericRepository<Category>, IRestaurantCategoryRepository
    {

        public RestaurantCategoryRepository(OnlineReservationContext context) : base(context)
        {
            
        }

        public List<Category> GetByCategories(Category[] categories)
        {
            return _dbContext.Categories.Where(c => categories.Contains(c)).ToList();
        }
    }
}
