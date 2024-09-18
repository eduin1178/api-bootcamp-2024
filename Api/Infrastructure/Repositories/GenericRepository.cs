using Api.Domain.Entities;
using Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
namespace Api.Infrastructure;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly ApiDbContext _context;

    protected GenericRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task<List<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }
    public async Task<T> Get(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
    public void Add(T entity)
    {
        _context.Add(entity);
    }

    public void Delete(int id)
    {
        _context.Remove(id);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }
}
