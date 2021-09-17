using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class dxNumberToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DxNumber",
                table: "Representations",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "DxNumber",
                table: "Representations",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 187, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 140, 191, 152, 108, 208, 230, 52, 230, 131, 155, 254, 156, 17, 124, 174, 35, 37, 94, 145, 47, 38, 127, 92, 68, 189, 18, 158, 141, 219, 140, 119, 78, 157, 163, 170, 18, 223, 41, 221, 242, 63, 198, 218, 205, 195, 205, 185, 129, 226, 47, 80, 94, 142, 169, 62, 77, 58, 223, 231, 156, 14, 149, 63, 85 }, new byte[] { 231, 238, 155, 214, 215, 123, 15, 136, 157, 204, 103, 100, 141, 145, 35, 212, 164, 26, 89, 79, 69, 96, 193, 86, 240, 103, 245, 65, 46, 235, 113, 149, 91, 64, 110, 121, 189, 137, 245, 151, 30, 182, 7, 135, 59, 51, 118, 80, 105, 61, 4, 194, 225, 199, 148, 125, 99, 47, 173, 6, 81, 137, 16, 239, 17, 219, 27, 170, 253, 197, 36, 50, 41, 164, 47, 132, 95, 165, 34, 128, 11, 204, 59, 213, 185, 14, 157, 177, 235, 67, 139, 29, 159, 116, 227, 112, 153, 9, 225, 129, 123, 214, 214, 195, 213, 113, 125, 155, 53, 69, 119, 203, 49, 31, 5, 92, 79, 158, 236, 210, 31, 51, 146, 136, 135, 89, 148, 97 } });
        }
    }
}
