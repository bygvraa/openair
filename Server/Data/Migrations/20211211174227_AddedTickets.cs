using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace OpenAir.Server.Data.Migrations
{
    public partial class AddedTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "063caae1-3e05-4ef1-80d6-2bb0679111bb");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "0e229e27-92a1-44c1-8799-d3859a293670");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "2155cab6-f2b6-46e1-99b9-0adf96faaa34");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "623bcb11-f4ab-4b42-8b06-409dcf07a38f");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "e32a74c6-3897-42a4-ac1c-afb70c3eb826");

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    IsBought = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fb7313d0-8f31-4a45-a7e4-2f8251855aec", "8dcc6468-e14b-43c7-9b40-948597450310", null, "Administrator", "ADMINISTRATOR" },
                    { "3df8a451-0d42-449a-98c5-7a32503830b4", "da53c6b5-a149-472c-a1fc-28f4dfe8db1c", null, "Koordinator", "KOORDINATOR" },
                    { "a4e02a7a-28d6-4b8e-8c27-bf4342d6d270", "f71d3f02-2f12-456d-ad59-8424292f7095", null, "Frivillig", "FRIVILLIG" },
                    { "45e9186c-caaf-4eca-87c7-cf2cf1579389", "8b1c4711-2f8e-4853-837e-8a6fffe5dd73", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "3fb478a5-50b5-439f-8c15-c5596b4b3f07", "b0b573dd-84bf-4360-86b0-fc49ec64f348", null, "Kunde", "KUNDE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "3df8a451-0d42-449a-98c5-7a32503830b4");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "3fb478a5-50b5-439f-8c15-c5596b4b3f07");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "45e9186c-caaf-4eca-87c7-cf2cf1579389");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "a4e02a7a-28d6-4b8e-8c27-bf4342d6d270");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "fb7313d0-8f31-4a45-a7e4-2f8251855aec");

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "623bcb11-f4ab-4b42-8b06-409dcf07a38f", "80998d57-1621-4217-95cc-0e354ba2fefa", null, "Administrator", "ADMINISTRATOR" },
                    { "e32a74c6-3897-42a4-ac1c-afb70c3eb826", "c25e61a6-ba18-4c14-a08d-ee250e0db4ce", null, "Koordinator", "KOORDINATOR" },
                    { "0e229e27-92a1-44c1-8799-d3859a293670", "00fbbb32-61c6-4d85-94ea-6d924a561505", null, "Frivillig", "FRIVILLIG" },
                    { "2155cab6-f2b6-46e1-99b9-0adf96faaa34", "9b6852c5-dbd2-4cec-9647-e2503ef5e746", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "063caae1-3e05-4ef1-80d6-2bb0679111bb", "7fb7770e-0e86-4817-9f86-04c8c6bb2676", null, "Kunde", "KUNDE" }
                });
        }
    }
}
