using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3864), new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3876), new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3878), new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3879), new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3881), new DateTime(2026, 8, 3, 16, 22, 39, 552, DateTimeKind.Local).AddTicks(3881) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3372), new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3388), new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3390), new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3391), new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3393), new DateTime(2026, 7, 21, 10, 17, 10, 891, DateTimeKind.Local).AddTicks(3393) });
        }
    }
}
