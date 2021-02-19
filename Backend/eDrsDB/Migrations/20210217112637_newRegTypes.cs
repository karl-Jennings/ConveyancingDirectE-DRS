using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class newRegTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                columns: new[] { "TypeName", "UpdatedDate" },
                values: new object[] { "Transfer and charge", new DateTime(2021, 2, 17, 16, 56, 37, 528, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                columns: new[] { "TypeName", "UpdatedDate" },
                values: new object[] { "Remortgage", new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                columns: new[] { "TypeName", "UpdatedDate" },
                values: new object[] { "Transfer of equity", new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                columns: new[] { "TypeCode", "TypeName", "UpdatedDate", "Url" },
                values: new object[] { "rem_frm", "Restriction, hostile takeover", new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3129), "removal-form" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                columns: new[] { "TypeCode", "TypeName", "UpdatedDate", "Url" },
                values: new object[] { "transfer", "Change of name", new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3131), "transfer" });

            migrationBuilder.InsertData(
                table: "RegistrationTypes",
                columns: new[] { "RegistrationTypeId", "Status", "TypeCode", "TypeName", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { 6L, true, "transfer", "Dispositionary first lease", new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3132), "transfer" },
                    { 7L, true, "transfer", "Transfer of part", new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3133), "transfer" },
                    { 8L, true, "transfer", "Lease extension", new DateTime(2021, 2, 17, 16, 56, 37, 529, DateTimeKind.Local).AddTicks(3135), "transfer" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 25, 5, 216, 31, 115, 232, 172, 240, 141, 73, 175, 184, 137, 105, 137, 157, 168, 212, 19, 135, 122, 163, 9, 93, 11, 200, 22, 113, 39, 81, 184, 234, 167, 173, 215, 120, 25, 206, 156, 235, 53, 58, 2, 111, 155, 112, 198, 13, 131, 243, 152, 144, 237, 213, 188, 217, 175, 223, 53, 131, 165, 245, 242 }, new byte[] { 70, 2, 34, 231, 175, 245, 31, 153, 146, 44, 142, 244, 29, 150, 93, 245, 42, 149, 80, 176, 184, 75, 52, 204, 39, 211, 246, 76, 13, 59, 3, 206, 199, 173, 41, 114, 217, 151, 119, 196, 174, 166, 130, 116, 102, 158, 136, 100, 125, 32, 99, 55, 117, 50, 7, 20, 30, 28, 179, 53, 150, 33, 147, 255, 47, 121, 170, 144, 11, 105, 138, 11, 235, 163, 71, 134, 41, 219, 0, 176, 103, 131, 47, 80, 81, 95, 75, 62, 45, 82, 19, 98, 94, 5, 94, 216, 127, 44, 44, 25, 210, 219, 254, 49, 11, 82, 214, 93, 196, 133, 108, 210, 131, 241, 179, 124, 6, 94, 128, 250, 217, 231, 166, 146, 116, 79, 211, 130 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L);

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                columns: new[] { "TypeName", "UpdatedDate" },
                values: new object[] { "Document Registration", new DateTime(2021, 2, 17, 11, 47, 8, 344, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                columns: new[] { "TypeName", "UpdatedDate" },
                values: new object[] { "Lease Extension", new DateTime(2021, 2, 17, 11, 47, 8, 345, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                columns: new[] { "TypeName", "UpdatedDate" },
                values: new object[] { "New Lease", new DateTime(2021, 2, 17, 11, 47, 8, 345, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                columns: new[] { "TypeCode", "TypeName", "UpdatedDate", "Url" },
                values: new object[] { "transfer", "Transfer of Part", new DateTime(2021, 2, 17, 11, 47, 8, 345, DateTimeKind.Local).AddTicks(4838), "transfer" });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                columns: new[] { "TypeCode", "TypeName", "UpdatedDate", "Url" },
                values: new object[] { "rem_frm", "Removal of default form A restriction (JP1)", new DateTime(2021, 2, 17, 11, 47, 8, 345, DateTimeKind.Local).AddTicks(4839), "removal-form" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 93, 171, 166, 28, 14, 74, 133, 102, 136, 40, 224, 205, 62, 14, 26, 173, 229, 224, 177, 155, 121, 240, 44, 248, 59, 144, 218, 60, 225, 157, 86, 128, 124, 94, 101, 153, 143, 192, 106, 129, 196, 49, 5, 85, 10, 105, 163, 108, 114, 22, 241, 94, 50, 236, 139, 77, 164, 203, 163, 35, 90, 7, 21, 57 }, new byte[] { 226, 115, 157, 109, 212, 24, 201, 189, 204, 173, 201, 31, 41, 61, 116, 228, 58, 199, 89, 90, 0, 116, 32, 122, 58, 107, 160, 31, 84, 67, 36, 183, 116, 61, 83, 16, 105, 207, 215, 46, 26, 153, 57, 197, 220, 93, 166, 152, 225, 68, 94, 92, 194, 130, 61, 73, 163, 39, 220, 9, 171, 224, 57, 228, 6, 158, 33, 16, 19, 146, 19, 41, 149, 239, 62, 215, 206, 53, 241, 254, 78, 216, 90, 144, 78, 61, 8, 100, 110, 155, 147, 40, 116, 15, 74, 60, 20, 30, 131, 27, 229, 0, 200, 224, 170, 45, 250, 190, 99, 136, 16, 6, 215, 231, 14, 203, 153, 34, 114, 231, 172, 164, 132, 59, 93, 122, 165, 117 } });
        }
    }
}
