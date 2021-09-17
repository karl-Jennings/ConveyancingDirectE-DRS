using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class addresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DxNumber = table.Column<int>(nullable: true),
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

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 187, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 4, 2, 17, 45, 12, 188, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 140, 191, 152, 108, 208, 230, 52, 230, 131, 155, 254, 156, 17, 124, 174, 35, 37, 94, 145, 47, 38, 127, 92, 68, 189, 18, 158, 141, 219, 140, 119, 78, 157, 163, 170, 18, 223, 41, 221, 242, 63, 198, 218, 205, 195, 205, 185, 129, 226, 47, 80, 94, 142, 169, 62, 77, 58, 223, 231, 156, 14, 149, 63, 85 }, new byte[] { 231, 238, 155, 214, 215, 123, 15, 136, 157, 204, 103, 100, 141, 145, 35, 212, 164, 26, 89, 79, 69, 96, 193, 86, 240, 103, 245, 65, 46, 235, 113, 149, 91, 64, 110, 121, 189, 137, 245, 151, 30, 182, 7, 135, 59, 51, 118, 80, 105, 61, 4, 194, 225, 199, 148, 125, 99, 47, 173, 6, 81, 137, 16, 239, 17, 219, 27, 170, 253, 197, 36, 50, 41, 164, 47, 132, 95, 165, 34, 128, 11, 204, 59, 213, 185, 14, 157, 177, 235, 67, 139, 29, 159, 116, 227, 112, 153, 9, 225, 129, 123, 214, 214, 195, 213, 113, 125, 155, 53, 69, 119, 203, 49, 31, 5, 92, 79, 158, 236, 210, 31, 51, 146, 136, 135, 89, 148, 97 } });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PartyId",
                table: "Addresses",
                column: "PartyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 42, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 3, 24, 12, 42, 42, 43, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 93, 234, 57, 211, 214, 14, 210, 16, 226, 28, 244, 255, 185, 195, 32, 230, 75, 143, 87, 14, 70, 74, 233, 191, 36, 210, 192, 110, 122, 194, 84, 27, 242, 151, 171, 250, 234, 7, 2, 144, 86, 249, 66, 81, 114, 77, 228, 217, 77, 119, 198, 2, 101, 238, 95, 55, 85, 41, 91, 166, 236, 96, 61 }, new byte[] { 138, 27, 0, 108, 246, 3, 175, 1, 195, 123, 173, 42, 252, 60, 157, 174, 23, 178, 118, 71, 120, 16, 243, 87, 153, 122, 147, 136, 63, 163, 89, 33, 55, 194, 18, 24, 80, 94, 193, 132, 238, 214, 161, 37, 49, 195, 53, 45, 60, 192, 226, 113, 58, 244, 225, 199, 82, 116, 165, 177, 192, 151, 153, 59, 86, 23, 135, 189, 134, 217, 13, 159, 240, 218, 158, 150, 191, 246, 112, 56, 74, 63, 203, 7, 240, 134, 144, 64, 0, 234, 18, 142, 155, 45, 239, 114, 243, 49, 207, 66, 115, 75, 127, 227, 88, 22, 83, 87, 249, 104, 11, 20, 226, 174, 250, 46, 201, 117, 144, 99, 136, 41, 255, 79, 252, 143, 252, 158 } });
        }
    }
}
