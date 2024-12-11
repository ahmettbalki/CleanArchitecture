using CleanArchitecture.Domain.Entities;
namespace CleanArchitecture.Application.Concracts.Persistence
{
    public interface IProductRepository : IGenericRepository<Product, int>
    {
        public Task<List<Product>> GetTopPriceProductsAsync(int count);
    }
}