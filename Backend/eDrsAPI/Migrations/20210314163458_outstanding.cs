using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class outstanding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Outstanding",
                columns: table => new
                {
                    OutstandingId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandRegistryId = table.Column<string>(nullable: true),
                    ServiceType = table.Column<string>(nullable: true),
                    NewResponse = table.Column<bool>(nullable: false),
                    TypeCode = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outstanding", x => x.OutstandingId);
                    table.ForeignKey(
                        name: "FK_Outstanding_DocumentReferences_DocumentReferenceId",
                        column: x => x.DocumentReferenceId,
                        principalTable: "DocumentReferences",
                        principalColumn: "DocumentReferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 780, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 22, 4, 57, 781, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 39, 111, 152, 253, 255, 128, 187, 224, 74, 199, 186, 197, 212, 244, 73, 200, 23, 120, 212, 223, 7, 19, 96, 251, 141, 13, 255, 195, 114, 248, 205, 36, 213, 93, 194, 174, 214, 184, 254, 221, 150, 239, 39, 124, 19, 216, 132, 209, 43, 145, 78, 24, 0, 72, 110, 69, 209, 104, 251, 12, 167, 181, 253, 53 }, new byte[] { 57, 8, 77, 217, 137, 121, 96, 186, 1, 171, 177, 47, 146, 48, 30, 113, 217, 78, 199, 2, 226, 62, 65, 84, 235, 233, 164, 253, 179, 127, 19, 22, 96, 235, 156, 176, 74, 191, 41, 120, 105, 162, 239, 225, 42, 128, 117, 39, 153, 238, 138, 39, 196, 2, 182, 229, 39, 101, 242, 135, 139, 242, 27, 23, 208, 118, 0, 69, 52, 68, 126, 186, 17, 109, 48, 154, 80, 130, 117, 19, 144, 103, 211, 114, 128, 163, 117, 193, 120, 32, 95, 77, 202, 62, 239, 186, 58, 81, 38, 37, 194, 93, 160, 120, 196, 197, 151, 227, 103, 119, 167, 200, 201, 42, 251, 163, 58, 225, 39, 83, 75, 16, 177, 203, 150, 35, 202, 53 } });

            migrationBuilder.CreateIndex(
                name: "IX_Outstanding_DocumentReferenceId",
                table: "Outstanding",
                column: "DocumentReferenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Outstanding");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 656, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 14, 9, 25, 26, 657, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 147, 190, 68, 214, 60, 111, 248, 192, 159, 91, 176, 104, 43, 161, 103, 180, 233, 137, 184, 42, 133, 56, 98, 16, 8, 195, 88, 145, 52, 129, 35, 27, 177, 99, 114, 9, 222, 12, 72, 160, 13, 123, 138, 62, 190, 154, 67, 82, 250, 114, 96, 143, 164, 147, 137, 81, 138, 111, 161, 203, 187, 119, 178, 180 }, new byte[] { 226, 68, 67, 7, 24, 186, 197, 123, 176, 22, 37, 33, 225, 40, 185, 116, 172, 83, 154, 72, 220, 97, 110, 214, 67, 232, 171, 145, 42, 215, 185, 147, 49, 237, 201, 147, 140, 43, 72, 121, 221, 57, 113, 212, 9, 176, 168, 233, 66, 247, 118, 44, 204, 137, 103, 66, 60, 51, 68, 251, 178, 120, 87, 159, 59, 210, 30, 230, 234, 42, 245, 156, 166, 167, 194, 96, 184, 31, 4, 188, 233, 125, 206, 128, 162, 10, 163, 56, 38, 161, 218, 227, 192, 209, 76, 127, 211, 60, 78, 106, 44, 106, 44, 180, 31, 9, 68, 8, 213, 220, 142, 229, 179, 180, 1, 150, 134, 0, 236, 33, 91, 67, 47, 29, 202, 101, 180, 124 } });
        }
    }
}
