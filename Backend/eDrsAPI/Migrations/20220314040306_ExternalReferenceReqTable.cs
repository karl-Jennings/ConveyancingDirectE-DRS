using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ExternalReferenceReqTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestLogs_DocumentReferences_DocumentReferenceId",
                table: "RequestLogs");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentReferenceId",
                table: "Requisition",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "ExternalReference",
                table: "Requisition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MessageId",
                table: "Requisition",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DocumentReferenceId",
                table: "RequestLogs",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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
                name: "FK_RequestLogs_DocumentReferences_DocumentReferenceId",
                table: "RequestLogs",
                column: "DocumentReferenceId",
                principalTable: "DocumentReferences",
                principalColumn: "DocumentReferenceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestLogs_DocumentReferences_DocumentReferenceId",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "ExternalReference",
                table: "Requisition");

            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "Requisition");

            migrationBuilder.AlterColumn<long>(
                name: "DocumentReferenceId",
                table: "Requisition",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "DocumentReferenceId",
                table: "RequestLogs",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 125, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 9, 10, 9, 126, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 16, 167, 126, 23, 18, 131, 65, 85, 17, 222, 17, 113, 143, 9, 2, 69, 252, 146, 148, 239, 18, 60, 5, 191, 51, 66, 178, 75, 215, 122, 240, 141, 61, 154, 175, 232, 124, 246, 213, 109, 40, 143, 2, 101, 55, 107, 146, 54, 155, 41, 154, 52, 108, 81, 249, 162, 156, 252, 40, 247, 31, 239, 83, 133 }, new byte[] { 132, 133, 40, 173, 180, 77, 127, 102, 172, 94, 85, 231, 221, 34, 132, 153, 245, 22, 228, 106, 233, 51, 40, 222, 139, 2, 212, 136, 207, 26, 51, 21, 212, 148, 33, 239, 39, 123, 1, 137, 192, 171, 254, 30, 94, 237, 101, 68, 29, 27, 211, 83, 199, 167, 215, 194, 97, 193, 116, 199, 153, 81, 60, 13, 86, 120, 223, 220, 145, 249, 144, 59, 2, 94, 58, 30, 201, 23, 119, 46, 39, 206, 114, 130, 70, 101, 8, 156, 139, 81, 70, 37, 29, 44, 248, 163, 174, 244, 52, 166, 229, 232, 128, 4, 81, 26, 119, 186, 89, 219, 62, 40, 250, 195, 124, 134, 193, 95, 146, 6, 116, 106, 147, 64, 129, 29, 136, 98 } });

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLogs_DocumentReferences_DocumentReferenceId",
                table: "RequestLogs",
                column: "DocumentReferenceId",
                principalTable: "DocumentReferences",
                principalColumn: "DocumentReferenceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
