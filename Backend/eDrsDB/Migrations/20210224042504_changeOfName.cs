using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class changeOfName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 24, 9, 55, 3, 870, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "chngName", new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(554), "change-name" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 213, 105, 247, 186, 45, 197, 133, 76, 2, 115, 45, 200, 66, 86, 216, 59, 150, 53, 71, 76, 220, 153, 12, 230, 203, 33, 82, 200, 6, 250, 119, 38, 200, 226, 150, 223, 14, 152, 188, 196, 4, 153, 62, 154, 13, 218, 121, 5, 176, 104, 215, 105, 138, 96, 198, 206, 221, 51, 218, 58, 241, 86, 150, 88 }, new byte[] { 205, 39, 35, 241, 227, 191, 117, 237, 236, 17, 116, 11, 181, 227, 222, 187, 25, 139, 194, 115, 19, 16, 228, 112, 139, 248, 45, 51, 243, 139, 31, 21, 57, 229, 177, 249, 79, 157, 45, 17, 218, 191, 23, 134, 171, 49, 1, 166, 74, 122, 144, 68, 211, 191, 223, 194, 198, 245, 151, 110, 61, 99, 56, 172, 13, 117, 108, 96, 43, 243, 58, 140, 252, 50, 91, 109, 229, 126, 177, 249, 134, 40, 55, 120, 122, 89, 72, 158, 157, 193, 230, 182, 228, 156, 107, 253, 150, 145, 128, 163, 35, 54, 59, 194, 48, 50, 158, 214, 194, 127, 235, 141, 31, 110, 121, 96, 255, 245, 198, 176, 104, 81, 192, 117, 84, 119, 39, 75 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 435, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "transfer", new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6074), "transfer" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 147, 137, 65, 98, 232, 80, 159, 171, 12, 65, 214, 168, 164, 65, 163, 101, 200, 127, 75, 161, 208, 111, 4, 212, 76, 236, 122, 205, 10, 51, 36, 198, 176, 190, 175, 63, 150, 165, 9, 32, 143, 86, 85, 135, 62, 60, 46, 228, 10, 201, 21, 234, 132, 103, 39, 167, 45, 240, 238, 206, 137, 244, 108, 66 }, new byte[] { 232, 254, 143, 161, 131, 6, 103, 157, 43, 49, 84, 91, 44, 86, 78, 56, 73, 35, 49, 243, 227, 200, 27, 117, 48, 197, 3, 26, 190, 63, 96, 41, 40, 116, 231, 40, 45, 27, 169, 198, 86, 37, 8, 252, 240, 235, 143, 112, 19, 210, 254, 193, 56, 209, 22, 121, 161, 24, 120, 110, 115, 203, 143, 197, 198, 30, 59, 98, 74, 48, 152, 57, 154, 247, 220, 247, 86, 138, 60, 162, 251, 120, 193, 189, 74, 108, 97, 191, 129, 0, 69, 40, 20, 109, 7, 121, 53, 124, 117, 15, 210, 116, 120, 192, 230, 250, 99, 246, 184, 131, 29, 158, 6, 56, 48, 232, 245, 169, 8, 192, 156, 164, 218, 200, 254, 175, 8, 165 } });
        }
    }
}
