using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class userId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentReferences_Users_UserId",
                table: "DocumentReferences");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "DocumentReferences",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 894, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 10, 11, 35, 7, 895, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 90, 88, 214, 71, 202, 16, 67, 43, 240, 18, 89, 241, 201, 146, 185, 161, 65, 3, 167, 15, 32, 17, 164, 131, 218, 71, 181, 233, 90, 41, 247, 54, 119, 33, 235, 90, 61, 47, 123, 31, 193, 3, 27, 6, 179, 65, 26, 157, 109, 192, 235, 73, 74, 42, 183, 163, 10, 158, 26, 142, 192, 217, 220, 190 }, new byte[] { 4, 61, 22, 92, 58, 63, 129, 62, 125, 164, 112, 24, 251, 230, 212, 150, 78, 130, 82, 114, 4, 54, 26, 46, 17, 163, 48, 86, 100, 99, 86, 205, 131, 32, 24, 105, 217, 181, 128, 145, 100, 8, 65, 25, 37, 99, 172, 116, 158, 82, 116, 85, 159, 233, 218, 186, 248, 199, 163, 209, 100, 14, 49, 76, 166, 118, 177, 29, 236, 82, 72, 107, 105, 14, 242, 200, 191, 57, 59, 201, 216, 109, 1, 179, 238, 4, 249, 15, 77, 34, 218, 138, 183, 216, 184, 244, 143, 5, 40, 10, 93, 213, 106, 44, 11, 159, 22, 99, 99, 67, 147, 99, 6, 150, 193, 119, 93, 158, 143, 136, 211, 57, 21, 176, 235, 128, 230, 232 } });

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentReferences_Users_UserId",
                table: "DocumentReferences",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentReferences_Users_UserId",
                table: "DocumentReferences");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "DocumentReferences",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 26, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 9, 17, 37, 12, 27, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 177, 247, 145, 228, 254, 32, 97, 172, 134, 40, 161, 98, 181, 135, 172, 147, 56, 251, 207, 125, 50, 158, 97, 155, 137, 222, 18, 119, 190, 145, 238, 64, 77, 251, 1, 2, 169, 79, 141, 179, 71, 247, 112, 160, 56, 232, 117, 0, 88, 81, 152, 165, 126, 236, 72, 6, 214, 36, 28, 209, 207, 117, 184, 52 }, new byte[] { 76, 11, 40, 131, 8, 13, 112, 3, 88, 163, 35, 202, 183, 195, 215, 146, 224, 231, 129, 13, 213, 31, 25, 102, 45, 2, 32, 132, 159, 125, 147, 113, 126, 226, 205, 55, 119, 113, 133, 103, 12, 68, 126, 106, 28, 70, 159, 234, 246, 25, 122, 2, 50, 61, 244, 102, 15, 61, 177, 212, 7, 58, 155, 254, 12, 118, 254, 174, 176, 150, 99, 153, 19, 84, 116, 95, 188, 209, 5, 255, 142, 179, 56, 56, 164, 217, 87, 157, 124, 78, 219, 36, 27, 5, 106, 12, 110, 119, 204, 57, 158, 255, 91, 112, 106, 202, 16, 165, 16, 110, 192, 30, 18, 151, 74, 172, 142, 142, 129, 191, 98, 228, 125, 17, 230, 83, 228, 0 } });

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentReferences_Users_UserId",
                table: "DocumentReferences",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
