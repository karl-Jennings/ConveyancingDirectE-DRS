using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class hangfirehash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hash",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Field = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    ExpireAt = table.Column<DateTime>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hash");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 231, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 155, 74, 158, 156, 223, 155, 221, 159, 209, 169, 128, 155, 118, 31, 224, 132, 176, 93, 142, 185, 9, 212, 161, 239, 181, 7, 66, 178, 224, 177, 186, 220, 118, 113, 133, 161, 224, 139, 149, 127, 141, 114, 148, 253, 40, 70, 222, 127, 108, 255, 7, 209, 201, 236, 144, 207, 103, 2, 130, 103, 193, 34, 168, 146 }, new byte[] { 240, 164, 185, 30, 241, 11, 149, 58, 62, 134, 86, 96, 159, 92, 172, 93, 71, 219, 16, 55, 242, 218, 96, 45, 215, 168, 144, 12, 208, 132, 209, 181, 5, 97, 215, 91, 164, 128, 75, 215, 97, 234, 198, 45, 4, 130, 28, 80, 56, 205, 89, 200, 1, 217, 108, 123, 17, 0, 35, 232, 188, 36, 65, 84, 106, 64, 141, 59, 186, 203, 234, 235, 222, 7, 42, 225, 118, 249, 104, 111, 159, 65, 180, 173, 184, 94, 210, 37, 223, 65, 111, 74, 116, 16, 71, 20, 23, 21, 207, 115, 214, 32, 228, 17, 172, 144, 139, 216, 178, 167, 48, 0, 57, 170, 202, 236, 223, 82, 130, 215, 222, 82, 246, 100, 165, 226, 211, 37 } });
        }
    }
}
