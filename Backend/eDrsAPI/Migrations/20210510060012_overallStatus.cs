using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class overallStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "DocumentReferences");

            migrationBuilder.AddColumn<bool>(
                name: "OverallStatus",
                table: "DocumentReferences",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 10, 11, 30, 11, 737, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 10, 11, 30, 11, 738, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 10, 11, 30, 11, 738, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 10, 11, 30, 11, 738, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 10, 11, 30, 11, 738, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 10, 11, 30, 11, 738, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 10, 11, 30, 11, 738, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 10, 11, 30, 11, 738, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 211, 99, 90, 81, 220, 56, 17, 32, 136, 81, 207, 191, 9, 82, 136, 89, 112, 131, 214, 128, 51, 165, 187, 238, 172, 16, 47, 43, 198, 166, 218, 56, 59, 195, 61, 159, 165, 47, 189, 42, 98, 42, 112, 72, 154, 246, 164, 63, 216, 70, 120, 31, 187, 134, 38, 210, 9, 224, 86, 114, 39, 215, 107, 47 }, new byte[] { 206, 31, 200, 223, 122, 18, 106, 79, 214, 22, 198, 42, 6, 15, 69, 148, 90, 169, 44, 161, 238, 160, 101, 86, 190, 191, 215, 107, 101, 193, 194, 39, 195, 121, 95, 4, 117, 43, 40, 97, 51, 130, 62, 36, 57, 46, 173, 6, 124, 41, 171, 50, 172, 122, 198, 91, 72, 228, 18, 114, 176, 140, 15, 66, 63, 177, 113, 188, 112, 66, 243, 173, 166, 91, 115, 65, 211, 154, 231, 211, 134, 12, 0, 225, 138, 91, 38, 12, 17, 136, 125, 87, 176, 111, 136, 227, 157, 105, 7, 251, 200, 59, 78, 199, 146, 9, 198, 117, 237, 33, 208, 25, 78, 159, 228, 169, 112, 120, 122, 89, 12, 196, 0, 242, 63, 63, 73, 213 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverallStatus",
                table: "DocumentReferences");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "DocumentReferences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 12, 17, 37, 28, 931, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 12, 17, 37, 28, 932, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 12, 17, 37, 28, 932, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 12, 17, 37, 28, 932, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 12, 17, 37, 28, 932, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 12, 17, 37, 28, 932, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 12, 17, 37, 28, 932, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 12, 17, 37, 28, 932, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 127, 113, 55, 52, 241, 54, 91, 166, 79, 177, 39, 65, 30, 95, 222, 12, 135, 13, 146, 253, 141, 142, 37, 110, 243, 160, 160, 217, 132, 225, 215, 194, 117, 225, 228, 150, 34, 53, 15, 149, 67, 82, 253, 98, 126, 5, 157, 170, 33, 154, 71, 228, 215, 36, 80, 28, 174, 97, 245, 62, 58, 160, 185, 105 }, new byte[] { 127, 67, 195, 243, 99, 247, 127, 128, 58, 186, 14, 6, 158, 51, 132, 37, 43, 243, 232, 195, 26, 27, 10, 126, 226, 8, 220, 253, 211, 180, 133, 228, 55, 5, 169, 223, 36, 224, 213, 235, 134, 121, 17, 157, 27, 215, 108, 13, 33, 5, 28, 213, 110, 237, 9, 49, 82, 153, 62, 202, 10, 40, 240, 103, 212, 144, 120, 65, 71, 78, 128, 253, 170, 54, 222, 136, 160, 239, 240, 81, 28, 127, 3, 237, 49, 189, 17, 213, 45, 210, 119, 167, 163, 120, 56, 44, 132, 126, 204, 155, 226, 22, 192, 18, 225, 253, 17, 75, 98, 157, 3, 126, 35, 138, 132, 40, 52, 142, 71, 188, 224, 190, 197, 118, 224, 174, 140, 83 } });
        }
    }
}
