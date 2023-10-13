using Catalog.Domain.Costumers.Entities;
using Catalog.Domain.Costumers.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Infrastructure.EFCore.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedNever();

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.FantasyName)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Tax)
                .HasColumnType("varchar(22)");

            builder.Property(p => p.Status)
                .HasColumnType("varchar(10")
                .HasConversion(
                v => v.ToString(),
                v => (Status)Enum.Parse(typeof(Status), v));

            builder.HasMany(p => p.Addresses)
                .WithOne()
                .HasForeignKey(p => p.CustomerId);
        }
    }
}
