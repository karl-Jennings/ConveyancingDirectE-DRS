using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class addForSer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressForService",
                table: "Parties",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 57, 48, 873, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 57, 48, 875, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 57, 48, 875, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 57, 48, 875, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 57, 48, 875, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 57, 48, 875, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 57, 48, 875, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 57, 48, 875, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 145, 217, 35, 249, 160, 138, 130, 19, 36, 10, 242, 135, 50, 205, 105, 51, 61, 161, 14, 0, 161, 169, 119, 117, 106, 69, 205, 91, 96, 55, 179, 52, 63, 186, 150, 156, 5, 127, 96, 5, 248, 99, 115, 7, 49, 6, 185, 18, 161, 123, 108, 147, 38, 117, 45, 133, 134, 227, 162, 73, 244, 120, 103, 123 }, new byte[] { 55, 119, 177, 150, 17, 155, 167, 80, 53, 191, 76, 232, 40, 99, 148, 12, 134, 53, 182, 89, 234, 19, 149, 113, 241, 78, 144, 217, 104, 200, 14, 115, 21, 254, 216, 164, 200, 199, 202, 58, 230, 69, 90, 208, 180, 196, 1, 5, 227, 158, 101, 232, 45, 145, 238, 247, 175, 146, 164, 16, 53, 245, 224, 94, 145, 24, 25, 47, 41, 71, 202, 249, 124, 123, 64, 26, 86, 7, 137, 6, 235, 95, 18, 231, 233, 205, 184, 239, 160, 36, 30, 207, 228, 37, 127, 131, 135, 28, 102, 199, 80, 4, 246, 18, 170, 20, 157, 246, 182, 81, 57, 51, 200, 53, 33, 90, 122, 23, 6, 85, 128, 141, 172, 121, 81, 198, 241, 253 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressForService",
                table: "Parties");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 36, 13, 671, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 36, 13, 672, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 36, 13, 672, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 36, 13, 672, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 36, 13, 672, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 36, 13, 672, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 36, 13, 672, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 16, 36, 13, 672, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 28, 105, 192, 222, 82, 153, 233, 168, 65, 125, 19, 231, 32, 231, 40, 149, 163, 150, 112, 170, 171, 201, 70, 65, 129, 164, 50, 203, 42, 248, 66, 20, 38, 190, 29, 253, 149, 204, 92, 241, 214, 103, 79, 120, 178, 187, 62, 154, 168, 18, 59, 152, 143, 160, 77, 244, 230, 99, 99, 113, 235, 90, 175, 183 }, new byte[] { 29, 144, 244, 213, 204, 160, 59, 173, 126, 254, 248, 173, 123, 52, 48, 118, 113, 118, 118, 85, 171, 19, 96, 3, 64, 176, 23, 125, 92, 102, 35, 243, 49, 169, 100, 82, 161, 201, 21, 171, 41, 105, 49, 147, 8, 167, 106, 134, 140, 31, 122, 91, 161, 95, 224, 166, 44, 243, 182, 64, 148, 2, 126, 227, 159, 8, 35, 2, 236, 40, 95, 22, 35, 13, 157, 26, 143, 165, 63, 233, 190, 38, 86, 148, 130, 81, 98, 110, 65, 194, 70, 148, 34, 117, 68, 131, 72, 196, 175, 86, 104, 75, 32, 237, 22, 145, 128, 91, 203, 28, 209, 153, 112, 125, 30, 85, 202, 249, 193, 175, 167, 162, 172, 254, 235, 15, 91, 50 } });
        }
    }
}
