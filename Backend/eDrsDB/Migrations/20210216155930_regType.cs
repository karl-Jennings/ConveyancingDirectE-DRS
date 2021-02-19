using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class regType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RegistrationTypeId",
                table: "DocumentReferences",
                nullable: false,
                defaultValue: 0L);

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
                name: "IX_DocumentReferences_RegistrationTypeId",
                table: "DocumentReferences",
                column: "RegistrationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentReferences_RegistrationTypes_RegistrationTypeId",
                table: "DocumentReferences",
                column: "RegistrationTypeId",
                principalTable: "RegistrationTypes",
                principalColumn: "RegistrationTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentReferences_RegistrationTypes_RegistrationTypeId",
                table: "DocumentReferences");

            migrationBuilder.DropIndex(
                name: "IX_DocumentReferences_RegistrationTypeId",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "RegistrationTypeId",
                table: "DocumentReferences");

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
    }
}
