using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupProjectEventAndMediaHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateedApplicationDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Photos_PhotoId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_users_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_users_UsersUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_categories_CategoryId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_users_UserId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_Events_UsersUserId",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Photos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotoId1",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CategoryId1",
                table: "Photos",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizerId",
                table: "Events",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_PhotoId1",
                table: "Carts",
                column: "PhotoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Photos_PhotoId",
                table: "Carts",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Photos_PhotoId1",
                table: "Carts",
                column: "PhotoId1",
                principalTable: "Photos",
                principalColumn: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_OrganizerId",
                table: "Events",
                column: "OrganizerId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Categories_CategoryId",
                table: "Photos",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Categories_CategoryId1",
                table: "Photos",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Users_UserId",
                table: "Photos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Photos_PhotoId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Photos_PhotoId1",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_OrganizerId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Categories_CategoryId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Categories_CategoryId1",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Users_UserId",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Photos_CategoryId1",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Events_OrganizerId",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Carts_PhotoId1",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "PhotoId1",
                table: "Carts");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UsersUserId",
                table: "Events",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Photos_PhotoId",
                table: "Carts",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_users_UsersUserId",
                table: "Events",
                column: "UsersUserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_categories_CategoryId",
                table: "Photos",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_users_UserId",
                table: "Photos",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
