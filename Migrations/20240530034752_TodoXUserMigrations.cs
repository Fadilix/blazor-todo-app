using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53261087-05e9-4d4f-acd8-df14d916d2fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "959d450e-f3ea-4003-8110-c30e610b3c8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96906c2e-8068-47b3-8170-5c5dbca9a3e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06a56725-a39c-4e50-98ab-8a98301b7e1f", null, "admin", "admin" },
                    { "eb949409-4143-4dd0-a7ff-c35abae36ea3", null, "client", "client" },
                    { "f389a198-3ee3-492b-b527-cd23270ebad6", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06a56725-a39c-4e50-98ab-8a98301b7e1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb949409-4143-4dd0-a7ff-c35abae36ea3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f389a198-3ee3-492b-b527-cd23270ebad6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "53261087-05e9-4d4f-acd8-df14d916d2fb", null, "admin", "admin" },
                    { "959d450e-f3ea-4003-8110-c30e610b3c8d", null, "client", "client" },
                    { "96906c2e-8068-47b3-8170-5c5dbca9a3e7", null, "seller", "seller" }
                });
        }
    }
}
