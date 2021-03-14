using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class responsetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RejectionReason",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResponseJson",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResponseType",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValidationErrors",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 656, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 147, 190, 68, 214, 60, 111, 248, 192, 159, 91, 176, 104, 43, 161, 103, 180, 233, 137, 184, 42, 133, 56, 98, 16, 8, 195, 88, 145, 52, 129, 35, 27, 177, 99, 114, 9, 222, 12, 72, 160, 13, 123, 138, 62, 190, 154, 67, 82, 250, 114, 96, 143, 164, 147, 137, 81, 138, 111, 161, 203, 187, 119, 178, 180 }, new byte[] { 226, 68, 67, 7, 24, 186, 197, 123, 176, 22, 37, 33, 225, 40, 185, 116, 172, 83, 154, 72, 220, 97, 110, 214, 67, 232, 171, 145, 42, 215, 185, 147, 49, 237, 201, 147, 140, 43, 72, 121, 221, 57, 113, 212, 9, 176, 168, 233, 66, 247, 118, 44, 204, 137, 103, 66, 60, 51, 68, 251, 178, 120, 87, 159, 59, 210, 30, 230, 234, 42, 245, 156, 166, 167, 194, 96, 184, 31, 4, 188, 233, 125, 206, 128, 162, 10, 163, 56, 38, 161, 218, 227, 192, 209, 76, 127, 211, 60, 78, 106, 44, 106, 44, 180, 31, 9, 68, 8, 213, 220, 142, 229, 179, 180, 1, 150, 134, 0, 236, 33, 91, 67, 47, 29, 202, 101, 180, 124 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RejectionReason",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ResponseJson",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ResponseType",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ValidationErrors",
                table: "RequestLogs");

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
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 241, 207, 19, 70, 78, 209, 240, 155, 71, 241, 96, 96, 217, 44, 23, 28, 104, 151, 236, 232, 18, 166, 203, 186, 112, 168, 19, 7, 190, 116, 229, 119, 131, 127, 94, 202, 195, 208, 127, 29, 174, 251, 240, 7, 58, 124, 245, 242, 250, 38, 60, 15, 201, 211, 88, 167, 82, 190, 57, 74, 32, 11, 221 }, new byte[] { 84, 119, 27, 228, 231, 83, 139, 129, 18, 104, 27, 62, 140, 197, 45, 102, 38, 221, 171, 200, 74, 67, 102, 113, 101, 71, 244, 94, 38, 221, 144, 53, 181, 150, 8, 55, 51, 197, 125, 215, 174, 162, 4, 98, 57, 86, 97, 127, 23, 90, 74, 1, 50, 185, 170, 57, 87, 255, 186, 105, 193, 249, 250, 68, 49, 239, 28, 196, 48, 80, 13, 78, 111, 217, 120, 21, 208, 134, 168, 28, 76, 168, 86, 107, 161, 97, 213, 232, 138, 63, 80, 175, 45, 169, 230, 94, 246, 62, 80, 186, 135, 91, 185, 124, 212, 8, 188, 125, 133, 230, 254, 141, 99, 139, 109, 79, 112, 43, 115, 5, 121, 201, 96, 103, 235, 76, 118, 78 } });
        }
    }
}
