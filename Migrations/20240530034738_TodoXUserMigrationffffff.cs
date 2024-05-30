using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationffffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "450cc79d-14c4-4937-9a18-22b3a8148877", null, "client", "client" },
                    { "7f0a7f1f-d3da-4df4-8fcd-7e4ff8305819", null, "admin", "admin" },
                    { "b517b8da-c2b2-4e3d-babf-e3e9d04d90a1", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "56c5f9f6-d4dd-413e-8735-e6fc0917986c", null, "client", "client" },
                    { "a7551412-7146-42e4-8451-c5d04e984dc3", null, "seller", "seller" },
                    { "d3f34ace-93a1-40c6-a152-5b9ae5347d75", null, "admin", "admin" }
                });
        }
    }
}
