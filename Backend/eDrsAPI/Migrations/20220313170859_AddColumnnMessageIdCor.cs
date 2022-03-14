using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class AddColumnnMessageIdCor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageId",
                table: "Outstanding",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 22, 38, 58, 907, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 22, 38, 58, 910, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 22, 38, 58, 910, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 22, 38, 58, 910, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 22, 38, 58, 910, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 22, 38, 58, 910, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 22, 38, 58, 910, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 22, 38, 58, 910, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 116, 196, 9, 224, 181, 140, 207, 40, 120, 50, 182, 71, 136, 133, 88, 244, 27, 81, 89, 2, 239, 42, 197, 246, 82, 169, 18, 230, 187, 161, 70, 148, 19, 201, 134, 175, 140, 42, 221, 235, 190, 56, 205, 160, 38, 85, 124, 151, 72, 151, 140, 235, 198, 239, 92, 192, 209, 12, 207, 240, 214, 205, 97 }, new byte[] { 25, 83, 37, 76, 102, 215, 81, 90, 140, 15, 2, 19, 231, 226, 43, 109, 78, 236, 162, 76, 118, 172, 104, 175, 249, 179, 241, 204, 213, 51, 134, 87, 86, 211, 47, 103, 12, 198, 209, 112, 113, 201, 25, 168, 238, 165, 150, 157, 253, 15, 173, 14, 70, 246, 177, 234, 192, 17, 90, 61, 82, 9, 237, 59, 88, 214, 62, 122, 5, 113, 235, 160, 166, 124, 182, 82, 235, 44, 73, 129, 214, 238, 42, 39, 185, 94, 71, 114, 232, 123, 47, 94, 36, 208, 14, 56, 106, 26, 197, 70, 134, 194, 25, 91, 179, 176, 72, 185, 105, 61, 74, 137, 238, 196, 96, 195, 253, 22, 198, 255, 81, 195, 19, 56, 225, 239, 17, 48 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Outstanding");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 345, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 206, 178, 211, 108, 165, 190, 48, 156, 58, 79, 113, 249, 246, 147, 163, 90, 211, 146, 179, 84, 61, 100, 156, 175, 246, 35, 229, 112, 223, 230, 190, 144, 245, 48, 21, 161, 30, 114, 163, 229, 146, 240, 69, 16, 247, 230, 244, 118, 82, 8, 179, 91, 79, 43, 9, 165, 142, 252, 15, 106, 160, 90, 118, 158 }, new byte[] { 94, 54, 18, 191, 80, 171, 3, 110, 132, 79, 47, 211, 248, 193, 91, 181, 215, 152, 6, 136, 197, 3, 48, 117, 205, 96, 229, 245, 3, 1, 120, 95, 32, 120, 168, 122, 235, 144, 137, 36, 209, 30, 119, 160, 195, 218, 91, 110, 22, 89, 55, 139, 102, 1, 99, 239, 178, 189, 42, 50, 195, 106, 95, 198, 6, 11, 163, 84, 143, 182, 188, 3, 130, 136, 68, 26, 229, 8, 46, 38, 9, 79, 224, 30, 237, 216, 66, 175, 20, 247, 9, 150, 46, 82, 50, 122, 100, 96, 82, 153, 15, 23, 219, 58, 160, 44, 219, 99, 38, 172, 124, 7, 163, 248, 162, 115, 77, 0, 131, 139, 24, 114, 202, 188, 229, 243, 40, 240 } });
        }
    }
}
