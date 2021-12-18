using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class RenamedColumnUserPasswordHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "user",
                newName: "PasswordHash");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "user",
                newName: "Password");
        }
    }
}
