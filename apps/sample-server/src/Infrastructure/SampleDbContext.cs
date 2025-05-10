using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sample.Infrastructure;

public class SampleDbContext : IdentityDbContext<IdentityUser>
{
    public SampleDbContext(DbContextOptions<SampleDbContext> options)
        : base(options) { }
}
