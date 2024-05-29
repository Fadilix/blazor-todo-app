using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
