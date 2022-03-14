using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class MessageIdSetAsString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MessageId",
                table: "SupportingDocuments",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "MessageId",
                table: "SupportingDocuments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 667, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 14, 10, 28, 42, 668, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 102, 195, 157, 221, 209, 35, 50, 42, 167, 83, 2, 7, 43, 140, 160, 23, 79, 236, 168, 185, 67, 184, 228, 146, 91, 240, 213, 203, 117, 92, 122, 152, 240, 172, 70, 252, 100, 152, 240, 240, 2, 36, 62, 120, 41, 101, 189, 110, 57, 88, 132, 245, 232, 216, 203, 146, 65, 206, 241, 153, 162, 234, 107 }, new byte[] { 199, 98, 93, 92, 101, 246, 40, 87, 199, 88, 121, 191, 76, 188, 152, 123, 237, 62, 165, 200, 58, 204, 163, 137, 180, 182, 0, 235, 9, 46, 148, 229, 169, 224, 246, 108, 224, 100, 75, 107, 102, 177, 103, 200, 172, 23, 2, 78, 135, 108, 76, 146, 65, 237, 77, 20, 26, 253, 199, 205, 40, 115, 144, 197, 69, 70, 204, 57, 77, 56, 128, 101, 246, 234, 32, 179, 127, 244, 34, 144, 111, 71, 79, 146, 0, 222, 150, 118, 13, 67, 81, 108, 35, 18, 66, 231, 250, 208, 219, 191, 119, 29, 156, 48, 131, 46, 99, 228, 78, 60, 248, 48, 172, 72, 143, 57, 21, 65, 165, 249, 226, 204, 91, 54, 21, 18, 43, 21 } });
        }
    }
}
