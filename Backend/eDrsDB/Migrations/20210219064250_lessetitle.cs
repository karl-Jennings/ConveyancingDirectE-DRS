using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class lessetitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LesseeTitleNumber",
                table: "TitleNumbers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AttachmentNotes",
                columns: table => new
                {
                    AttachmentNotesId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalProviderFilter = table.Column<string>(nullable: true),
                    MessageId = table.Column<long>(nullable: false),
                    ExternalReference = table.Column<string>(nullable: true),
                    ApplicationMessageId = table.Column<string>(nullable: true),
                    ApplicationService = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false)
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
                value: new DateTime(2021, 2, 19, 12, 12, 49, 455, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 12, 49, 457, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 239, 166, 212, 236, 183, 35, 198, 197, 197, 160, 89, 50, 166, 124, 152, 197, 41, 146, 77, 38, 130, 84, 157, 202, 123, 28, 200, 220, 43, 233, 17, 247, 173, 153, 250, 199, 25, 51, 21, 47, 116, 77, 12, 198, 139, 137, 30, 43, 186, 141, 203, 230, 120, 159, 79, 213, 44, 10, 108, 235, 56, 164, 126 }, new byte[] { 202, 79, 117, 56, 25, 137, 156, 70, 147, 77, 31, 171, 217, 189, 219, 70, 204, 156, 104, 61, 190, 218, 25, 41, 7, 98, 173, 99, 26, 154, 84, 200, 211, 106, 191, 114, 143, 240, 112, 162, 154, 50, 167, 25, 29, 25, 145, 141, 251, 202, 243, 228, 43, 206, 246, 255, 185, 156, 108, 74, 40, 12, 205, 55, 149, 239, 189, 166, 152, 75, 216, 41, 239, 233, 217, 51, 49, 58, 152, 221, 27, 49, 239, 65, 139, 231, 122, 145, 200, 209, 44, 46, 56, 22, 193, 10, 255, 178, 205, 211, 170, 38, 152, 212, 99, 105, 131, 236, 100, 146, 33, 247, 225, 217, 177, 229, 224, 154, 240, 237, 208, 237, 45, 67, 6, 29, 95, 25 } });

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentNotes_DocumentReferenceId",
                table: "AttachmentNotes",
                column: "DocumentReferenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttachmentNotes");

            migrationBuilder.DropColumn(
                name: "LesseeTitleNumber",
                table: "TitleNumbers");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 735, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 10, 11, 7, 736, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 29, 112, 220, 3, 26, 178, 103, 89, 16, 227, 107, 206, 198, 236, 181, 157, 228, 79, 95, 76, 32, 55, 146, 153, 46, 129, 166, 42, 189, 50, 163, 212, 176, 238, 177, 185, 8, 234, 133, 107, 227, 81, 56, 207, 112, 200, 219, 212, 233, 2, 7, 21, 164, 28, 35, 247, 150, 141, 243, 33, 95, 233, 71, 168 }, new byte[] { 122, 21, 47, 170, 207, 32, 142, 207, 41, 53, 68, 150, 61, 197, 50, 247, 176, 55, 102, 3, 132, 36, 151, 219, 219, 214, 41, 118, 39, 97, 237, 189, 147, 145, 132, 220, 84, 42, 210, 148, 41, 60, 164, 71, 152, 231, 152, 221, 204, 69, 66, 136, 239, 5, 246, 152, 160, 220, 117, 131, 18, 194, 214, 125, 53, 50, 150, 26, 129, 250, 250, 255, 94, 229, 205, 251, 200, 159, 76, 130, 65, 181, 66, 143, 118, 231, 104, 146, 139, 245, 254, 88, 201, 185, 47, 199, 3, 137, 32, 187, 34, 29, 86, 46, 174, 137, 61, 226, 21, 35, 249, 153, 88, 116, 103, 127, 48, 202, 185, 196, 122, 201, 194, 245, 13, 170, 89, 71 } });
        }
    }
}
