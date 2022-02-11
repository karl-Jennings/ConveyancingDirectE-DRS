using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class RequisitionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requisition",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    TypeCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    File = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    AppMessageId = table.Column<string>(nullable: true),
                    RejectionReason = table.Column<string>(nullable: true),
                    ValidationErrors = table.Column<string>(nullable: true),
                    ResponseType = table.Column<string>(nullable: true),
                    ResponseJson = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false),
                    IsSuccess = table.Column<bool>(nullable: false),
                    AttachmentName = table.Column<string>(nullable: true),
                    AttachmentId = table.Column<string>(nullable: true),
                    CreateRegistrationXMLRequest = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisition", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 22, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 2, 10, 18, 22, 15, 23, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 241, 143, 215, 107, 197, 63, 177, 187, 141, 229, 97, 227, 69, 82, 234, 155, 11, 25, 161, 107, 131, 27, 36, 152, 193, 102, 205, 51, 66, 65, 31, 217, 189, 26, 59, 49, 39, 1, 131, 166, 26, 46, 111, 96, 255, 235, 231, 232, 115, 241, 126, 77, 43, 252, 42, 242, 111, 237, 52, 44, 228, 200, 20, 55 }, new byte[] { 237, 23, 12, 77, 123, 222, 118, 137, 58, 109, 247, 80, 2, 121, 81, 58, 188, 67, 10, 24, 175, 150, 104, 105, 66, 237, 55, 194, 62, 40, 244, 68, 133, 238, 21, 144, 25, 67, 141, 207, 207, 3, 188, 186, 5, 40, 180, 244, 95, 54, 93, 159, 54, 79, 233, 87, 83, 114, 134, 220, 78, 254, 190, 242, 191, 215, 239, 194, 136, 231, 63, 230, 30, 210, 14, 46, 143, 125, 165, 102, 79, 64, 202, 228, 182, 119, 231, 78, 241, 118, 53, 35, 223, 215, 40, 128, 126, 42, 86, 50, 224, 116, 120, 96, 160, 13, 59, 26, 9, 42, 67, 79, 51, 149, 173, 195, 42, 49, 215, 165, 198, 105, 41, 28, 226, 150, 96, 37 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requisition");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 391, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 14, 18, 43, 41, 392, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 28, 254, 14, 129, 95, 67, 180, 97, 153, 41, 255, 144, 62, 39, 139, 61, 147, 234, 132, 103, 184, 106, 101, 155, 37, 1, 209, 212, 106, 158, 16, 243, 193, 62, 94, 231, 42, 86, 50, 92, 147, 153, 44, 155, 82, 125, 67, 36, 226, 222, 57, 206, 26, 97, 80, 235, 39, 90, 211, 125, 15, 199, 93 }, new byte[] { 31, 80, 162, 35, 18, 74, 111, 20, 44, 38, 162, 160, 100, 8, 67, 162, 22, 193, 138, 13, 241, 216, 99, 49, 132, 243, 135, 236, 215, 179, 113, 44, 20, 71, 161, 216, 215, 102, 84, 28, 6, 104, 101, 254, 74, 188, 23, 177, 117, 147, 129, 154, 95, 234, 160, 144, 16, 81, 185, 180, 20, 251, 218, 206, 37, 122, 98, 42, 224, 190, 128, 123, 164, 189, 101, 199, 240, 167, 204, 107, 181, 116, 229, 168, 248, 217, 95, 124, 19, 54, 155, 2, 49, 102, 209, 192, 111, 248, 111, 244, 170, 48, 148, 156, 173, 181, 84, 254, 242, 119, 230, 82, 231, 171, 124, 133, 59, 40, 52, 237, 100, 183, 52, 72, 253, 40, 178, 18 } });
        }
    }
}
