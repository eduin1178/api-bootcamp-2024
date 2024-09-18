using Api.Domain.Entities;
using Api.Domain.Repositories;

namespace Api.Infrastructure.Repositories
{
    public sealed class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApiDbContext context) : base(context)
        {
        }

        public Task<User> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }
    }
}
