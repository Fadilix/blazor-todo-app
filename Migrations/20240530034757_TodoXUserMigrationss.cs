using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigrationss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06a56725-a39c-4e50-98ab-8a98301b7e1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb949409-4143-4dd0-a7ff-c35abae36ea3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f389a198-3ee3-492b-b527-cd23270ebad6");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "06a56725-a39c-4e50-98ab-8a98301b7e1f", null, "admin", "admin" },
                    { "eb949409-4143-4dd0-a7ff-c35abae36ea3", null, "client", "client" },
                    { "f389a198-3ee3-492b-b527-cd23270ebad6", null, "seller", "seller" }
                });
        }
    }
}
