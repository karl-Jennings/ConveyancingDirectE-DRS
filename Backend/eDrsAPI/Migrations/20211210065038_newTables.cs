using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class newTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 649, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 230, 19, 221, 66, 92, 208, 219, 24, 195, 6, 61, 3, 132, 214, 100, 8, 14, 58, 122, 242, 141, 135, 72, 37, 89, 80, 255, 200, 196, 132, 127, 54, 127, 18, 144, 117, 28, 13, 30, 53, 103, 201, 36, 123, 81, 129, 161, 169, 92, 111, 209, 164, 201, 51, 91, 124, 230, 23, 70, 29, 162, 75, 223, 253 }, new byte[] { 206, 135, 163, 94, 12, 140, 51, 179, 156, 133, 243, 97, 18, 235, 7, 207, 219, 109, 163, 131, 3, 88, 93, 249, 88, 14, 214, 235, 90, 61, 18, 135, 59, 199, 181, 249, 51, 166, 15, 203, 172, 0, 57, 202, 107, 167, 250, 24, 136, 24, 18, 169, 70, 133, 210, 7, 235, 46, 144, 50, 23, 206, 187, 104, 251, 132, 211, 248, 36, 5, 213, 59, 24, 109, 132, 4, 162, 173, 57, 157, 121, 218, 131, 42, 160, 26, 73, 70, 148, 86, 170, 59, 79, 89, 48, 239, 160, 114, 208, 156, 14, 192, 154, 126, 182, 30, 37, 197, 189, 3, 105, 122, 142, 207, 74, 70, 37, 88, 253, 215, 18, 68, 49, 121, 24, 13, 231, 230 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 276, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 34, 150, 20, 189, 148, 234, 166, 50, 187, 237, 186, 238, 66, 157, 101, 120, 221, 46, 89, 124, 157, 184, 115, 192, 56, 139, 143, 129, 71, 164, 132, 184, 73, 203, 111, 46, 103, 95, 199, 177, 77, 130, 173, 86, 5, 76, 52, 200, 117, 236, 220, 27, 72, 167, 33, 188, 177, 220, 115, 44, 167, 87, 180 }, new byte[] { 248, 113, 209, 61, 23, 23, 171, 169, 251, 189, 79, 120, 210, 133, 6, 85, 121, 180, 36, 52, 178, 128, 232, 75, 94, 41, 199, 9, 134, 141, 189, 146, 169, 106, 73, 167, 85, 78, 120, 26, 146, 179, 86, 214, 47, 103, 158, 113, 160, 14, 205, 201, 224, 153, 162, 197, 10, 4, 56, 143, 218, 176, 7, 115, 74, 15, 252, 178, 192, 129, 33, 16, 96, 194, 9, 71, 36, 82, 204, 195, 194, 37, 33, 104, 156, 161, 166, 109, 220, 19, 107, 131, 39, 122, 25, 70, 178, 187, 61, 147, 41, 40, 170, 92, 114, 43, 171, 246, 104, 215, 17, 105, 139, 91, 230, 50, 15, 109, 238, 62, 135, 8, 200, 221, 31, 69, 165, 207 } });
        }
    }
}
