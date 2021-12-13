using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class RemovedColumnFromTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "IsBought",
                table: "ticket");

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ff80afd-c014-4596-9f1c-9a38b0c90d30", "a9d30661-5f60-4939-bf23-0fa1c12f491a", null, "Administrator", "ADMINISTRATOR" },
                    { "ddf8b502-9232-4939-9e5a-f57206eca7e6", "10109e45-16bc-408c-a22e-4b561000494f", null, "Koordinator", "KOORDINATOR" },
                    { "321e7ad6-7834-468f-a20b-4d20f2cda07f", "6518af42-4507-41d6-beee-d716e850e13c", null, "Frivillig", "FRIVILLIG" },
                    { "6648deb4-8210-4c51-a96e-a3f57cf5e53f", "0af033f7-1594-4c18-8ffc-7f807da1bc0a", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "f9eb323d-571f-45f0-b788-b2d17322405d", "cdb85301-58db-4534-82d5-efc174b35f41", null, "Kunde", "KUNDE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "321e7ad6-7834-468f-a20b-4d20f2cda07f");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "6648deb4-8210-4c51-a96e-a3f57cf5e53f");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "9ff80afd-c014-4596-9f1c-9a38b0c90d30");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "ddf8b502-9232-4939-9e5a-f57206eca7e6");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "f9eb323d-571f-45f0-b788-b2d17322405d");

            migrationBuilder.AddColumn<bool>(
                name: "IsBought",
                table: "ticket",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
    }
}
