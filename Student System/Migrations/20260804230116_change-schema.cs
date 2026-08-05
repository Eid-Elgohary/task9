using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_System.Migrations
{
    /// <inheritdoc />
    public partial class changeschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Academy");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Students",
                newSchema: "Academy");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "StudentCourses",
                newSchema: "Academy");

            migrationBuilder.RenameTable(
                name: "Resources",
                newName: "Resources",
                newSchema: "Academy");

            migrationBuilder.RenameTable(
                name: "HomeWorkSubmissions",
                newName: "HomeWorkSubmissions",
                newSchema: "Academy");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Courses",
                newSchema: "Academy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Students",
                schema: "Academy",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                schema: "Academy",
                newName: "StudentCourses");

            migrationBuilder.RenameTable(
                name: "Resources",
                schema: "Academy",
                newName: "Resources");

            migrationBuilder.RenameTable(
                name: "HomeWorkSubmissions",
                schema: "Academy",
                newName: "HomeWorkSubmissions");

            migrationBuilder.RenameTable(
                name: "Courses",
                schema: "Academy",
                newName: "Courses");
        }
    }
}
