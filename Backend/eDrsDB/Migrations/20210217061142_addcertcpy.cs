using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class addcertcpy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Documents_ApplicationFormId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "CertifiedCopy",
                table: "Documents");

            migrationBuilder.AddColumn<string>(
                name: "CertifiedCopy",
                table: "ApplicationForms",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ApplicationFormId",
                table: "Documents",
                column: "ApplicationFormId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Documents_ApplicationFormId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "CertifiedCopy",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<string>(
                name: "CertifiedCopy",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ApplicationFormId",
                table: "Documents",
                column: "ApplicationFormId");
        }
    }
}
