using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class lrcred : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LrCredentials",
                columns: table => new
                {
                    LrCredentialsId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LrCredentials", x => x.LrCredentialsId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LrCredentials");

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
