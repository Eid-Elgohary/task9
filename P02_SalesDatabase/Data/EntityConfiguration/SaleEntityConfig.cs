using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Models;

namespace P02_SalesDatabase.Data.EntityConfiguration
{
    internal class SaleEntityConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(sa => sa.SaleId);

            builder.Property(sa => sa.SaleId)
                .ValueGeneratedOnAdd()
                .IsRequired(true);

            builder.Property(sa => sa.Date)
                .IsRequired(true);

            builder.HasOne(sa => sa.Product)
                .WithMany(p => p.Sales)
                .HasForeignKey(sa => sa.ProductId)
                .IsRequired(true);

            builder.HasOne(sa => sa.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(sa => sa.CustomerId)
                .IsRequired(true);

            builder.HasOne(sa => sa.Store)
                .WithMany(s => s.Sales)
                .HasForeignKey(sa => sa.StoreId)
                .IsRequired(true);



        }
    }
}
