using Catalog.Domain.Costumers.Entities;
using Catalog.Infrastructure.EFCore.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.EFCore
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }


        public DbSet<Customer> Customers => Set<Customer>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }

    }
}
