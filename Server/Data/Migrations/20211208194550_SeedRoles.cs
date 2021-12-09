using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "role");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "role",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
