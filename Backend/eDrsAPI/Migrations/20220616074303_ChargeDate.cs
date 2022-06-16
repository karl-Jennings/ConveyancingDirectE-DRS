using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ChargeDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ChargeDate",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 6, 16, 13, 13, 2, 564, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 6, 16, 13, 13, 2, 566, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 6, 16, 13, 13, 2, 566, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 6, 16, 13, 13, 2, 566, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 6, 16, 13, 13, 2, 566, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 6, 16, 13, 13, 2, 566, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 6, 16, 13, 13, 2, 566, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 6, 16, 13, 13, 2, 566, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 140, 216, 117, 96, 26, 54, 35, 238, 124, 33, 196, 100, 62, 218, 112, 143, 119, 189, 11, 238, 6, 177, 172, 193, 70, 42, 110, 237, 183, 159, 0, 13, 6, 150, 123, 240, 58, 155, 133, 99, 204, 2, 179, 1, 131, 108, 201, 205, 141, 36, 107, 55, 101, 186, 155, 29, 43, 230, 95, 63, 49, 151, 218, 169 }, new byte[] { 80, 134, 31, 47, 33, 132, 0, 206, 248, 159, 200, 172, 90, 107, 100, 46, 90, 200, 249, 11, 97, 74, 43, 116, 71, 39, 154, 250, 129, 246, 220, 116, 209, 192, 123, 204, 245, 122, 44, 71, 179, 135, 165, 247, 178, 75, 226, 76, 143, 219, 143, 62, 87, 78, 202, 21, 45, 87, 26, 56, 44, 106, 54, 182, 172, 224, 130, 41, 111, 209, 80, 0, 230, 170, 66, 12, 31, 163, 107, 208, 55, 143, 194, 218, 16, 223, 27, 57, 129, 209, 127, 186, 239, 187, 172, 57, 54, 64, 36, 193, 207, 15, 230, 156, 150, 40, 4, 147, 239, 8, 116, 229, 130, 145, 222, 220, 130, 89, 75, 60, 236, 227, 192, 117, 192, 152, 30, 98 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ChargeDate",
                table: "ApplicationForms",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 336, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 32, 95, 250, 136, 121, 29, 246, 110, 206, 161, 24, 72, 252, 16, 67, 68, 46, 248, 91, 17, 253, 238, 37, 78, 154, 217, 71, 43, 219, 73, 135, 32, 238, 217, 216, 220, 122, 38, 240, 40, 198, 44, 67, 246, 253, 230, 173, 74, 218, 174, 139, 74, 69, 157, 75, 4, 183, 214, 75, 226, 249, 43, 202 }, new byte[] { 92, 232, 127, 167, 210, 216, 182, 124, 200, 158, 111, 201, 46, 13, 208, 83, 53, 117, 247, 61, 201, 8, 162, 108, 97, 5, 202, 226, 155, 196, 16, 88, 251, 131, 125, 107, 110, 40, 171, 58, 104, 211, 184, 234, 190, 127, 155, 27, 91, 2, 173, 87, 84, 11, 35, 246, 145, 219, 224, 72, 213, 106, 207, 100, 96, 19, 95, 136, 13, 106, 79, 221, 248, 173, 100, 109, 104, 176, 225, 239, 119, 132, 221, 141, 211, 178, 14, 73, 92, 121, 136, 214, 35, 87, 51, 63, 234, 133, 39, 81, 52, 209, 222, 252, 85, 59, 183, 102, 226, 95, 88, 166, 36, 36, 100, 74, 198, 206, 100, 178, 212, 218, 103, 147, 136, 167, 223, 187 } });
        }
    }
}
