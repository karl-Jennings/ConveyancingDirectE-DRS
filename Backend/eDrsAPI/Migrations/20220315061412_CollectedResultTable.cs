using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class CollectedResultTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollectedResult",
                columns: table => new
                {
                    ResultId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageId = table.Column<string>(nullable: true),
                    AppMessageId = table.Column<string>(nullable: true),
                    ExternalReference = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    TypeCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    File = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    RejectionReason = table.Column<string>(nullable: true),
                    ValidationErrors = table.Column<string>(nullable: true),
                    ResponseType = table.Column<string>(nullable: true),
                    ResponseJson = table.Column<string>(nullable: true),
                    IsSuccess = table.Column<bool>(nullable: false),
                    AttachmentName = table.Column<string>(nullable: true),
                    AttachmentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectedResult", x => x.ResultId);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 11, 44, 11, 321, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 11, 44, 11, 321, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 11, 44, 11, 321, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 11, 44, 11, 321, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 11, 44, 11, 321, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 11, 44, 11, 321, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 11, 44, 11, 321, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 11, 44, 11, 321, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 120, 124, 86, 40, 216, 227, 58, 111, 203, 64, 192, 170, 142, 123, 67, 175, 73, 142, 58, 154, 238, 25, 38, 138, 122, 129, 16, 108, 183, 9, 56, 204, 12, 111, 70, 184, 46, 213, 124, 147, 49, 141, 201, 139, 169, 61, 255, 195, 253, 150, 162, 66, 20, 84, 118, 127, 210, 245, 78, 234, 54, 132, 140, 116 }, new byte[] { 159, 75, 121, 164, 71, 169, 143, 116, 217, 18, 88, 7, 63, 170, 71, 139, 174, 243, 104, 229, 4, 120, 53, 73, 144, 164, 5, 28, 231, 15, 153, 139, 204, 218, 183, 227, 208, 246, 229, 109, 80, 16, 117, 213, 118, 185, 22, 144, 52, 6, 7, 48, 197, 0, 11, 89, 188, 48, 243, 75, 216, 36, 129, 208, 67, 100, 83, 133, 61, 228, 79, 233, 95, 175, 152, 124, 175, 113, 158, 173, 39, 85, 62, 35, 87, 138, 224, 103, 64, 242, 205, 251, 33, 122, 9, 17, 233, 43, 243, 112, 222, 77, 180, 220, 224, 36, 164, 219, 210, 74, 81, 157, 109, 252, 22, 16, 217, 133, 109, 77, 29, 175, 156, 158, 96, 154, 45, 148 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectedResult");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 980, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 15, 9, 36, 27, 983, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 215, 247, 82, 194, 164, 39, 44, 226, 87, 182, 103, 137, 11, 123, 157, 133, 206, 172, 192, 36, 35, 210, 37, 168, 225, 23, 160, 202, 155, 123, 38, 175, 81, 250, 122, 107, 181, 228, 224, 45, 114, 239, 108, 92, 255, 145, 20, 134, 5, 10, 103, 21, 142, 25, 97, 84, 155, 27, 53, 176, 158, 213, 147, 195 }, new byte[] { 166, 44, 214, 196, 27, 210, 86, 195, 166, 78, 177, 67, 37, 224, 70, 198, 174, 208, 177, 152, 194, 124, 67, 254, 114, 240, 210, 91, 132, 134, 148, 196, 155, 101, 56, 182, 49, 248, 159, 134, 74, 97, 121, 177, 231, 246, 199, 6, 31, 130, 252, 178, 84, 49, 151, 213, 14, 231, 119, 236, 222, 8, 88, 5, 244, 92, 25, 178, 226, 57, 196, 39, 254, 76, 42, 55, 19, 59, 43, 255, 105, 110, 5, 154, 169, 254, 88, 35, 186, 221, 19, 151, 92, 26, 52, 108, 209, 237, 75, 84, 165, 45, 225, 89, 47, 25, 80, 183, 150, 224, 69, 241, 141, 95, 167, 135, 238, 27, 80, 224, 44, 24, 205, 220, 0, 40, 226, 83 } });
        }
    }
}
