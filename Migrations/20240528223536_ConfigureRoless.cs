using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureRoless : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bc19938-f249-495b-809f-5e3bab109fad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bafcd5b-cf84-4faf-ac0e-dc848fcdefa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ad0e0bc-63fa-455c-a486-cfd8403bfec0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a39d8324-e623-40d7-b917-37b793f4433a", null, "admin", "admin" },
                    { "ebdcb8f0-bedc-4797-8454-9d0bf2c9a95e", null, "seller", "seller" },
                    { "fe8048f0-833a-4c12-bb61-8f3d27e9cf9e", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a39d8324-e623-40d7-b917-37b793f4433a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebdcb8f0-bedc-4797-8454-9d0bf2c9a95e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe8048f0-833a-4c12-bb61-8f3d27e9cf9e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4bc19938-f249-495b-809f-5e3bab109fad", null, "seller", null },
                    { "5bafcd5b-cf84-4faf-ac0e-dc848fcdefa2", null, "client", null },
                    { "7ad0e0bc-63fa-455c-a486-cfd8403bfec0", null, "admin", "seller" }
                });
        }
    }
}
