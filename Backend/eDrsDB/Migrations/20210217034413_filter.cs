using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class filter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalProviderFilter",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalReference",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 79, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 80, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 80, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 80, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 14, 13, 80, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 214, 123, 205, 83, 110, 224, 62, 235, 15, 199, 109, 230, 9, 93, 26, 110, 247, 35, 98, 140, 192, 13, 153, 138, 187, 205, 59, 59, 122, 59, 222, 94, 241, 189, 49, 127, 5, 17, 206, 110, 102, 133, 160, 52, 31, 192, 33, 193, 117, 27, 76, 29, 95, 167, 221, 18, 162, 219, 232, 239, 20, 17, 94 }, new byte[] { 52, 115, 103, 17, 129, 28, 157, 66, 59, 24, 208, 210, 72, 46, 17, 26, 203, 222, 139, 124, 8, 117, 80, 91, 244, 216, 167, 69, 20, 87, 50, 15, 179, 146, 249, 128, 122, 248, 37, 130, 85, 189, 40, 226, 130, 200, 154, 243, 116, 154, 38, 62, 219, 51, 39, 161, 85, 178, 180, 65, 154, 136, 251, 110, 27, 50, 237, 1, 83, 49, 194, 156, 93, 84, 109, 196, 58, 154, 5, 175, 41, 75, 114, 27, 222, 171, 23, 8, 22, 109, 191, 183, 102, 147, 250, 167, 242, 133, 40, 226, 213, 249, 210, 30, 83, 14, 114, 136, 205, 170, 196, 247, 204, 121, 77, 162, 177, 38, 72, 8, 189, 221, 114, 40, 174, 206, 61, 129 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalProviderFilter",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "ExternalReference",
                table: "DocumentReferences");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 892, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 894, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 894, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 894, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 3, 57, 894, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 158, 168, 220, 159, 198, 152, 214, 147, 61, 162, 197, 210, 100, 135, 218, 108, 26, 33, 168, 80, 231, 227, 110, 201, 178, 163, 57, 182, 159, 16, 41, 162, 244, 46, 14, 47, 10, 163, 71, 136, 152, 208, 217, 207, 2, 78, 245, 184, 73, 143, 191, 154, 138, 114, 38, 11, 72, 253, 239, 2, 27, 101, 164, 214 }, new byte[] { 74, 47, 134, 137, 191, 36, 109, 181, 96, 67, 64, 161, 76, 175, 24, 87, 117, 164, 164, 160, 156, 116, 86, 204, 182, 158, 87, 216, 185, 205, 206, 88, 95, 205, 29, 244, 157, 42, 26, 97, 196, 4, 222, 81, 68, 250, 127, 197, 95, 88, 217, 156, 127, 255, 14, 192, 186, 137, 8, 154, 139, 38, 161, 191, 199, 126, 245, 66, 207, 24, 26, 59, 83, 11, 101, 174, 153, 9, 230, 11, 143, 180, 110, 34, 148, 156, 144, 136, 97, 145, 54, 238, 71, 158, 166, 127, 206, 247, 233, 101, 180, 15, 159, 36, 44, 150, 94, 164, 251, 25, 144, 215, 141, 171, 112, 170, 59, 89, 141, 29, 32, 26, 243, 226, 90, 97, 53, 93 } });
        }
    }
}
