using Sample.APIs;
using Sample.Infrastructure;
using Sample.Infrastructure.Models;

namespace Sample.APIs;

public abstract class CustomersServiceBase : ICustomersService
{
    protected readonly SampleDbContext _context;

    public CustomersServiceBase(SampleDbContext context)
    {
        _context = context;
    }

    public async Task<string> AddCustomer(string data)
    {
        throw new NotImplementedException();
    }
}
