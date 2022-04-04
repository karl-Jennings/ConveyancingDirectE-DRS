using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class AttachementResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AttachmentResultRequestLogId",
                table: "RequestLogs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AttachmentResult",
                columns: table => new
                {
                    RequestLogId = table.Column<long>(nullable: false)
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
                    DocumentReferenceId = table.Column<long>(nullable: true),
                    IsSuccess = table.Column<bool>(nullable: false),
                    AttachmentName = table.Column<string>(nullable: true),
                    AttachmentId = table.Column<string>(nullable: true),
                    CreateRegistrationXMLRequest = table.Column<string>(nullable: true),
                    MessageId = table.Column<string>(nullable: true),
                    ExternalReference = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentResult", x => x.RequestLogId);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 658, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 3, 11, 25, 15, 659, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 188, 145, 163, 36, 131, 177, 248, 77, 236, 237, 33, 100, 77, 197, 78, 124, 21, 30, 134, 236, 230, 106, 45, 5, 120, 165, 22, 228, 62, 3, 115, 82, 63, 133, 143, 174, 196, 16, 82, 3, 190, 15, 40, 163, 214, 69, 17, 221, 69, 48, 51, 17, 8, 214, 168, 109, 244, 219, 104, 91, 122, 217, 47 }, new byte[] { 201, 2, 201, 85, 173, 103, 253, 15, 5, 93, 77, 175, 75, 64, 104, 192, 27, 246, 183, 201, 174, 70, 169, 45, 240, 214, 132, 120, 67, 166, 164, 204, 49, 245, 32, 220, 157, 229, 201, 81, 208, 146, 121, 12, 50, 203, 148, 211, 23, 208, 59, 67, 67, 223, 55, 116, 178, 117, 65, 163, 247, 212, 57, 84, 209, 159, 140, 62, 233, 71, 49, 119, 221, 251, 52, 182, 184, 229, 86, 159, 53, 163, 92, 249, 111, 49, 110, 104, 70, 30, 175, 153, 12, 16, 5, 202, 45, 87, 53, 66, 231, 254, 56, 174, 80, 9, 250, 234, 244, 116, 33, 212, 86, 193, 114, 236, 13, 203, 11, 60, 5, 242, 198, 252, 66, 171, 120, 38 } });

            migrationBuilder.CreateIndex(
                name: "IX_RequestLogs_AttachmentResultRequestLogId",
                table: "RequestLogs",
                column: "AttachmentResultRequestLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestLogs_AttachmentResult_AttachmentResultRequestLogId",
                table: "RequestLogs",
                column: "AttachmentResultRequestLogId",
                principalTable: "AttachmentResult",
                principalColumn: "RequestLogId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestLogs_AttachmentResult_AttachmentResultRequestLogId",
                table: "RequestLogs");

            migrationBuilder.DropTable(
                name: "AttachmentResult");

            migrationBuilder.DropIndex(
                name: "IX_RequestLogs_AttachmentResultRequestLogId",
                table: "RequestLogs");

            migrationBuilder.DropColumn(
                name: "AttachmentResultRequestLogId",
                table: "RequestLogs");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 1, 15, 41, 16, 629, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 1, 15, 41, 16, 630, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 1, 15, 41, 16, 630, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 1, 15, 41, 16, 630, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 1, 15, 41, 16, 630, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 1, 15, 41, 16, 630, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 1, 15, 41, 16, 630, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 4, 1, 15, 41, 16, 630, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 24, 153, 77, 157, 119, 59, 106, 252, 140, 211, 92, 85, 27, 83, 193, 134, 15, 79, 87, 231, 25, 221, 109, 67, 230, 9, 166, 124, 175, 199, 161, 31, 55, 58, 100, 125, 123, 187, 127, 74, 89, 169, 144, 4, 233, 26, 43, 64, 179, 19, 214, 1, 49, 60, 105, 1, 210, 133, 123, 175, 254, 41, 255, 132 }, new byte[] { 130, 158, 166, 41, 146, 45, 243, 87, 103, 7, 91, 40, 135, 27, 87, 76, 124, 253, 58, 168, 91, 89, 186, 6, 106, 50, 11, 76, 157, 203, 229, 223, 78, 135, 225, 201, 127, 254, 151, 186, 130, 112, 167, 193, 9, 120, 105, 38, 80, 39, 49, 245, 212, 131, 196, 176, 56, 44, 217, 16, 77, 211, 112, 170, 73, 200, 252, 134, 80, 107, 10, 230, 195, 196, 140, 247, 196, 157, 18, 227, 116, 116, 110, 210, 117, 17, 127, 145, 86, 145, 39, 194, 197, 66, 166, 102, 113, 217, 114, 78, 113, 187, 188, 43, 192, 48, 69, 4, 204, 65, 9, 70, 2, 102, 61, 75, 120, 78, 83, 118, 82, 248, 77, 226, 217, 81, 209, 177 } });
        }
    }
}
