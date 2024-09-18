using Api.Domain.Entities;
using System.Linq.Expressions;

namespace Api.Domain.Repositories
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);       
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
