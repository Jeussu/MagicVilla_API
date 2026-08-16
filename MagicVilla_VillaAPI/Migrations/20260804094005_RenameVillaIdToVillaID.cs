using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameVillaIdToVillaID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers");

            migrationBuilder.RenameColumn(
                name: "VillaId",
                table: "VillaNumbers",
                newName: "VillaID");

            migrationBuilder.RenameIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                newName: "IX_VillaNumbers_VillaID");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(80), new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(91), new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(93), new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(94), new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(96), new DateTime(2026, 8, 4, 16, 40, 5, 431, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.RenameColumn(
                name: "VillaID",
                table: "VillaNumbers",
                newName: "VillaId");

            migrationBuilder.RenameIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                newName: "IX_VillaNumbers_VillaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
