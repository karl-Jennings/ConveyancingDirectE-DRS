using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class attId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AttachmentId",
                table: "Documents",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 904, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 134, 14, 192, 141, 98, 135, 94, 98, 225, 134, 115, 207, 191, 106, 139, 122, 103, 73, 186, 235, 180, 200, 175, 227, 115, 104, 184, 22, 42, 101, 135, 23, 146, 238, 182, 25, 145, 94, 224, 32, 25, 56, 36, 233, 206, 223, 46, 255, 95, 135, 38, 190, 78, 9, 115, 181, 76, 100, 68, 144, 207, 7, 22 }, new byte[] { 225, 183, 136, 84, 147, 15, 201, 163, 218, 42, 106, 7, 245, 60, 191, 101, 127, 143, 16, 254, 86, 77, 34, 41, 163, 35, 121, 60, 204, 94, 124, 90, 52, 168, 209, 56, 181, 14, 70, 166, 12, 183, 24, 158, 241, 95, 146, 81, 170, 128, 99, 16, 189, 85, 57, 35, 212, 87, 127, 27, 54, 173, 127, 245, 164, 17, 68, 190, 129, 196, 95, 243, 32, 146, 207, 76, 99, 239, 210, 179, 6, 10, 173, 19, 28, 105, 103, 84, 67, 27, 254, 158, 239, 66, 72, 76, 144, 165, 199, 115, 23, 185, 220, 189, 219, 51, 225, 252, 248, 137, 83, 87, 113, 35, 50, 53, 63, 139, 253, 185, 150, 129, 158, 192, 45, 194, 21, 243 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentId",
                table: "Documents");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 91, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 64, 179, 175, 142, 224, 85, 77, 242, 120, 24, 149, 51, 37, 206, 47, 65, 223, 96, 8, 153, 220, 243, 16, 228, 131, 162, 197, 60, 54, 231, 204, 35, 205, 84, 19, 141, 98, 83, 138, 18, 247, 121, 36, 43, 21, 35, 181, 38, 228, 231, 152, 223, 96, 179, 17, 35, 206, 135, 14, 251, 162, 71, 254, 251 }, new byte[] { 22, 106, 186, 162, 90, 181, 202, 213, 36, 235, 74, 205, 113, 230, 145, 6, 130, 115, 112, 190, 142, 167, 105, 72, 215, 107, 199, 113, 98, 121, 84, 26, 5, 102, 24, 12, 34, 151, 122, 148, 172, 148, 232, 129, 234, 125, 94, 30, 89, 159, 227, 177, 31, 237, 28, 66, 157, 59, 194, 101, 221, 17, 9, 206, 221, 76, 16, 73, 235, 158, 224, 171, 93, 59, 58, 155, 137, 236, 144, 24, 83, 100, 82, 109, 140, 202, 219, 236, 103, 199, 219, 143, 146, 34, 91, 193, 255, 9, 122, 185, 175, 200, 103, 118, 80, 120, 113, 201, 122, 17, 160, 197, 190, 57, 158, 156, 222, 219, 171, 144, 78, 237, 237, 16, 65, 22, 181, 102 } });
        }
    }
}
