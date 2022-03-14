using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class setNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Outstanding_DocumentReferences_DocumentReferenceId",
                table: "Outstanding");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentReferenceId",
                table: "Outstanding",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 667, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 102, 195, 157, 221, 209, 35, 50, 42, 167, 83, 2, 7, 43, 140, 160, 23, 79, 236, 168, 185, 67, 184, 228, 146, 91, 240, 213, 203, 117, 92, 122, 152, 240, 172, 70, 252, 100, 152, 240, 240, 2, 36, 62, 120, 41, 101, 189, 110, 57, 88, 132, 245, 232, 216, 203, 146, 65, 206, 241, 153, 162, 234, 107 }, new byte[] { 199, 98, 93, 92, 101, 246, 40, 87, 199, 88, 121, 191, 76, 188, 152, 123, 237, 62, 165, 200, 58, 204, 163, 137, 180, 182, 0, 235, 9, 46, 148, 229, 169, 224, 246, 108, 224, 100, 75, 107, 102, 177, 103, 200, 172, 23, 2, 78, 135, 108, 76, 146, 65, 237, 77, 20, 26, 253, 199, 205, 40, 115, 144, 197, 69, 70, 204, 57, 77, 56, 128, 101, 246, 234, 32, 179, 127, 244, 34, 144, 111, 71, 79, 146, 0, 222, 150, 118, 13, 67, 81, 108, 35, 18, 66, 231, 250, 208, 219, 191, 119, 29, 156, 48, 131, 46, 99, 228, 78, 60, 248, 48, 172, 72, 143, 57, 21, 65, 165, 249, 226, 204, 91, 54, 21, 18, 43, 21 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Outstanding_DocumentReferences_DocumentReferenceId",
                table: "Outstanding",
                column: "DocumentReferenceId",
                principalTable: "DocumentReferences",
                principalColumn: "DocumentReferenceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Outstanding_DocumentReferences_DocumentReferenceId",
                table: "Outstanding");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentReferenceId",
                table: "Outstanding",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 33, 5, 577, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 33, 5, 578, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 33, 5, 578, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 33, 5, 578, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 33, 5, 578, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 33, 5, 578, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 33, 5, 578, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 33, 5, 578, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 178, 145, 157, 116, 254, 102, 82, 126, 187, 14, 244, 186, 183, 247, 196, 86, 176, 165, 210, 118, 196, 239, 20, 63, 39, 74, 224, 76, 251, 44, 24, 24, 49, 220, 140, 150, 164, 248, 99, 173, 75, 228, 133, 71, 25, 208, 185, 129, 75, 46, 204, 9, 2, 239, 225, 50, 132, 16, 61, 60, 130, 178, 118 }, new byte[] { 0, 175, 96, 204, 144, 243, 215, 201, 115, 63, 34, 229, 156, 252, 78, 172, 166, 35, 196, 215, 20, 221, 212, 27, 122, 36, 6, 35, 66, 68, 61, 22, 204, 130, 121, 94, 36, 79, 78, 98, 17, 26, 236, 178, 42, 174, 200, 221, 143, 239, 162, 82, 108, 9, 31, 136, 96, 60, 16, 179, 44, 208, 65, 85, 32, 243, 186, 11, 56, 190, 103, 84, 100, 94, 110, 202, 57, 232, 30, 242, 34, 186, 202, 209, 155, 233, 248, 21, 202, 192, 229, 131, 4, 100, 101, 66, 73, 223, 41, 112, 16, 80, 98, 247, 119, 62, 29, 232, 142, 49, 48, 88, 200, 7, 95, 90, 138, 187, 202, 138, 34, 88, 19, 142, 187, 182, 113, 195 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Outstanding_DocumentReferences_DocumentReferenceId",
                table: "Outstanding",
                column: "DocumentReferenceId",
                principalTable: "DocumentReferences",
                principalColumn: "DocumentReferenceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
