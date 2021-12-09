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
                    { "ebe8ea9f-6b3f-4140-bae9-db4ad6d7f283", "0e8f607c-a669-40fe-a67c-9fef987d6c38", null, "Administrator", "ADMINISTRATOR" },
                    { "74f1ca47-ba2c-40d5-99bf-398103ecb91a", "13ba3c94-5233-4d03-b121-cfa46564899d", null, "Koordinator", "KOORDINATOR" },
                    { "474ad8a1-620b-4978-add1-674260ebe20f", "f5e4ca42-63b7-41fc-b7a1-289d7908b53f", null, "Frivillig", "FRIVILLIG" },
                    { "ba65c393-10be-408b-bb5a-e0e9aefe228d", "87e27967-fc8d-4e76-aaf4-4e6b4d2a939f", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "11c5211f-ea6b-4a72-912f-121509238fb8", "df26a5f2-14a9-41c7-8977-d48809d20954", null, "Kunde", "KUNDE" }
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
                keyValue: "11c5211f-ea6b-4a72-912f-121509238fb8");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "474ad8a1-620b-4978-add1-674260ebe20f");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "74f1ca47-ba2c-40d5-99bf-398103ecb91a");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "ba65c393-10be-408b-bb5a-e0e9aefe228d");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "ebe8ea9f-6b3f-4140-bae9-db4ad6d7f283");

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
