using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigration_ç_èfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todo_AspNetUsers_IdUser",
                table: "todo");

            migrationBuilder.DropIndex(
                name: "IX_todo_IdUser",
                table: "todo");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f874acc-6f0e-40f4-bce5-1cf05bd5afb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c0dda9-d781-4edd-83d6-122a5470d2f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de85c08e-b5be-4a1c-8466-16d9880e580a");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "todo");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "todo",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b48b280c-5488-4614-8cc0-3aaf82fc21f1", null, "client", "client" },
                    { "f72ade57-8bae-4b49-b768-5f61cd5cf9b3", null, "seller", "seller" },
                    { "fd37ecca-75d6-45d5-aa15-59a56a8df3a7", null, "admin", "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_todo_user_id",
                table: "todo",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_todo_AspNetUsers_user_id",
                table: "todo",
                column: "user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todo_AspNetUsers_user_id",
                table: "todo");

            migrationBuilder.DropIndex(
                name: "IX_todo_user_id",
                table: "todo");

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

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "todo",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "todo",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f874acc-6f0e-40f4-bce5-1cf05bd5afb4", null, "admin", "admin" },
                    { "d0c0dda9-d781-4edd-83d6-122a5470d2f2", null, "client", "client" },
                    { "de85c08e-b5be-4a1c-8466-16d9880e580a", null, "seller", "seller" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_todo_IdUser",
                table: "todo",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_todo_AspNetUsers_IdUser",
                table: "todo",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
