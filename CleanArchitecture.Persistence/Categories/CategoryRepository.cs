using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Application.Concracts.Persistence;
namespace CleanArchitecture.Persistence.Categories;
public class CategoryRepository(AppDbContext context)
        : GenericRepository<Category, int>(context), ICategoryRepository
{
    public Task<Category?> GetCategoryWithProductsAsync(int id)
    {
        return context.Categories.Include(x => x.Products).FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<List<Category>> GetCategoryWithProductsAsync()
    {
        return context.Categories.Include(x => x.Products).ToListAsync();
    }

    public IQueryable<Category> GetCategoryWithProducts()
    {
        return context.Categories.Include(x => x.Products).AsQueryable();
    }
}
