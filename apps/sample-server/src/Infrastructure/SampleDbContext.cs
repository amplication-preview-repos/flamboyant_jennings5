using Microsoft.EntityFrameworkCore;

namespace Sample.Infrastructure;

public class SampleDbContext : DbContext
{
    public SampleDbContext(DbContextOptions<SampleDbContext> options)
        : base(options) { }
}
