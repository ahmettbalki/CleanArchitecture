using CleanArchitecture.Application.Concracts.Persistence;
namespace CleanArchitecture.Persistence;
public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public Task<int> SaveChangesAsync() => context.SaveChangesAsync();
}
