using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 58, 4, 961, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 58, 4, 961, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 58, 4, 961, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 58, 4, 961, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 58, 4, 961, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 58, 4, 961, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 58, 4, 961, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 58, 4, 961, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 245, 117, 139, 33, 241, 225, 195, 124, 172, 253, 121, 26, 82, 195, 243, 241, 211, 15, 90, 86, 43, 77, 103, 210, 169, 20, 182, 74, 147, 168, 155, 1, 31, 243, 79, 230, 72, 245, 68, 174, 158, 203, 132, 176, 23, 28, 126, 8, 144, 27, 240, 104, 165, 112, 187, 102, 219, 27, 131, 241, 178, 132, 12, 15 }, new byte[] { 186, 222, 149, 96, 97, 245, 31, 230, 217, 89, 57, 104, 115, 122, 60, 118, 190, 134, 174, 202, 203, 183, 232, 72, 103, 170, 186, 227, 232, 20, 242, 126, 219, 68, 11, 23, 89, 226, 238, 6, 59, 248, 216, 221, 54, 93, 169, 12, 163, 51, 112, 64, 153, 181, 213, 99, 240, 22, 243, 119, 44, 148, 182, 87, 10, 244, 18, 248, 28, 97, 32, 114, 133, 222, 96, 173, 108, 199, 208, 94, 91, 0, 31, 250, 237, 87, 81, 42, 28, 116, 125, 82, 125, 220, 159, 67, 232, 85, 238, 249, 216, 230, 55, 101, 233, 235, 134, 231, 42, 82, 127, 245, 51, 63, 138, 84, 182, 137, 9, 6, 165, 164, 150, 174, 232, 164, 212, 251 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 50, 29, 822, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 45, 152, 96, 208, 174, 242, 9, 227, 178, 116, 64, 114, 6, 222, 70, 136, 135, 75, 1, 232, 236, 80, 154, 157, 66, 126, 114, 129, 141, 149, 58, 127, 246, 206, 74, 81, 207, 83, 81, 224, 252, 173, 47, 8, 84, 226, 32, 3, 141, 9, 88, 186, 242, 75, 189, 213, 238, 194, 13, 99, 98, 165, 25, 205 }, new byte[] { 14, 217, 187, 86, 204, 190, 31, 100, 186, 189, 1, 20, 228, 51, 35, 151, 2, 98, 198, 191, 190, 2, 96, 211, 48, 111, 133, 103, 195, 24, 9, 79, 66, 192, 12, 91, 227, 87, 126, 233, 220, 15, 252, 122, 82, 79, 31, 43, 56, 237, 25, 32, 48, 189, 174, 3, 206, 39, 247, 37, 118, 129, 74, 200, 98, 98, 4, 176, 129, 46, 232, 229, 31, 224, 35, 85, 75, 136, 7, 185, 187, 205, 77, 167, 127, 156, 32, 174, 82, 197, 203, 192, 224, 125, 100, 103, 119, 58, 1, 57, 169, 191, 39, 24, 20, 182, 189, 30, 93, 104, 113, 130, 144, 84, 250, 60, 66, 127, 233, 231, 109, 246, 251, 196, 104, 5, 117, 130 } });
        }
    }
}
