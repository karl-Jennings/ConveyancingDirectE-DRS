using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class DateCreatedOutstandings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Outstanding",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 980, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 215, 247, 82, 194, 164, 39, 44, 226, 87, 182, 103, 137, 11, 123, 157, 133, 206, 172, 192, 36, 35, 210, 37, 168, 225, 23, 160, 202, 155, 123, 38, 175, 81, 250, 122, 107, 181, 228, 224, 45, 114, 239, 108, 92, 255, 145, 20, 134, 5, 10, 103, 21, 142, 25, 97, 84, 155, 27, 53, 176, 158, 213, 147, 195 }, new byte[] { 166, 44, 214, 196, 27, 210, 86, 195, 166, 78, 177, 67, 37, 224, 70, 198, 174, 208, 177, 152, 194, 124, 67, 254, 114, 240, 210, 91, 132, 134, 148, 196, 155, 101, 56, 182, 49, 248, 159, 134, 74, 97, 121, 177, 231, 246, 199, 6, 31, 130, 252, 178, 84, 49, 151, 213, 14, 231, 119, 236, 222, 8, 88, 5, 244, 92, 25, 178, 226, 57, 196, 39, 254, 76, 42, 55, 19, 59, 43, 255, 105, 110, 5, 154, 169, 254, 88, 35, 186, 221, 19, 151, 92, 26, 52, 108, 209, 237, 75, 84, 165, 45, 225, 89, 47, 25, 80, 183, 150, 224, 69, 241, 141, 95, 167, 135, 238, 27, 80, 224, 44, 24, 205, 220, 0, 40, 226, 83 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Outstanding");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 18, 5, 46, 614, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 18, 5, 46, 615, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 18, 5, 46, 615, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 18, 5, 46, 615, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 18, 5, 46, 615, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 18, 5, 46, 615, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 18, 5, 46, 615, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 18, 5, 46, 615, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 17, 255, 60, 69, 147, 135, 57, 254, 174, 137, 126, 206, 213, 87, 154, 182, 196, 163, 15, 181, 220, 74, 73, 132, 70, 39, 77, 65, 143, 151, 168, 189, 207, 198, 95, 80, 145, 174, 10, 119, 22, 250, 47, 79, 148, 78, 116, 144, 243, 117, 233, 87, 212, 160, 196, 5, 111, 36, 8, 137, 216, 238, 93, 172 }, new byte[] { 167, 94, 154, 90, 157, 56, 107, 73, 122, 33, 105, 146, 33, 49, 249, 193, 199, 6, 61, 157, 30, 171, 196, 78, 131, 35, 153, 41, 155, 74, 52, 90, 52, 219, 207, 167, 10, 89, 61, 228, 124, 109, 108, 224, 145, 19, 254, 111, 146, 152, 7, 71, 12, 242, 149, 20, 150, 160, 52, 72, 81, 106, 235, 53, 60, 194, 14, 20, 174, 33, 169, 193, 218, 47, 78, 28, 12, 134, 251, 118, 120, 187, 44, 131, 120, 190, 205, 93, 8, 198, 164, 16, 32, 46, 179, 247, 98, 108, 126, 0, 7, 167, 65, 156, 25, 129, 69, 134, 244, 243, 169, 41, 160, 37, 134, 170, 185, 25, 217, 197, 62, 144, 253, 184, 125, 29, 128, 248 } });
        }
    }
}
