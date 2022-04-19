using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ApplicationFormTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 884, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 74, 4, 233, 87, 191, 236, 80, 116, 248, 136, 187, 101, 199, 10, 18, 193, 50, 211, 123, 67, 145, 79, 136, 76, 90, 146, 223, 183, 114, 215, 196, 145, 47, 223, 71, 25, 72, 246, 93, 202, 43, 233, 249, 71, 106, 214, 215, 68, 141, 186, 103, 31, 121, 181, 252, 247, 243, 250, 209, 1, 179, 119, 169, 0 }, new byte[] { 190, 71, 138, 12, 212, 94, 62, 200, 208, 169, 54, 124, 67, 13, 107, 23, 171, 115, 86, 251, 196, 43, 204, 187, 201, 74, 228, 43, 25, 8, 199, 131, 108, 14, 149, 88, 100, 88, 37, 226, 148, 124, 23, 80, 55, 36, 217, 39, 98, 27, 23, 19, 154, 38, 8, 177, 77, 195, 83, 41, 95, 232, 70, 237, 201, 2, 11, 110, 171, 219, 223, 234, 15, 47, 198, 82, 156, 147, 126, 218, 145, 78, 10, 174, 30, 198, 53, 71, 246, 45, 137, 96, 135, 111, 202, 181, 174, 241, 215, 171, 60, 62, 14, 171, 98, 111, 126, 211, 119, 211, 203, 191, 54, 230, 146, 254, 190, 103, 82, 157, 245, 167, 34, 198, 11, 42, 56, 219 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 658, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 188, 145, 163, 36, 131, 177, 248, 77, 236, 237, 33, 100, 77, 197, 78, 124, 21, 30, 134, 236, 230, 106, 45, 5, 120, 165, 22, 228, 62, 3, 115, 82, 63, 133, 143, 174, 196, 16, 82, 3, 190, 15, 40, 163, 214, 69, 17, 221, 69, 48, 51, 17, 8, 214, 168, 109, 244, 219, 104, 91, 122, 217, 47 }, new byte[] { 201, 2, 201, 85, 173, 103, 253, 15, 5, 93, 77, 175, 75, 64, 104, 192, 27, 246, 183, 201, 174, 70, 169, 45, 240, 214, 132, 120, 67, 166, 164, 204, 49, 245, 32, 220, 157, 229, 201, 81, 208, 146, 121, 12, 50, 203, 148, 211, 23, 208, 59, 67, 67, 223, 55, 116, 178, 117, 65, 163, 247, 212, 57, 84, 209, 159, 140, 62, 233, 71, 49, 119, 221, 251, 52, 182, 184, 229, 86, 159, 53, 163, 92, 249, 111, 49, 110, 104, 70, 30, 175, 153, 12, 16, 5, 202, 45, 87, 53, 66, 231, 254, 56, 174, 80, 9, 250, 234, 244, 116, 33, 212, 86, 193, 114, 236, 13, 203, 11, 60, 5, 242, 198, 252, 66, 171, 120, 38 } });
        }
    }
}
