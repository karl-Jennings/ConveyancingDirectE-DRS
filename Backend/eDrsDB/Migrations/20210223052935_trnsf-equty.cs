using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class trnsfequty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 435, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "trns_eqty", new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6070), "transfer-equity" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 23, 10, 59, 35, 436, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 147, 137, 65, 98, 232, 80, 159, 171, 12, 65, 214, 168, 164, 65, 163, 101, 200, 127, 75, 161, 208, 111, 4, 212, 76, 236, 122, 205, 10, 51, 36, 198, 176, 190, 175, 63, 150, 165, 9, 32, 143, 86, 85, 135, 62, 60, 46, 228, 10, 201, 21, 234, 132, 103, 39, 167, 45, 240, 238, 206, 137, 244, 108, 66 }, new byte[] { 232, 254, 143, 161, 131, 6, 103, 157, 43, 49, 84, 91, 44, 86, 78, 56, 73, 35, 49, 243, 227, 200, 27, 117, 48, 197, 3, 26, 190, 63, 96, 41, 40, 116, 231, 40, 45, 27, 169, 198, 86, 37, 8, 252, 240, 235, 143, 112, 19, 210, 254, 193, 56, 209, 22, 121, 161, 24, 120, 110, 115, 203, 143, 197, 198, 30, 59, 98, 74, 48, 152, 57, 154, 247, 220, 247, 86, 138, 60, 162, 251, 120, 193, 189, 74, 108, 97, 191, 129, 0, 69, 40, 20, 109, 7, 121, 53, 124, 117, 15, 210, 116, 120, 192, 230, 250, 99, 246, 184, 131, 29, 158, 6, 56, 48, 232, 245, 169, 8, 192, 156, 164, 218, 200, 254, 175, 8, 165 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "new_lease", new DateTime(2021, 2, 22, 16, 57, 48, 875, DateTimeKind.Local).AddTicks(1834), "new-lease" });

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
    }
}
