using Api.Domain.Entities;
using Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories;

public sealed class ProductRespository : GenericRepository<Product>, IProductRespository
{
    public ProductRespository(ApiDbContext context) : base(context)
    {
    }

    public Task<List<Product>> GetByCategoryId(int id)
    {
        return  _context.Set<Product>().Where(p => p.CategoryId == id).ToListAsync();
    }

    public Task<List<Product>> GetPageAsync(int pageIndex, int pageSize)
    {
       return _context.Set<Product>().ToListAsync();
    }
}
