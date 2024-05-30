using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "531ecb7c-5df3-4dd8-88b9-679c3ac69ed3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e97f46d-05c4-4b60-a329-a6716183d579");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "964bb3b1-ddb6-4867-9521-95752afa739a");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "531ecb7c-5df3-4dd8-88b9-679c3ac69ed3", null, "seller", "seller" },
                    { "7e97f46d-05c4-4b60-a329-a6716183d579", null, "client", "client" },
                    { "964bb3b1-ddb6-4867-9521-95752afa739a", null, "admin", "admin" }
                });
        }
    }
}
