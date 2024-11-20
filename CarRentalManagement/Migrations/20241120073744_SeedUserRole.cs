using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8120), new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8136), new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8538), new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8543), new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 11, 20, 15, 37, 43, 624, DateTimeKind.Local).AddTicks(8546) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(113), new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(128), new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(421), new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(424), new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(551), new DateTime(2024, 11, 20, 10, 47, 8, 996, DateTimeKind.Local).AddTicks(552) });
        }
    }
}
