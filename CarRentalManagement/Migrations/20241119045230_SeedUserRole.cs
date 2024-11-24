using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6cdb4aed-bb10-48a6-850b-519928bbb044", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPPG+CyeSr7JNkMxd8Uin2+5+CM3A49efZFNVJnFwiFbeakF37udL3oL/gg+TYTejQ==", null, false, "94f76ad8-6800-4e13-90a7-eacd28d50ad5", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 52, 29, 896, DateTimeKind.Local).AddTicks(9891), new DateTime(2024, 11, 19, 12, 52, 29, 896, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 52, 29, 896, DateTimeKind.Local).AddTicks(9904), new DateTime(2024, 11, 19, 12, 52, 29, 896, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(234), new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(346), new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(348), new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(350), new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(352), new DateTime(2024, 11, 19, 12, 52, 29, 897, DateTimeKind.Local).AddTicks(352) });

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
                values: new object[] { new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(3958), new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(3972), new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4268), new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4441), new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4445), new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4447), new DateTime(2024, 11, 19, 12, 17, 46, 196, DateTimeKind.Local).AddTicks(4447) });
        }
    }
}
