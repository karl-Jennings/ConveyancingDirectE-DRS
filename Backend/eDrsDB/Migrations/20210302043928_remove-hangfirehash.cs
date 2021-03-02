using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class removehangfirehash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hash");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 10, 9, 27, 686, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 10, 9, 27, 687, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 10, 9, 27, 687, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 10, 9, 27, 687, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 10, 9, 27, 687, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 10, 9, 27, 687, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 10, 9, 27, 687, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 10, 9, 27, 687, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 53, 77, 144, 139, 139, 133, 228, 87, 85, 151, 230, 207, 139, 46, 83, 75, 137, 227, 191, 196, 67, 22, 36, 108, 250, 6, 97, 61, 171, 84, 79, 37, 7, 192, 92, 79, 85, 143, 209, 162, 135, 214, 248, 203, 244, 10, 230, 14, 133, 20, 209, 242, 107, 127, 138, 238, 127, 114, 111, 16, 18, 122, 102, 165 }, new byte[] { 235, 123, 224, 83, 93, 236, 211, 167, 157, 191, 114, 243, 138, 108, 79, 3, 14, 231, 230, 28, 185, 189, 98, 24, 149, 9, 241, 233, 207, 70, 13, 249, 58, 206, 19, 26, 4, 112, 190, 91, 211, 220, 39, 122, 12, 175, 219, 88, 43, 88, 93, 33, 8, 204, 174, 157, 2, 235, 96, 243, 157, 180, 210, 58, 226, 172, 51, 155, 180, 230, 110, 59, 120, 4, 122, 40, 149, 35, 237, 78, 233, 229, 15, 59, 3, 107, 73, 63, 184, 214, 87, 119, 93, 217, 39, 246, 205, 212, 3, 96, 97, 179, 212, 80, 144, 169, 218, 195, 173, 95, 91, 194, 3, 30, 34, 35, 46, 13, 30, 217, 132, 161, 9, 84, 48, 103, 212, 98 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hash",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Field = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpireAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hash", x => new { x.Key, x.Field });
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 9, 52, 19, 763, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 9, 52, 19, 765, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 9, 52, 19, 765, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 9, 52, 19, 765, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 9, 52, 19, 765, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 9, 52, 19, 765, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 9, 52, 19, 765, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 2, 9, 52, 19, 765, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 12, 15, 101, 173, 18, 45, 175, 6, 50, 216, 67, 217, 217, 110, 255, 233, 136, 225, 119, 100, 21, 250, 17, 10, 63, 85, 209, 0, 240, 79, 129, 140, 17, 253, 77, 150, 134, 217, 210, 13, 95, 114, 227, 87, 150, 171, 163, 119, 120, 215, 131, 69, 148, 149, 24, 212, 81, 15, 9, 128, 133, 153, 107, 47 }, new byte[] { 189, 157, 75, 92, 16, 81, 196, 18, 254, 173, 248, 213, 36, 104, 44, 84, 242, 175, 145, 17, 242, 170, 86, 175, 23, 78, 154, 254, 16, 93, 222, 228, 222, 219, 183, 186, 213, 144, 150, 75, 150, 16, 26, 239, 132, 115, 142, 235, 244, 164, 0, 225, 184, 158, 144, 77, 125, 46, 240, 235, 15, 206, 49, 39, 133, 86, 160, 152, 44, 75, 120, 217, 180, 244, 188, 65, 178, 209, 77, 78, 115, 112, 86, 14, 77, 42, 108, 230, 38, 172, 141, 2, 119, 225, 228, 179, 53, 64, 149, 183, 131, 111, 255, 62, 207, 218, 226, 31, 191, 108, 69, 53, 227, 111, 138, 203, 159, 246, 160, 168, 44, 69, 200, 217, 104, 145, 79, 21 } });
        }
    }
}
