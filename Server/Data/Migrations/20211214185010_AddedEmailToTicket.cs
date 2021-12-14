using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class AddedEmailToTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ticket",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "ticket");
        }
    }
}
