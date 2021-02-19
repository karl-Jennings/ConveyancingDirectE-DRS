using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class TPtoStr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                table: "DocumentReferences",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 47, 8, 344, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 47, 8, 345, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 47, 8, 345, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 47, 8, 345, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 47, 8, 345, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 93, 171, 166, 28, 14, 74, 133, 102, 136, 40, 224, 205, 62, 14, 26, 173, 229, 224, 177, 155, 121, 240, 44, 248, 59, 144, 218, 60, 225, 157, 86, 128, 124, 94, 101, 153, 143, 192, 106, 129, 196, 49, 5, 85, 10, 105, 163, 108, 114, 22, 241, 94, 50, 236, 139, 77, 164, 203, 163, 35, 90, 7, 21, 57 }, new byte[] { 226, 115, 157, 109, 212, 24, 201, 189, 204, 173, 201, 31, 41, 61, 116, 228, 58, 199, 89, 90, 0, 116, 32, 122, 58, 107, 160, 31, 84, 67, 36, 183, 116, 61, 83, 16, 105, 207, 215, 46, 26, 153, 57, 197, 220, 93, 166, 152, 225, 68, 94, 92, 194, 130, 61, 73, 163, 39, 220, 9, 171, 224, 57, 228, 6, 158, 33, 16, 19, 146, 19, 41, 149, 239, 62, 215, 206, 53, 241, 254, 78, 216, 90, 144, 78, 61, 8, 100, 110, 155, 147, 40, 116, 15, 74, 60, 20, 30, 131, 27, 229, 0, 200, 224, 170, 45, 250, 190, 99, 136, 16, 6, 215, 231, 14, 203, 153, 34, 114, 231, 172, 164, 132, 59, 93, 122, 165, 117 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TelephoneNumber",
                table: "DocumentReferences",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 41, 42, 87, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 41, 42, 88, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 41, 42, 88, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 41, 42, 88, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 11, 41, 42, 88, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 37, 35, 235, 39, 123, 97, 220, 155, 30, 212, 206, 119, 239, 135, 59, 246, 168, 11, 55, 32, 178, 255, 35, 13, 232, 141, 97, 254, 96, 166, 17, 24, 187, 238, 233, 218, 196, 113, 50, 227, 191, 57, 166, 46, 68, 107, 134, 242, 30, 54, 109, 197, 170, 2, 116, 96, 82, 74, 214, 36, 129, 183, 23, 211 }, new byte[] { 245, 79, 27, 162, 141, 227, 143, 107, 41, 240, 230, 239, 131, 119, 165, 40, 52, 232, 222, 40, 108, 242, 243, 50, 89, 59, 154, 246, 148, 42, 176, 137, 144, 169, 71, 31, 116, 235, 218, 50, 219, 64, 136, 95, 91, 255, 115, 96, 89, 108, 78, 37, 239, 191, 215, 213, 92, 36, 106, 236, 146, 182, 47, 182, 6, 85, 120, 67, 148, 136, 255, 117, 63, 172, 101, 88, 196, 148, 114, 177, 209, 185, 142, 191, 203, 114, 179, 196, 145, 137, 47, 215, 235, 40, 161, 107, 80, 251, 240, 140, 103, 106, 88, 210, 166, 72, 17, 26, 70, 122, 23, 69, 50, 56, 249, 189, 187, 77, 204, 52, 84, 235, 198, 179, 121, 39, 195, 181 } });
        }
    }
}
