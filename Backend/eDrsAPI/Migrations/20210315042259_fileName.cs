using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class fileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppMessageId",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 233, 50, 91, 212, 16, 219, 82, 161, 70, 218, 124, 9, 136, 86, 45, 165, 216, 100, 234, 125, 180, 224, 165, 79, 129, 199, 171, 203, 10, 89, 245, 185, 26, 189, 13, 179, 196, 187, 173, 150, 202, 3, 177, 126, 105, 8, 200, 133, 158, 231, 182, 248, 11, 44, 157, 1, 155, 125, 201, 142, 19, 96, 238, 99 }, new byte[] { 42, 100, 199, 88, 43, 9, 191, 110, 107, 125, 195, 77, 91, 211, 128, 127, 116, 195, 201, 36, 102, 226, 82, 35, 185, 113, 202, 153, 194, 38, 187, 109, 47, 147, 78, 237, 79, 180, 29, 139, 59, 145, 107, 109, 194, 66, 247, 66, 249, 11, 173, 121, 9, 94, 87, 29, 200, 148, 144, 14, 246, 159, 151, 214, 160, 157, 108, 252, 168, 173, 201, 132, 209, 38, 158, 154, 77, 45, 40, 51, 219, 40, 179, 216, 75, 56, 244, 205, 129, 109, 5, 140, 97, 247, 229, 10, 101, 129, 15, 15, 80, 90, 53, 23, 45, 233, 199, 98, 34, 207, 223, 112, 186, 177, 149, 121, 81, 17, 110, 219, 166, 165, 53, 7, 133, 143, 254, 59 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppMessageId",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "RequestLogs");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 23, 47, 20, 129, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 23, 47, 20, 130, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 23, 47, 20, 130, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 23, 47, 20, 130, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 23, 47, 20, 130, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 23, 47, 20, 130, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 23, 47, 20, 130, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 23, 47, 20, 130, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 194, 174, 239, 227, 13, 144, 193, 232, 42, 250, 190, 119, 151, 206, 187, 233, 135, 222, 31, 41, 26, 126, 15, 172, 87, 232, 44, 43, 189, 231, 206, 86, 203, 145, 236, 205, 64, 34, 219, 68, 226, 23, 238, 101, 148, 210, 210, 93, 18, 85, 161, 39, 130, 100, 238, 41, 16, 108, 145, 84, 37, 99, 50, 158 }, new byte[] { 184, 240, 192, 192, 209, 254, 101, 149, 53, 138, 53, 232, 110, 220, 206, 7, 121, 107, 212, 211, 180, 172, 154, 59, 180, 138, 185, 170, 112, 98, 218, 120, 180, 139, 119, 73, 231, 141, 151, 92, 249, 34, 237, 145, 21, 162, 93, 62, 118, 149, 97, 185, 141, 159, 92, 76, 186, 160, 247, 28, 140, 19, 46, 167, 134, 168, 115, 173, 166, 209, 166, 176, 232, 149, 130, 182, 16, 61, 97, 211, 136, 192, 54, 225, 147, 72, 61, 156, 25, 232, 8, 34, 108, 172, 18, 200, 228, 132, 116, 196, 202, 213, 114, 82, 99, 33, 244, 205, 5, 247, 79, 194, 142, 230, 166, 28, 223, 203, 149, 23, 101, 209, 22, 50, 23, 169, 218, 34 } });
        }
    }
}
