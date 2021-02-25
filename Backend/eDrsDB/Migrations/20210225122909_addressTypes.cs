using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class addressTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DxExchange",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "DxNumber",
                table: "Representations");

            migrationBuilder.AddColumn<string>(
                name: "AddressType",
                table: "Representations",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DxAddressId",
                table: "Representations",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PostalAddressId",
                table: "Representations",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "DxAddress",
                columns: table => new
                {
                    DxAddressId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DxNumber = table.Column<long>(nullable: false),
                    DxExchange = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DxAddress", x => x.DxAddressId);
                });

            migrationBuilder.CreateTable(
                name: "PostalAddress",
                columns: table => new
                {
                    PostalAddressId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_PostalAddress", x => x.PostalAddressId);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 17, 59, 8, 880, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 17, 59, 8, 881, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 17, 59, 8, 881, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 17, 59, 8, 881, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 17, 59, 8, 881, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 17, 59, 8, 881, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 17, 59, 8, 881, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 17, 59, 8, 881, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 13, 225, 213, 185, 71, 191, 239, 237, 220, 72, 107, 167, 190, 142, 130, 164, 249, 130, 176, 155, 162, 175, 166, 25, 221, 128, 252, 37, 224, 50, 92, 45, 74, 240, 99, 35, 177, 161, 77, 16, 94, 67, 160, 59, 123, 0, 30, 98, 141, 143, 62, 239, 224, 248, 5, 8, 111, 120, 195, 81, 236, 56, 144, 177 }, new byte[] { 209, 73, 189, 240, 96, 199, 83, 242, 83, 27, 241, 100, 1, 43, 221, 12, 111, 83, 252, 224, 219, 38, 181, 32, 178, 173, 87, 85, 167, 238, 47, 209, 216, 160, 54, 45, 147, 13, 70, 97, 64, 105, 90, 127, 117, 124, 165, 23, 193, 82, 76, 89, 254, 51, 11, 232, 63, 196, 82, 5, 216, 205, 162, 143, 156, 198, 68, 228, 2, 23, 10, 230, 175, 250, 217, 196, 153, 53, 122, 204, 138, 6, 100, 244, 72, 110, 179, 109, 18, 241, 71, 183, 178, 228, 109, 216, 245, 149, 198, 24, 181, 17, 100, 154, 239, 37, 212, 97, 142, 47, 77, 86, 108, 202, 196, 238, 42, 64, 239, 185, 149, 4, 226, 16, 9, 26, 43, 169 } });

            migrationBuilder.CreateIndex(
                name: "IX_Representations_DxAddressId",
                table: "Representations",
                column: "DxAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Representations_PostalAddressId",
                table: "Representations",
                column: "PostalAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Representations_DxAddress_DxAddressId",
                table: "Representations",
                column: "DxAddressId",
                principalTable: "DxAddress",
                principalColumn: "DxAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Representations_PostalAddress_PostalAddressId",
                table: "Representations",
                column: "PostalAddressId",
                principalTable: "PostalAddress",
                principalColumn: "PostalAddressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Representations_DxAddress_DxAddressId",
                table: "Representations");

            migrationBuilder.DropForeignKey(
                name: "FK_Representations_PostalAddress_PostalAddressId",
                table: "Representations");

            migrationBuilder.DropTable(
                name: "DxAddress");

            migrationBuilder.DropTable(
                name: "PostalAddress");

            migrationBuilder.DropIndex(
                name: "IX_Representations_DxAddressId",
                table: "Representations");

            migrationBuilder.DropIndex(
                name: "IX_Representations_PostalAddressId",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "AddressType",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "DxAddressId",
                table: "Representations");

            migrationBuilder.DropColumn(
                name: "PostalAddressId",
                table: "Representations");

            migrationBuilder.AddColumn<string>(
                name: "DxExchange",
                table: "Representations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DxNumber",
                table: "Representations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 241, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 25, 13, 21, 47, 243, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 88, 181, 94, 156, 170, 92, 116, 139, 83, 96, 113, 63, 230, 18, 3, 103, 34, 237, 245, 214, 119, 108, 155, 217, 187, 50, 252, 197, 26, 221, 218, 88, 230, 230, 1, 32, 194, 224, 51, 7, 45, 114, 231, 13, 64, 93, 208, 182, 193, 34, 53, 51, 105, 150, 28, 239, 162, 41, 230, 27, 243, 166, 189, 91 }, new byte[] { 84, 226, 208, 69, 208, 104, 60, 253, 8, 127, 168, 75, 110, 113, 19, 188, 201, 105, 183, 204, 8, 169, 45, 43, 106, 176, 99, 185, 165, 243, 252, 10, 68, 215, 211, 129, 54, 79, 182, 245, 15, 230, 161, 124, 167, 212, 152, 28, 57, 184, 81, 125, 37, 43, 161, 45, 226, 54, 86, 225, 145, 193, 72, 188, 250, 223, 122, 132, 39, 165, 49, 226, 58, 104, 99, 214, 251, 147, 96, 216, 229, 69, 241, 38, 162, 119, 228, 130, 237, 89, 216, 117, 242, 215, 3, 224, 70, 206, 4, 241, 47, 226, 28, 245, 170, 202, 86, 248, 182, 169, 158, 166, 72, 76, 139, 241, 111, 168, 178, 202, 33, 182, 199, 217, 29, 89, 44, 178 } });
        }
    }
}
