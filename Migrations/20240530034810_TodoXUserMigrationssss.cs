using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d0b95a7-4633-44f7-83ea-a011b7569fd6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47bea45f-6d88-4e60-9af0-9dba1ddc9776");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1560911-91a0-4b9a-bd53-56b932ca8828");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0d0b95a7-4633-44f7-83ea-a011b7569fd6", null, "admin", "admin" },
                    { "47bea45f-6d88-4e60-9af0-9dba1ddc9776", null, "seller", "seller" },
                    { "b1560911-91a0-4b9a-bd53-56b932ca8828", null, "client", "client" }
                });
        }
    }
}
