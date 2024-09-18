using Api.Domain.Entities;
using Api.Domain.Repositories;

namespace Api.Infrastructure.Repositories;

public sealed class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(ApiDbContext context) : base(context)
    {
    }

}
