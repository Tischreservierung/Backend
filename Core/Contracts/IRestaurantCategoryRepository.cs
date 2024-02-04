using Core.Models;

namespace Core.Contracts
{
    public interface IRestaurantCategoryRepository : IGenericRepository<Category>
    {
        List<Category> GetByCategories(Category[] categories);
    }
}
