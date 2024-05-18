using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace productsTemplate.Migrations
{
    /// <inheritdoc />
    public partial class AddedAddressColumnInPersonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Persons");
        }
    }
}
