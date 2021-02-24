using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class remgage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "rem_gage", new DateTime(2021, 2, 22, 16, 36, 13, 672, DateTimeKind.Local).AddTicks(7475), "remortgage" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 463, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "lease_ext", new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(1967), "lease-extension" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 207, 12, 97, 75, 83, 59, 182, 220, 220, 150, 206, 128, 113, 78, 149, 165, 61, 43, 66, 35, 166, 131, 180, 203, 22, 82, 202, 132, 30, 183, 247, 188, 79, 201, 49, 142, 163, 209, 30, 89, 112, 232, 240, 225, 222, 235, 52, 211, 47, 171, 189, 37, 240, 81, 238, 247, 175, 147, 92, 236, 123, 0, 137, 44 }, new byte[] { 201, 185, 184, 219, 158, 245, 23, 101, 187, 13, 177, 121, 116, 167, 241, 40, 4, 50, 215, 133, 178, 253, 6, 117, 107, 75, 166, 88, 113, 54, 189, 220, 27, 42, 179, 71, 215, 80, 102, 87, 104, 36, 169, 141, 191, 21, 82, 126, 54, 214, 209, 174, 184, 35, 242, 201, 72, 47, 211, 73, 48, 17, 89, 87, 138, 33, 113, 154, 179, 135, 125, 89, 40, 212, 1, 234, 206, 223, 211, 227, 75, 136, 143, 98, 46, 105, 167, 23, 32, 192, 123, 128, 17, 147, 190, 106, 26, 48, 198, 118, 230, 201, 34, 23, 137, 111, 27, 66, 16, 86, 18, 137, 40, 32, 254, 55, 134, 0, 41, 38, 111, 232, 4, 67, 7, 10, 211, 5 } });
        }
    }
}
