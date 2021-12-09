using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class AddedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "task",
                type: "text",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Category",
                table: "task");

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
    }
}
