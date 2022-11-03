using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface ICategoryRepository
    {
        Task<EntityResponse<Category>> ListCategories(FiltersRequest filters);
        Task<EntityResponse<Category>> ListCategoriesAsync();
        Task<Category> CategoryById(int categoryId);
        Task<bool> InsertCategory(Category category);
        Task<bool> UpdateCategory(Category category);
        Task<bool> DeleteCategory(int categoryId);
    }
}