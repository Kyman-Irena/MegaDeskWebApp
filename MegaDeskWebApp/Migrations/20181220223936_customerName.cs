using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWebApp.Migrations
{
    public partial class customerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "DeskQuote");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "DeskQuote",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "DeskQuote",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "DeskQuote");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "DeskQuote",
                nullable: true);
        }
    }
}
