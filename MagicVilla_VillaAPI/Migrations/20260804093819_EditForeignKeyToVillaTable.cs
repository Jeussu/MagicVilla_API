using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class EditForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8377), new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8390), new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8391), new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8393), new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8394), new DateTime(2026, 8, 4, 16, 38, 19, 207, DateTimeKind.Local).AddTicks(8395) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4413), new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4427), new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4429), new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4430), new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4432), new DateTime(2026, 8, 4, 15, 58, 39, 216, DateTimeKind.Local).AddTicks(4432) });
        }
    }
}
