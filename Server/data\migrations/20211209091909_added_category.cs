using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.datamigrations
{
    public partial class added_category : Migration
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
                    { "508ad851-b7cf-4d6c-9b2c-b3fa34f986a9", "7313afeb-433b-4e5d-b983-26b73539b17d", null, "Administrator", "ADMINISTRATOR" },
                    { "6271454e-6612-47ce-91e7-0aea7ef299f2", "55842daa-8eea-43aa-98aa-c993220b52dc", null, "Koordinator", "KOORDINATOR" },
                    { "b0b2ac16-d04a-4114-897f-98f9c87bcbac", "e171ac10-96fe-4b41-8291-969f3843762a", null, "Frivillig", "FRIVILLIG" },
                    { "a7fab35e-d7f6-4304-a398-3edc5b38ad59", "e640c2d8-25e5-489e-bb7f-64fe116954a0", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "1a44edb7-7a25-42dd-a69e-4e48669cc050", "f779de14-85d9-48e8-ba4d-c650b16f8066", null, "Kunde", "KUNDE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "1a44edb7-7a25-42dd-a69e-4e48669cc050");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "508ad851-b7cf-4d6c-9b2c-b3fa34f986a9");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "6271454e-6612-47ce-91e7-0aea7ef299f2");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "a7fab35e-d7f6-4304-a398-3edc5b38ad59");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "b0b2ac16-d04a-4114-897f-98f9c87bcbac");

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
