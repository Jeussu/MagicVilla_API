using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNullableToFalse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumbers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7235), new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7248), new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7250), new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7251), new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7253), new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7253) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumbers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
