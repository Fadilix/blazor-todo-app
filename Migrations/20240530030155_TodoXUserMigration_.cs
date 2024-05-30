using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorTodoApp.Migrations
{
    /// <inheritdoc />
    public partial class TodoXUserMigration_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "todo",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07f96bd9-f937-4867-9af3-e8abd31ba3b9", null, "seller", "seller" },
                    { "88ecbcff-9cfc-4054-bbae-2be980427480", null, "client", "client" },
                    { "bae1a1da-5b3d-4c31-939b-c87f43f184d8", null, "admin", "admin" }
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
                keyValue: "07f96bd9-f937-4867-9af3-e8abd31ba3b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88ecbcff-9cfc-4054-bbae-2be980427480");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bae1a1da-5b3d-4c31-939b-c87f43f184d8");

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "todo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "todo",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

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
    }
}
