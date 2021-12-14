using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class XMLRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateRegistrationXMLRequest",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 391, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 28, 254, 14, 129, 95, 67, 180, 97, 153, 41, 255, 144, 62, 39, 139, 61, 147, 234, 132, 103, 184, 106, 101, 155, 37, 1, 209, 212, 106, 158, 16, 243, 193, 62, 94, 231, 42, 86, 50, 92, 147, 153, 44, 155, 82, 125, 67, 36, 226, 222, 57, 206, 26, 97, 80, 235, 39, 90, 211, 125, 15, 199, 93 }, new byte[] { 31, 80, 162, 35, 18, 74, 111, 20, 44, 38, 162, 160, 100, 8, 67, 162, 22, 193, 138, 13, 241, 216, 99, 49, 132, 243, 135, 236, 215, 179, 113, 44, 20, 71, 161, 216, 215, 102, 84, 28, 6, 104, 101, 254, 74, 188, 23, 177, 117, 147, 129, 154, 95, 234, 160, 144, 16, 81, 185, 180, 20, 251, 218, 206, 37, 122, 98, 42, 224, 190, 128, 123, 164, 189, 101, 199, 240, 167, 204, 107, 181, 116, 229, 168, 248, 217, 95, 124, 19, 54, 155, 2, 49, 102, 209, 192, 111, 248, 111, 244, 170, 48, 148, 156, 173, 181, 84, 254, 242, 119, 230, 82, 231, 171, 124, 133, 59, 40, 52, 237, 100, 183, 52, 72, 253, 40, 178, 18 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateRegistrationXMLRequest",
                table: "RequestLogs");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 649, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 10, 12, 20, 37, 650, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 230, 19, 221, 66, 92, 208, 219, 24, 195, 6, 61, 3, 132, 214, 100, 8, 14, 58, 122, 242, 141, 135, 72, 37, 89, 80, 255, 200, 196, 132, 127, 54, 127, 18, 144, 117, 28, 13, 30, 53, 103, 201, 36, 123, 81, 129, 161, 169, 92, 111, 209, 164, 201, 51, 91, 124, 230, 23, 70, 29, 162, 75, 223, 253 }, new byte[] { 206, 135, 163, 94, 12, 140, 51, 179, 156, 133, 243, 97, 18, 235, 7, 207, 219, 109, 163, 131, 3, 88, 93, 249, 88, 14, 214, 235, 90, 61, 18, 135, 59, 199, 181, 249, 51, 166, 15, 203, 172, 0, 57, 202, 107, 167, 250, 24, 136, 24, 18, 169, 70, 133, 210, 7, 235, 46, 144, 50, 23, 206, 187, 104, 251, 132, 211, 248, 36, 5, 213, 59, 24, 109, 132, 4, 162, 173, 57, 157, 121, 218, 131, 42, 160, 26, 73, 70, 148, 86, 170, 59, 79, 89, 48, 239, 160, 114, 208, 156, 14, 192, 154, 126, 182, 30, 37, 197, 189, 3, 105, 122, 142, 207, 74, 70, 37, 88, 253, 215, 18, 68, 49, 121, 24, 13, 231, 230 } });
        }
    }
}
