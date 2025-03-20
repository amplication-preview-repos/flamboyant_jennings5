using Microsoft.AspNetCore.Mvc;
using Sample.APIs;

namespace Sample.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
