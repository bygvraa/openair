using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.datamigrations
{
    public partial class added_categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_device_code",
                table: "device_code");

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

            migrationBuilder.RenameTable(
                name: "device_code",
                newName: "DeviceCodes");

            migrationBuilder.RenameIndex(
                name: "IX_device_code_Expiration",
                table: "DeviceCodes",
                newName: "IX_DeviceCodes_Expiration");

            migrationBuilder.RenameIndex(
                name: "IX_device_code_DeviceCode",
                table: "DeviceCodes",
                newName: "IX_DeviceCodes_DeviceCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeviceCodes",
                table: "DeviceCodes",
                column: "UserCode");

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a66fb4ce-9ee6-4a49-b12b-0b3186266e9b", "75ea64d7-2d89-4cf3-8a2d-c0ba01d123fc", null, "Administrator", "ADMINISTRATOR" },
                    { "2f476bbb-2de4-4cc6-905e-3635cd8c8c2c", "54824d5b-4c54-4d42-b8ab-91b38ee8ddb6", null, "Koordinator", "KOORDINATOR" },
                    { "8aac62f6-4f12-4b3b-bdd7-7238b3b61da2", "542c2f70-02e7-4226-81a5-86e08034ad73", null, "Frivillig", "FRIVILLIG" },
                    { "eda4889b-ce44-477b-ac69-856f04cacc3b", "2af8f15c-6fe6-40a5-a93d-8fb883b5e896", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "faa75e61-366d-45b9-91da-d8a029cd5bd1", "c4c6784c-8152-4867-bd91-6c1e49392335", null, "Kunde", "KUNDE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DeviceCodes",
                table: "DeviceCodes");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "2f476bbb-2de4-4cc6-905e-3635cd8c8c2c");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "8aac62f6-4f12-4b3b-bdd7-7238b3b61da2");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "a66fb4ce-9ee6-4a49-b12b-0b3186266e9b");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "eda4889b-ce44-477b-ac69-856f04cacc3b");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "faa75e61-366d-45b9-91da-d8a029cd5bd1");

            migrationBuilder.RenameTable(
                name: "DeviceCodes",
                newName: "device_code");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "device_code",
                newName: "IX_device_code_Expiration");

            migrationBuilder.RenameIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "device_code",
                newName: "IX_device_code_DeviceCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_device_code",
                table: "device_code",
                column: "UserCode");

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
    }
}
