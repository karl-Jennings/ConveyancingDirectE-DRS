using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class lrcredv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LrCredentials",
                columns: new[] { "LrCredentialsId", "Password", "Username" },
                values: new object[] { 1L, "landreg001", "BGUser001" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 46, 25, 219, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 46, 25, 220, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 46, 25, 220, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 46, 25, 220, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 46, 25, 220, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 46, 25, 220, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 46, 25, 220, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 46, 25, 220, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 56, 64, 247, 240, 168, 39, 134, 151, 49, 216, 80, 158, 65, 81, 28, 55, 222, 80, 205, 19, 240, 212, 230, 45, 178, 78, 127, 194, 140, 253, 178, 94, 185, 77, 70, 24, 173, 105, 138, 138, 225, 80, 215, 0, 116, 128, 10, 3, 135, 104, 148, 112, 131, 26, 118, 231, 138, 8, 33, 111, 0, 245, 142 }, new byte[] { 146, 26, 39, 41, 25, 199, 118, 11, 183, 56, 172, 187, 110, 171, 18, 39, 61, 61, 75, 95, 34, 94, 179, 115, 132, 154, 75, 42, 91, 32, 35, 159, 39, 109, 234, 209, 147, 14, 88, 94, 20, 195, 167, 225, 134, 166, 124, 132, 180, 157, 231, 223, 10, 147, 183, 249, 113, 35, 114, 155, 136, 216, 198, 198, 171, 114, 132, 103, 153, 184, 153, 117, 201, 56, 187, 160, 140, 70, 27, 112, 34, 81, 141, 201, 189, 125, 173, 165, 201, 39, 254, 174, 76, 176, 128, 60, 86, 42, 18, 4, 214, 8, 77, 71, 227, 109, 221, 25, 34, 45, 41, 217, 25, 226, 119, 115, 173, 164, 232, 197, 222, 154, 117, 127, 109, 60, 3, 181 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LrCredentials",
                keyColumn: "LrCredentialsId",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 43, 4, 258, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 43, 4, 259, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 43, 4, 259, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 43, 4, 259, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 43, 4, 259, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 43, 4, 259, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 43, 4, 259, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 17, 9, 43, 4, 259, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 68, 192, 150, 154, 182, 95, 135, 245, 22, 188, 238, 215, 108, 105, 60, 246, 85, 164, 173, 248, 187, 205, 254, 210, 137, 54, 153, 204, 146, 36, 166, 119, 202, 189, 2, 244, 190, 194, 227, 182, 180, 121, 80, 182, 92, 175, 225, 239, 204, 46, 195, 248, 54, 138, 185, 245, 183, 49, 94, 221, 2, 152, 57 }, new byte[] { 65, 52, 115, 103, 155, 62, 53, 5, 246, 110, 58, 252, 225, 158, 70, 232, 179, 94, 111, 10, 168, 180, 46, 25, 146, 101, 39, 107, 217, 22, 206, 60, 94, 246, 37, 214, 62, 162, 224, 2, 142, 139, 224, 211, 181, 148, 229, 41, 196, 202, 6, 32, 165, 241, 70, 6, 158, 234, 215, 166, 142, 58, 49, 145, 56, 16, 43, 100, 183, 160, 2, 251, 63, 251, 254, 75, 11, 14, 157, 40, 219, 23, 144, 232, 57, 212, 17, 230, 127, 126, 205, 149, 186, 158, 72, 35, 215, 237, 179, 96, 56, 193, 230, 246, 34, 103, 20, 43, 163, 57, 134, 150, 93, 142, 97, 115, 187, 124, 230, 108, 129, 115, 250, 115, 252, 160, 98, 151 } });
        }
    }
}
