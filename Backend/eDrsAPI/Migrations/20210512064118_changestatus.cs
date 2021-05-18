using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class changestatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OverallStatus",
                table: "DocumentReferences",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 12, 12, 11, 18, 294, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 12, 12, 11, 18, 295, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 12, 12, 11, 18, 295, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 12, 12, 11, 18, 295, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 12, 12, 11, 18, 295, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 12, 12, 11, 18, 295, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 12, 12, 11, 18, 295, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 5, 12, 12, 11, 18, 295, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 252, 70, 175, 250, 145, 136, 190, 232, 63, 62, 96, 55, 230, 65, 217, 254, 167, 156, 42, 41, 170, 205, 101, 232, 88, 75, 183, 150, 231, 12, 131, 37, 125, 163, 87, 218, 208, 110, 34, 61, 151, 49, 168, 133, 216, 55, 87, 176, 20, 50, 147, 203, 126, 130, 209, 87, 91, 240, 52, 163, 63, 197, 166, 199 }, new byte[] { 42, 190, 211, 137, 6, 84, 18, 56, 111, 212, 217, 85, 126, 89, 197, 228, 69, 17, 101, 29, 148, 170, 191, 128, 178, 43, 220, 122, 132, 126, 163, 75, 30, 196, 80, 26, 17, 144, 186, 219, 20, 14, 195, 100, 124, 47, 210, 128, 190, 186, 191, 233, 87, 193, 151, 197, 72, 182, 209, 27, 30, 0, 24, 25, 135, 105, 203, 4, 176, 74, 222, 23, 160, 112, 101, 243, 124, 116, 6, 245, 99, 126, 81, 18, 163, 152, 175, 249, 76, 181, 245, 29, 75, 139, 103, 115, 220, 219, 152, 43, 136, 199, 85, 66, 54, 174, 65, 19, 180, 24, 186, 104, 162, 38, 201, 123, 237, 39, 137, 232, 54, 107, 41, 74, 78, 133, 215, 220 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "OverallStatus",
                table: "DocumentReferences",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
