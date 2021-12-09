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
                    { "704cd4ed-6a98-40ee-98ea-44099162cafd", "1412651b-f202-460d-8ca2-7efbaaa12fd3", null, "Administrator", "ADMINISTRATOR" },
                    { "b31e4eab-e885-496d-8952-e70e698c5e2a", "f15f08fd-c767-4297-8e5b-79be21e67f30", null, "Koordinator", "KOORDINATOR" },
                    { "2930ce41-2658-405e-b7da-162a80eb0d0b", "91a692af-e673-42f1-90e2-649335693dc5", null, "Frivillig", "FRIVILLIG" },
                    { "6e9f23e8-7d00-4425-aa68-e315218f402b", "7b2956ee-2dca-43ba-89ed-29fc912fef96", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "bc0da442-7824-4a3f-85f2-24f8b56d4230", "fdd46695-e2bd-4550-9919-cbc7f5eb8be9", null, "Kunde", "KUNDE" }
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
                keyValue: "2930ce41-2658-405e-b7da-162a80eb0d0b");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "6e9f23e8-7d00-4425-aa68-e315218f402b");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "704cd4ed-6a98-40ee-98ea-44099162cafd");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "b31e4eab-e885-496d-8952-e70e698c5e2a");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "bc0da442-7824-4a3f-85f2-24f8b56d4230");

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
