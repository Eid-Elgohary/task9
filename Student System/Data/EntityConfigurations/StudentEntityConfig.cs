using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;

namespace P01_StudentSystem.Data.EntityConfigurations
{
    internal class StudentEntityConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasKey(s => s.StudentId);

            builder.Property(s => s.StudentId)
                .ValueGeneratedOnAdd();


            builder.Property(s => s.Name)
                .IsUnicode(true)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.PhoneNumber)
                .HasColumnType("varchar")
                .IsRequired(false)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength(true);

            builder.Property(s => s.RegisteredOn)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();

            builder.Property(s => s.Birthday)
                .IsRequired(false);


            builder.ToTable(t => t.HasCheckConstraint("CK_Student_PhoneNumber_Length", "LEN(PhoneNumber) = 10 OR PhoneNumber IS NULL"));
        }
    }
}
