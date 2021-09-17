using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationService",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "ApplicationType",
                table: "SupportingDocuments");

            migrationBuilder.AlterColumn<string>(
                name: "ExternalReference",
                table: "SupportingDocuments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocumentType",
                table: "SupportingDocuments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocumentName",
                table: "SupportingDocuments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CertifiedCopy",
                table: "SupportingDocuments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationMessageId",
                table: "SupportingDocuments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalProviderFilter",
                table: "SupportingDocuments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Representations",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Roles",
                table: "Parties",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartyType",
                table: "Parties",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyOrForeName",
                table: "Parties",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Documents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                table: "Documents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Base64",
                table: "Documents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsMdRef",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExternalReference",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "DocumentType",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "DocumentName",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CertifiedCopy",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationMessageId",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalProviderFilter",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationService",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationType",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Representations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Roles",
                table: "Parties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PartyType",
                table: "Parties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyOrForeName",
                table: "Parties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Base64",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "IsMdRef",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
    }
}
