using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class AdminAndUserSetIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("090c3c5d-f3b2-488a-9849-c64403080049"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a94e657b-7745-41f0-9097-6e9a7d722e1c"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"), 0, "2c56e81d-3c89-4257-b740-0a031b947c98", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEN22mHcrO94Zx487Y/ltdR8HzGExGY82y+rYIy9Yvp4ZL+8Q1LIUkupQosyB9qjORg==", null, false, "17a65028-0858-45c9-9c38-7bccbdec6bb3", null, false, "stefcho@abv.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"), 0, "64a60bd4-798b-49bd-a79f-87a46a08d049", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEIlQjOYKzakDYbqEXum94PPNbs3Gt1Nou7AqCgSX4HlQl7lqnwaypCjXCCLh0a3b3Q==", null, false, "7c3442fa-669d-4058-803d-b6433c955042", null, false, "admin@woodcarvingcamp.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("090c3c5d-f3b2-488a-9849-c64403080049"), 0, "9c385dd9-4c81-4f6e-ae8a-1daa27806770", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAELIbdhG37Na2nlYFjPksREzawdrB3hH77EtuciHowgeoBW8oUuxUDNy+OlM8R5aV+g==", null, false, "415115c8-e8b5-43b1-8df7-0ca404122531", null, false, "admin@woodcarvingcamp.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShoppingCartId", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a94e657b-7745-41f0-9097-6e9a7d722e1c"), 0, "3eff63e5-4c95-448d-b15a-f04373bbffd5", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEA3cZkGYcEY7NGCIZZumZg2b0F4nnWTIrdBpAGNOsTGERoAlWi5MAHu7l9z0jd7t+w==", null, false, "c8aa40be-5df5-453b-bd0f-05aceb486572", null, false, "stefcho@abv.bg" });
        }
    }
}
