using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class removeNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "DocumentReferences");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 16, 18, 49, 21, 734, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 16, 18, 49, 21, 735, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 16, 18, 49, 21, 735, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 16, 18, 49, 21, 735, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 16, 18, 49, 21, 735, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 16, 18, 49, 21, 735, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 16, 18, 49, 21, 735, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 16, 18, 49, 21, 735, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 37, 208, 209, 238, 142, 65, 52, 23, 210, 122, 174, 16, 69, 192, 41, 129, 45, 222, 67, 94, 64, 116, 126, 181, 104, 160, 227, 139, 186, 143, 196, 221, 56, 24, 30, 188, 123, 86, 159, 144, 112, 161, 214, 178, 180, 76, 88, 43, 212, 178, 246, 112, 81, 123, 106, 247, 230, 90, 21, 120, 199, 16, 41, 190 }, new byte[] { 174, 170, 45, 63, 145, 114, 10, 223, 233, 39, 144, 174, 254, 5, 198, 56, 36, 55, 210, 18, 167, 45, 232, 107, 175, 92, 16, 3, 198, 3, 19, 179, 76, 151, 76, 135, 219, 108, 150, 218, 171, 241, 154, 122, 93, 239, 92, 98, 14, 57, 71, 75, 150, 47, 230, 167, 23, 23, 108, 73, 15, 193, 156, 178, 71, 60, 136, 99, 141, 117, 79, 55, 200, 224, 3, 201, 109, 216, 61, 180, 176, 64, 106, 44, 148, 138, 81, 6, 122, 79, 208, 187, 48, 135, 100, 191, 216, 8, 217, 25, 173, 87, 66, 130, 214, 26, 6, 48, 14, 179, 48, 136, 167, 185, 77, 97, 211, 234, 165, 205, 102, 50, 7, 191, 244, 107, 43, 95 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "DocumentReferences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 15, 9, 52, 59, 391, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 233, 50, 91, 212, 16, 219, 82, 161, 70, 218, 124, 9, 136, 86, 45, 165, 216, 100, 234, 125, 180, 224, 165, 79, 129, 199, 171, 203, 10, 89, 245, 185, 26, 189, 13, 179, 196, 187, 173, 150, 202, 3, 177, 126, 105, 8, 200, 133, 158, 231, 182, 248, 11, 44, 157, 1, 155, 125, 201, 142, 19, 96, 238, 99 }, new byte[] { 42, 100, 199, 88, 43, 9, 191, 110, 107, 125, 195, 77, 91, 211, 128, 127, 116, 195, 201, 36, 102, 226, 82, 35, 185, 113, 202, 153, 194, 38, 187, 109, 47, 147, 78, 237, 79, 180, 29, 139, 59, 145, 107, 109, 194, 66, 247, 66, 249, 11, 173, 121, 9, 94, 87, 29, 200, 148, 144, 14, 246, 159, 151, 214, 160, 157, 108, 252, 168, 173, 201, 132, 209, 38, 158, 154, 77, 45, 40, 51, 219, 40, 179, 216, 75, 56, 244, 205, 129, 109, 5, 140, 97, 247, 229, 10, 101, 129, 15, 15, 80, 90, 53, 23, 45, 233, 199, 98, 34, 207, 223, 112, 186, 177, 149, 121, 81, 17, 110, 219, 166, 165, 53, 7, 133, 143, 254, 59 } });
        }
    }
}
