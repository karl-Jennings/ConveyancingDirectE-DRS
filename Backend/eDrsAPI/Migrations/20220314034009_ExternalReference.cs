using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ExternalReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExternalReference",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 125, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 167, 126, 23, 18, 131, 65, 85, 17, 222, 17, 113, 143, 9, 2, 69, 252, 146, 148, 239, 18, 60, 5, 191, 51, 66, 178, 75, 215, 122, 240, 141, 61, 154, 175, 232, 124, 246, 213, 109, 40, 143, 2, 101, 55, 107, 146, 54, 155, 41, 154, 52, 108, 81, 249, 162, 156, 252, 40, 247, 31, 239, 83, 133 }, new byte[] { 132, 133, 40, 173, 180, 77, 127, 102, 172, 94, 85, 231, 221, 34, 132, 153, 245, 22, 228, 106, 233, 51, 40, 222, 139, 2, 212, 136, 207, 26, 51, 21, 212, 148, 33, 239, 39, 123, 1, 137, 192, 171, 254, 30, 94, 237, 101, 68, 29, 27, 211, 83, 199, 167, 215, 194, 97, 193, 116, 199, 153, 81, 60, 13, 86, 120, 223, 220, 145, 249, 144, 59, 2, 94, 58, 30, 201, 23, 119, 46, 39, 206, 114, 130, 70, 101, 8, 156, 139, 81, 70, 37, 29, 44, 248, 163, 174, 244, 52, 166, 229, 232, 128, 4, 81, 26, 119, 186, 89, 219, 62, 40, 250, 195, 124, 134, 193, 95, 146, 6, 116, 106, 147, 64, 129, 29, 136, 98 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalReference",
                table: "RequestLogs");

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
    }
}
