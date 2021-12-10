using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class ApplicationForService3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressForService",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressForServiceOption = table.Column<string>(nullable: true),
                    PartyId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressForService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressForService_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "PartyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressForService_AdditionalAddress",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    addressForServiceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressForService_AdditionalAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressForService_AdditionalAddress_AddressForService_addressForServiceId",
                        column: x => x.addressForServiceId,
                        principalTable: "AddressForService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressForService_PostalAddress",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareOfName = table.Column<string>(nullable: true),
                    CareOfReference = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    addressForServiceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressForService_PostalAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressForService_PostalAddress_AddressForService_addressForServiceId",
                        column: x => x.addressForServiceId,
                        principalTable: "AddressForService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalAddress_EmailAddress",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    AddressForService_AdditionalAddressId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalAddress_EmailAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalAddress_EmailAddress_AddressForService_AdditionalAddress_AddressForService_AdditionalAddressId",
                        column: x => x.AddressForService_AdditionalAddressId,
                        principalTable: "AddressForService_AdditionalAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalAddress_PostalAddress",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareOfName = table.Column<string>(nullable: true),
                    CareOfReference = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    AddressLine4 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    AddressForService_AdditionalAddressId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalAddress_PostalAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalAddress_PostalAddress_AddressForService_AdditionalAddress_AddressForService_AdditionalAddressId",
                        column: x => x.AddressForService_AdditionalAddressId,
                        principalTable: "AddressForService_AdditionalAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressForService_DXAddress",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DXNumber = table.Column<string>(nullable: true),
                    DXExchange = table.Column<string>(nullable: true),
                    CareOfName = table.Column<string>(nullable: true),
                    CareOfReference = table.Column<string>(nullable: true),
                    AddressForService_AdditionalAddressId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressForService_DXAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressForService_DXAddress_AddressForService_AdditionalAddress_AddressForService_AdditionalAddressId",
                        column: x => x.AddressForService_AdditionalAddressId,
                        principalTable: "AddressForService_AdditionalAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 12, 5, 22, 435, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 12, 5, 22, 437, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 12, 5, 22, 437, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 12, 5, 22, 437, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 12, 5, 22, 437, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 12, 5, 22, 437, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 12, 5, 22, 437, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 12, 5, 22, 437, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 248, 135, 110, 163, 177, 155, 166, 159, 237, 116, 241, 191, 162, 247, 44, 172, 43, 215, 198, 205, 22, 233, 99, 35, 77, 29, 56, 218, 17, 61, 21, 186, 62, 175, 203, 75, 34, 4, 48, 249, 136, 132, 54, 252, 29, 192, 69, 216, 12, 234, 194, 128, 45, 200, 178, 1, 224, 37, 47, 117, 143, 0, 151 }, new byte[] { 28, 162, 77, 203, 201, 136, 24, 209, 243, 116, 33, 181, 208, 252, 146, 155, 97, 252, 129, 88, 216, 193, 223, 125, 50, 4, 52, 18, 109, 191, 68, 100, 17, 23, 187, 180, 67, 202, 219, 106, 110, 38, 139, 251, 239, 252, 151, 95, 16, 121, 24, 100, 45, 134, 235, 120, 120, 234, 154, 251, 99, 68, 160, 192, 115, 236, 185, 253, 206, 235, 85, 74, 219, 179, 2, 166, 193, 176, 173, 244, 162, 236, 163, 105, 254, 53, 14, 154, 160, 105, 142, 51, 80, 59, 56, 224, 153, 82, 46, 116, 124, 77, 107, 108, 21, 215, 214, 13, 112, 115, 2, 160, 158, 28, 125, 78, 182, 180, 62, 116, 162, 107, 253, 187, 186, 78, 190, 26 } });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalAddress_EmailAddress_AddressForService_AdditionalAddressId",
                table: "AdditionalAddress_EmailAddress",
                column: "AddressForService_AdditionalAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalAddress_PostalAddress_AddressForService_AdditionalAddressId",
                table: "AdditionalAddress_PostalAddress",
                column: "AddressForService_AdditionalAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AddressForService_PartyId",
                table: "AddressForService",
                column: "PartyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AddressForService_AdditionalAddress_addressForServiceId",
                table: "AddressForService_AdditionalAddress",
                column: "addressForServiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AddressForService_DXAddress_AddressForService_AdditionalAddressId",
                table: "AddressForService_DXAddress",
                column: "AddressForService_AdditionalAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AddressForService_PostalAddress_addressForServiceId",
                table: "AddressForService_PostalAddress",
                column: "addressForServiceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalAddress_EmailAddress");

            migrationBuilder.DropTable(
                name: "AdditionalAddress_PostalAddress");

            migrationBuilder.DropTable(
                name: "AddressForService_DXAddress");

            migrationBuilder.DropTable(
                name: "AddressForService_PostalAddress");

            migrationBuilder.DropTable(
                name: "AddressForService_AdditionalAddress");

            migrationBuilder.DropTable(
                name: "AddressForService");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 8, 11, 53, 1, 336, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 41, 104, 119, 82, 171, 88, 52, 165, 41, 194, 232, 177, 62, 3, 166, 220, 97, 24, 141, 14, 158, 9, 219, 47, 135, 174, 219, 140, 69, 187, 213, 239, 187, 83, 96, 44, 228, 240, 80, 32, 249, 53, 36, 99, 244, 20, 37, 11, 32, 32, 119, 237, 96, 248, 181, 22, 143, 91, 148, 216, 101, 120, 187, 128 }, new byte[] { 66, 158, 14, 255, 189, 42, 169, 142, 208, 175, 60, 60, 70, 99, 10, 127, 107, 74, 35, 162, 138, 12, 155, 6, 53, 93, 9, 194, 88, 11, 191, 12, 161, 86, 250, 152, 36, 134, 176, 226, 126, 102, 128, 112, 172, 50, 90, 71, 224, 22, 95, 46, 131, 221, 30, 201, 183, 4, 33, 99, 8, 24, 4, 98, 196, 236, 192, 171, 129, 238, 43, 162, 96, 112, 35, 188, 160, 13, 50, 153, 141, 126, 146, 96, 66, 109, 30, 154, 197, 204, 18, 158, 201, 11, 251, 240, 221, 154, 81, 246, 62, 10, 201, 45, 106, 8, 192, 96, 244, 70, 246, 104, 206, 157, 59, 84, 142, 175, 154, 58, 108, 139, 159, 229, 120, 221, 75, 28 } });
        }
    }
}
