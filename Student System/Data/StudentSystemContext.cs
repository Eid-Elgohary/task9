using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.EntityConfigurations;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.Data
{
    internal class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<HomeWorkSubmissions> HomeWorkSubmissions { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.; initial catalog = P01_StudentSystem_db;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"Microsoft SQL Server Data Tools, SQL Server Object Explorer\";Command Timeout=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Academy");

            modelBuilder.ApplyConfiguration(new StudentEntityConfig());

            modelBuilder.ApplyConfiguration(new CourseEntityConfig());

            modelBuilder.ApplyConfiguration(new HomeWorkSubmissionEntityConfig());

            modelBuilder.ApplyConfiguration(new ResourceEntityConfig());

            modelBuilder.ApplyConfiguration(new StudentCourseEntityConfig());


        }
    }
}
