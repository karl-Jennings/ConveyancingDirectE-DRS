using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class apptype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "SupportingDocuments");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationType",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 634, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 231, 222, 183, 20, 254, 199, 222, 97, 101, 7, 19, 144, 55, 30, 134, 240, 190, 228, 143, 215, 225, 15, 156, 198, 235, 158, 132, 70, 5, 104, 74, 104, 129, 21, 54, 202, 67, 90, 138, 45, 155, 150, 119, 6, 9, 243, 4, 78, 209, 3, 205, 78, 4, 133, 96, 53, 125, 136, 70, 78, 208, 235, 218, 194 }, new byte[] { 104, 4, 184, 73, 166, 100, 155, 95, 230, 234, 92, 106, 227, 96, 68, 97, 176, 33, 104, 83, 170, 198, 239, 231, 9, 215, 170, 144, 242, 218, 60, 121, 187, 104, 28, 12, 113, 94, 183, 25, 56, 23, 225, 217, 3, 14, 163, 197, 197, 122, 216, 26, 39, 98, 203, 51, 201, 136, 155, 205, 98, 138, 202, 71, 151, 132, 52, 38, 164, 218, 182, 124, 83, 31, 168, 251, 185, 110, 103, 127, 197, 247, 26, 74, 87, 93, 43, 30, 226, 25, 224, 68, 46, 117, 130, 127, 201, 137, 154, 130, 59, 236, 92, 164, 37, 246, 105, 229, 70, 248, 77, 10, 121, 104, 29, 111, 120, 187, 118, 230, 232, 120, 105, 68, 211, 12, 73, 38 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationType",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "SupportingDocuments");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "SupportingDocuments",
                type: "nvarchar(max)",
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
    }
}
