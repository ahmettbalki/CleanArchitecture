﻿using CleanArchitecture.Domain.Entities;
namespace CleanArchitecture.Application.Concracts.Persistence;
public interface ICategoryRepository : IGenericRepository<Category, int>
{
    Task<Category?> GetCategoryWithProductsAsync(int id);
    Task<List<Category>> GetCategoryWithProductsAsync();
}
