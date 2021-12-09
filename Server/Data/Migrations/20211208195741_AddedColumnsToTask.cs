using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class AddedColumnsToTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "3bdb0987-3be7-4675-a1d5-96cfd19c3ccc");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "56f42721-4190-4b53-b9d3-16ff2db4544a");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "6eda37cc-5c0d-4302-b20c-87e2818b811a");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "a91aa131-3fd2-41ec-ab20-9179fcbc18c8");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "baf4726b-0f83-4500-96a8-2ce28166ad76");

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

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "206f8ab2-4401-4bab-a582-c0a3497b2cf2", "dafbb343-6db4-44c8-a183-c16bb49ad373", null, "Administrator", "ADMINISTRATOR" },
                    { "b21fbd50-2a20-444c-820c-9fe0af611c4a", "52af4d79-ee83-4fd6-bf3e-6c5d7e36fc38", null, "Koordinator", "KOORDINATOR" },
                    { "2518f051-42e0-4a0b-9427-3e01fedf7045", "8e660a40-8e44-4743-8e50-f8917b0ad081", null, "Frivillig", "FRIVILLIG" },
                    { "7b65297c-6db6-40d1-90ac-69101d16d51d", "b540d493-6db5-43dd-b477-ab57fe318553", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "43e7e463-fb7b-4a78-a33d-4c330568a646", "054d6792-9c50-4e39-af44-f7991863590d", null, "Kunde", "KUNDE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "206f8ab2-4401-4bab-a582-c0a3497b2cf2");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "2518f051-42e0-4a0b-9427-3e01fedf7045");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "43e7e463-fb7b-4a78-a33d-4c330568a646");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "7b65297c-6db6-40d1-90ac-69101d16d51d");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "b21fbd50-2a20-444c-820c-9fe0af611c4a");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "task");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "task");

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6eda37cc-5c0d-4302-b20c-87e2818b811a", "cf0bf6ea-51ae-4b1d-9f2f-ddeae3c3678c", null, "Administrator", "ADMINISTRATOR" },
                    { "baf4726b-0f83-4500-96a8-2ce28166ad76", "a64c2141-7b99-4e50-911a-1c4ff2f56a6f", null, "Koordinator", "KOORDINATOR" },
                    { "a91aa131-3fd2-41ec-ab20-9179fcbc18c8", "88c8a64a-1eb0-434d-8962-e8ab6d2f19d0", null, "Frivillig", "FRIVILLIG" },
                    { "56f42721-4190-4b53-b9d3-16ff2db4544a", "71b4aacf-a317-44bc-aea9-c3037e07732d", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "3bdb0987-3be7-4675-a1d5-96cfd19c3ccc", "21e8444c-2146-4f17-b5e0-25db4fe33d18", null, "Kunde", "KUNDE" }
                });
        }
    }
}
