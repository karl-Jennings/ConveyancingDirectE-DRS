using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class logs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestLogs",
                columns: table => new
                {
                    RequestLogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    TypeCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    File = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLogs", x => x.RequestLogId);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 904, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 4, 47, 905, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 223, 210, 89, 152, 15, 243, 81, 201, 197, 44, 109, 211, 136, 188, 114, 171, 57, 70, 130, 115, 138, 240, 216, 150, 66, 153, 209, 19, 0, 59, 160, 226, 25, 99, 31, 122, 72, 20, 235, 219, 66, 90, 152, 138, 201, 149, 110, 167, 202, 96, 60, 71, 166, 183, 249, 159, 189, 15, 61, 181, 240, 30, 31, 27 }, new byte[] { 170, 255, 167, 100, 200, 77, 247, 87, 223, 4, 54, 242, 163, 231, 72, 162, 187, 126, 174, 224, 238, 193, 130, 176, 6, 216, 212, 137, 42, 151, 22, 47, 114, 224, 131, 4, 110, 17, 128, 100, 212, 91, 179, 141, 155, 155, 18, 41, 27, 205, 15, 204, 0, 222, 116, 91, 171, 103, 128, 162, 234, 193, 173, 20, 45, 27, 87, 177, 20, 25, 221, 127, 41, 5, 110, 38, 20, 198, 2, 79, 153, 61, 62, 136, 101, 31, 238, 59, 43, 198, 14, 80, 1, 17, 166, 0, 246, 44, 157, 127, 250, 10, 163, 102, 251, 230, 237, 61, 21, 104, 84, 120, 159, 172, 106, 120, 219, 150, 36, 28, 38, 100, 195, 7, 30, 64, 122, 55 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestLogs");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 16, 56, 37, 528, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 25, 5, 216, 31, 115, 232, 172, 240, 141, 73, 175, 184, 137, 105, 137, 157, 168, 212, 19, 135, 122, 163, 9, 93, 11, 200, 22, 113, 39, 81, 184, 234, 167, 173, 215, 120, 25, 206, 156, 235, 53, 58, 2, 111, 155, 112, 198, 13, 131, 243, 152, 144, 237, 213, 188, 217, 175, 223, 53, 131, 165, 245, 242 }, new byte[] { 70, 2, 34, 231, 175, 245, 31, 153, 146, 44, 142, 244, 29, 150, 93, 245, 42, 149, 80, 176, 184, 75, 52, 204, 39, 211, 246, 76, 13, 59, 3, 206, 199, 173, 41, 114, 217, 151, 119, 196, 174, 166, 130, 116, 102, 158, 136, 100, 125, 32, 99, 55, 117, 50, 7, 20, 30, 28, 179, 53, 150, 33, 147, 255, 47, 121, 170, 144, 11, 105, 138, 11, 235, 163, 71, 134, 41, 219, 0, 176, 103, 131, 47, 80, 81, 95, 75, 62, 45, 82, 19, 98, 94, 5, 94, 216, 127, 44, 44, 25, 210, 219, 254, 49, 11, 82, 214, 93, 196, 133, 108, 210, 131, 241, 179, 124, 6, 94, 128, 250, 217, 231, 166, 146, 116, 79, 211, 130 } });
        }
    }
}
