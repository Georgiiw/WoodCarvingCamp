using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class CartItemShoppingCartIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new Guid("31908d04-7a29-45d7-ae3c-49875b2940dd"), 0, "3249bd0f-0156-4d50-9f44-ebea73ac910c", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEPU95xSoCdk1zMkEtZr6M5PTb041gnIUqwLEEKe+HozpodaPLwoJBK5ePTm/pfys8g==", null, false, "c504e1b4-ddf6-4f29-b826-1e1fa7c01991", false, "admin@woodcarvingcamp.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d7ba15b7-7d94-4609-844f-0d1156ad1201"), 0, "dcbd075d-afbd-4174-be52-95bc644d6138", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEDmHjCluMMHhc/I2RW4DlZMqgn46rh7Ban3Hu3qSxKfNfJyUepQNOc+J7DO6E1vFZA==", null, false, "6b52af31-2c77-4ece-8ad4-023927949ff9", false, "stefcho@abv.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31908d04-7a29-45d7-ae3c-49875b2940dd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7ba15b7-7d94-4609-844f-0d1156ad1201"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("30740afc-25b0-492b-b8c5-3a5078d450de"), 0, "88635b9e-905e-44ca-b40d-a2ab9963c80e", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEMgXP05KsHvKA4rP79tx9DC1khurTGlrfaau03AosV33Z+WIDQdOUO1ouSoWlliRCg==", null, false, "08b60dd0-4c79-420e-abd5-e44421cb8990", false, "admin@woodcarvingcamp.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9f3456f9-8913-4d88-8fba-8f9e77a252de"), 0, "a5e18295-faa2-4be6-9822-6070e6a3e10b", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEFpvBncUWY7Ez1zBzGFNILH9kRNh5tdW5DwxxIeCjMRv8BlXSZoz/7sMIf0vHgVs6Q==", null, false, "650db66f-3815-42a7-b115-1c6fd480b17e", false, "stefcho@abv.bg" });
        }
    }
}
