using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class msgId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_TitleNumbers_TitleNumberId",
                table: "ApplicationForms");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_TitleNumberId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "TitleNumberId",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<string>(
                name: "MessageID",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 892, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 894, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 894, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 894, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 894, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 158, 168, 220, 159, 198, 152, 214, 147, 61, 162, 197, 210, 100, 135, 218, 108, 26, 33, 168, 80, 231, 227, 110, 201, 178, 163, 57, 182, 159, 16, 41, 162, 244, 46, 14, 47, 10, 163, 71, 136, 152, 208, 217, 207, 2, 78, 245, 184, 73, 143, 191, 154, 138, 114, 38, 11, 72, 253, 239, 2, 27, 101, 164, 214 }, new byte[] { 74, 47, 134, 137, 191, 36, 109, 181, 96, 67, 64, 161, 76, 175, 24, 87, 117, 164, 164, 160, 156, 116, 86, 204, 182, 158, 87, 216, 185, 205, 206, 88, 95, 205, 29, 244, 157, 42, 26, 97, 196, 4, 222, 81, 68, 250, 127, 197, 95, 88, 217, 156, 127, 255, 14, 192, 186, 137, 8, 154, 139, 38, 161, 191, 199, 126, 245, 66, 207, 24, 26, 59, 83, 11, 101, 174, 153, 9, 230, 11, 143, 180, 110, 34, 148, 156, 144, 136, 97, 145, 54, 238, 71, 158, 166, 127, 206, 247, 233, 101, 180, 15, 159, 36, 44, 150, 94, 164, 251, 25, 144, 215, 141, 171, 112, 170, 59, 89, 141, 29, 32, 26, 243, 226, 90, 97, 53, 93 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageID",
                table: "DocumentReferences");

            migrationBuilder.AddColumn<long>(
                name: "TitleNumberId",
                table: "ApplicationForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 21, 29, 30, 507, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 21, 29, 30, 508, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 21, 29, 30, 508, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 21, 29, 30, 508, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 21, 29, 30, 508, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 213, 16, 62, 90, 216, 114, 4, 183, 89, 169, 41, 192, 2, 99, 141, 53, 252, 83, 56, 50, 151, 37, 56, 70, 73, 45, 185, 43, 90, 113, 101, 197, 199, 51, 129, 95, 57, 246, 109, 32, 166, 125, 179, 159, 61, 173, 172, 216, 25, 81, 205, 152, 72, 78, 64, 181, 225, 66, 39, 163, 105, 186, 233, 195 }, new byte[] { 167, 25, 229, 3, 180, 146, 253, 54, 4, 115, 239, 78, 252, 199, 111, 149, 133, 47, 49, 60, 130, 253, 208, 0, 215, 117, 179, 191, 128, 126, 110, 9, 113, 99, 66, 76, 111, 155, 107, 142, 63, 240, 163, 169, 142, 118, 128, 209, 238, 114, 17, 221, 7, 129, 59, 49, 2, 19, 108, 92, 9, 193, 200, 93, 175, 186, 204, 86, 191, 178, 192, 16, 25, 29, 26, 156, 34, 236, 216, 6, 44, 8, 11, 81, 161, 97, 232, 167, 109, 246, 136, 4, 245, 236, 165, 78, 52, 187, 5, 56, 61, 18, 93, 53, 75, 252, 144, 162, 160, 30, 110, 231, 62, 97, 76, 66, 44, 139, 25, 94, 164, 90, 255, 171, 125, 246, 35, 11 } });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_TitleNumberId",
                table: "ApplicationForms",
                column: "TitleNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_TitleNumbers_TitleNumberId",
                table: "ApplicationForms",
                column: "TitleNumberId",
                principalTable: "TitleNumbers",
                principalColumn: "TitleNumberId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
