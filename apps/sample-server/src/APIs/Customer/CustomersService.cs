using Microsoft.AspNetCore.Mvc;
using Sample.Infrastructure;

namespace Sample.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(SampleDbContext context)
        : base(context) { }
}
