using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f575e4-77ec-46e1-af9e-2c2f919131d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b58d085-f86a-48e5-9969-d16662fb1836");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3974d5a-2545-4b5f-a535-e408683d0aed");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "40f575e4-77ec-46e1-af9e-2c2f919131d2", null, "seller", "seller" },
                    { "6b58d085-f86a-48e5-9969-d16662fb1836", null, "admin", "admin" },
                    { "c3974d5a-2545-4b5f-a535-e408683d0aed", null, "client", "client" }
                });
        }
    }
}
