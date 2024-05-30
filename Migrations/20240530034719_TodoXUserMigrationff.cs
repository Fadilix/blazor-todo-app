using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6dd9eb64-5c7d-4df8-8083-645a10093bbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad82ddda-d9b6-45c8-b843-4c58623b66ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab68e73-9dd9-4e8f-875b-993342dd3645");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60a72024-265b-4ded-8db3-abcb8b37063e", null, "admin", "admin" },
                    { "6fee2842-af3b-4de4-86fb-7774893bc1ce", null, "client", "client" },
                    { "c0df64fb-bdae-44e2-b15a-a12ceeb3e965", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60a72024-265b-4ded-8db3-abcb8b37063e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fee2842-af3b-4de4-86fb-7774893bc1ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0df64fb-bdae-44e2-b15a-a12ceeb3e965");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6dd9eb64-5c7d-4df8-8083-645a10093bbe", null, "admin", "admin" },
                    { "ad82ddda-d9b6-45c8-b843-4c58623b66ca", null, "client", "client" },
                    { "fab68e73-9dd9-4e8f-875b-993342dd3645", null, "seller", "seller" }
                });
        }
    }
}
