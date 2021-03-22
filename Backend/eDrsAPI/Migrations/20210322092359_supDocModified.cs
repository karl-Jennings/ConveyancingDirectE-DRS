using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class supDocModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "DocumentId",
                table: "SupportingDocuments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalProviderFilter",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationMessageId",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationService",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Base64",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalReference",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "MessageId",
                table: "SupportingDocuments",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 14, 53, 58, 31, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 14, 53, 58, 32, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 14, 53, 58, 32, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 14, 53, 58, 32, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 14, 53, 58, 32, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 14, 53, 58, 32, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 14, 53, 58, 32, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 14, 53, 58, 32, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 217, 68, 226, 123, 161, 9, 197, 89, 90, 231, 66, 105, 99, 176, 227, 138, 234, 68, 190, 54, 213, 226, 28, 10, 241, 161, 16, 199, 205, 114, 127, 114, 249, 118, 34, 205, 6, 119, 123, 244, 51, 213, 9, 238, 130, 31, 154, 69, 69, 188, 26, 92, 128, 184, 115, 87, 158, 119, 186, 235, 189, 193, 245, 169 }, new byte[] { 71, 128, 200, 135, 1, 179, 127, 46, 79, 230, 162, 138, 252, 134, 51, 217, 233, 39, 106, 224, 1, 60, 244, 109, 89, 48, 203, 25, 158, 123, 255, 115, 153, 2, 197, 145, 73, 248, 105, 208, 103, 209, 215, 130, 9, 157, 1, 253, 121, 220, 121, 118, 162, 57, 104, 49, 246, 152, 252, 46, 57, 247, 142, 21, 227, 118, 160, 185, 90, 55, 176, 190, 149, 10, 73, 69, 16, 65, 104, 237, 172, 227, 212, 186, 97, 35, 148, 255, 238, 21, 249, 138, 245, 86, 91, 167, 110, 32, 234, 135, 160, 111, 60, 110, 171, 140, 119, 111, 103, 175, 171, 215, 67, 24, 22, 227, 55, 174, 96, 105, 226, 248, 58, 73, 25, 205, 38, 151 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalProviderFilter",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "ApplicationMessageId",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "ApplicationService",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "Base64",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "ExternalReference",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "SupportingDocuments");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentId",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 18, 15, 52, 22, 424, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 171, 97, 4, 246, 184, 214, 163, 128, 239, 183, 207, 159, 149, 61, 245, 31, 57, 108, 69, 65, 237, 66, 35, 57, 40, 36, 236, 179, 162, 76, 238, 128, 41, 145, 213, 100, 7, 43, 123, 46, 178, 45, 188, 92, 174, 97, 229, 64, 29, 145, 129, 188, 54, 144, 43, 254, 50, 156, 55, 89, 8, 218, 103, 129 }, new byte[] { 177, 226, 152, 130, 119, 167, 31, 27, 164, 218, 163, 235, 1, 37, 210, 54, 207, 201, 47, 197, 232, 61, 52, 129, 255, 228, 56, 246, 72, 196, 149, 219, 244, 219, 247, 20, 181, 64, 129, 202, 205, 0, 125, 231, 41, 67, 81, 13, 99, 76, 186, 205, 178, 77, 89, 56, 96, 76, 61, 26, 240, 152, 0, 36, 50, 162, 5, 176, 146, 69, 182, 93, 76, 219, 198, 156, 155, 147, 72, 166, 47, 43, 183, 90, 17, 194, 216, 62, 10, 91, 204, 68, 241, 228, 161, 59, 45, 41, 94, 99, 51, 127, 202, 182, 212, 201, 141, 1, 243, 213, 28, 252, 54, 141, 235, 141, 116, 71, 134, 237, 100, 122, 46, 194, 7, 200, 192, 112 } });
        }
    }
}
