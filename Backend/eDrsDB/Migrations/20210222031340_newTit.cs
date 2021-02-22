using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class newTit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ChargeDate",
                table: "ApplicationForms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MDRef",
                table: "ApplicationForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Variety",
                table: "ApplicationForms",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "trns_chrge", new DateTime(2021, 2, 22, 8, 43, 40, 313, DateTimeKind.Local).AddTicks(9895), "transfer-and-charge" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 8, 43, 40, 314, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 8, 43, 40, 314, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 8, 43, 40, 314, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 8, 43, 40, 314, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 8, 43, 40, 314, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 8, 43, 40, 314, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 8, 43, 40, 314, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 153, 241, 43, 154, 217, 140, 35, 7, 93, 114, 112, 142, 226, 95, 168, 116, 204, 106, 111, 42, 44, 10, 130, 236, 147, 129, 196, 249, 79, 224, 170, 166, 56, 253, 174, 30, 146, 44, 67, 119, 213, 23, 77, 75, 142, 236, 40, 215, 240, 17, 2, 41, 16, 35, 152, 232, 157, 99, 215, 140, 173, 92, 144, 133 }, new byte[] { 179, 4, 29, 155, 192, 214, 189, 32, 56, 123, 170, 97, 251, 103, 158, 196, 128, 204, 103, 250, 100, 81, 70, 187, 48, 123, 198, 69, 127, 213, 174, 124, 184, 234, 153, 142, 214, 19, 245, 189, 17, 63, 81, 25, 86, 255, 233, 135, 129, 125, 63, 242, 79, 165, 197, 237, 15, 138, 47, 110, 126, 25, 155, 150, 18, 171, 193, 220, 205, 155, 103, 100, 73, 199, 184, 106, 142, 225, 100, 62, 87, 39, 56, 211, 121, 98, 36, 245, 2, 89, 167, 163, 82, 148, 1, 79, 181, 13, 83, 73, 30, 161, 103, 249, 143, 247, 128, 133, 144, 220, 87, 27, 207, 65, 23, 253, 99, 56, 70, 154, 79, 249, 151, 222, 127, 240, 118, 211 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChargeDate",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "MDRef",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "Variety",
                table: "ApplicationForms");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                columns: new[] { "TypeCode", "UpdatedDate", "Url" },
                values: new object[] { "doc_reg", new DateTime(2021, 2, 19, 12, 38, 46, 265, DateTimeKind.Local).AddTicks(9277), "document-registration" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 19, 12, 38, 46, 266, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 97, 16, 255, 43, 39, 121, 35, 7, 30, 253, 204, 57, 189, 240, 223, 89, 211, 131, 59, 72, 34, 93, 110, 100, 173, 160, 104, 143, 216, 80, 105, 130, 153, 140, 32, 225, 28, 235, 181, 116, 0, 177, 6, 63, 32, 124, 52, 139, 88, 75, 51, 188, 53, 91, 188, 36, 179, 246, 54, 81, 129, 101, 150, 203 }, new byte[] { 244, 43, 133, 38, 238, 142, 95, 114, 1, 33, 59, 241, 129, 88, 113, 202, 99, 196, 83, 216, 192, 85, 205, 139, 41, 175, 131, 159, 142, 67, 67, 73, 252, 211, 102, 214, 97, 153, 223, 232, 16, 135, 188, 248, 57, 164, 139, 169, 199, 7, 51, 37, 221, 68, 112, 118, 60, 214, 26, 155, 244, 147, 150, 238, 103, 1, 91, 63, 79, 135, 222, 82, 213, 126, 125, 0, 24, 13, 32, 119, 171, 128, 205, 67, 171, 171, 184, 233, 107, 66, 191, 180, 143, 46, 196, 88, 98, 242, 24, 23, 164, 50, 197, 72, 44, 243, 13, 231, 136, 249, 18, 198, 110, 6, 4, 120, 234, 250, 136, 232, 40, 123, 58, 104, 39, 251, 126, 226 } });
        }
    }
}
