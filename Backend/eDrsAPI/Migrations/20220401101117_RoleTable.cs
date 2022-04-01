using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class RoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roles",
                table: "Parties");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    PartyId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleType = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    PartyId1 = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.PartyId);
                    table.ForeignKey(
                        name: "FK_Role_Parties_PartyId1",
                        column: x => x.PartyId1,
                        principalTable: "Parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PartyId",
                table: "Addresses",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_PartyId1",
                table: "Role",
                column: "PartyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Parties_PartyId",
                table: "Addresses",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "PartyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Parties_PartyId",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_PartyId",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "Parties",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
