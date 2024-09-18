using Api.Domain.Entities;

namespace Api.Domain.Repositories
{
    public interface IProductRespository : IGenericRepository<Product>
    {
        Task<List<Product>> GetByCategoryId(int id);

        Task<List<Product>> GetPageAsync(int pageIndex, int pageSize);
    }
}
