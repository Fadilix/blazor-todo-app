using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ab03dc-0f51-4a80-a1e5-09ef86471066");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fa058ed-708d-4a09-aad3-7d26c6acece1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cabffe4-72b1-4640-aebc-67c8ce3fdfe8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71d7ff92-83d3-4def-af02-174e0360852d", null, "client", "client" },
                    { "97c94ba3-c912-42f4-9426-8554f9e3cc89", null, "admin", "admin" },
                    { "a5025e6b-3fa3-4b33-b6c1-d88edad551f7", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71d7ff92-83d3-4def-af02-174e0360852d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97c94ba3-c912-42f4-9426-8554f9e3cc89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5025e6b-3fa3-4b33-b6c1-d88edad551f7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22ab03dc-0f51-4a80-a1e5-09ef86471066", null, "seller", "seller" },
                    { "3fa058ed-708d-4a09-aad3-7d26c6acece1", null, "admin", "admin" },
                    { "6cabffe4-72b1-4640-aebc-67c8ce3fdfe8", null, "client", "client" }
                });
        }
    }
}
