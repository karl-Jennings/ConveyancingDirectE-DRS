using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class removeNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttachmentNotes");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 91, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 64, 179, 175, 142, 224, 85, 77, 242, 120, 24, 149, 51, 37, 206, 47, 65, 223, 96, 8, 153, 220, 243, 16, 228, 131, 162, 197, 60, 54, 231, 204, 35, 205, 84, 19, 141, 98, 83, 138, 18, 247, 121, 36, 43, 21, 35, 181, 38, 228, 231, 152, 223, 96, 179, 17, 35, 206, 135, 14, 251, 162, 71, 254, 251 }, new byte[] { 22, 106, 186, 162, 90, 181, 202, 213, 36, 235, 74, 205, 113, 230, 145, 6, 130, 115, 112, 190, 142, 167, 105, 72, 215, 107, 199, 113, 98, 121, 84, 26, 5, 102, 24, 12, 34, 151, 122, 148, 172, 148, 232, 129, 234, 125, 94, 30, 89, 159, 227, 177, 31, 237, 28, 66, 157, 59, 194, 101, 221, 17, 9, 206, 221, 76, 16, 73, 235, 158, 224, 171, 93, 59, 58, 155, 137, 236, 144, 24, 83, 100, 82, 109, 140, 202, 219, 236, 103, 199, 219, 143, 146, 34, 91, 193, 255, 9, 122, 185, 175, 200, 103, 118, 80, 120, 113, 201, 122, 17, 160, 197, 190, 57, 158, 156, 222, 219, 171, 144, 78, 237, 237, 16, 65, 22, 181, 102 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttachmentNotes",
                columns: table => new
                {
                    AttachmentNotesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalProviderFilter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationMessageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentReferenceId = table.Column<long>(type: "bigint", nullable: true),
                    ExternalReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageId = table.Column<long>(type: "bigint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentNotes", x => x.AttachmentNotesId);
                    table.ForeignKey(
                        name: "FK_AttachmentNotes_DocumentReferences_DocumentReferenceId",
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
                value: new DateTime(2021, 3, 22, 15, 24, 20, 634, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 22, 15, 24, 20, 635, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 231, 222, 183, 20, 254, 199, 222, 97, 101, 7, 19, 144, 55, 30, 134, 240, 190, 228, 143, 215, 225, 15, 156, 198, 235, 158, 132, 70, 5, 104, 74, 104, 129, 21, 54, 202, 67, 90, 138, 45, 155, 150, 119, 6, 9, 243, 4, 78, 209, 3, 205, 78, 4, 133, 96, 53, 125, 136, 70, 78, 208, 235, 218, 194 }, new byte[] { 104, 4, 184, 73, 166, 100, 155, 95, 230, 234, 92, 106, 227, 96, 68, 97, 176, 33, 104, 83, 170, 198, 239, 231, 9, 215, 170, 144, 242, 218, 60, 121, 187, 104, 28, 12, 113, 94, 183, 25, 56, 23, 225, 217, 3, 14, 163, 197, 197, 122, 216, 26, 39, 98, 203, 51, 201, 136, 155, 205, 98, 138, 202, 71, 151, 132, 52, 38, 164, 218, 182, 124, 83, 31, 168, 251, 185, 110, 103, 127, 197, 247, 26, 74, 87, 93, 43, 30, 226, 25, 224, 68, 46, 117, 130, 127, 201, 137, 154, 130, 59, 236, 92, 164, 37, 246, 105, 229, 70, 248, 77, 10, 121, 104, 29, 111, 120, 187, 118, 230, 232, 120, 105, 68, 211, 12, 73, 38 } });

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentNotes_DocumentReferenceId",
                table: "AttachmentNotes",
                column: "DocumentReferenceId");
        }
    }
}
