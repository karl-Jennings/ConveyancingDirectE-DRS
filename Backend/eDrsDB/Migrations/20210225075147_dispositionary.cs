using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class dispositionary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 241, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "dispositionary", new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2291), "dispositionary" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 181, 94, 156, 170, 92, 116, 139, 83, 96, 113, 63, 230, 18, 3, 103, 34, 237, 245, 214, 119, 108, 155, 217, 187, 50, 252, 197, 26, 221, 218, 88, 230, 230, 1, 32, 194, 224, 51, 7, 45, 114, 231, 13, 64, 93, 208, 182, 193, 34, 53, 51, 105, 150, 28, 239, 162, 41, 230, 27, 243, 166, 189, 91 }, new byte[] { 84, 226, 208, 69, 208, 104, 60, 253, 8, 127, 168, 75, 110, 113, 19, 188, 201, 105, 183, 204, 8, 169, 45, 43, 106, 176, 99, 185, 165, 243, 252, 10, 68, 215, 211, 129, 54, 79, 182, 245, 15, 230, 161, 124, 167, 212, 152, 28, 57, 184, 81, 125, 37, 43, 161, 45, 226, 54, 86, 225, 145, 193, 72, 188, 250, 223, 122, 132, 39, 165, 49, 226, 58, 104, 99, 214, 251, 147, 96, 216, 229, 69, 241, 38, 162, 119, 228, 130, 237, 89, 216, 117, 242, 215, 3, 224, 70, 206, 4, 241, 47, 226, 28, 245, 170, 202, 86, 248, 182, 169, 158, 166, 72, 76, 139, 241, 111, 168, 178, 202, 33, 182, 199, 217, 29, 89, 44, 178 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "transfer", new DateTime(2021, 2, 24, 9, 55, 3, 872, DateTimeKind.Local).AddTicks(556), "transfer" });

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
    }
}
