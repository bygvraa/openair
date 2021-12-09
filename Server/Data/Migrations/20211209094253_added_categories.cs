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
                    { "44cdeca2-d8fa-4add-928a-27782b409e28", "793747dd-f108-4b93-971b-4e09b570fcb9", null, "Administrator", "ADMINISTRATOR" },
                    { "b6382535-082c-42d4-9161-0c9328c7181d", "718c4fe3-f4bd-4c6a-9988-c31bc66082c1", null, "Koordinator", "KOORDINATOR" },
                    { "e118dbc2-4873-4588-8864-79acb30caba3", "a2673f79-97a1-415f-b8e7-8ec5285443c1", null, "Frivillig", "FRIVILLIG" },
                    { "c28347f6-fae1-4d31-9a22-fb19fc3195d4", "54a41f32-f692-41bd-b091-d698822f660c", null, "Kontaktperson", "KONTAKTPERSON" },
                    { "799f29be-9aa9-4cba-b4ff-eb34b7aca573", "057a1ff3-e775-4ebf-8fd0-f338ede70b3d", null, "Kunde", "KUNDE" }
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
                keyValue: "44cdeca2-d8fa-4add-928a-27782b409e28");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "799f29be-9aa9-4cba-b4ff-eb34b7aca573");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "b6382535-082c-42d4-9161-0c9328c7181d");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "c28347f6-fae1-4d31-9a22-fb19fc3195d4");

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "Id",
                keyValue: "e118dbc2-4873-4588-8864-79acb30caba3");

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
