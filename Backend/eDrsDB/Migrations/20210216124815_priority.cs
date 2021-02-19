using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class priority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 775, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 106, 141, 231, 2, 163, 53, 157, 242, 20, 231, 71, 214, 252, 221, 47, 142, 2, 125, 131, 223, 69, 35, 59, 61, 138, 186, 242, 162, 66, 246, 156, 248, 7, 95, 73, 42, 32, 31, 202, 127, 157, 2, 98, 27, 56, 105, 129, 78, 220, 190, 229, 190, 90, 233, 20, 125, 229, 44, 132, 215, 147, 75, 219, 121 }, new byte[] { 115, 123, 0, 178, 96, 138, 253, 192, 2, 255, 154, 203, 4, 249, 114, 62, 250, 222, 93, 233, 110, 250, 93, 131, 88, 206, 248, 25, 9, 204, 1, 59, 60, 52, 177, 11, 111, 49, 230, 142, 107, 46, 135, 14, 114, 240, 71, 188, 151, 212, 233, 242, 185, 87, 181, 36, 166, 69, 106, 138, 68, 51, 123, 220, 104, 225, 87, 193, 31, 160, 215, 23, 221, 248, 105, 83, 42, 172, 193, 212, 12, 230, 33, 80, 102, 87, 212, 41, 162, 212, 18, 73, 3, 132, 39, 236, 202, 243, 29, 68, 132, 228, 179, 102, 169, 225, 109, 220, 124, 57, 143, 66, 28, 107, 128, 132, 147, 223, 197, 2, 48, 188, 66, 30, 120, 251, 176, 40 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "ApplicationForms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 801, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 802, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 802, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 802, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 802, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 73, 149, 138, 190, 7, 126, 68, 152, 98, 92, 123, 214, 20, 159, 116, 219, 255, 41, 86, 145, 194, 78, 29, 207, 181, 130, 68, 2, 171, 185, 174, 9, 225, 210, 220, 48, 134, 192, 88, 17, 25, 195, 13, 155, 215, 37, 157, 78, 64, 28, 74, 30, 148, 81, 139, 174, 206, 44, 178, 186, 235, 46, 159, 66 }, new byte[] { 64, 248, 73, 53, 218, 145, 140, 67, 145, 138, 55, 149, 34, 46, 53, 113, 149, 48, 7, 254, 66, 126, 187, 150, 78, 21, 27, 151, 187, 19, 214, 51, 43, 28, 78, 222, 42, 164, 140, 207, 169, 210, 42, 246, 210, 182, 128, 170, 170, 74, 217, 78, 206, 219, 133, 0, 150, 127, 146, 210, 26, 156, 221, 56, 50, 7, 140, 140, 135, 255, 245, 231, 242, 123, 239, 136, 233, 216, 83, 69, 66, 239, 30, 186, 127, 229, 206, 57, 219, 174, 14, 199, 82, 91, 95, 38, 205, 218, 17, 145, 152, 88, 12, 39, 10, 215, 173, 225, 131, 161, 166, 218, 70, 164, 52, 167, 19, 24, 75, 107, 155, 107, 41, 4, 73, 27, 98, 35 } });
        }
    }
}
