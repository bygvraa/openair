using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.datamigrations
{
    public partial class added_categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "user");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "user",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "task",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "task",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "task",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "task",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "role",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70bb6f3a-c0d4-499d-814e-e85228ee572a", "b57dff72-23a5-4825-8639-506b9df2b9e0", null, "Administrator", "ADMINISTRATOR" },
                    { "2a07d941-2117-43d9-bef5-217275b94159", "db8d6a69-e361-4b7b-b427-cca01f02d784", null, "Koordinator", "KOORDINATOR" },
                    { "a1f652e3-bd00-4324-ae05-ec0aa19d0add", "8d9ccc7d-ce34-4288-bf9c-27984ab690bf", null, "Frivillig", "FRIVILLIG" },
                    { "07810fd6-2266-43d2-b4c8-ec482d92e986", "964b2224-cee7-4b45-a090-ec90c3a8a30e", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "3832d167-3c02-4713-a985-88a0d01d2d87", "cea64a0d-f35d-40e0-9ae9-981d35b03f3a", null, "Kunde", "KUNDE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "07810fd6-2266-43d2-b4c8-ec482d92e986");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "2a07d941-2117-43d9-bef5-217275b94159");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "3832d167-3c02-4713-a985-88a0d01d2d87");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "70bb6f3a-c0d4-499d-814e-e85228ee572a");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "a1f652e3-bd00-4324-ae05-ec0aa19d0add");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "task");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "task");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "task");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "task");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "role");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "user",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "user",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
