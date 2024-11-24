using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(1939), new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(1953), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(1956), new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(1956), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2155), new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2155), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2157), new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2158), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2250), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2251), new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2252), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2253), new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2253), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2255), new DateTime(2024, 11, 18, 17, 36, 57, 594, DateTimeKind.Local).AddTicks(2255), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

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
        }
    }
}
