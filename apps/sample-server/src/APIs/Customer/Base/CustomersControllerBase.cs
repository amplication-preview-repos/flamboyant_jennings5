using Microsoft.AspNetCore.Mvc;
using Sample.APIs;

namespace Sample.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CustomersControllerBase : ControllerBase
{
    protected readonly ICustomersService _service;

    public CustomersControllerBase(ICustomersService service)
    {
        _service = service;
    }

    [HttpGet("{Id}/add-customer")]
    public async Task<string> AddCustomer([FromBody()] string data)
    {
        return await _service.AddCustomer(data);
    }
}
