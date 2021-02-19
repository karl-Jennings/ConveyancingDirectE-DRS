using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class ErrorLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    ErrorLogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(maxLength: 500, nullable: true),
                    Message = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Source = table.Column<string>(maxLength: 2147483647, nullable: true),
                    StackTraceString = table.Column<string>(maxLength: 2147483647, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "Datetime", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.ErrorLogId);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 177, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 178, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 178, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 178, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 22, 10, 15, 21, 178, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 30, 54, 153, 231, 60, 71, 184, 143, 175, 174, 132, 181, 15, 56, 111, 225, 7, 74, 219, 161, 42, 125, 114, 61, 55, 2, 182, 149, 64, 208, 20, 103, 52, 196, 153, 151, 163, 131, 159, 16, 118, 208, 252, 216, 23, 71, 105, 225, 239, 64, 107, 23, 92, 76, 195, 66, 183, 80, 209, 148, 246, 85, 81 }, new byte[] { 72, 74, 75, 166, 36, 227, 27, 18, 123, 76, 137, 73, 188, 94, 35, 27, 185, 109, 13, 19, 122, 249, 67, 228, 116, 11, 206, 73, 145, 96, 122, 40, 118, 113, 152, 240, 233, 252, 254, 112, 30, 237, 234, 233, 252, 215, 185, 53, 152, 131, 12, 185, 181, 218, 139, 19, 208, 29, 227, 113, 92, 173, 49, 174, 2, 58, 80, 218, 194, 95, 162, 227, 35, 191, 135, 15, 172, 13, 237, 57, 124, 115, 83, 54, 34, 140, 24, 83, 164, 185, 210, 36, 73, 42, 90, 217, 229, 110, 126, 220, 192, 116, 224, 81, 164, 139, 134, 142, 35, 160, 86, 146, 53, 126, 96, 36, 1, 102, 192, 28, 62, 234, 54, 251, 104, 57, 188, 241 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 153, 10, 158, 59, 196, 204, 130, 147, 134, 231, 94, 9, 187, 166, 199, 207, 192, 94, 75, 49, 1, 71, 36, 2, 34, 111, 182, 79, 56, 61, 114, 103, 157, 185, 81, 46, 154, 212, 244, 108, 195, 222, 226, 86, 209, 83, 177, 76, 253, 174, 17, 37, 182, 86, 41, 106, 229, 3, 0, 29, 150, 17, 171 }, new byte[] { 11, 149, 68, 101, 33, 94, 27, 58, 3, 202, 194, 194, 51, 200, 236, 38, 92, 215, 30, 142, 15, 131, 219, 87, 245, 3, 245, 3, 33, 5, 128, 86, 164, 88, 83, 91, 34, 148, 80, 78, 104, 164, 181, 0, 153, 181, 52, 93, 36, 31, 152, 146, 174, 220, 1, 119, 104, 143, 91, 32, 197, 162, 14, 219, 181, 134, 79, 61, 164, 173, 64, 237, 160, 243, 133, 36, 237, 121, 168, 148, 99, 46, 162, 159, 135, 152, 173, 213, 225, 56, 38, 126, 124, 216, 25, 148, 56, 122, 23, 208, 72, 38, 30, 135, 109, 47, 177, 233, 12, 53, 154, 237, 100, 165, 123, 204, 198, 59, 17, 75, 222, 152, 217, 17, 69, 106, 79, 236 } });
        }
    }
}
