using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class AddedColumnToTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "task",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "456f3502-06c8-483b-b599-e10f2e840a98", "c3a0c770-d442-4887-82fa-4e014775ddd2", null, "Administrator", "ADMINISTRATOR" },
                    { "c023a974-433c-4d09-a651-bde5b9c41e6e", "c897cdd0-3f71-40fa-b98c-77d02b8e9bfb", null, "Koordinator", "KOORDINATOR" },
                    { "d605214f-daa2-479f-8623-1644c95066cc", "9dd95b6c-5e60-4db9-ba06-24802cf398ed", null, "Frivillig", "FRIVILLIG" },
                    { "5399b195-0a0a-4654-afad-ae0f3aea0bc2", "e0a64ef3-b91e-4393-8f55-239880fad427", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "49df8e49-1e00-4f89-b2d6-176e35a363ca", "02b66ecf-87ef-4ed9-8912-050f04e59766", null, "Kunde", "KUNDE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "456f3502-06c8-483b-b599-e10f2e840a98");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "49df8e49-1e00-4f89-b2d6-176e35a363ca");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "5399b195-0a0a-4654-afad-ae0f3aea0bc2");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "c023a974-433c-4d09-a651-bde5b9c41e6e");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "d605214f-daa2-479f-8623-1644c95066cc");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "task");

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
    }
}
