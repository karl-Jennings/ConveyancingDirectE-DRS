using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class MessageID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationMessageId",
                table: "DocumentReferences");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationMessageId",
                table: "Documents",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationMessageId",
                table: "Documents");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationMessageId",
                table: "DocumentReferences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 19, 56, 6, 899, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 19, 56, 6, 900, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 19, 56, 6, 900, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 19, 56, 6, 900, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 19, 56, 6, 900, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 19, 56, 6, 900, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 19, 56, 6, 900, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 19, 56, 6, 900, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 56, 221, 109, 194, 233, 156, 114, 74, 187, 53, 190, 58, 36, 173, 177, 95, 121, 172, 231, 185, 230, 243, 226, 229, 28, 17, 224, 90, 252, 157, 217, 64, 185, 75, 195, 109, 47, 109, 81, 101, 252, 172, 105, 81, 28, 19, 103, 160, 18, 203, 81, 65, 54, 223, 100, 103, 20, 126, 147, 200, 220, 35, 1, 14 }, new byte[] { 72, 180, 189, 20, 119, 202, 90, 185, 146, 82, 201, 5, 34, 66, 6, 242, 87, 19, 156, 92, 82, 139, 160, 180, 247, 17, 82, 166, 203, 167, 49, 98, 88, 221, 147, 153, 204, 208, 75, 199, 243, 184, 31, 162, 91, 195, 9, 82, 230, 133, 106, 137, 106, 247, 0, 247, 83, 170, 73, 78, 9, 3, 45, 242, 44, 162, 252, 30, 159, 236, 157, 243, 3, 91, 46, 21, 24, 88, 247, 255, 87, 178, 137, 84, 249, 111, 32, 188, 114, 67, 222, 116, 51, 207, 146, 72, 170, 65, 142, 29, 56, 42, 249, 176, 168, 103, 223, 216, 195, 86, 187, 93, 18, 36, 89, 180, 195, 24, 79, 180, 128, 186, 87, 48, 191, 67, 227, 186 } });
        }
    }
}
