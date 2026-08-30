using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUserToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8715), "https://dotnetmastery.com/bluevillaimages/villa3.jpg", new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8725), "https://dotnetmastery.com/bluevillaimages/villa1.jpg", new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8726), "https://dotnetmastery.com/bluevillaimages/villa4.jpg", new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8728), "https://dotnetmastery.com/bluevillaimages/villa5.jpg", new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8729), "https://dotnetmastery.com/bluevillaimages/villa2.jpg", new DateTime(2026, 8, 23, 16, 12, 38, 534, DateTimeKind.Local).AddTicks(8730) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7235), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7248), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7250), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg", new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7251), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg", new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "ImageUrl", "UpdateDate" },
                values: new object[] { new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7253), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", new DateTime(2026, 8, 17, 21, 44, 34, 980, DateTimeKind.Local).AddTicks(7253) });
        }
    }
}
