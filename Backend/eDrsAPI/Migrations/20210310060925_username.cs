using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class username : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 39, 25, 46, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 39, 25, 47, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 39, 25, 47, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 39, 25, 47, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 39, 25, 47, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 39, 25, 47, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 39, 25, 47, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 39, 25, 47, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { new byte[] { 48, 241, 207, 19, 70, 78, 209, 240, 155, 71, 241, 96, 96, 217, 44, 23, 28, 104, 151, 236, 232, 18, 166, 203, 186, 112, 168, 19, 7, 190, 116, 229, 119, 131, 127, 94, 202, 195, 208, 127, 29, 174, 251, 240, 7, 58, 124, 245, 242, 250, 38, 60, 15, 201, 211, 88, 167, 82, 190, 57, 74, 32, 11, 221 }, new byte[] { 84, 119, 27, 228, 231, 83, 139, 129, 18, 104, 27, 62, 140, 197, 45, 102, 38, 221, 171, 200, 74, 67, 102, 113, 101, 71, 244, 94, 38, 221, 144, 53, 181, 150, 8, 55, 51, 197, 125, 215, 174, 162, 4, 98, 57, 86, 97, 127, 23, 90, 74, 1, 50, 185, 170, 57, 87, 255, 186, 105, 193, 249, 250, 68, 49, 239, 28, 196, 48, 80, 13, 78, 111, 217, 120, 21, 208, 134, 168, 28, 76, 168, 86, 107, 161, 97, 213, 232, 138, 63, 80, 175, 45, 169, 230, 94, 246, 62, 80, 186, 135, 91, 185, 124, 212, 8, 188, 125, 133, 230, 254, 141, 99, 139, 109, 79, 112, 43, 115, 5, 121, 201, 96, 103, 235, 76, 118, 78 }, "edrs-admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 894, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 90, 88, 214, 71, 202, 16, 67, 43, 240, 18, 89, 241, 201, 146, 185, 161, 65, 3, 167, 15, 32, 17, 164, 131, 218, 71, 181, 233, 90, 41, 247, 54, 119, 33, 235, 90, 61, 47, 123, 31, 193, 3, 27, 6, 179, 65, 26, 157, 109, 192, 235, 73, 74, 42, 183, 163, 10, 158, 26, 142, 192, 217, 220, 190 }, new byte[] { 4, 61, 22, 92, 58, 63, 129, 62, 125, 164, 112, 24, 251, 230, 212, 150, 78, 130, 82, 114, 4, 54, 26, 46, 17, 163, 48, 86, 100, 99, 86, 205, 131, 32, 24, 105, 217, 181, 128, 145, 100, 8, 65, 25, 37, 99, 172, 116, 158, 82, 116, 85, 159, 233, 218, 186, 248, 199, 163, 209, 100, 14, 49, 76, 166, 118, 177, 29, 236, 82, 72, 107, 105, 14, 242, 200, 191, 57, 59, 201, 216, 109, 1, 179, 238, 4, 249, 15, 77, 34, 218, 138, 183, 216, 184, 244, 143, 5, 40, 10, 93, 213, 106, 44, 11, 159, 22, 99, 99, 67, 147, 99, 6, 150, 193, 119, 93, 158, 143, 136, 211, 57, 21, 176, 235, 128, 230, 232 } });
        }
    }
}
