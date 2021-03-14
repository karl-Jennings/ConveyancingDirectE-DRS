using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class attId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttachmentId",
                table: "RequestLogs",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "RequestLogs");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 780, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 39, 111, 152, 253, 255, 128, 187, 224, 74, 199, 186, 197, 212, 244, 73, 200, 23, 120, 212, 223, 7, 19, 96, 251, 141, 13, 255, 195, 114, 248, 205, 36, 213, 93, 194, 174, 214, 184, 254, 221, 150, 239, 39, 124, 19, 216, 132, 209, 43, 145, 78, 24, 0, 72, 110, 69, 209, 104, 251, 12, 167, 181, 253, 53 }, new byte[] { 57, 8, 77, 217, 137, 121, 96, 186, 1, 171, 177, 47, 146, 48, 30, 113, 217, 78, 199, 2, 226, 62, 65, 84, 235, 233, 164, 253, 179, 127, 19, 22, 96, 235, 156, 176, 74, 191, 41, 120, 105, 162, 239, 225, 42, 128, 117, 39, 153, 238, 138, 39, 196, 2, 182, 229, 39, 101, 242, 135, 139, 242, 27, 23, 208, 118, 0, 69, 52, 68, 126, 186, 17, 109, 48, 154, 80, 130, 117, 19, 144, 103, 211, 114, 128, 163, 117, 193, 120, 32, 95, 77, 202, 62, 239, 186, 58, 81, 38, 37, 194, 93, 160, 120, 196, 197, 151, 227, 103, 119, 167, 200, 201, 42, 251, 163, 58, 225, 39, 83, 75, 16, 177, 203, 150, 35, 202, 53 } });
        }
    }
}
