using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class teleDataType : Migration
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

            migrationBuilder.CreateTable(
                name: "RegistrationTypes",
                columns: table => new
                {
                    RegistrationTypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(maxLength: 150, nullable: true),
                    TypeCode = table.Column<string>(maxLength: 150, nullable: true),
                    Url = table.Column<string>(maxLength: 300, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationTypes", x => x.RegistrationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(maxLength: 150, nullable: false),
                    Lastname = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 350, nullable: true),
                    Designation = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentReferences",
                columns: table => new
                {
                    DocumentReferenceId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reference = table.Column<string>(nullable: true),
                    TotalFeeInPence = table.Column<int>(nullable: false),
                    MessageID = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<long>(nullable: false),
                    AdditionalProviderFilter = table.Column<string>(nullable: true),
                    ExternalReference = table.Column<string>(nullable: true),
                    AP1WarningUnderstood = table.Column<bool>(nullable: false),
                    ApplicationDate = table.Column<string>(nullable: true),
                    DisclosableOveridingInterests = table.Column<bool>(nullable: false),
                    PostcodeOfProperty = table.Column<string>(nullable: true),
                    LocalAuthority = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ApplicationAffects = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    RegistrationTypeId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentReferences", x => x.DocumentReferenceId);
                    table.ForeignKey(
                        name: "FK_DocumentReferences_RegistrationTypes_RegistrationTypeId",
                        column: x => x.RegistrationTypeId,
                        principalTable: "RegistrationTypes",
                        principalColumn: "RegistrationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentReferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationForms",
                columns: table => new
                {
                    ApplicationFormId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Variety = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    FeeInPence = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    ExternalReference = table.Column<string>(nullable: true),
                    CertifiedCopy = table.Column<string>(nullable: true),
                    ChargeDate = table.Column<DateTime>(nullable: false),
                    MDRef = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.ApplicationFormId);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_DocumentReferences_DocumentReferenceId",
                        column: x => x.DocumentReferenceId,
                        principalTable: "DocumentReferences",
                        principalColumn: "DocumentReferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    AddressForService = table.Column<string>(nullable: true),
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
                name: "Representations",
                columns: table => new
                {
                    RepresentationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    RepresentativeId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    AddressType = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false),
                    CareOfName = table.Column<string>(nullable: true),
                    CareOfReference = table.Column<string>(nullable: true),
                    DxNumber = table.Column<long>(nullable: false),
                    DxExchange = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Representations", x => x.RepresentationId);
                    table.ForeignKey(
                        name: "FK_Representations_DocumentReferences_DocumentReferenceId",
                        column: x => x.DocumentReferenceId,
                        principalTable: "DocumentReferences",
                        principalColumn: "DocumentReferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestLogs",
                columns: table => new
                {
                    RequestLogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    TypeCode = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    File = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLogs", x => x.RequestLogId);
                    table.ForeignKey(
                        name: "FK_RequestLogs_DocumentReferences_DocumentReferenceId",
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

            migrationBuilder.CreateTable(
                name: "TitleNumbers",
                columns: table => new
                {
                    TitleNumberId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleNumberCode = table.Column<string>(maxLength: 150, nullable: true),
                    LesseeTitleNumber = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    DocumentReferenceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleNumbers", x => x.TitleNumberId);
                    table.ForeignKey(
                        name: "FK_TitleNumbers_DocumentReferences_DocumentReferenceId",
                        column: x => x.DocumentReferenceId,
                        principalTable: "DocumentReferences",
                        principalColumn: "DocumentReferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Base64 = table.Column<string>(nullable: true),
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

            migrationBuilder.InsertData(
                table: "RegistrationTypes",
                columns: new[] { "RegistrationTypeId", "Status", "TypeCode", "TypeName", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1L, true, "trns_chrge", "Transfer and charge", new DateTime(2021, 3, 8, 11, 52, 24, 762, DateTimeKind.Local).AddTicks(7556), "transfer-and-charge" },
                    { 2L, true, "rem_gage", "Remortgage", new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7610), "remortgage" },
                    { 3L, true, "trns_eqty", "Transfer of equity", new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7636), "transfer-equity" },
                    { 4L, true, "rem_frm", "Restriction, hostile takeover", new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7639), "removal-form" },
                    { 5L, true, "chngName", "Change of name", new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7641), "change-name" },
                    { 6L, true, "dispositionary", "Dispositionary first lease", new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7643), "dispositionary" },
                    { 7L, true, "transfer", "Transfer of part", new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7645), "transfer" },
                    { 8L, true, "lease_ext", "Lease extension", new DateTime(2021, 3, 8, 11, 52, 24, 763, DateTimeKind.Local).AddTicks(7647), "lease-extension" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Designation", "Email", "Firstname", "Lastname", "PasswordHash", "PasswordSalt", "Status", "UpdatedDate" },
                values: new object[] { 1L, "admin", "dushyanthaccura@gmail.com", "Admin", null, new byte[] { 92, 80, 23, 65, 101, 55, 100, 169, 244, 81, 112, 23, 237, 183, 113, 191, 21, 51, 20, 105, 234, 31, 51, 244, 90, 101, 244, 246, 51, 49, 110, 220, 178, 131, 44, 207, 205, 173, 5, 200, 36, 197, 186, 133, 164, 83, 126, 23, 33, 179, 99, 204, 38, 34, 176, 224, 76, 123, 151, 235, 22, 137, 143, 4 }, new byte[] { 113, 173, 249, 130, 174, 206, 145, 6, 109, 13, 126, 225, 70, 46, 152, 32, 171, 184, 108, 225, 62, 3, 63, 171, 27, 234, 142, 194, 213, 53, 49, 121, 255, 130, 161, 174, 31, 17, 248, 250, 162, 58, 192, 161, 206, 7, 250, 73, 26, 192, 36, 232, 224, 131, 190, 69, 235, 225, 45, 166, 214, 70, 178, 137, 132, 49, 227, 183, 156, 140, 12, 232, 203, 185, 234, 200, 252, 131, 96, 152, 183, 212, 238, 97, 106, 29, 145, 188, 109, 88, 90, 66, 197, 238, 215, 148, 183, 250, 185, 70, 118, 123, 136, 21, 62, 122, 113, 202, 134, 12, 124, 2, 164, 19, 67, 175, 114, 137, 102, 89, 35, 165, 231, 118, 39, 159, 43, 57 }, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_DocumentReferenceId",
                table: "ApplicationForms",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentNotes_DocumentReferenceId",
                table: "AttachmentNotes",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentReferences_RegistrationTypeId",
                table: "DocumentReferences",
                column: "RegistrationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentReferences_UserId",
                table: "DocumentReferences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ApplicationFormId",
                table: "Documents",
                column: "ApplicationFormId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parties_DocumentReferenceId",
                table: "Parties",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Representations_DocumentReferenceId",
                table: "Representations",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLogs_DocumentReferenceId",
                table: "RequestLogs",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportingDocuments_DocumentReferenceId",
                table: "SupportingDocuments",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleNumbers_DocumentReferenceId",
                table: "TitleNumbers",
                column: "DocumentReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttachmentNotes");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "Parties");

            migrationBuilder.DropTable(
                name: "Representations");

            migrationBuilder.DropTable(
                name: "RequestLogs");

            migrationBuilder.DropTable(
                name: "SupportingDocuments");

            migrationBuilder.DropTable(
                name: "TitleNumbers");

            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "DocumentReferences");

            migrationBuilder.DropTable(
                name: "RegistrationTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
