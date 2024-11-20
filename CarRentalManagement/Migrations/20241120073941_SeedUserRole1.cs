using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "1f973913-07dd-40f2-8ab0-c4d8a5fc9696", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOS0hyLGmTgfCdf7FvGUcrWkTysywEspoNSoYjGpOtQVxJYI3QjTHs3ZIk8begFzAA==", null, false, "13b02a7c-7924-4469-b6fb-d95b40105c4c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(5845), new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(5865), new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6122), new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6253), new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6255), new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 11, 20, 15, 39, 40, 119, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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
    }
}
