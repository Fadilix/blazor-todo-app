using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cff2723-d245-4dde-a7d8-17d26194289e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba03c349-81a6-4199-9793-1800e0c9eec4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf9f2182-549b-4542-ad20-4b7d62d13d37");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "todo",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "todo",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "todo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ee83cdf-773c-4667-9ac2-44110f1606c8", null, "admin", "admin" },
                    { "5d9d2610-0052-49a2-895e-838ebd31205d", null, "client", "client" },
                    { "c266a8c7-3697-40ab-9945-ec459354ae5c", null, "seller", "seller" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_todo_UserId1",
                table: "todo",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_todo_AspNetUsers_UserId1",
                table: "todo",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todo_AspNetUsers_UserId1",
                table: "todo");

            migrationBuilder.DropIndex(
                name: "IX_todo_UserId1",
                table: "todo");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee83cdf-773c-4667-9ac2-44110f1606c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d9d2610-0052-49a2-895e-838ebd31205d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c266a8c7-3697-40ab-9945-ec459354ae5c");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "todo");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "todo");

            migrationBuilder.UpdateData(
                table: "todo",
                keyColumn: "description",
                keyValue: null,
                column: "description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "todo",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1cff2723-d245-4dde-a7d8-17d26194289e", null, "client", "client" },
                    { "ba03c349-81a6-4199-9793-1800e0c9eec4", null, "admin", "admin" },
                    { "bf9f2182-549b-4542-ad20-4b7d62d13d37", null, "seller", "seller" }
                });
        }
    }
}
