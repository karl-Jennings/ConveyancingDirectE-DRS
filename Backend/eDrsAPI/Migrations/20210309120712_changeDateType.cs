using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class changeDateType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TypeCode",
                table: "RequestLogs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApplicationDate",
                table: "DocumentReferences",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 26, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 247, 145, 228, 254, 32, 97, 172, 134, 40, 161, 98, 181, 135, 172, 147, 56, 251, 207, 125, 50, 158, 97, 155, 137, 222, 18, 119, 190, 145, 238, 64, 77, 251, 1, 2, 169, 79, 141, 179, 71, 247, 112, 160, 56, 232, 117, 0, 88, 81, 152, 165, 126, 236, 72, 6, 214, 36, 28, 209, 207, 117, 184, 52 }, new byte[] { 76, 11, 40, 131, 8, 13, 112, 3, 88, 163, 35, 202, 183, 195, 215, 146, 224, 231, 129, 13, 213, 31, 25, 102, 45, 2, 32, 132, 159, 125, 147, 113, 126, 226, 205, 55, 119, 113, 133, 103, 12, 68, 126, 106, 28, 70, 159, 234, 246, 25, 122, 2, 50, 61, 244, 102, 15, 61, 177, 212, 7, 58, 155, 254, 12, 118, 254, 174, 176, 150, 99, 153, 19, 84, 116, 95, 188, 209, 5, 255, 142, 179, 56, 56, 164, 217, 87, 157, 124, 78, 219, 36, 27, 5, 106, 12, 110, 119, 204, 57, 158, 255, 91, 112, 106, 202, 16, 165, 16, 110, 192, 30, 18, 151, 74, 172, 142, 142, 129, 191, 98, 228, 125, 17, 230, 83, 228, 0 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TypeCode",
                table: "RequestLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationDate",
                table: "DocumentReferences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 8, 11, 52, 24, 762, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 92, 80, 23, 65, 101, 55, 100, 169, 244, 81, 112, 23, 237, 183, 113, 191, 21, 51, 20, 105, 234, 31, 51, 244, 90, 101, 244, 246, 51, 49, 110, 220, 178, 131, 44, 207, 205, 173, 5, 200, 36, 197, 186, 133, 164, 83, 126, 23, 33, 179, 99, 204, 38, 34, 176, 224, 76, 123, 151, 235, 22, 137, 143, 4 }, new byte[] { 113, 173, 249, 130, 174, 206, 145, 6, 109, 13, 126, 225, 70, 46, 152, 32, 171, 184, 108, 225, 62, 3, 63, 171, 27, 234, 142, 194, 213, 53, 49, 121, 255, 130, 161, 174, 31, 17, 248, 250, 162, 58, 192, 161, 206, 7, 250, 73, 26, 192, 36, 232, 224, 131, 190, 69, 235, 225, 45, 166, 214, 70, 178, 137, 132, 49, 227, 183, 156, 140, 12, 232, 203, 185, 234, 200, 252, 131, 96, 152, 183, 212, 238, 97, 106, 29, 145, 188, 109, 88, 90, 66, 197, 238, 215, 148, 183, 250, 185, 70, 118, 123, 136, 21, 62, 122, 113, 202, 134, 12, 124, 2, 164, 19, 67, 175, 114, 137, 102, 89, 35, 165, 231, 118, 39, 159, 43, 57 } });
        }
    }
}
