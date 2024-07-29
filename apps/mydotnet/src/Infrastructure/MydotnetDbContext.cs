using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mydotnet.Infrastructure.Models;

namespace Mydotnet.Infrastructure;

public class MydotnetDbContext : IdentityDbContext<IdentityUser>
{
    public MydotnetDbContext(DbContextOptions<MydotnetDbContext> options) : base(options)
    {
    }

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }

    public DbSet<ProductDbModel> Products { get; set; }
}
