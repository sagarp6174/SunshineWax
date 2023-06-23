using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SunshineWax.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedDataTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Sunshiners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Sunshiners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Sunshiners");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Sunshiners");
        }
    }
}
