using Api.Domain.Entities;

namespace Api.Domain.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByEmail(string email);
        Task<List<User>> GetAll();
        Task<List<User>> GetByStatus(bool status);

    }
}
