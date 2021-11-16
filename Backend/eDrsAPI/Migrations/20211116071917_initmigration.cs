using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class initmigration : Migration
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
                    Username = table.Column<string>(maxLength: 150, nullable: false),
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
                    Reference = table.Column<string>(nullable: false),
                    TotalFeeInPence = table.Column<int>(nullable: false),
                    MessageID = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<long>(nullable: false),
                    AdditionalProviderFilter = table.Column<string>(nullable: true),
                    ExternalReference = table.Column<string>(nullable: true),
                    AP1WarningUnderstood = table.Column<bool>(nullable: false),
                    ApplicationDate = table.Column<DateTime>(nullable: false),
                    DisclosableOveridingInterests = table.Column<bool>(nullable: false),
                    PostcodeOfProperty = table.Column<string>(nullable: true),
                    LocalAuthority = table.Column<string>(nullable: true),
                    ApplicationAffects = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    RegistrationTypeId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    IsApiSuccess = table.Column<bool>(nullable: false),
                    OverallStatus = table.Column<int>(nullable: true),
                    ServiceTitleType = table.Column<string>(nullable: true)
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
                    Variety = table.Column<string>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    FeeInPence = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    ExternalReference = table.Column<string>(nullable: true),
                    CertifiedCopy = table.Column<string>(nullable: false),
                    ChargeDate = table.Column<DateTime>(nullable: false),
                    IsMdRef = table.Column<string>(nullable: true),
                    SortCode = table.Column<string>(nullable: true),
                    MdRef = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    PartyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsApplicant = table.Column<bool>(nullable: false),
                    CompanyOrForeName = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Roles = table.Column<string>(nullable: true),
                    PartyType = table.Column<string>(nullable: false),
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
                    Type = table.Column<string>(nullable: false),
                    RepresentativeId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    AddressType = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false),
                    CareOfName = table.Column<string>(nullable: true),
                    CareOfReference = table.Column<string>(nullable: true),
                    DxNumber = table.Column<string>(nullable: true),
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
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
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
                    CertifiedCopy = table.Column<string>(nullable: false),
                    DocumentId = table.Column<long>(nullable: false),
                    DocumentName = table.Column<string>(nullable: false),
                    AdditionalProviderFilter = table.Column<string>(nullable: false),
                    MessageId = table.Column<long>(nullable: false),
                    ExternalReference = table.Column<string>(nullable: false),
                    ApplicationMessageId = table.Column<string>(nullable: false),
                    DocumentType = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Base64 = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    IsChecked = table.Column<bool>(nullable: false),
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
                    AdditionalTitles = table.Column<string>(nullable: true),
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
                    AttachmentId = table.Column<long>(nullable: false),
                    Base64 = table.Column<string>(nullable: false),
                    FileName = table.Column<string>(nullable: false),
                    FileExtension = table.Column<string>(nullable: false),
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
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    SubType = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    CareOfName = table.Column<string>(nullable: true),
                    CareOfReference = table.Column<string>(nullable: true),
                    DxNumber = table.Column<string>(nullable: true),
                    DxExchange = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    PartyId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "PartyId",
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
                    { 1L, true, "trns_chrge", "Transfer and charge", new DateTime(2021, 11, 16, 12, 49, 16, 742, DateTimeKind.Local).AddTicks(7346), "transfer-and-charge" },
                    { 2L, true, "rem_gage", "Remortgage", new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6347), "remortgage" },
                    { 3L, true, "trns_eqty", "Transfer of equity", new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6372), "transfer-equity" },
                    { 4L, true, "rem_frm", "Restriction, hostile takeover", new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6375), "removal-form" },
                    { 5L, true, "chngName", "Change of name", new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6376), "change-name" },
                    { 6L, true, "dispositionary", "Dispositionary first lease", new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6378), "dispositionary" },
                    { 7L, true, "transfer", "Transfer of part", new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6379), "transfer" },
                    { 8L, true, "lease_ext", "Lease extension", new DateTime(2021, 11, 16, 12, 49, 16, 743, DateTimeKind.Local).AddTicks(6381), "lease-extension" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Designation", "Email", "Firstname", "Lastname", "PasswordHash", "PasswordSalt", "Status", "UpdatedDate", "Username" },
                values: new object[] { 1L, "admin", "dushyanthaccura@gmail.com", "Admin", null, new byte[] { 41, 186, 241, 85, 253, 190, 131, 62, 125, 168, 23, 27, 82, 22, 218, 100, 200, 106, 9, 73, 108, 160, 205, 9, 204, 45, 135, 157, 211, 67, 120, 149, 128, 5, 3, 18, 219, 17, 180, 196, 244, 96, 117, 73, 48, 234, 1, 87, 251, 75, 227, 120, 153, 91, 123, 171, 187, 173, 220, 183, 28, 100, 193, 5 }, new byte[] { 223, 220, 25, 241, 80, 40, 115, 27, 166, 7, 175, 201, 219, 186, 36, 67, 161, 97, 155, 16, 66, 162, 69, 123, 189, 223, 209, 240, 190, 166, 90, 44, 53, 38, 246, 180, 234, 138, 231, 5, 2, 202, 159, 97, 88, 126, 36, 51, 115, 243, 213, 159, 65, 231, 5, 30, 144, 38, 2, 225, 38, 66, 169, 239, 86, 220, 125, 115, 48, 131, 106, 148, 156, 66, 253, 251, 113, 218, 18, 130, 75, 182, 74, 212, 69, 24, 76, 110, 247, 202, 134, 58, 159, 150, 201, 188, 34, 3, 135, 133, 89, 107, 72, 179, 144, 208, 122, 46, 162, 100, 201, 106, 21, 204, 1, 163, 174, 48, 4, 136, 187, 247, 105, 252, 198, 188, 204, 26 }, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "edrs-admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PartyId",
                table: "Addresses",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_DocumentReferenceId",
                table: "ApplicationForms",
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
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "LrCredentials");

            migrationBuilder.DropTable(
                name: "Outstanding");

            migrationBuilder.DropTable(
                name: "Representations");

            migrationBuilder.DropTable(
                name: "RequestLogs");

            migrationBuilder.DropTable(
                name: "SupportingDocuments");

            migrationBuilder.DropTable(
                name: "TitleNumbers");

            migrationBuilder.DropTable(
                name: "Parties");

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
