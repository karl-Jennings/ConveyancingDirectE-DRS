using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class titleType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TitleType",
                table: "TitleNumbers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 601, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 602, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 602, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 602, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 602, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 10, 163, 75, 25, 236, 44, 193, 230, 53, 202, 72, 94, 229, 209, 124, 25, 233, 84, 83, 252, 89, 247, 198, 102, 242, 180, 105, 134, 44, 113, 173, 113, 144, 128, 21, 217, 248, 101, 138, 138, 57, 24, 59, 85, 69, 19, 129, 72, 78, 121, 64, 38, 160, 98, 59, 181, 104, 228, 249, 125, 196, 202, 87, 146 }, new byte[] { 150, 90, 213, 35, 239, 86, 223, 205, 142, 113, 52, 108, 195, 58, 245, 13, 117, 196, 98, 183, 201, 161, 168, 42, 103, 12, 239, 47, 165, 170, 127, 253, 231, 98, 71, 70, 253, 167, 73, 1, 109, 189, 48, 187, 110, 87, 73, 87, 148, 216, 39, 246, 66, 62, 123, 151, 15, 149, 83, 46, 17, 102, 18, 217, 142, 30, 134, 141, 169, 5, 249, 12, 201, 122, 37, 35, 194, 92, 24, 105, 202, 23, 178, 110, 122, 61, 162, 35, 62, 124, 190, 202, 134, 46, 168, 76, 224, 159, 148, 119, 148, 157, 172, 97, 252, 15, 55, 146, 79, 74, 174, 72, 217, 235, 33, 217, 248, 118, 62, 202, 80, 169, 254, 123, 173, 79, 68, 94 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleType",
                table: "TitleNumbers");

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
    }
}
