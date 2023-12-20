using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyBackendWebsite.Migrations
{
    public partial class UpdateUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "IsRememberMe",
                table: "AppUsers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AppUsers",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AppUsers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsRememberMe",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
