using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class editLeaseExtUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 265, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "lease_ext", new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8079), "lease-extension" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 16, 255, 43, 39, 121, 35, 7, 30, 253, 204, 57, 189, 240, 223, 89, 211, 131, 59, 72, 34, 93, 110, 100, 173, 160, 104, 143, 216, 80, 105, 130, 153, 140, 32, 225, 28, 235, 181, 116, 0, 177, 6, 63, 32, 124, 52, 139, 88, 75, 51, 188, 53, 91, 188, 36, 179, 246, 54, 81, 129, 101, 150, 203 }, new byte[] { 244, 43, 133, 38, 238, 142, 95, 114, 1, 33, 59, 241, 129, 88, 113, 202, 99, 196, 83, 216, 192, 85, 205, 139, 41, 175, 131, 159, 142, 67, 67, 73, 252, 211, 102, 214, 97, 153, 223, 232, 16, 135, 188, 248, 57, 164, 139, 169, 199, 7, 51, 37, 221, 68, 112, 118, 60, 214, 26, 155, 244, 147, 150, 238, 103, 1, 91, 63, 79, 135, 222, 82, 213, 126, 125, 0, 24, 13, 32, 119, 171, 128, 205, 67, 171, 171, 184, 233, 107, 66, 191, 180, 143, 46, 196, 88, 98, 242, 24, 23, 164, 50, 197, 72, 44, 243, 13, 231, 136, 249, 18, 198, 110, 6, 4, 120, 234, 250, 136, 232, 40, 123, 58, 104, 39, 251, 126, 226 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 455, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "transfer", new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6498), "transfer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 239, 166, 212, 236, 183, 35, 198, 197, 197, 160, 89, 50, 166, 124, 152, 197, 41, 146, 77, 38, 130, 84, 157, 202, 123, 28, 200, 220, 43, 233, 17, 247, 173, 153, 250, 199, 25, 51, 21, 47, 116, 77, 12, 198, 139, 137, 30, 43, 186, 141, 203, 230, 120, 159, 79, 213, 44, 10, 108, 235, 56, 164, 126 }, new byte[] { 202, 79, 117, 56, 25, 137, 156, 70, 147, 77, 31, 171, 217, 189, 219, 70, 204, 156, 104, 61, 190, 218, 25, 41, 7, 98, 173, 99, 26, 154, 84, 200, 211, 106, 191, 114, 143, 240, 112, 162, 154, 50, 167, 25, 29, 25, 145, 141, 251, 202, 243, 228, 43, 206, 246, 255, 185, 156, 108, 74, 40, 12, 205, 55, 149, 239, 189, 166, 152, 75, 216, 41, 239, 233, 217, 51, 49, 58, 152, 221, 27, 49, 239, 65, 139, 231, 122, 145, 200, 209, 44, 46, 56, 22, 193, 10, 255, 178, 205, 211, 170, 38, 152, 212, 99, 105, 131, 236, 100, 146, 33, 247, 225, 217, 177, 229, 224, 154, 240, 237, 208, 237, 45, 67, 6, 29, 95, 25 } });
        }
    }
}
