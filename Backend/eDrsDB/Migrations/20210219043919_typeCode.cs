using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class typeCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TypeCode",
                table: "RequestLogs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TypeCode",
                table: "RequestLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 904, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 223, 210, 89, 152, 15, 243, 81, 201, 197, 44, 109, 211, 136, 188, 114, 171, 57, 70, 130, 115, 138, 240, 216, 150, 66, 153, 209, 19, 0, 59, 160, 226, 25, 99, 31, 122, 72, 20, 235, 219, 66, 90, 152, 138, 201, 149, 110, 167, 202, 96, 60, 71, 166, 183, 249, 159, 189, 15, 61, 181, 240, 30, 31, 27 }, new byte[] { 170, 255, 167, 100, 200, 77, 247, 87, 223, 4, 54, 242, 163, 231, 72, 162, 187, 126, 174, 224, 238, 193, 130, 176, 6, 216, 212, 137, 42, 151, 22, 47, 114, 224, 131, 4, 110, 17, 128, 100, 212, 91, 179, 141, 155, 155, 18, 41, 27, 205, 15, 204, 0, 222, 116, 91, 171, 103, 128, 162, 234, 193, 173, 20, 45, 27, 87, 177, 20, 25, 221, 127, 41, 5, 110, 38, 20, 198, 2, 79, 153, 61, 62, 136, 101, 31, 238, 59, 43, 198, 14, 80, 1, 17, 166, 0, 246, 44, 157, 127, 250, 10, 163, 102, 251, 230, 237, 61, 21, 104, 84, 120, 159, 172, 106, 120, 219, 150, 36, 28, 38, 100, 195, 7, 30, 64, 122, 55 } });
        }
    }
}
