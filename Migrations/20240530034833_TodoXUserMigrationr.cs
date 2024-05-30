using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2f7c4ac2-8bae-42b8-9f8f-e8f5aacbdc91", null, "client", "client" },
                    { "3e9f9423-5902-4054-a436-ed3ce9e85422", null, "seller", "seller" },
                    { "f9057dd3-b004-4449-be38-1027725599db", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "71d7ff92-83d3-4def-af02-174e0360852d", null, "client", "client" },
                    { "97c94ba3-c912-42f4-9426-8554f9e3cc89", null, "admin", "admin" },
                    { "a5025e6b-3fa3-4b33-b6c1-d88edad551f7", null, "seller", "seller" }
                });
        }
    }
}
