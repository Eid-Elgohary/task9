using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_SalesDatabase.Models;

namespace P02_SalesDatabase.Data.EntityConfiguration
{
    internal class StoreEntityConfig : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(s => s.StoreId);

            builder.Property(s => s.StoreId)
                .ValueGeneratedOnAdd()
                .IsRequired(true);

            builder.Property(s => s.Name)
                .HasMaxLength(80)
                .IsUnicode(true)
                .IsRequired(true);

            builder.HasMany(s => s.Sales)
                .WithOne(sa => sa.Store)
                .IsRequired(true);



        }
    }
}
