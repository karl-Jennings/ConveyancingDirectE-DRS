using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrsDB.Migrations
{
    public partial class representation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Representations",
                columns: table => new
                {
                    RepresentationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    RepresentativeId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Reference = table.Column<string>(nullable: true),
                    DxNumber = table.Column<long>(nullable: false),
                    DxExchange = table.Column<string>(nullable: true),
                    DocumentReferenceId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Representations", x => x.RepresentationId);
                    table.ForeignKey(
                        name: "FK_Representations_DocumentReferences_DocumentReferenceId",
                        column: x => x.DocumentReferenceId,
                        principalTable: "DocumentReferences",
                        principalColumn: "DocumentReferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 463, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 2L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 3L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 4L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 5L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 6L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 7L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 8L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 11, 47, 27, 464, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 207, 12, 97, 75, 83, 59, 182, 220, 220, 150, 206, 128, 113, 78, 149, 165, 61, 43, 66, 35, 166, 131, 180, 203, 22, 82, 202, 132, 30, 183, 247, 188, 79, 201, 49, 142, 163, 209, 30, 89, 112, 232, 240, 225, 222, 235, 52, 211, 47, 171, 189, 37, 240, 81, 238, 247, 175, 147, 92, 236, 123, 0, 137, 44 }, new byte[] { 201, 185, 184, 219, 158, 245, 23, 101, 187, 13, 177, 121, 116, 167, 241, 40, 4, 50, 215, 133, 178, 253, 6, 117, 107, 75, 166, 88, 113, 54, 189, 220, 27, 42, 179, 71, 215, 80, 102, 87, 104, 36, 169, 141, 191, 21, 82, 126, 54, 214, 209, 174, 184, 35, 242, 201, 72, 47, 211, 73, 48, 17, 89, 87, 138, 33, 113, 154, 179, 135, 125, 89, 40, 212, 1, 234, 206, 223, 211, 227, 75, 136, 143, 98, 46, 105, 167, 23, 32, 192, 123, 128, 17, 147, 190, 106, 26, 48, 198, 118, 230, 201, 34, 23, 137, 111, 27, 66, 16, 86, 18, 137, 40, 32, 254, 55, 134, 0, 41, 38, 111, 232, 4, 67, 7, 10, 211, 5 } });

            migrationBuilder.CreateIndex(
                name: "IX_Representations_DocumentReferenceId",
                table: "Representations",
                column: "DocumentReferenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Representations");

            migrationBuilder.UpdateData(
                table: "RegistrationTypes",
                keyColumn: "RegistrationTypeId",
                keyValue: 1L,
                column: "UpdatedDate",
                value: new DateTime(2021, 2, 22, 8, 43, 40, 313, DateTimeKind.Local).AddTicks(9895));

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
    }
}
