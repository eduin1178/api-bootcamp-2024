using Api.Domain.Entities;
using Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories
{
    public sealed class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApiDbContext context) : base(context)
        {
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _context.Set<User>().FirstOrDefaultAsync(x=>x.Email == email);  
        }

        public Task<List<User>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }
    }
}
