using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class comments_1to1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d592925-ed66-4c1a-9a58-c133582a7734");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0ff819c-b0ee-4517-a2b1-c141aa1e4385");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "comments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "118dee71-3567-4dc3-8be2-35a4c176a105", null, "Admin", "ADMIN" },
                    { "7a5b8b28-735e-4b98-b73c-35c3d5baaf4c", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_AppUserId",
                table: "comments",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_AspNetUsers_AppUserId",
                table: "comments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_AspNetUsers_AppUserId",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_AppUserId",
                table: "comments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "118dee71-3567-4dc3-8be2-35a4c176a105");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5b8b28-735e-4b98-b73c-35c3d5baaf4c");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d592925-ed66-4c1a-9a58-c133582a7734", null, "Admin", "ADMIN" },
                    { "b0ff819c-b0ee-4517-a2b1-c141aa1e4385", null, "User", "USER" }
                });
        }
    }
}
