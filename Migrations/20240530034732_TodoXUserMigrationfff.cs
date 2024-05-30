using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationfff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "56c5f9f6-d4dd-413e-8735-e6fc0917986c", null, "client", "client" },
                    { "a7551412-7146-42e4-8451-c5d04e984dc3", null, "seller", "seller" },
                    { "d3f34ace-93a1-40c6-a152-5b9ae5347d75", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56c5f9f6-d4dd-413e-8735-e6fc0917986c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7551412-7146-42e4-8451-c5d04e984dc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3f34ace-93a1-40c6-a152-5b9ae5347d75");

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
    }
}
