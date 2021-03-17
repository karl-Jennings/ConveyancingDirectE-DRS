using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class mdRefv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 27, 6, 893, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 27, 6, 894, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 27, 6, 894, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 27, 6, 894, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 27, 6, 894, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 27, 6, 894, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 27, 6, 894, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 27, 6, 894, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 239, 182, 30, 153, 216, 78, 241, 140, 95, 64, 80, 42, 220, 146, 211, 207, 42, 17, 86, 210, 129, 189, 239, 179, 225, 17, 18, 234, 58, 112, 94, 2, 114, 198, 177, 219, 81, 39, 180, 103, 53, 217, 38, 47, 71, 49, 255, 214, 79, 109, 143, 252, 128, 221, 235, 200, 130, 171, 108, 239, 104, 141, 105, 95 }, new byte[] { 5, 241, 245, 128, 231, 13, 247, 241, 56, 254, 242, 248, 178, 170, 237, 147, 174, 234, 42, 84, 229, 44, 248, 151, 233, 207, 75, 26, 220, 41, 105, 111, 137, 57, 234, 230, 58, 4, 115, 120, 94, 144, 110, 114, 147, 28, 141, 47, 215, 163, 235, 43, 245, 7, 19, 128, 223, 12, 5, 5, 38, 142, 234, 122, 57, 225, 117, 91, 136, 74, 236, 61, 93, 143, 184, 83, 4, 35, 161, 2, 238, 124, 80, 180, 76, 231, 172, 181, 211, 241, 44, 82, 115, 255, 175, 212, 229, 88, 203, 19, 36, 96, 246, 56, 134, 242, 142, 90, 58, 109, 157, 34, 28, 225, 97, 132, 236, 101, 38, 212, 245, 41, 23, 159, 30, 151, 3, 53 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 12, 14, 822, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 12, 14, 824, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 12, 14, 824, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 12, 14, 824, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 12, 14, 824, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 12, 14, 824, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 12, 14, 824, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 14, 12, 14, 824, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 212, 93, 61, 175, 130, 61, 156, 200, 171, 10, 67, 173, 14, 247, 253, 100, 185, 178, 85, 220, 12, 221, 27, 121, 155, 255, 151, 95, 82, 47, 99, 91, 109, 22, 23, 196, 238, 127, 15, 177, 16, 150, 110, 183, 132, 145, 171, 55, 118, 42, 32, 161, 62, 255, 147, 194, 56, 39, 240, 181, 27, 49, 166, 31 }, new byte[] { 171, 41, 101, 101, 73, 199, 156, 140, 17, 223, 40, 244, 181, 231, 253, 32, 102, 159, 114, 117, 22, 63, 184, 160, 55, 47, 218, 57, 150, 76, 63, 93, 98, 242, 39, 25, 227, 59, 14, 87, 230, 142, 83, 135, 118, 55, 103, 19, 80, 189, 3, 208, 234, 12, 116, 251, 174, 165, 55, 104, 28, 226, 94, 229, 7, 247, 124, 158, 159, 226, 137, 18, 228, 53, 151, 198, 216, 180, 151, 249, 143, 83, 252, 126, 250, 83, 102, 215, 7, 33, 63, 42, 144, 137, 199, 71, 116, 150, 78, 39, 66, 245, 170, 40, 218, 143, 186, 161, 200, 20, 248, 102, 53, 252, 89, 211, 53, 87, 193, 200, 239, 107, 74, 167, 207, 57, 197, 66 } });
        }
    }
}
