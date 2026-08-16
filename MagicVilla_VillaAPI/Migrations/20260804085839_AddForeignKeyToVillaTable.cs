using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VillaNumbers");

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
    }
}
