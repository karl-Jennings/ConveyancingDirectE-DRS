using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class extRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_Parties_PartyId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_SupportingDocuments_SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_PartyId",
                table: "ApplicationForms");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "PartyId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<string>(
                name: "CertifiedCopy",
                table: "ApplicationForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalReference",
                table: "ApplicationForms",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 329, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 330, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 330, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 330, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 10, 39, 40, 330, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 242, 132, 209, 35, 112, 202, 49, 61, 236, 156, 189, 224, 3, 156, 165, 196, 209, 162, 90, 18, 124, 247, 76, 37, 215, 219, 54, 236, 203, 236, 73, 107, 84, 227, 104, 4, 251, 83, 17, 236, 210, 221, 248, 39, 206, 125, 22, 135, 86, 216, 23, 136, 28, 27, 167, 30, 140, 137, 196, 29, 165, 175, 197, 232 }, new byte[] { 9, 156, 178, 248, 243, 251, 9, 130, 15, 249, 171, 118, 88, 164, 135, 207, 92, 45, 237, 113, 15, 205, 60, 208, 162, 32, 128, 115, 245, 44, 167, 6, 27, 44, 227, 244, 13, 29, 28, 153, 94, 246, 53, 179, 230, 75, 63, 78, 229, 147, 31, 67, 100, 253, 218, 10, 88, 19, 144, 202, 63, 22, 112, 170, 14, 174, 70, 170, 104, 35, 174, 172, 180, 205, 81, 49, 95, 168, 225, 219, 76, 22, 181, 155, 22, 199, 93, 12, 21, 125, 12, 197, 91, 136, 33, 158, 75, 248, 13, 208, 89, 235, 39, 190, 74, 50, 191, 85, 17, 130, 208, 28, 130, 176, 36, 139, 233, 11, 123, 193, 141, 171, 70, 133, 184, 71, 155, 133 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertifiedCopy",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "ExternalReference",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<long>(
                name: "PartyId",
                table: "ApplicationForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 523, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 524, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 524, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 524, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 17, 9, 37, 21, 524, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 233, 248, 42, 210, 153, 145, 131, 119, 147, 198, 232, 184, 203, 42, 225, 9, 53, 98, 153, 204, 141, 74, 177, 129, 171, 101, 186, 248, 59, 56, 62, 228, 177, 80, 54, 91, 61, 213, 41, 161, 233, 126, 43, 124, 243, 131, 59, 103, 70, 245, 170, 82, 253, 140, 180, 56, 247, 173, 134, 83, 201, 132, 73 }, new byte[] { 212, 165, 20, 133, 237, 5, 38, 56, 211, 81, 143, 196, 87, 92, 54, 50, 141, 255, 119, 97, 49, 158, 62, 55, 39, 125, 7, 240, 129, 120, 92, 144, 215, 213, 235, 72, 52, 43, 81, 49, 158, 97, 104, 27, 32, 252, 153, 242, 52, 88, 223, 81, 73, 48, 177, 117, 84, 151, 208, 247, 121, 123, 250, 153, 104, 116, 140, 115, 232, 56, 99, 53, 163, 97, 0, 54, 86, 69, 175, 85, 101, 165, 150, 39, 19, 24, 214, 183, 231, 233, 100, 229, 234, 184, 171, 48, 186, 54, 253, 140, 0, 208, 203, 241, 65, 180, 94, 38, 37, 15, 102, 171, 31, 181, 136, 227, 250, 38, 32, 234, 21, 204, 227, 1, 80, 189, 204, 34 } });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_PartyId",
                table: "ApplicationForms",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_SupportingDocumentsSupportingDocumentId",
                table: "ApplicationForms",
                column: "SupportingDocumentsSupportingDocumentId");

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
        }
    }
}
