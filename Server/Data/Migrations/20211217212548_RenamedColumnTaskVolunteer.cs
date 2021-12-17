using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class RenamedColumnTaskVolunteer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_task_user_Volunteer",
                table: "task");

            migrationBuilder.RenameColumn(
                name: "Volunteer",
                table: "task",
                newName: "VolunteerEmail");

            migrationBuilder.RenameIndex(
                name: "IX_task_Volunteer",
                table: "task",
                newName: "IX_task_VolunteerEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_task_user_VolunteerEmail",
                table: "task",
                column: "VolunteerEmail",
                principalTable: "user",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_task_user_VolunteerEmail",
                table: "task");

            migrationBuilder.RenameColumn(
                name: "VolunteerEmail",
                table: "task",
                newName: "Volunteer");

            migrationBuilder.RenameIndex(
                name: "IX_task_VolunteerEmail",
                table: "task",
                newName: "IX_task_Volunteer");

            migrationBuilder.AddForeignKey(
                name: "FK_task_user_Volunteer",
                table: "task",
                column: "Volunteer",
                principalTable: "user",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
