using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class init : Migration
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

            migrationBuilder.CreateTable(
                name: "RegistrationTypes",
                columns: table => new
                {
                    RegistrationTypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(maxLength: 150, nullable: true),
                    TypeCode = table.Column<string>(maxLength: 150, nullable: true),
                    Url = table.Column<string>(maxLength: 300, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true, defaultValue: true)
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
                    Username = table.Column<string>(maxLength: 150, nullable: true),
                    Firstname = table.Column<string>(maxLength: 150, nullable: true),
                    Lastname = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 350, nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true, defaultValue: true)
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
                    TotalFeeInPence = table.Column<int>(nullable: true),
                    MessageID = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<long>(nullable: true),
                    AdditionalProviderFilter = table.Column<string>(nullable: true),
                    ExternalReference = table.Column<string>(nullable: true),
                    AP1WarningUnderstood = table.Column<bool>(nullable: true),
                    ApplicationDate = table.Column<DateTime>(nullable: true),
                    DisclosableOveridingInterests = table.Column<bool>(nullable: true),
                    PostcodeOfProperty = table.Column<string>(nullable: true),
                    LocalAuthority = table.Column<string>(nullable: true),
                    ApplicationAffects = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: true, defaultValue: true),
                    RegistrationTypeId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationForms",
                columns: table => new
                {
                    ApplicationFormId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Variety = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    FeeInPence = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ExternalReference = table.Column<string>(nullable: true),
                    CertifiedCopy = table.Column<string>(nullable: true),
                    ChargeDate = table.Column<DateTime>(nullable: true),
                    IsMdRef = table.Column<string>(nullable: true),
                    SortCode = table.Column<string>(nullable: true),
                    MdRef = table.Column<string>(nullable: true),
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
                    MessageId = table.Column<long>(nullable: true),
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
                name: "Outstanding",
                columns: table => new
                {
                    OutstandingId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandRegistryId = table.Column<string>(nullable: true),
                    ServiceType = table.Column<string>(nullable: true),
                    NewResponse = table.Column<bool>(nullable: true),
                    TypeCode = table.Column<int>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    PartyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsApplicant = table.Column<bool>(nullable: true),
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
                    RepresentativeId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    AddressType = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: true),
                    CareOfName = table.Column<string>(nullable: true),
                    CareOfReference = table.Column<string>(nullable: true),
                    DxNumber = table.Column<long>(nullable: true),
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
                    TypeCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValueSql: "GETDATE()"),
                    File = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    AppMessageId = table.Column<string>(nullable: true),
                    RejectionReason = table.Column<string>(nullable: true),
                    ValidationErrors = table.Column<string>(nullable: true),
                    ResponseType = table.Column<string>(nullable: true),
                    ResponseJson = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false),
                    AttachmentId = table.Column<string>(nullable: true)
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
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
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
                table: "LrCredentials",
                columns: new[] { "LrCredentialsId", "Password", "Username" },
                values: new object[] { 1L, "landreg001", "BGUser001" });

            migrationBuilder.InsertData(
                table: "RegistrationTypes",
                columns: new[] { "RegistrationTypeId", "Status", "TypeCode", "TypeName", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1L, true, "trns_chrge", "Transfer and charge", new DateTime(2021, 3, 18, 15, 52, 22, 424, DateTimeKind.Local).AddTicks(8506), "transfer-and-charge" },
                    { 2L, true, "rem_gage", "Remortgage", new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6844), "remortgage" },
                    { 3L, true, "trns_eqty", "Transfer of equity", new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6870), "transfer-equity" },
                    { 4L, true, "rem_frm", "Restriction, hostile takeover", new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6872), "removal-form" },
                    { 5L, true, "chngName", "Change of name", new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6874), "change-name" },
                    { 6L, true, "dispositionary", "Dispositionary first lease", new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6875), "dispositionary" },
                    { 7L, true, "transfer", "Transfer of part", new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6877), "transfer" },
                    { 8L, true, "lease_ext", "Lease extension", new DateTime(2021, 3, 18, 15, 52, 22, 425, DateTimeKind.Local).AddTicks(6878), "lease-extension" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Designation", "Email", "Firstname", "Lastname", "PasswordHash", "PasswordSalt", "Status", "UpdatedDate", "Username" },
                values: new object[] { 1L, "admin", "it@cdpll.co.uk", "Admin", null, new byte[] { 171, 97, 4, 246, 184, 214, 163, 128, 239, 183, 207, 159, 149, 61, 245, 31, 57, 108, 69, 65, 237, 66, 35, 57, 40, 36, 236, 179, 162, 76, 238, 128, 41, 145, 213, 100, 7, 43, 123, 46, 178, 45, 188, 92, 174, 97, 229, 64, 29, 145, 129, 188, 54, 144, 43, 254, 50, 156, 55, 89, 8, 218, 103, 129 }, new byte[] { 177, 226, 152, 130, 119, 167, 31, 27, 164, 218, 163, 235, 1, 37, 210, 54, 207, 201, 47, 197, 232, 61, 52, 129, 255, 228, 56, 246, 72, 196, 149, 219, 244, 219, 247, 20, 181, 64, 129, 202, 205, 0, 125, 231, 41, 67, 81, 13, 99, 76, 186, 205, 178, 77, 89, 56, 96, 76, 61, 26, 240, 152, 0, 36, 50, 162, 5, 176, 146, 69, 182, 93, 76, 219, 198, 156, 155, 147, 72, 166, 47, 43, 183, 90, 17, 194, 216, 62, 10, 91, 204, 68, 241, 228, 161, 59, 45, 41, 94, 99, 51, 127, 202, 182, 212, 201, 141, 1, 243, 213, 28, 252, 54, 141, 235, 141, 116, 71, 134, 237, 100, 122, 46, 194, 7, 200, 192, 112 }, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "edrs-admin" });

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
                name: "IX_Outstanding_DocumentReferenceId",
                table: "Outstanding",
                column: "DocumentReferenceId");

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
                name: "LrCredentials");

            migrationBuilder.DropTable(
                name: "Outstanding");

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
