using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.Data.EntityConfigurations
{
    internal class StudentCourseEntityConfig : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {

            builder.HasKey(sc => new
            {
                sc.StudentId,
                sc.CourseId
            });

            builder.HasOne(sc => sc.Student)
               .WithMany(s => s.StudentCourses)
               .HasForeignKey(sc => sc.StudentId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(sc => sc.Course)
              .WithMany(c => c.StudentCourses)
              .HasForeignKey(sc => sc.CourseId)
              .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
