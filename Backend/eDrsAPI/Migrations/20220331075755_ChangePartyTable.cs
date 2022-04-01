using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ChangePartyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Parties_PartyId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PartyId",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 31, 13, 27, 55, 276, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 31, 13, 27, 55, 277, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 31, 13, 27, 55, 277, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 31, 13, 27, 55, 277, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 31, 13, 27, 55, 277, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 31, 13, 27, 55, 277, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 31, 13, 27, 55, 277, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2022, 3, 31, 13, 27, 55, 277, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 3, 169, 40, 78, 215, 53, 69, 157, 60, 40, 254, 123, 125, 64, 59, 155, 243, 12, 8, 56, 183, 19, 98, 143, 105, 64, 239, 1, 180, 214, 11, 23, 160, 184, 30, 115, 56, 120, 151, 201, 34, 171, 30, 88, 136, 234, 102, 56, 74, 94, 220, 213, 63, 195, 164, 119, 88, 133, 237, 181, 96, 115, 143, 171 }, new byte[] { 16, 246, 182, 72, 110, 201, 73, 114, 173, 125, 170, 176, 6, 75, 99, 24, 35, 217, 63, 253, 210, 59, 124, 225, 171, 197, 119, 132, 67, 254, 110, 31, 221, 115, 110, 6, 177, 238, 51, 2, 204, 255, 217, 174, 253, 143, 168, 118, 227, 55, 177, 242, 237, 166, 111, 59, 67, 70, 47, 137, 104, 16, 135, 45, 44, 116, 207, 85, 63, 220, 164, 21, 188, 249, 195, 193, 135, 180, 161, 28, 32, 223, 52, 161, 200, 45, 204, 47, 227, 131, 12, 126, 147, 24, 62, 12, 128, 241, 9, 226, 132, 49, 74, 159, 217, 90, 78, 251, 103, 117, 148, 164, 25, 198, 240, 235, 0, 226, 228, 166, 175, 40, 169, 127, 87, 188, 190, 57 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PartyId",
                table: "Addresses",
                column: "PartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Parties_PartyId",
                table: "Addresses",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
