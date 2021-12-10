using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ApplicationForService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressForService",
                table: "Parties");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 41, 104, 119, 82, 171, 88, 52, 165, 41, 194, 232, 177, 62, 3, 166, 220, 97, 24, 141, 14, 158, 9, 219, 47, 135, 174, 219, 140, 69, 187, 213, 239, 187, 83, 96, 44, 228, 240, 80, 32, 249, 53, 36, 99, 244, 20, 37, 11, 32, 32, 119, 237, 96, 248, 181, 22, 143, 91, 148, 216, 101, 120, 187, 128 }, new byte[] { 66, 158, 14, 255, 189, 42, 169, 142, 208, 175, 60, 60, 70, 99, 10, 127, 107, 74, 35, 162, 138, 12, 155, 6, 53, 93, 9, 194, 88, 11, 191, 12, 161, 86, 250, 152, 36, 134, 176, 226, 126, 102, 128, 112, 172, 50, 90, 71, 224, 22, 95, 46, 131, 221, 30, 201, 183, 4, 33, 99, 8, 24, 4, 98, 196, 236, 192, 171, 129, 238, 43, 162, 96, 112, 35, 188, 160, 13, 50, 153, 141, 126, 146, 96, 66, 109, 30, 154, 197, 204, 18, 158, 201, 11, 251, 240, 221, 154, 81, 246, 62, 10, 201, 45, 106, 8, 192, 96, 244, 70, 246, 104, 206, 157, 59, 84, 142, 175, 154, 58, 108, 139, 159, 229, 120, 221, 75, 28 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressForService",
                table: "Parties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 11, 16, 12, 49, 16, 742, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 41, 186, 241, 85, 253, 190, 131, 62, 125, 168, 23, 27, 82, 22, 218, 100, 200, 106, 9, 73, 108, 160, 205, 9, 204, 45, 135, 157, 211, 67, 120, 149, 128, 5, 3, 18, 219, 17, 180, 196, 244, 96, 117, 73, 48, 234, 1, 87, 251, 75, 227, 120, 153, 91, 123, 171, 187, 173, 220, 183, 28, 100, 193, 5 }, new byte[] { 223, 220, 25, 241, 80, 40, 115, 27, 166, 7, 175, 201, 219, 186, 36, 67, 161, 97, 155, 16, 66, 162, 69, 123, 189, 223, 209, 240, 190, 166, 90, 44, 53, 38, 246, 180, 234, 138, 231, 5, 2, 202, 159, 97, 88, 126, 36, 51, 115, 243, 213, 159, 65, 231, 5, 30, 144, 38, 2, 225, 38, 66, 169, 239, 86, 220, 125, 115, 48, 131, 106, 148, 156, 66, 253, 251, 113, 218, 18, 130, 75, 182, 74, 212, 69, 24, 76, 110, 247, 202, 134, 58, 159, 150, 201, 188, 34, 3, 135, 133, 89, 107, 72, 179, 144, 208, 122, 46, 162, 100, 201, 106, 21, 204, 1, 163, 174, 48, 4, 136, 187, 247, 105, 252, 198, 188, 204, 26 } });
        }
    }
}
