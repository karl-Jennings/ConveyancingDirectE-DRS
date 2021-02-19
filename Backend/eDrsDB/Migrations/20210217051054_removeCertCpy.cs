using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class removeCertCpy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertifiedCopy",
                table: "ApplicationForms");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 40, 53, 637, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 40, 53, 638, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 40, 53, 638, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 40, 53, 638, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 40, 53, 638, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 11, 61, 70, 27, 76, 183, 66, 83, 202, 10, 229, 14, 173, 64, 39, 207, 110, 31, 210, 27, 1, 3, 225, 203, 36, 164, 28, 104, 140, 53, 253, 40, 233, 255, 61, 178, 130, 55, 191, 81, 149, 218, 190, 43, 243, 176, 155, 196, 128, 160, 31, 95, 132, 138, 180, 28, 35, 47, 182, 217, 34, 32, 62, 23 }, new byte[] { 14, 3, 28, 57, 195, 18, 113, 152, 103, 52, 8, 178, 173, 134, 69, 126, 131, 75, 179, 51, 9, 80, 157, 194, 85, 81, 251, 77, 229, 102, 37, 122, 193, 126, 252, 42, 60, 97, 7, 136, 169, 72, 219, 131, 128, 185, 176, 129, 208, 13, 215, 98, 32, 60, 190, 84, 72, 157, 70, 232, 187, 109, 240, 246, 14, 217, 132, 173, 140, 135, 233, 122, 187, 70, 176, 240, 160, 136, 150, 150, 11, 182, 159, 203, 49, 70, 240, 107, 201, 47, 235, 77, 147, 85, 87, 39, 164, 184, 21, 4, 62, 121, 60, 132, 249, 244, 192, 166, 206, 127, 165, 76, 166, 21, 127, 193, 16, 240, 227, 174, 196, 47, 226, 189, 200, 55, 6, 248 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CertifiedCopy",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 329, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 330, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 330, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 330, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 330, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 242, 132, 209, 35, 112, 202, 49, 61, 236, 156, 189, 224, 3, 156, 165, 196, 209, 162, 90, 18, 124, 247, 76, 37, 215, 219, 54, 236, 203, 236, 73, 107, 84, 227, 104, 4, 251, 83, 17, 236, 210, 221, 248, 39, 206, 125, 22, 135, 86, 216, 23, 136, 28, 27, 167, 30, 140, 137, 196, 29, 165, 175, 197, 232 }, new byte[] { 9, 156, 178, 248, 243, 251, 9, 130, 15, 249, 171, 118, 88, 164, 135, 207, 92, 45, 237, 113, 15, 205, 60, 208, 162, 32, 128, 115, 245, 44, 167, 6, 27, 44, 227, 244, 13, 29, 28, 153, 94, 246, 53, 179, 230, 75, 63, 78, 229, 147, 31, 67, 100, 253, 218, 10, 88, 19, 144, 202, 63, 22, 112, 170, 14, 174, 70, 170, 104, 35, 174, 172, 180, 205, 81, 49, 95, 168, 225, 219, 76, 22, 181, 155, 22, 199, 93, 12, 21, 125, 12, 197, 91, 136, 33, 158, 75, 248, 13, 208, 89, 235, 39, 190, 74, 50, 191, 85, 17, 130, 208, 28, 130, 176, 36, 139, 233, 11, 123, 193, 141, 171, 70, 133, 184, 71, 155, 133 } });
        }
    }
}
