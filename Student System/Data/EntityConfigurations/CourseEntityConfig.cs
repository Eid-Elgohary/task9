using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.Data.EntityConfigurations
{
    internal class CourseEntityConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);

            builder.Property(c => c.CourseId)
                .ValueGeneratedOnAdd();


            builder.Property(c => c.Name)
                .HasMaxLength(80)
                .IsUnicode()
                .IsRequired(true);

            builder.Property(c => c.Description)
                .IsUnicode()
                .IsRequired(false);

            builder.Property(c => c.StartDate)
                .IsRequired(true);

            builder.Property(c => c.EndDate)
               .IsRequired(true);

            builder.Property(c => c.Price)
                .HasPrecision(10, 2)
                .IsRequired(true);


            builder.HasMany(c => c.Resources)
                .WithOne(r => r.Course)
                .HasForeignKey(c => c.CourseId)
                .IsRequired(true);

            builder.HasMany(c => c.HomeWorkSubmissions)
            .WithOne(h => h.Course)
            .HasForeignKey(c => c.CourseId)
            .IsRequired(true);


        }
    }
}
