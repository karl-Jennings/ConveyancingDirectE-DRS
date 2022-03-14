using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class AddColumnnMessageId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageId",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 345, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 13, 12, 7, 38, 346, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 206, 178, 211, 108, 165, 190, 48, 156, 58, 79, 113, 249, 246, 147, 163, 90, 211, 146, 179, 84, 61, 100, 156, 175, 246, 35, 229, 112, 223, 230, 190, 144, 245, 48, 21, 161, 30, 114, 163, 229, 146, 240, 69, 16, 247, 230, 244, 118, 82, 8, 179, 91, 79, 43, 9, 165, 142, 252, 15, 106, 160, 90, 118, 158 }, new byte[] { 94, 54, 18, 191, 80, 171, 3, 110, 132, 79, 47, 211, 248, 193, 91, 181, 215, 152, 6, 136, 197, 3, 48, 117, 205, 96, 229, 245, 3, 1, 120, 95, 32, 120, 168, 122, 235, 144, 137, 36, 209, 30, 119, 160, 195, 218, 91, 110, 22, 89, 55, 139, 102, 1, 99, 239, 178, 189, 42, 50, 195, 106, 95, 198, 6, 11, 163, 84, 143, 182, 188, 3, 130, 136, 68, 26, 229, 8, 46, 38, 9, 79, 224, 30, 237, 216, 66, 175, 20, 247, 9, 150, 46, 82, 50, 122, 100, 96, 82, 153, 15, 23, 219, 58, 160, 44, 219, 99, 38, 172, 124, 7, 163, 248, 162, 115, 77, 0, 131, 139, 24, 114, 202, 188, 229, 243, 40, 240 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageId",
                table: "RequestLogs");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 11, 14, 52, 36, 58, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 11, 14, 52, 36, 59, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 11, 14, 52, 36, 59, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 11, 14, 52, 36, 59, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 11, 14, 52, 36, 59, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 11, 14, 52, 36, 59, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 11, 14, 52, 36, 59, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 11, 14, 52, 36, 59, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 126, 71, 58, 119, 208, 217, 98, 50, 189, 177, 48, 79, 249, 190, 229, 150, 28, 212, 217, 193, 85, 155, 47, 60, 143, 52, 187, 255, 66, 133, 143, 64, 12, 14, 186, 135, 232, 1, 79, 214, 243, 226, 219, 60, 51, 133, 51, 116, 82, 228, 167, 233, 114, 160, 167, 28, 171, 66, 194, 78, 214, 161, 236 }, new byte[] { 7, 97, 172, 26, 240, 51, 141, 43, 120, 188, 192, 50, 97, 132, 65, 167, 100, 240, 186, 15, 209, 236, 213, 23, 24, 71, 49, 172, 150, 64, 206, 186, 29, 202, 165, 13, 6, 32, 40, 251, 209, 108, 80, 103, 211, 196, 145, 152, 249, 115, 83, 116, 223, 152, 25, 250, 209, 91, 90, 201, 44, 89, 52, 176, 190, 225, 240, 251, 241, 46, 97, 135, 62, 172, 23, 67, 30, 229, 11, 175, 129, 233, 156, 168, 251, 215, 35, 228, 28, 100, 227, 211, 245, 187, 14, 119, 135, 101, 215, 206, 209, 144, 42, 66, 31, 181, 152, 119, 216, 134, 60, 109, 239, 239, 52, 49, 50, 186, 68, 105, 69, 243, 44, 184, 239, 19, 162, 44 } });
        }
    }
}
