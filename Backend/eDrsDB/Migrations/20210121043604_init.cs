using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    ReferenceName = table.Column<string>(maxLength: 150, nullable: true),
                    ReferenceCode = table.Column<string>(maxLength: 150, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 350, nullable: true),
                    Notes = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    UserId = table.Column<long>(nullable: false),
                    RegistrationTypeId = table.Column<long>(nullable: false)
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
                name: "TitleNumbers",
                columns: table => new
                {
                    TitleNumberId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleNumberCode = table.Column<string>(maxLength: 150, nullable: true),
                    PropertyName = table.Column<string>(maxLength: 500, nullable: true),
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
                name: "ApplicationForms",
                columns: table => new
                {
                    ApplicationFormId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 300, nullable: true),
                    Reference = table.Column<string>(maxLength: 300, nullable: true),
                    ChargeDate = table.Column<DateTime>(nullable: false),
                    IsAgreed = table.Column<bool>(nullable: false),
                    FileLocation = table.Column<string>(maxLength: 2147483647, nullable: true),
                    CertificationType = table.Column<string>(maxLength: 2147483647, nullable: true),
                    Fee = table.Column<decimal>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false, defaultValue: true),
                    TitleNumberId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.ApplicationFormId);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_TitleNumbers_TitleNumberId",
                        column: x => x.TitleNumberId,
                        principalTable: "TitleNumbers",
                        principalColumn: "TitleNumberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RegistrationTypes",
                columns: new[] { "RegistrationTypeId", "Status", "TypeCode", "TypeName", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 1L, true, "doc_reg", "Document Registration", new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(1005), "document-registration" },
                    { 2L, true, "lease_ext", "Lease Extension", new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(9142), "lease-extension" },
                    { 3L, true, "new_lease", "New Lease", new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(9169), "new-lease" },
                    { 4L, true, "transfer", "Transfer of Part", new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(9171), "transfer" },
                    { 5L, true, "rem_frm", "Removal of default form A restriction (JP1)", new DateTime(2021, 1, 21, 10, 6, 4, 267, DateTimeKind.Local).AddTicks(9173), "removal-form" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Designation", "Email", "Firstname", "Lastname", "PasswordHash", "PasswordSalt", "Status", "UpdatedDate" },
                values: new object[] { 1L, "admin", "dushyanthaccura@gmail.com", "Admin", null, new byte[] { 97, 153, 10, 158, 59, 196, 204, 130, 147, 134, 231, 94, 9, 187, 166, 199, 207, 192, 94, 75, 49, 1, 71, 36, 2, 34, 111, 182, 79, 56, 61, 114, 103, 157, 185, 81, 46, 154, 212, 244, 108, 195, 222, 226, 86, 209, 83, 177, 76, 253, 174, 17, 37, 182, 86, 41, 106, 229, 3, 0, 29, 150, 17, 171 }, new byte[] { 11, 149, 68, 101, 33, 94, 27, 58, 3, 202, 194, 194, 51, 200, 236, 38, 92, 215, 30, 142, 15, 131, 219, 87, 245, 3, 245, 3, 33, 5, 128, 86, 164, 88, 83, 91, 34, 148, 80, 78, 104, 164, 181, 0, 153, 181, 52, 93, 36, 31, 152, 146, 174, 220, 1, 119, 104, 143, 91, 32, 197, 162, 14, 219, 181, 134, 79, 61, 164, 173, 64, 237, 160, 243, 133, 36, 237, 121, 168, 148, 99, 46, 162, 159, 135, 152, 173, 213, 225, 56, 38, 126, 124, 216, 25, 148, 56, 122, 23, 208, 72, 38, 30, 135, 109, 47, 177, 233, 12, 53, 154, 237, 100, 165, 123, 204, 198, 59, 17, 75, 222, 152, 217, 17, 69, 106, 79, 236 }, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_TitleNumberId",
                table: "ApplicationForms",
                column: "TitleNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentReferences_RegistrationTypeId",
                table: "DocumentReferences",
                column: "RegistrationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentReferences_UserId",
                table: "DocumentReferences",
                column: "UserId");

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
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "TitleNumbers");

            migrationBuilder.DropTable(
                name: "DocumentReferences");

            migrationBuilder.DropTable(
                name: "RegistrationTypes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
