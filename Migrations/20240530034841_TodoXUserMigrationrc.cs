using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationrc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f7c4ac2-8bae-42b8-9f8f-e8f5aacbdc91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e9f9423-5902-4054-a436-ed3ce9e85422");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9057dd3-b004-4449-be38-1027725599db");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "674317d6-3b9a-41d1-ad8d-bb2721f099f9", null, "client", "client" },
                    { "7b82afbc-7a9c-496a-a440-4ef954a5ffa9", null, "admin", "admin" },
                    { "ab901f13-18f8-4131-85fb-3c6f07a41be6", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "674317d6-3b9a-41d1-ad8d-bb2721f099f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b82afbc-7a9c-496a-a440-4ef954a5ffa9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab901f13-18f8-4131-85fb-3c6f07a41be6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f7c4ac2-8bae-42b8-9f8f-e8f5aacbdc91", null, "client", "client" },
                    { "3e9f9423-5902-4054-a436-ed3ce9e85422", null, "seller", "seller" },
                    { "f9057dd3-b004-4449-be38-1027725599db", null, "admin", "admin" }
                });
        }
    }
}
