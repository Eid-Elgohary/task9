using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_SalesDatabase.Models;

namespace P02_SalesDatabase.Data.EntityConfiguration
{
    internal class ProductEntityConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            builder.Property(p => p.ProductId)
                .ValueGeneratedOnAdd()
                .IsRequired(true);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(p => p.Description)
                .HasMaxLength(250)
                .HasDefaultValue("no description")
                .IsUnicode(true)
                .IsRequired(true);
                

            builder.Property(p => p.Quantity)
                .HasColumnType("decimal(10,2)")
                .IsRequired(true);

            builder.Property(p => p.Price)
                .HasColumnType("decimal(10,2)")
                .IsRequired(true);

            builder.HasMany(p => p.Sales)
                .WithOne(s => s.Product)
                .IsRequired(true);




        }
    }
}
