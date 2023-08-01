using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class AddCartAndCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("65bd5b19-44f4-425f-87d4-bf89a717c77d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f17ac982-58c0-4b84-83c1-0c43ddde3811"));

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
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
                values: new object[] { new Guid("30740afc-25b0-492b-b8c5-3a5078d450de"), 0, "88635b9e-905e-44ca-b40d-a2ab9963c80e", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEMgXP05KsHvKA4rP79tx9DC1khurTGlrfaau03AosV33Z+WIDQdOUO1ouSoWlliRCg==", null, false, "08b60dd0-4c79-420e-abd5-e44421cb8990", false, "admin@woodcarvingcamp.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9f3456f9-8913-4d88-8fba-8f9e77a252de"), 0, "a5e18295-faa2-4be6-9822-6070e6a3e10b", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEFpvBncUWY7Ez1zBzGFNILH9kRNh5tdW5DwxxIeCjMRv8BlXSZoz/7sMIf0vHgVs6Q==", null, false, "650db66f-3815-42a7-b115-1c6fd480b17e", false, "stefcho@abv.bg" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30740afc-25b0-492b-b8c5-3a5078d450de"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f3456f9-8913-4d88-8fba-8f9e77a252de"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("65bd5b19-44f4-425f-87d4-bf89a717c77d"), 0, "fadb5cd2-9381-4c93-b83a-f0a2dfccc22d", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAENSSzAvFSFLFvEWDx8qhTK4I7lkIFnu24s+JhM26b1jhfOe/Uw5c2QGRI5qwDiH5Dw==", null, false, "7bad4028-1cc4-46e5-acb7-cbebd522d2b6", false, "stefcho@abv.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f17ac982-58c0-4b84-83c1-0c43ddde3811"), 0, "2a144983-a5a8-42df-bd73-fe2f37a19095", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEB50CZVorf282oM3Ia3ev+wZRmA8y/EeDO5ZuXqbjWWSDqhAUUxlJ5txxQLpHS7kcQ==", null, false, "bbd09118-ea12-4e0b-b6e0-47b099c8d81b", false, "admin@woodcarvingcamp.bg" });
        }
    }
}
