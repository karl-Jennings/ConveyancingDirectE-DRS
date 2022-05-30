using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ApplyToRespondToRequisition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ApplyToRespondToRequisition",
                table: "SupportingDocuments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ApplyToRespondToRequisition",
                table: "Documents",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 336, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 5, 30, 9, 33, 46, 337, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 32, 95, 250, 136, 121, 29, 246, 110, 206, 161, 24, 72, 252, 16, 67, 68, 46, 248, 91, 17, 253, 238, 37, 78, 154, 217, 71, 43, 219, 73, 135, 32, 238, 217, 216, 220, 122, 38, 240, 40, 198, 44, 67, 246, 253, 230, 173, 74, 218, 174, 139, 74, 69, 157, 75, 4, 183, 214, 75, 226, 249, 43, 202 }, new byte[] { 92, 232, 127, 167, 210, 216, 182, 124, 200, 158, 111, 201, 46, 13, 208, 83, 53, 117, 247, 61, 201, 8, 162, 108, 97, 5, 202, 226, 155, 196, 16, 88, 251, 131, 125, 107, 110, 40, 171, 58, 104, 211, 184, 234, 190, 127, 155, 27, 91, 2, 173, 87, 84, 11, 35, 246, 145, 219, 224, 72, 213, 106, 207, 100, 96, 19, 95, 136, 13, 106, 79, 221, 248, 173, 100, 109, 104, 176, 225, 239, 119, 132, 221, 141, 211, 178, 14, 73, 92, 121, 136, 214, 35, 87, 51, 63, 234, 133, 39, 81, 52, 209, 222, 252, 85, 59, 183, 102, 226, 95, 88, 166, 36, 36, 100, 74, 198, 206, 100, 178, 212, 218, 103, 147, 136, 167, 223, 187 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplyToRespondToRequisition",
                table: "SupportingDocuments");

            migrationBuilder.DropColumn(
                name: "ApplyToRespondToRequisition",
                table: "Documents");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 28, 9, 46, 37, 370, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 28, 9, 46, 37, 371, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 28, 9, 46, 37, 371, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 28, 9, 46, 37, 371, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 28, 9, 46, 37, 371, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 28, 9, 46, 37, 371, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 28, 9, 46, 37, 371, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 28, 9, 46, 37, 371, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 118, 101, 106, 5, 221, 43, 54, 96, 126, 15, 91, 240, 67, 191, 217, 218, 189, 10, 70, 11, 182, 43, 132, 57, 187, 252, 216, 34, 11, 76, 156, 143, 26, 47, 44, 63, 194, 162, 223, 58, 49, 121, 111, 131, 191, 166, 141, 77, 23, 39, 106, 69, 17, 61, 131, 245, 172, 10, 221, 104, 7, 237, 188 }, new byte[] { 190, 151, 200, 129, 188, 115, 49, 241, 237, 247, 115, 139, 179, 199, 252, 25, 109, 183, 187, 29, 19, 16, 224, 7, 45, 201, 50, 57, 32, 47, 250, 49, 44, 209, 15, 113, 156, 209, 70, 149, 183, 94, 52, 63, 10, 55, 14, 68, 109, 220, 154, 54, 231, 93, 210, 67, 17, 169, 98, 178, 103, 196, 73, 234, 202, 69, 178, 145, 190, 82, 39, 126, 254, 98, 251, 103, 93, 127, 15, 42, 168, 188, 231, 249, 33, 208, 34, 82, 202, 77, 93, 169, 74, 182, 35, 181, 150, 219, 199, 141, 156, 226, 24, 8, 217, 154, 59, 202, 205, 28, 7, 35, 135, 76, 225, 163, 232, 17, 167, 2, 253, 124, 230, 60, 70, 185, 34, 47 } });
        }
    }
}
