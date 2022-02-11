using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class RequisitionTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Requisition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationMessageId",
                table: "DocumentReferences",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Requisition");

            migrationBuilder.DropColumn(
                name: "ApplicationMessageId",
                table: "DocumentReferences");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 22, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 241, 143, 215, 107, 197, 63, 177, 187, 141, 229, 97, 227, 69, 82, 234, 155, 11, 25, 161, 107, 131, 27, 36, 152, 193, 102, 205, 51, 66, 65, 31, 217, 189, 26, 59, 49, 39, 1, 131, 166, 26, 46, 111, 96, 255, 235, 231, 232, 115, 241, 126, 77, 43, 252, 42, 242, 111, 237, 52, 44, 228, 200, 20, 55 }, new byte[] { 237, 23, 12, 77, 123, 222, 118, 137, 58, 109, 247, 80, 2, 121, 81, 58, 188, 67, 10, 24, 175, 150, 104, 105, 66, 237, 55, 194, 62, 40, 244, 68, 133, 238, 21, 144, 25, 67, 141, 207, 207, 3, 188, 186, 5, 40, 180, 244, 95, 54, 93, 159, 54, 79, 233, 87, 83, 114, 134, 220, 78, 254, 190, 242, 191, 215, 239, 194, 136, 231, 63, 230, 30, 210, 14, 46, 143, 125, 165, 102, 79, 64, 202, 228, 182, 119, 231, 78, 241, 118, 53, 35, 223, 215, 40, 128, 126, 42, 86, 50, 224, 116, 120, 96, 160, 13, 59, 26, 9, 42, 67, 79, 51, 149, 173, 195, 42, 49, 215, 165, 198, 105, 41, 28, 226, 150, 96, 37 } });
        }
    }
}
