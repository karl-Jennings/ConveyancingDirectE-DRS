using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class ignorefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 250, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 251, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 251, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 251, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 251, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 173, 251, 213, 6, 178, 168, 254, 102, 238, 152, 182, 99, 129, 8, 108, 31, 197, 108, 38, 147, 48, 154, 93, 65, 252, 54, 127, 243, 145, 162, 206, 86, 178, 66, 180, 164, 125, 204, 147, 52, 211, 87, 224, 230, 178, 171, 164, 62, 140, 162, 176, 88, 91, 199, 111, 60, 250, 177, 180, 127, 29, 68, 113, 196 }, new byte[] { 181, 165, 227, 15, 102, 161, 61, 83, 225, 229, 152, 89, 52, 129, 143, 159, 200, 61, 143, 249, 190, 185, 197, 182, 36, 44, 109, 123, 229, 53, 79, 92, 78, 105, 250, 150, 127, 222, 0, 151, 132, 216, 201, 119, 51, 163, 188, 164, 121, 224, 79, 60, 253, 75, 214, 135, 240, 75, 58, 217, 207, 109, 220, 190, 217, 127, 115, 182, 27, 132, 211, 2, 110, 162, 232, 1, 74, 96, 19, 135, 229, 118, 19, 6, 32, 34, 176, 150, 110, 243, 187, 192, 97, 20, 154, 172, 89, 177, 197, 248, 2, 150, 149, 79, 68, 2, 190, 97, 20, 95, 158, 162, 47, 170, 219, 175, 48, 247, 94, 84, 141, 115, 129, 185, 165, 160, 230, 18 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 177, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 178, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 178, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 178, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 178, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 30, 54, 153, 231, 60, 71, 184, 143, 175, 174, 132, 181, 15, 56, 111, 225, 7, 74, 219, 161, 42, 125, 114, 61, 55, 2, 182, 149, 64, 208, 20, 103, 52, 196, 153, 151, 163, 131, 159, 16, 118, 208, 252, 216, 23, 71, 105, 225, 239, 64, 107, 23, 92, 76, 195, 66, 183, 80, 209, 148, 246, 85, 81 }, new byte[] { 72, 74, 75, 166, 36, 227, 27, 18, 123, 76, 137, 73, 188, 94, 35, 27, 185, 109, 13, 19, 122, 249, 67, 228, 116, 11, 206, 73, 145, 96, 122, 40, 118, 113, 152, 240, 233, 252, 254, 112, 30, 237, 234, 233, 252, 215, 185, 53, 152, 131, 12, 185, 181, 218, 139, 19, 208, 29, 227, 113, 92, 173, 49, 174, 2, 58, 80, 218, 194, 95, 162, 227, 35, 191, 135, 15, 172, 13, 237, 57, 124, 115, 83, 54, 34, 140, 24, 83, 164, 185, 210, 36, 73, 42, 90, 217, 229, 110, 126, 220, 192, 116, 224, 81, 164, 139, 134, 142, 35, 160, 86, 146, 53, 126, 96, 36, 1, 102, 192, 28, 62, 234, 54, 251, 104, 57, 188, 241 } });
        }
    }
}
