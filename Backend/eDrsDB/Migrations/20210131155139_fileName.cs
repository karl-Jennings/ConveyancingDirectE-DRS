using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class fileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "ApplicationForms",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 31, 21, 21, 38, 975, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 31, 21, 21, 38, 976, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 31, 21, 21, 38, 976, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 31, 21, 21, 38, 976, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 31, 21, 21, 38, 976, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 151, 196, 247, 46, 244, 200, 189, 134, 104, 132, 138, 212, 188, 132, 52, 97, 73, 20, 239, 130, 136, 5, 98, 118, 246, 42, 205, 159, 204, 184, 101, 13, 98, 85, 45, 59, 240, 171, 105, 30, 164, 46, 197, 115, 179, 155, 144, 16, 166, 93, 97, 57, 85, 171, 148, 21, 64, 27, 107, 33, 189, 224, 154, 18 }, new byte[] { 103, 197, 68, 248, 154, 108, 187, 97, 128, 243, 121, 136, 150, 212, 21, 107, 91, 20, 20, 104, 129, 59, 180, 201, 211, 31, 209, 176, 183, 15, 165, 208, 149, 146, 120, 22, 179, 120, 209, 202, 131, 197, 55, 181, 184, 110, 22, 58, 3, 69, 203, 79, 114, 57, 94, 129, 34, 121, 206, 10, 62, 163, 177, 126, 69, 157, 193, 4, 46, 146, 163, 2, 250, 119, 158, 104, 168, 130, 33, 42, 198, 36, 219, 174, 181, 120, 98, 236, 28, 213, 133, 141, 183, 163, 91, 137, 251, 33, 160, 153, 254, 39, 221, 60, 155, 18, 182, 91, 212, 124, 235, 193, 56, 11, 222, 101, 136, 135, 207, 22, 179, 147, 1, 132, 71, 30, 61, 252 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "ApplicationForms");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 250, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 251, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 251, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 251, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 27, 13, 41, 42, 251, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 173, 251, 213, 6, 178, 168, 254, 102, 238, 152, 182, 99, 129, 8, 108, 31, 197, 108, 38, 147, 48, 154, 93, 65, 252, 54, 127, 243, 145, 162, 206, 86, 178, 66, 180, 164, 125, 204, 147, 52, 211, 87, 224, 230, 178, 171, 164, 62, 140, 162, 176, 88, 91, 199, 111, 60, 250, 177, 180, 127, 29, 68, 113, 196 }, new byte[] { 181, 165, 227, 15, 102, 161, 61, 83, 225, 229, 152, 89, 52, 129, 143, 159, 200, 61, 143, 249, 190, 185, 197, 182, 36, 44, 109, 123, 229, 53, 79, 92, 78, 105, 250, 150, 127, 222, 0, 151, 132, 216, 201, 119, 51, 163, 188, 164, 121, 224, 79, 60, 253, 75, 214, 135, 240, 75, 58, 217, 207, 109, 220, 190, 217, 127, 115, 182, 27, 132, 211, 2, 110, 162, 232, 1, 74, 96, 19, 135, 229, 118, 19, 6, 32, 34, 176, 150, 110, 243, 187, 192, 97, 20, 154, 172, 89, 177, 197, 248, 2, 150, 149, 79, 68, 2, 190, 97, 20, 95, 158, 162, 47, 170, 219, 175, 48, 247, 94, 84, 141, 115, 129, 185, 165, 160, 230, 18 } });
        }
    }
}
