using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class base64add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_ApplicationForms_ApplicationFormId1",
                table: "ApplicationForms");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_ApplicationFormId1",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "ApplicationFormId1",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<string>(
                name: "Base64",
                table: "Documents",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 19, 33, 39, 593, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 19, 33, 39, 594, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 19, 33, 39, 594, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 19, 33, 39, 594, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 19, 33, 39, 594, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 168, 105, 154, 86, 9, 180, 38, 21, 25, 155, 80, 229, 49, 130, 137, 226, 22, 93, 201, 154, 202, 182, 209, 22, 116, 31, 77, 216, 250, 15, 169, 125, 236, 239, 85, 158, 226, 129, 95, 110, 90, 188, 76, 93, 153, 202, 118, 30, 156, 186, 14, 216, 63, 246, 244, 200, 68, 190, 4, 69, 217, 254, 37, 61 }, new byte[] { 205, 64, 86, 208, 115, 123, 27, 158, 247, 65, 198, 26, 162, 236, 80, 19, 81, 250, 105, 110, 203, 79, 214, 221, 173, 175, 136, 212, 221, 219, 251, 214, 135, 114, 110, 253, 207, 182, 100, 159, 16, 13, 9, 121, 173, 151, 12, 155, 77, 134, 88, 0, 149, 43, 2, 135, 247, 190, 215, 93, 83, 229, 57, 70, 149, 140, 248, 241, 137, 177, 126, 178, 44, 202, 122, 134, 42, 89, 150, 218, 15, 136, 89, 94, 154, 92, 204, 119, 0, 23, 108, 102, 104, 122, 126, 151, 172, 172, 20, 231, 162, 99, 243, 99, 225, 164, 37, 254, 50, 238, 138, 105, 251, 244, 184, 66, 239, 245, 235, 3, 180, 24, 33, 35, 226, 44, 162, 53 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64",
                table: "Documents");

            migrationBuilder.AddColumn<long>(
                name: "ApplicationFormId1",
                table: "ApplicationForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 775, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 106, 141, 231, 2, 163, 53, 157, 242, 20, 231, 71, 214, 252, 221, 47, 142, 2, 125, 131, 223, 69, 35, 59, 61, 138, 186, 242, 162, 66, 246, 156, 248, 7, 95, 73, 42, 32, 31, 202, 127, 157, 2, 98, 27, 56, 105, 129, 78, 220, 190, 229, 190, 90, 233, 20, 125, 229, 44, 132, 215, 147, 75, 219, 121 }, new byte[] { 115, 123, 0, 178, 96, 138, 253, 192, 2, 255, 154, 203, 4, 249, 114, 62, 250, 222, 93, 233, 110, 250, 93, 131, 88, 206, 248, 25, 9, 204, 1, 59, 60, 52, 177, 11, 111, 49, 230, 142, 107, 46, 135, 14, 114, 240, 71, 188, 151, 212, 233, 242, 185, 87, 181, 36, 166, 69, 106, 138, 68, 51, 123, 220, 104, 225, 87, 193, 31, 160, 215, 23, 221, 248, 105, 83, 42, 172, 193, 212, 12, 230, 33, 80, 102, 87, 212, 41, 162, 212, 18, 73, 3, 132, 39, 236, 202, 243, 29, 68, 132, 228, 179, 102, 169, 225, 109, 220, 124, 57, 143, 66, 28, 107, 128, 132, 147, 223, 197, 2, 48, 188, 66, 30, 120, 251, 176, 40 } });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_ApplicationFormId1",
                table: "ApplicationForms",
                column: "ApplicationFormId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_ApplicationForms_ApplicationFormId1",
                table: "ApplicationForms",
                column: "ApplicationFormId1",
                principalTable: "ApplicationForms",
                principalColumn: "ApplicationFormId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
