namespace CleanArchitecture.Application.Concracts.Persistence;
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
