using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreakpointApp.Infrastructure.Migrations
{
    public partial class AddUserHashAndSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "Salt");

            migrationBuilder.AddColumn<string>(
                name: "Hash",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hash",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Salt",
                table: "User",
                newName: "Password");
        }
    }
}
