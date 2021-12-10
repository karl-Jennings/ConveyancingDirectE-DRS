using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsAPI.Migrations
{
    public partial class newcolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AddressForService_AdditionalAddress_addressForServiceId",
                table: "AddressForService_AdditionalAddress");

            migrationBuilder.DropIndex(
                name: "IX_AddressForService_PartyId",
                table: "AddressForService");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "AddressForService_PostalAddress",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DXNumber",
                table: "AddressForService_DXAddress",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DXExchange",
                table: "AddressForService_DXAddress",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 276, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 12, 9, 12, 43, 20, 277, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 34, 150, 20, 189, 148, 234, 166, 50, 187, 237, 186, 238, 66, 157, 101, 120, 221, 46, 89, 124, 157, 184, 115, 192, 56, 139, 143, 129, 71, 164, 132, 184, 73, 203, 111, 46, 103, 95, 199, 177, 77, 130, 173, 86, 5, 76, 52, 200, 117, 236, 220, 27, 72, 167, 33, 188, 177, 220, 115, 44, 167, 87, 180 }, new byte[] { 248, 113, 209, 61, 23, 23, 171, 169, 251, 189, 79, 120, 210, 133, 6, 85, 121, 180, 36, 52, 178, 128, 232, 75, 94, 41, 199, 9, 134, 141, 189, 146, 169, 106, 73, 167, 85, 78, 120, 26, 146, 179, 86, 214, 47, 103, 158, 113, 160, 14, 205, 201, 224, 153, 162, 197, 10, 4, 56, 143, 218, 176, 7, 115, 74, 15, 252, 178, 192, 129, 33, 16, 96, 194, 9, 71, 36, 82, 204, 195, 194, 37, 33, 104, 156, 161, 166, 109, 220, 19, 107, 131, 39, 122, 25, 70, 178, 187, 61, 147, 41, 40, 170, 92, 114, 43, 171, 246, 104, 215, 17, 105, 139, 91, 230, 50, 15, 109, 238, 62, 135, 8, 200, 221, 31, 69, 165, 207 } });

            migrationBuilder.CreateIndex(
                name: "IX_AddressForService_AdditionalAddress_addressForServiceId",
                table: "AddressForService_AdditionalAddress",
                column: "addressForServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressForService_PartyId",
                table: "AddressForService",
                column: "PartyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AddressForService_AdditionalAddress_addressForServiceId",
                table: "AddressForService_AdditionalAddress");

            migrationBuilder.DropIndex(
                name: "IX_AddressForService_PartyId",
                table: "AddressForService");

            migrationBuilder.AlterColumn<string>(
                name: "AddressLine1",
                table: "AddressForService_PostalAddress",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "DXNumber",
                table: "AddressForService_DXAddress",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "DXExchange",
                table: "AddressForService_DXAddress",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
                name: "IX_AddressForService_AdditionalAddress_addressForServiceId",
                table: "AddressForService_AdditionalAddress",
                column: "addressForServiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AddressForService_PartyId",
                table: "AddressForService",
                column: "PartyId",
                unique: true);
        }
    }
}
