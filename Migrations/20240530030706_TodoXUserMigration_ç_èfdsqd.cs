using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigration_ç_èfdsqd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b48b280c-5488-4614-8cc0-3aaf82fc21f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f72ade57-8bae-4b49-b768-5f61cd5cf9b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd37ecca-75d6-45d5-aa15-59a56a8df3a7");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "b48b280c-5488-4614-8cc0-3aaf82fc21f1", null, "client", "client" },
                    { "f72ade57-8bae-4b49-b768-5f61cd5cf9b3", null, "seller", "seller" },
                    { "fd37ecca-75d6-45d5-aa15-59a56a8df3a7", null, "admin", "admin" }
                });
        }
    }
}
