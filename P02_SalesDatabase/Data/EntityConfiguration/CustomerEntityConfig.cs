using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Models;

namespace P02_SalesDatabase.Data.EntityConfiguration
{
    internal class CustomerEntityConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.CustomerId)
                .ValueGeneratedOnAdd()
                .IsRequired(true);

            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(c => c.Email)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(c => c.CreditCArdNumber)
                .IsRequired(true);

            builder.HasMany(c => c.Sales)
                .WithOne(s => s.Customer)
                .IsRequired(true);




        }
    }
}
