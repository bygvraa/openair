using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.DataMigrations
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
                    { "f2d77251-856a-4a60-b97d-5b4f754336c4", "ae4681e6-3819-4523-b2a4-0e9a6dc54f2b", null, "Administrator", "ADMINISTRATOR" },
                    { "5972316b-f142-40d5-a305-dddb117572cc", "31777dee-e303-42f4-a46f-35d351a0baa0", null, "Koordinator", "KOORDINATOR" },
                    { "92aedfef-b341-4cb4-8f07-6b2a7f45ab7a", "0fc6e0d0-14ac-4b13-98da-3666cafc3461", null, "Frivillig", "FRIVILLIG" },
                    { "7edcd7df-9a3b-4470-ab71-ee7682e59825", "7e8a234e-c5ce-4a46-94cd-ee22d573b1e0", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "117e5db2-5a91-4d7f-9cec-1367bf323284", "ff69d6d0-6a6c-48df-9596-402f9915ce34", null, "Kunde", "KUNDE" }
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
                keyValue: "117e5db2-5a91-4d7f-9cec-1367bf323284");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "5972316b-f142-40d5-a305-dddb117572cc");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "7edcd7df-9a3b-4470-ab71-ee7682e59825");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "92aedfef-b341-4cb4-8f07-6b2a7f45ab7a");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "f2d77251-856a-4a60-b97d-5b4f754336c4");

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
