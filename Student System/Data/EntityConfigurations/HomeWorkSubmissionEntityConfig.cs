using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.Data.EntityConfigurations
{
    internal class HomeWorkSubmissionEntityConfig : IEntityTypeConfiguration<HomeWorkSubmissions>
    {
        public void Configure(EntityTypeBuilder<HomeWorkSubmissions> builder)
        {

            builder.HasKey(h => h.HomeWorkId);

            builder.Property(h => h.HomeWorkId)
                .ValueGeneratedOnAdd()
                .IsRequired(true);

            builder.Property(h => h.Content)
                .IsUnicode(false)
                .IsRequired(true);

            builder.Property(h => h.ContentType)
                .IsRequired(true);

            builder.Property(h => h.SubmissionTime)
                .IsRequired(true)
                .HasDefaultValueSql("GETDATE()");

            builder.ToTable(h => h.HasCheckConstraint("CK_Content_Type", "ContentType IN (1, 2, 3)"));

            builder.HasOne(h => h.Course)
                .WithMany(c => c.HomeWorkSubmissions)
                .HasForeignKey(h => h.CourseId)
                .IsRequired(true);

            builder.HasOne(h => h.Student)
                .WithMany(s => s.HomeWorkSubmissions)
                .HasForeignKey(h => h.StudentId)
                .IsRequired(true);




        }
    }
}
