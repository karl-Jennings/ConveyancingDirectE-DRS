using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class careofaddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CareOfName",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareOfReference",
                table: "Representations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 231, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 19, 0, 14, 233, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 155, 74, 158, 156, 223, 155, 221, 159, 209, 169, 128, 155, 118, 31, 224, 132, 176, 93, 142, 185, 9, 212, 161, 239, 181, 7, 66, 178, 224, 177, 186, 220, 118, 113, 133, 161, 224, 139, 149, 127, 141, 114, 148, 253, 40, 70, 222, 127, 108, 255, 7, 209, 201, 236, 144, 207, 103, 2, 130, 103, 193, 34, 168, 146 }, new byte[] { 240, 164, 185, 30, 241, 11, 149, 58, 62, 134, 86, 96, 159, 92, 172, 93, 71, 219, 16, 55, 242, 218, 96, 45, 215, 168, 144, 12, 208, 132, 209, 181, 5, 97, 215, 91, 164, 128, 75, 215, 97, 234, 198, 45, 4, 130, 28, 80, 56, 205, 89, 200, 1, 217, 108, 123, 17, 0, 35, 232, 188, 36, 65, 84, 106, 64, 141, 59, 186, 203, 234, 235, 222, 7, 42, 225, 118, 249, 104, 111, 159, 65, 180, 173, 184, 94, 210, 37, 223, 65, 111, 74, 116, 16, 71, 20, 23, 21, 207, 115, 214, 32, 228, 17, 172, 144, 139, 216, 178, 167, 48, 0, 57, 170, 202, 236, 223, 82, 130, 215, 222, 82, 246, 100, 165, 226, 211, 37 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareOfName",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "CareOfReference",
                table: "Representations");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 209, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 168, 230, 90, 118, 43, 8, 97, 64, 63, 192, 24, 37, 206, 224, 60, 1, 7, 236, 150, 253, 249, 147, 96, 131, 43, 185, 252, 33, 79, 84, 140, 186, 39, 228, 205, 227, 153, 247, 169, 205, 235, 177, 214, 47, 210, 18, 121, 232, 88, 61, 117, 174, 47, 233, 124, 156, 197, 120, 209, 28, 97, 223, 185, 96 }, new byte[] { 157, 255, 190, 23, 107, 236, 205, 8, 39, 234, 117, 252, 226, 88, 173, 116, 130, 74, 132, 241, 104, 105, 32, 99, 66, 7, 62, 164, 69, 32, 219, 62, 65, 214, 42, 65, 206, 25, 184, 157, 211, 239, 161, 71, 25, 218, 100, 246, 126, 238, 229, 7, 106, 16, 225, 110, 58, 103, 129, 202, 237, 24, 134, 213, 206, 184, 252, 206, 156, 193, 93, 214, 112, 147, 42, 124, 234, 24, 189, 147, 29, 152, 39, 240, 233, 79, 196, 192, 196, 40, 246, 66, 48, 220, 208, 184, 118, 221, 139, 240, 138, 109, 33, 180, 97, 143, 15, 27, 208, 86, 156, 100, 225, 16, 229, 27, 201, 244, 152, 192, 71, 95, 81, 24, 247, 16, 53, 95 } });
        }
    }
}
