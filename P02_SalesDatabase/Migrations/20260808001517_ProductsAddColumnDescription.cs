using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAddColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Sales",
                table: "Products",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "no description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Sales",
                table: "Products");
        }
    }
}
