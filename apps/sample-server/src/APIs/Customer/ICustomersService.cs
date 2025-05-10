namespace Sample.APIs;

public interface ICustomersService
{
    public Task<string> AddCustomer(string data);
}
