using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationffffffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "450cc79d-14c4-4937-9a18-22b3a8148877");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f0a7f1f-d3da-4df4-8fcd-7e4ff8305819");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b517b8da-c2b2-4e3d-babf-e3e9d04d90a1");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "450cc79d-14c4-4937-9a18-22b3a8148877", null, "client", "client" },
                    { "7f0a7f1f-d3da-4df4-8fcd-7e4ff8305819", null, "admin", "admin" },
                    { "b517b8da-c2b2-4e3d-babf-e3e9d04d90a1", null, "seller", "seller" }
                });
        }
    }
}
