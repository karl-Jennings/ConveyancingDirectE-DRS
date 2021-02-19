using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class newDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_TitleNumbers_TitleNumberId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentReferences_RegistrationTypes_RegistrationTypeId",
                table: "DocumentReferences");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentReferences_Users_UserId",
                table: "DocumentReferences");

            migrationBuilder.DropIndex(
                name: "IX_DocumentReferences_RegistrationTypeId",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "PropertyName",
                table: "TitleNumbers");

            migrationBuilder.DropColumn(
                name: "TitleType",
                table: "TitleNumbers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "ReferenceCode",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "ReferenceName",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "RegistrationTypeId",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "CertificationType",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "ChargeDate",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "Fee",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "FileLocation",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "IsAgreed",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ApplicationForms");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "DocumentReferences",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "DocumentReferences",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(350)",
                oldMaxLength: 350,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AP1WarningUnderstood",
                table: "DocumentReferences",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationAffects",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationDate",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DisclosableOveridingInterests",
                table: "DocumentReferences",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LocalAuthority",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostcodeOfProperty",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "DocumentReferences",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TelephoneNumber",
                table: "DocumentReferences",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalFeeInPence",
                table: "DocumentReferences",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TitleNumberId",
                table: "ApplicationForms",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ApplicationFormId1",
                table: "ApplicationForms",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DocumentReferenceId",
                table: "ApplicationForms",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "FeeInPence",
                table: "ApplicationForms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "PartyId",
                table: "ApplicationForms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "ApplicationForms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "ApplicationForms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertifiedCopy = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    ApplicationFormId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_ApplicationForms_ApplicationFormId",
                        column: x => x.ApplicationFormId,
                        principalTable: "ApplicationForms",
                        principalColumn: "ApplicationFormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    PartyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsApplicant = table.Column<bool>(nullable: false),
                    CompanyOrForeName = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Roles = table.Column<string>(nullable: true),
                    PartyType = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.PartyId);
                    table.ForeignKey(
                        name: "FK_Parties_DocumentReferences_DocumentReferenceId",
                        column: x => x.DocumentReferenceId,
                        principalTable: "DocumentReferences",
                        principalColumn: "DocumentReferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupportingDocuments",
                columns: table => new
                {
                    SupportingDocumentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertifiedCopy = table.Column<string>(nullable: true),
                    DocumentId = table.Column<string>(nullable: true),
                    DocumentName = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportingDocuments", x => x.SupportingDocumentId);
                    table.ForeignKey(
                        name: "FK_SupportingDocuments_DocumentReferences_DocumentReferenceId",
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
                value: new DateTime(2021, 2, 16, 15, 53, 48, 801, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 802, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 802, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 802, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 16, 15, 53, 48, 802, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 73, 149, 138, 190, 7, 126, 68, 152, 98, 92, 123, 214, 20, 159, 116, 219, 255, 41, 86, 145, 194, 78, 29, 207, 181, 130, 68, 2, 171, 185, 174, 9, 225, 210, 220, 48, 134, 192, 88, 17, 25, 195, 13, 155, 215, 37, 157, 78, 64, 28, 74, 30, 148, 81, 139, 174, 206, 44, 178, 186, 235, 46, 159, 66 }, new byte[] { 64, 248, 73, 53, 218, 145, 140, 67, 145, 138, 55, 149, 34, 46, 53, 113, 149, 48, 7, 254, 66, 126, 187, 150, 78, 21, 27, 151, 187, 19, 214, 51, 43, 28, 78, 222, 42, 164, 140, 207, 169, 210, 42, 246, 210, 182, 128, 170, 170, 74, 217, 78, 206, 219, 133, 0, 150, 127, 146, 210, 26, 156, 221, 56, 50, 7, 140, 140, 135, 255, 245, 231, 242, 123, 239, 136, 233, 216, 83, 69, 66, 239, 30, 186, 127, 229, 206, 57, 219, 174, 14, 199, 82, 91, 95, 38, 205, 218, 17, 145, 152, 88, 12, 39, 10, 215, 173, 225, 131, 161, 166, 218, 70, 164, 52, 167, 19, 24, 75, 107, 155, 107, 41, 4, 73, 27, 98, 35 } });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_ApplicationFormId1",
                table: "ApplicationForms",
                column: "ApplicationFormId1");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_DocumentReferenceId",
                table: "ApplicationForms",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_PartyId",
                table: "ApplicationForms",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms",
                column: "SupportingDocumentsSupportingDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ApplicationFormId",
                table: "Documents",
                column: "ApplicationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Parties_DocumentReferenceId",
                table: "Parties",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportingDocuments_DocumentReferenceId",
                table: "SupportingDocuments",
                column: "DocumentReferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_ApplicationForms_ApplicationFormId1",
                table: "ApplicationForms",
                column: "ApplicationFormId1",
                principalTable: "ApplicationForms",
                principalColumn: "ApplicationFormId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_DocumentReferences_DocumentReferenceId",
                table: "ApplicationForms",
                column: "DocumentReferenceId",
                principalTable: "DocumentReferences",
                principalColumn: "DocumentReferenceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_Parties_PartyId",
                table: "ApplicationForms",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_SupportingDocuments_SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms",
                column: "SupportingDocumentsSupportingDocumentId",
                principalTable: "SupportingDocuments",
                principalColumn: "SupportingDocumentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_TitleNumbers_TitleNumberId",
                table: "ApplicationForms",
                column: "TitleNumberId",
                principalTable: "TitleNumbers",
                principalColumn: "TitleNumberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentReferences_Users_UserId",
                table: "DocumentReferences",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_ApplicationForms_ApplicationFormId1",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_DocumentReferences_DocumentReferenceId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_Parties_PartyId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_SupportingDocuments_SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_TitleNumbers_TitleNumberId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentReferences_Users_UserId",
                table: "DocumentReferences");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Parties");

            migrationBuilder.DropTable(
                name: "SupportingDocuments");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_ApplicationFormId1",
                table: "ApplicationForms");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_DocumentReferenceId",
                table: "ApplicationForms");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_PartyId",
                table: "ApplicationForms");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "AP1WarningUnderstood",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "ApplicationAffects",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "ApplicationDate",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "DisclosableOveridingInterests",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "LocalAuthority",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "PostcodeOfProperty",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "TotalFeeInPence",
                table: "DocumentReferences");

            migrationBuilder.DropColumn(
                name: "ApplicationFormId1",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "DocumentReferenceId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "FeeInPence",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<string>(
                name: "PropertyName",
                table: "TitleNumbers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleType",
                table: "TitleNumbers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "DocumentReferences",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "DocumentReferences",
                type: "nvarchar(350)",
                maxLength: 350,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DocumentReferences",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<string>(
                name: "ReferenceCode",
                table: "DocumentReferences",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferenceName",
                table: "DocumentReferences",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RegistrationTypeId",
                table: "DocumentReferences",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "DocumentReferences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApplicationForms",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TitleNumberId",
                table: "ApplicationForms",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CertificationType",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChargeDate",
                table: "ApplicationForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ApplicationForms",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<decimal>(
                name: "Fee",
                table: "ApplicationForms",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "FileLocation",
                table: "ApplicationForms",
                type: "nvarchar(max)",
                maxLength: 2147483647,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "ApplicationForms",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAgreed",
                table: "ApplicationForms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "ApplicationForms",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "ApplicationForms",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ApplicationForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 601, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 602, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 602, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 602, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 2, 10, 45, 45, 602, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 10, 163, 75, 25, 236, 44, 193, 230, 53, 202, 72, 94, 229, 209, 124, 25, 233, 84, 83, 252, 89, 247, 198, 102, 242, 180, 105, 134, 44, 113, 173, 113, 144, 128, 21, 217, 248, 101, 138, 138, 57, 24, 59, 85, 69, 19, 129, 72, 78, 121, 64, 38, 160, 98, 59, 181, 104, 228, 249, 125, 196, 202, 87, 146 }, new byte[] { 150, 90, 213, 35, 239, 86, 223, 205, 142, 113, 52, 108, 195, 58, 245, 13, 117, 196, 98, 183, 201, 161, 168, 42, 103, 12, 239, 47, 165, 170, 127, 253, 231, 98, 71, 70, 253, 167, 73, 1, 109, 189, 48, 187, 110, 87, 73, 87, 148, 216, 39, 246, 66, 62, 123, 151, 15, 149, 83, 46, 17, 102, 18, 217, 142, 30, 134, 141, 169, 5, 249, 12, 201, 122, 37, 35, 194, 92, 24, 105, 202, 23, 178, 110, 122, 61, 162, 35, 62, 124, 190, 202, 134, 46, 168, 76, 224, 159, 148, 119, 148, 157, 172, 97, 252, 15, 55, 146, 79, 74, 174, 72, 217, 235, 33, 217, 248, 118, 62, 202, 80, 169, 254, 123, 173, 79, 68, 94 } });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentReferences_RegistrationTypeId",
                table: "DocumentReferences",
                column: "RegistrationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_TitleNumbers_TitleNumberId",
                table: "ApplicationForms",
                column: "TitleNumberId",
                principalTable: "TitleNumbers",
                principalColumn: "TitleNumberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentReferences_RegistrationTypes_RegistrationTypeId",
                table: "DocumentReferences",
                column: "RegistrationTypeId",
                principalTable: "RegistrationTypes",
                principalColumn: "RegistrationTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentReferences_Users_UserId",
                table: "DocumentReferences",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
