using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class refId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DocumentReferenceId",
                table: "RequestLogs",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 735, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 29, 112, 220, 3, 26, 178, 103, 89, 16, 227, 107, 206, 198, 236, 181, 157, 228, 79, 95, 76, 32, 55, 146, 153, 46, 129, 166, 42, 189, 50, 163, 212, 176, 238, 177, 185, 8, 234, 133, 107, 227, 81, 56, 207, 112, 200, 219, 212, 233, 2, 7, 21, 164, 28, 35, 247, 150, 141, 243, 33, 95, 233, 71, 168 }, new byte[] { 122, 21, 47, 170, 207, 32, 142, 207, 41, 53, 68, 150, 61, 197, 50, 247, 176, 55, 102, 3, 132, 36, 151, 219, 219, 214, 41, 118, 39, 97, 237, 189, 147, 145, 132, 220, 84, 42, 210, 148, 41, 60, 164, 71, 152, 231, 152, 221, 204, 69, 66, 136, 239, 5, 246, 152, 160, 220, 117, 131, 18, 194, 214, 125, 53, 50, 150, 26, 129, 250, 250, 255, 94, 229, 205, 251, 200, 159, 76, 130, 65, 181, 66, 143, 118, 231, 104, 146, 139, 245, 254, 88, 201, 185, 47, 199, 3, 137, 32, 187, 34, 29, 86, 46, 174, 137, 61, 226, 21, 35, 249, 153, 88, 116, 103, 127, 48, 202, 185, 196, 122, 201, 194, 245, 13, 170, 89, 71 } });

            migrationBuilder.CreateIndex(
                name: "IX_RequestLogs_DocumentReferenceId",
                table: "RequestLogs",
                column: "DocumentReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLogs_DocumentReferences_DocumentReferenceId",
                table: "RequestLogs",
                column: "DocumentReferenceId",
                principalTable: "DocumentReferences",
                principalColumn: "DocumentReferenceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestLogs_DocumentReferences_DocumentReferenceId",
                table: "RequestLogs");

            migrationBuilder.DropIndex(
                name: "IX_RequestLogs_DocumentReferenceId",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "DocumentReferenceId",
                table: "RequestLogs");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 9, 19, 206, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 9, 19, 207, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 9, 19, 207, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 9, 19, 207, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 9, 19, 207, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 9, 19, 207, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 9, 19, 207, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 9, 19, 207, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 127, 15, 122, 45, 46, 34, 202, 128, 137, 186, 209, 230, 196, 59, 39, 92, 32, 216, 148, 229, 237, 193, 50, 167, 140, 220, 238, 177, 81, 119, 68, 250, 28, 51, 11, 55, 119, 225, 201, 153, 12, 50, 18, 31, 192, 222, 211, 41, 15, 203, 78, 173, 107, 59, 210, 201, 148, 169, 160, 119, 209, 208, 154 }, new byte[] { 146, 228, 13, 207, 225, 149, 21, 27, 166, 232, 106, 175, 20, 116, 130, 15, 166, 171, 118, 231, 93, 254, 56, 18, 209, 228, 149, 148, 95, 79, 4, 108, 215, 46, 220, 159, 194, 107, 106, 103, 8, 169, 91, 250, 20, 207, 11, 81, 32, 90, 250, 173, 169, 127, 27, 66, 93, 226, 85, 222, 107, 171, 47, 44, 224, 74, 9, 8, 64, 9, 133, 178, 173, 149, 154, 32, 143, 167, 226, 159, 225, 210, 43, 103, 237, 151, 59, 60, 140, 57, 214, 179, 98, 97, 240, 236, 247, 209, 107, 48, 129, 177, 3, 208, 225, 225, 15, 99, 229, 130, 157, 53, 71, 190, 59, 247, 169, 253, 87, 111, 34, 48, 39, 120, 226, 146, 150, 134 } });
        }
    }
}
