using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigration_ç_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07f96bd9-f937-4867-9af3-e8abd31ba3b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88ecbcff-9cfc-4054-bbae-2be980427480");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bae1a1da-5b3d-4c31-939b-c87f43f184d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3614eea2-5d80-4cf1-b61a-30a1dd6a8ba0", null, "admin", "admin" },
                    { "936b082d-6f43-44d6-b026-00a875f7d370", null, "seller", "seller" },
                    { "a8279053-d9f8-4312-8d2a-9a46c6770cb7", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3614eea2-5d80-4cf1-b61a-30a1dd6a8ba0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "936b082d-6f43-44d6-b026-00a875f7d370");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8279053-d9f8-4312-8d2a-9a46c6770cb7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07f96bd9-f937-4867-9af3-e8abd31ba3b9", null, "seller", "seller" },
                    { "88ecbcff-9cfc-4054-bbae-2be980427480", null, "client", "client" },
                    { "bae1a1da-5b3d-4c31-939b-c87f43f184d8", null, "admin", "admin" }
                });
        }
    }
}
