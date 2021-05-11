using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class removelessee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LesseeTitleNumber",
                table: "TitleNumbers");

            migrationBuilder.AlterColumn<string>(
                name: "Roles",
                table: "Parties",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LesseeTitleNumber",
                table: "TitleNumbers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Roles",
                table: "Parties",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
