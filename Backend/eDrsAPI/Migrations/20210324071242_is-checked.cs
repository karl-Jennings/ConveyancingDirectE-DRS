using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ischecked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "SupportingDocuments",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "ApplicationForms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 42, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 93, 234, 57, 211, 214, 14, 210, 16, 226, 28, 244, 255, 185, 195, 32, 230, 75, 143, 87, 14, 70, 74, 233, 191, 36, 210, 192, 110, 122, 194, 84, 27, 242, 151, 171, 250, 234, 7, 2, 144, 86, 249, 66, 81, 114, 77, 228, 217, 77, 119, 198, 2, 101, 238, 95, 55, 85, 41, 91, 166, 236, 96, 61 }, new byte[] { 138, 27, 0, 108, 246, 3, 175, 1, 195, 123, 173, 42, 252, 60, 157, 174, 23, 178, 118, 71, 120, 16, 243, 87, 153, 122, 147, 136, 63, 163, 89, 33, 55, 194, 18, 24, 80, 94, 193, 132, 238, 214, 161, 37, 49, 195, 53, 45, 60, 192, 226, 113, 58, 244, 225, 199, 82, 116, 165, 177, 192, 151, 153, 59, 86, 23, 135, 189, 134, 217, 13, 159, 240, 218, 158, 150, 191, 246, 112, 56, 74, 63, 203, 7, 240, 134, 144, 64, 0, 234, 18, 142, 155, 45, 239, 114, 243, 49, 207, 66, 115, 75, 127, 227, 88, 22, 83, 87, 249, 104, 11, 20, 226, 174, 250, 46, 201, 117, 144, 99, 136, 41, 255, 79, 252, 143, 252, 158 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "ApplicationForms");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 904, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 13, 42, 47, 905, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 105, 134, 14, 192, 141, 98, 135, 94, 98, 225, 134, 115, 207, 191, 106, 139, 122, 103, 73, 186, 235, 180, 200, 175, 227, 115, 104, 184, 22, 42, 101, 135, 23, 146, 238, 182, 25, 145, 94, 224, 32, 25, 56, 36, 233, 206, 223, 46, 255, 95, 135, 38, 190, 78, 9, 115, 181, 76, 100, 68, 144, 207, 7, 22 }, new byte[] { 225, 183, 136, 84, 147, 15, 201, 163, 218, 42, 106, 7, 245, 60, 191, 101, 127, 143, 16, 254, 86, 77, 34, 41, 163, 35, 121, 60, 204, 94, 124, 90, 52, 168, 209, 56, 181, 14, 70, 166, 12, 183, 24, 158, 241, 95, 146, 81, 170, 128, 99, 16, 189, 85, 57, 35, 212, 87, 127, 27, 54, 173, 127, 245, 164, 17, 68, 190, 129, 196, 95, 243, 32, 146, 207, 76, 99, 239, 210, 179, 6, 10, 173, 19, 28, 105, 103, 84, 67, 27, 254, 158, 239, 66, 72, 76, 144, 165, 199, 115, 23, 185, 220, 189, 219, 51, 225, 252, 248, 137, 83, 87, 113, 35, 50, 53, 63, 139, 253, 185, 150, 129, 158, 192, 45, 194, 21, 243 } });
        }
    }
}
