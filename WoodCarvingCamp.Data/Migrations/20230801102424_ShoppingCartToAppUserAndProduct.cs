using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class ShoppingCartToAppUserAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31908d04-7a29-45d7-ae3c-49875b2940dd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7ba15b7-7d94-4609-844f-0d1156ad1201"));

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductShoppingCart",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShoppingCart", x => new { x.ProductsId, x.ShoppingCartId });
                    table.ForeignKey(
                        name: "FK_ProductShoppingCart_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductShoppingCart_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("090c3c5d-f3b2-488a-9849-c64403080049"), 0, "9c385dd9-4c81-4f6e-ae8a-1daa27806770", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAELIbdhG37Na2nlYFjPksREzawdrB3hH77EtuciHowgeoBW8oUuxUDNy+OlM8R5aV+g==", null, false, "415115c8-e8b5-43b1-8df7-0ca404122531", null, false, "admin@woodcarvingcamp.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a94e657b-7745-41f0-9097-6e9a7d722e1c"), 0, "3eff63e5-4c95-448d-b15a-f04373bbffd5", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEA3cZkGYcEY7NGCIZZumZg2b0F4nnWTIrdBpAGNOsTGERoAlWi5MAHu7l9z0jd7t+w==", null, false, "c8aa40be-5df5-453b-bd0f-05aceb486572", null, false, "stefcho@abv.bg" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShoppingCartId",
                table: "AspNetUsers",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShoppingCart_ShoppingCartId",
                table: "ProductShoppingCart",
                column: "ShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartId",
                table: "AspNetUsers",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShoppingCarts_ShoppingCartId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProductShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ShoppingCartId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("090c3c5d-f3b2-488a-9849-c64403080049"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a94e657b-7745-41f0-9097-6e9a7d722e1c"));

            migrationBuilder.DropColumn(
                name: "ShoppingCartId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("31908d04-7a29-45d7-ae3c-49875b2940dd"), 0, "3249bd0f-0156-4d50-9f44-ebea73ac910c", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEPU95xSoCdk1zMkEtZr6M5PTb041gnIUqwLEEKe+HozpodaPLwoJBK5ePTm/pfys8g==", null, false, "c504e1b4-ddf6-4f29-b826-1e1fa7c01991", false, "admin@woodcarvingcamp.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d7ba15b7-7d94-4609-844f-0d1156ad1201"), 0, "dcbd075d-afbd-4174-be52-95bc644d6138", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEDmHjCluMMHhc/I2RW4DlZMqgn46rh7Ban3Hu3qSxKfNfJyUepQNOc+J7DO6E1vFZA==", null, false, "6b52af31-2c77-4ece-8ad4-023927949ff9", false, "stefcho@abv.bg" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId");
        }
    }
}
