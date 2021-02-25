using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class addressTypesv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Representations_DxAddress_DxAddressId",
                table: "Representations");

            migrationBuilder.DropForeignKey(
                name: "FK_Representations_PostalAddress_PostalAddressId",
                table: "Representations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostalAddress",
                table: "PostalAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DxAddress",
                table: "DxAddress");

            migrationBuilder.RenameTable(
                name: "PostalAddress",
                newName: "PostalAddresses");

            migrationBuilder.RenameTable(
                name: "DxAddress",
                newName: "DxAddresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostalAddresses",
                table: "PostalAddresses",
                column: "PostalAddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DxAddresses",
                table: "DxAddresses",
                column: "DxAddressId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Representations_DxAddresses_DxAddressId",
                table: "Representations");

            migrationBuilder.DropForeignKey(
                name: "FK_Representations_PostalAddresses_PostalAddressId",
                table: "Representations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostalAddresses",
                table: "PostalAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DxAddresses",
                table: "DxAddresses");

            migrationBuilder.RenameTable(
                name: "PostalAddresses",
                newName: "PostalAddress");

            migrationBuilder.RenameTable(
                name: "DxAddresses",
                newName: "DxAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostalAddress",
                table: "PostalAddress",
                column: "PostalAddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DxAddress",
                table: "DxAddress",
                column: "DxAddressId");

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
    }
}
