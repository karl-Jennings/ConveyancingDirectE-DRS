using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class pass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 523, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 524, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 524, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 524, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 524, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 233, 248, 42, 210, 153, 145, 131, 119, 147, 198, 232, 184, 203, 42, 225, 9, 53, 98, 153, 204, 141, 74, 177, 129, 171, 101, 186, 248, 59, 56, 62, 228, 177, 80, 54, 91, 61, 213, 41, 161, 233, 126, 43, 124, 243, 131, 59, 103, 70, 245, 170, 82, 253, 140, 180, 56, 247, 173, 134, 83, 201, 132, 73 }, new byte[] { 212, 165, 20, 133, 237, 5, 38, 56, 211, 81, 143, 196, 87, 92, 54, 50, 141, 255, 119, 97, 49, 158, 62, 55, 39, 125, 7, 240, 129, 120, 92, 144, 215, 213, 235, 72, 52, 43, 81, 49, 158, 97, 104, 27, 32, 252, 153, 242, 52, 88, 223, 81, 73, 48, 177, 117, 84, 151, 208, 247, 121, 123, 250, 153, 104, 116, 140, 115, 232, 56, 99, 53, 163, 97, 0, 54, 86, 69, 175, 85, 101, 165, 150, 39, 19, 24, 214, 183, 231, 233, 100, 229, 234, 184, 171, 48, 186, 54, 253, 140, 0, 208, 203, 241, 65, 180, 94, 38, 37, 15, 102, 171, 31, 181, 136, 227, 250, 38, 32, 234, 21, 204, 227, 1, 80, 189, 204, 34 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "DocumentReferences");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 79, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 80, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 80, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 80, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 80, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 214, 123, 205, 83, 110, 224, 62, 235, 15, 199, 109, 230, 9, 93, 26, 110, 247, 35, 98, 140, 192, 13, 153, 138, 187, 205, 59, 59, 122, 59, 222, 94, 241, 189, 49, 127, 5, 17, 206, 110, 102, 133, 160, 52, 31, 192, 33, 193, 117, 27, 76, 29, 95, 167, 221, 18, 162, 219, 232, 239, 20, 17, 94 }, new byte[] { 52, 115, 103, 17, 129, 28, 157, 66, 59, 24, 208, 210, 72, 46, 17, 26, 203, 222, 139, 124, 8, 117, 80, 91, 244, 216, 167, 69, 20, 87, 50, 15, 179, 146, 249, 128, 122, 248, 37, 130, 85, 189, 40, 226, 130, 200, 154, 243, 116, 154, 38, 62, 219, 51, 39, 161, 85, 178, 180, 65, 154, 136, 251, 110, 27, 50, 237, 1, 83, 49, 194, 156, 93, 84, 109, 196, 58, 154, 5, 175, 41, 75, 114, 27, 222, 171, 23, 8, 22, 109, 191, 183, 102, 147, 250, 167, 242, 133, 40, 226, 213, 249, 210, 30, 83, 14, 114, 136, 205, 170, 196, 247, 204, 121, 77, 162, 177, 38, 72, 8, 189, 221, 114, 40, 174, 206, 61, 129 } });
        }
    }
}
