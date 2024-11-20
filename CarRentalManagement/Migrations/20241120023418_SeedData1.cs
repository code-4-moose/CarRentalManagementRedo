using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(7706), new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(7719), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(7722), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(8042), new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(8043), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(8045), new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(8046), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(8048), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 11, 20, 10, 34, 18, 46, DateTimeKind.Local).AddTicks(8051), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 10, 32, 33, 974, DateTimeKind.Local).AddTicks(4224), new DateTime(2024, 11, 20, 10, 32, 33, 974, DateTimeKind.Local).AddTicks(4238), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 10, 32, 33, 974, DateTimeKind.Local).AddTicks(4246), new DateTime(2024, 11, 20, 10, 32, 33, 974, DateTimeKind.Local).AddTicks(4247), "Blue", "System" }
                });
        }
    }
}
