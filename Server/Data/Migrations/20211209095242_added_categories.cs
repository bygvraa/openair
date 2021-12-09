using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenAir.Server.Data.Migrations
{
    public partial class added_categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DeviceCodes",
                table: "DeviceCodes");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "1965e255-9f40-477a-a797-3d9a1591ef4e");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "1ecba5ba-2a2b-4b6c-b956-b3b60fffe864");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "277f807a-b6f9-4f38-8c01-91a6fac9c6af");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "959348c2-d264-40c9-8433-851bac0ea404");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "dcc4eac0-2a93-4c49-822b-31ea814984df");

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
                    { "74b78003-776b-4a58-b562-4962b2fc795b", "5ab14c9a-565b-4d85-9000-9e84bb23f73b", null, "Administrator", "ADMINISTRATOR" },
                    { "13e5d5cb-8bfd-47b0-a5fc-4efd3ab9d1cb", "e98ad864-811c-435d-96e3-14191ce703a1", null, "Koordinator", "KOORDINATOR" },
                    { "818e03cc-65e6-4582-9b56-82b4e745bf70", "f7fac062-c06a-4538-8813-8637c35c69b8", null, "Frivillig", "FRIVILLIG" },
                    { "b5706ba0-0bcc-4495-8caa-db4d9663ee69", "725fee72-81e3-4db3-940c-5780cdc50b0e", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "d098708a-76c5-4279-a34d-feddbf15c759", "e74c310d-b242-4bf2-8e6a-7a4c248c0102", null, "Kunde", "KUNDE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_device_code",
                table: "device_code");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "13e5d5cb-8bfd-47b0-a5fc-4efd3ab9d1cb");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "74b78003-776b-4a58-b562-4962b2fc795b");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "818e03cc-65e6-4582-9b56-82b4e745bf70");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "b5706ba0-0bcc-4495-8caa-db4d9663ee69");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "d098708a-76c5-4279-a34d-feddbf15c759");

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
                    { "277f807a-b6f9-4f38-8c01-91a6fac9c6af", "16b26344-90a6-433c-b834-df139b140ccc", null, "Administrator", "ADMINISTRATOR" },
                    { "dcc4eac0-2a93-4c49-822b-31ea814984df", "9c1af5ca-e174-4a80-8a5d-e0cb4c82437f", null, "Koordinator", "KOORDINATOR" },
                    { "959348c2-d264-40c9-8433-851bac0ea404", "dcb16ae7-8be2-44ae-8543-e445f515d59b", null, "Frivillig", "FRIVILLIG" },
                    { "1ecba5ba-2a2b-4b6c-b956-b3b60fffe864", "c023b382-be13-4744-b6a4-4d026b42cac1", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "1965e255-9f40-477a-a797-3d9a1591ef4e", "9f656c44-eb00-471f-af2b-1ffa4389bb1d", null, "Kunde", "KUNDE" }
                });
        }
    }
}
