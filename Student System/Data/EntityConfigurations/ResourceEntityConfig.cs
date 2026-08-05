using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.Data.EntityConfigurations
{
    internal class ResourceEntityConfig : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(r => r.ResourceId);

            builder.Property(r => r.ResourceId)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Name)
                .HasMaxLength(50)
                .IsUnicode(true)
                .IsRequired(true);

            builder.Property(r => r.Url)
                .IsUnicode(false)
                .IsRequired(true)
                .HasMaxLength(500);

            builder.Property(r => r.ResourceType)
                .IsRequired(true);

            builder.ToTable(t => t.HasCheckConstraint("CK_Resource_Type", "ResourceType IN (1, 2, 3, 4)"));

            builder.HasOne(r => r.Course)
                .WithMany(c => c.Resources)
                .HasForeignKey(r => r.CourseId)
                .IsRequired();

        }
    }
}
