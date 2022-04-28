using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class IdentityEvidence_RepresentativeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdentityEvidence_RepresentativeId",
                table: "Representations",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityEvidence_RepresentativeId",
                table: "Representations");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 884, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 19, 19, 27, 24, 885, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 74, 4, 233, 87, 191, 236, 80, 116, 248, 136, 187, 101, 199, 10, 18, 193, 50, 211, 123, 67, 145, 79, 136, 76, 90, 146, 223, 183, 114, 215, 196, 145, 47, 223, 71, 25, 72, 246, 93, 202, 43, 233, 249, 71, 106, 214, 215, 68, 141, 186, 103, 31, 121, 181, 252, 247, 243, 250, 209, 1, 179, 119, 169, 0 }, new byte[] { 190, 71, 138, 12, 212, 94, 62, 200, 208, 169, 54, 124, 67, 13, 107, 23, 171, 115, 86, 251, 196, 43, 204, 187, 201, 74, 228, 43, 25, 8, 199, 131, 108, 14, 149, 88, 100, 88, 37, 226, 148, 124, 23, 80, 55, 36, 217, 39, 98, 27, 23, 19, 154, 38, 8, 177, 77, 195, 83, 41, 95, 232, 70, 237, 201, 2, 11, 110, 171, 219, 223, 234, 15, 47, 198, 82, 156, 147, 126, 218, 145, 78, 10, 174, 30, 198, 53, 71, 246, 45, 137, 96, 135, 111, 202, 181, 174, 241, 215, 171, 60, 62, 14, 171, 98, 111, 126, 211, 119, 211, 203, 191, 54, 230, 146, 254, 190, 103, 82, 157, 245, 167, 34, 198, 11, 42, 56, 219 } });
        }
    }
}
