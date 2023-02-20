using Mc2.CrudTest.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Mc2.CrudTest.Infrastructure.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers").HasKey(x => x.Id);
            builder.Property(x => x.Firstname).HasMaxLength(50);
            builder.Property(x => x.Lastname).HasMaxLength(100);
        }
    }
}
