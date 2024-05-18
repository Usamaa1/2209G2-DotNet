using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace productsTemplate.Migrations
{
    /// <inheritdoc />
    public partial class ImageColumnAddedInProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "prodImage",
                table: "ProductsTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prodImage",
                table: "ProductsTable");
        }
    }
}
