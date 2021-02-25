using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class addressTypesv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Representations_DxAddresses_DxAddressId",
                table: "Representations");

            migrationBuilder.DropForeignKey(
                name: "FK_Representations_PostalAddresses_PostalAddressId",
                table: "Representations");

            migrationBuilder.DropTable(
                name: "DxAddresses");

            migrationBuilder.DropTable(
                name: "PostalAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Representations_DxAddressId",
                table: "Representations");

            migrationBuilder.DropIndex(
                name: "IX_Representations_PostalAddressId",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "DxAddressId",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "PostalAddressId",
                table: "Representations");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine3",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine4",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DxExchange",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DxNumber",
                table: "Representations",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "Representations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 209, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 1, 27, 211, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 168, 230, 90, 118, 43, 8, 97, 64, 63, 192, 24, 37, 206, 224, 60, 1, 7, 236, 150, 253, 249, 147, 96, 131, 43, 185, 252, 33, 79, 84, 140, 186, 39, 228, 205, 227, 153, 247, 169, 205, 235, 177, 214, 47, 210, 18, 121, 232, 88, 61, 117, 174, 47, 233, 124, 156, 197, 120, 209, 28, 97, 223, 185, 96 }, new byte[] { 157, 255, 190, 23, 107, 236, 205, 8, 39, 234, 117, 252, 226, 88, 173, 116, 130, 74, 132, 241, 104, 105, 32, 99, 66, 7, 62, 164, 69, 32, 219, 62, 65, 214, 42, 65, 206, 25, 184, 157, 211, 239, 161, 71, 25, 218, 100, 246, 126, 238, 229, 7, 106, 16, 225, 110, 58, 103, 129, 202, 237, 24, 134, 213, 206, 184, 252, 206, 156, 193, 93, 214, 112, 147, 42, 124, 234, 24, 189, 147, 29, 152, 39, 240, 233, 79, 196, 192, 196, 40, 246, 66, 48, 220, 208, 184, 118, 221, 139, 240, 138, 109, 33, 180, 97, 143, 15, 27, 208, 86, 156, 100, 225, 16, 229, 27, 201, 244, 152, 192, 71, 95, 81, 24, 247, 16, 53, 95 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "AddressLine3",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "AddressLine4",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "County",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "DxExchange",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "DxNumber",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Representations");

            migrationBuilder.AddColumn<long>(
                name: "DxAddressId",
                table: "Representations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PostalAddressId",
                table: "Representations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "DxAddresses",
                columns: table => new
                {
                    DxAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DxExchange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DxNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DxAddresses", x => x.DxAddressId);
                });

            migrationBuilder.CreateTable(
                name: "PostalAddresses",
                columns: table => new
                {
                    PostalAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostalAddresses", x => x.PostalAddressId);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 0, 10, 383, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 0, 10, 385, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 0, 10, 385, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 0, 10, 385, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 0, 10, 385, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 0, 10, 385, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 0, 10, 385, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 18, 0, 10, 385, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 51, 237, 69, 140, 126, 123, 39, 190, 3, 176, 223, 89, 138, 224, 230, 253, 24, 30, 48, 124, 105, 115, 161, 195, 49, 115, 212, 78, 97, 223, 163, 180, 40, 253, 201, 45, 186, 48, 45, 40, 185, 79, 29, 4, 219, 167, 37, 195, 142, 137, 18, 224, 183, 3, 95, 230, 248, 153, 206, 21, 207, 28, 59, 60 }, new byte[] { 155, 195, 241, 168, 108, 195, 192, 240, 214, 99, 153, 80, 75, 37, 98, 127, 4, 18, 190, 157, 43, 145, 244, 216, 92, 146, 90, 87, 100, 115, 15, 160, 130, 189, 149, 233, 47, 122, 89, 195, 124, 23, 141, 106, 179, 85, 230, 225, 61, 189, 46, 0, 79, 217, 107, 32, 140, 174, 159, 142, 13, 110, 208, 41, 101, 217, 184, 108, 222, 213, 166, 126, 68, 70, 53, 59, 45, 167, 25, 177, 189, 141, 47, 167, 241, 111, 166, 103, 203, 24, 49, 95, 107, 38, 36, 78, 44, 81, 38, 157, 216, 85, 250, 255, 37, 166, 139, 33, 52, 112, 200, 50, 155, 227, 18, 178, 232, 214, 254, 94, 216, 19, 62, 148, 181, 192, 204, 120 } });

            migrationBuilder.CreateIndex(
                name: "IX_Representations_DxAddressId",
                table: "Representations",
                column: "DxAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Representations_PostalAddressId",
                table: "Representations",
                column: "PostalAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Representations_DxAddresses_DxAddressId",
                table: "Representations",
                column: "DxAddressId",
                principalTable: "DxAddresses",
                principalColumn: "DxAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Representations_PostalAddresses_PostalAddressId",
                table: "Representations",
                column: "PostalAddressId",
                principalTable: "PostalAddresses",
                principalColumn: "PostalAddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
