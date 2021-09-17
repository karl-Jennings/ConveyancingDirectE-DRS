using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class dxd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "DocumentReferences",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApiSuccess",
                table: "DocumentReferences",
                nullable: true,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Variety",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExternalReference",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CertifiedCopy",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DxNumber",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 8, 14, 12, 17, 134, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 8, 14, 12, 17, 135, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 8, 14, 12, 17, 135, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 8, 14, 12, 17, 135, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 8, 14, 12, 17, 135, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 8, 14, 12, 17, 135, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 8, 14, 12, 17, 135, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 8, 14, 12, 17, 135, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 204, 209, 53, 102, 137, 92, 245, 120, 177, 232, 33, 67, 236, 94, 216, 139, 223, 167, 81, 175, 172, 173, 193, 21, 99, 27, 132, 205, 203, 216, 252, 191, 211, 185, 53, 244, 151, 238, 11, 234, 62, 44, 160, 246, 39, 9, 110, 190, 224, 188, 38, 122, 220, 3, 234, 190, 230, 235, 2, 90, 226, 42, 110, 249 }, new byte[] { 105, 217, 172, 42, 85, 67, 60, 142, 41, 17, 212, 225, 12, 41, 209, 254, 24, 102, 185, 145, 73, 148, 188, 177, 137, 102, 95, 90, 198, 5, 156, 157, 16, 195, 140, 187, 97, 250, 223, 55, 2, 193, 25, 126, 246, 46, 238, 32, 190, 30, 252, 126, 118, 240, 61, 155, 228, 145, 65, 146, 135, 113, 148, 154, 207, 239, 116, 195, 192, 246, 237, 59, 166, 78, 163, 153, 98, 52, 63, 97, 6, 136, 156, 149, 163, 17, 102, 132, 102, 54, 186, 44, 89, 235, 2, 55, 179, 172, 21, 239, 126, 252, 226, 59, 53, 104, 206, 44, 12, 145, 19, 36, 171, 61, 20, 219, 224, 4, 106, 175, 157, 124, 193, 62, 132, 64, 139, 202 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApiSuccess",
                table: "DocumentReferences");

            migrationBuilder.AlterColumn<string>(
                name: "Reference",
                table: "DocumentReferences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Variety",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ExternalReference",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CertifiedCopy",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "DxNumber",
                table: "Addresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 6, 12, 7, 30, 292, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 6, 12, 7, 30, 293, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 6, 12, 7, 30, 293, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 6, 12, 7, 30, 293, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 6, 12, 7, 30, 293, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 6, 12, 7, 30, 293, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 6, 12, 7, 30, 293, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 6, 12, 7, 30, 293, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 21, 84, 155, 76, 196, 1, 173, 123, 118, 41, 72, 11, 70, 244, 76, 254, 45, 2, 14, 181, 236, 122, 231, 182, 82, 253, 127, 59, 216, 93, 114, 180, 1, 93, 79, 186, 57, 102, 207, 26, 213, 209, 139, 185, 192, 171, 62, 62, 123, 45, 102, 49, 151, 164, 151, 51, 87, 126, 174, 222, 58, 116, 156, 23 }, new byte[] { 68, 243, 30, 214, 121, 222, 10, 159, 198, 254, 121, 148, 234, 228, 101, 125, 37, 166, 113, 104, 181, 235, 117, 46, 234, 13, 36, 161, 99, 61, 38, 223, 123, 98, 16, 42, 51, 106, 239, 78, 130, 91, 98, 116, 183, 65, 10, 59, 2, 104, 16, 3, 209, 132, 151, 56, 73, 237, 206, 160, 93, 158, 131, 92, 134, 106, 111, 149, 126, 52, 230, 76, 234, 233, 90, 11, 8, 56, 29, 54, 25, 47, 129, 35, 31, 50, 33, 159, 18, 234, 27, 228, 133, 221, 73, 1, 174, 126, 91, 100, 114, 73, 33, 82, 12, 115, 178, 154, 128, 210, 177, 44, 169, 156, 0, 244, 231, 236, 181, 12, 33, 160, 132, 12, 83, 4, 222, 10 } });
        }
    }
}
