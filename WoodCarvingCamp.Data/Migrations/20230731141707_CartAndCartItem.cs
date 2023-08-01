using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class CartAndCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("43bc0bd0-c88b-4dcf-9b06-28f3d15e1547"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9da6c903-33ba-4fd5-bb73-cee3c4b45613"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("65bd5b19-44f4-425f-87d4-bf89a717c77d"), 0, "fadb5cd2-9381-4c93-b83a-f0a2dfccc22d", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAENSSzAvFSFLFvEWDx8qhTK4I7lkIFnu24s+JhM26b1jhfOe/Uw5c2QGRI5qwDiH5Dw==", null, false, "7bad4028-1cc4-46e5-acb7-cbebd522d2b6", false, "stefcho@abv.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f17ac982-58c0-4b84-83c1-0c43ddde3811"), 0, "2a144983-a5a8-42df-bd73-fe2f37a19095", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEB50CZVorf282oM3Ia3ev+wZRmA8y/EeDO5ZuXqbjWWSDqhAUUxlJ5txxQLpHS7kcQ==", null, false, "bbd09118-ea12-4e0b-b6e0-47b099c8d81b", false, "admin@woodcarvingcamp.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("65bd5b19-44f4-425f-87d4-bf89a717c77d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f17ac982-58c0-4b84-83c1-0c43ddde3811"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("43bc0bd0-c88b-4dcf-9b06-28f3d15e1547"), 0, "cb0d8939-d094-47db-be86-3165a46587b1", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEBeD5vQG9FpTf6QKLyQhyYK4TnslLf6vfU7QgF/NYxWHw/ZbLaPYo0cwae9JEgdP4w==", null, false, "08e93d7c-e97b-48eb-8c1c-a23c8ab00bbd", false, "stefcho@abv.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9da6c903-33ba-4fd5-bb73-cee3c4b45613"), 0, "bbc7639f-3602-41a9-b79e-55b738cd2062", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEBfCboqTz3pdxayJNwPsDgPET0SfPYbRqnjx0GoiXnTyTu+LeFqlEjeUW7PGuJD+zQ==", null, false, "61c82727-2b58-432e-bf11-a9f646444d66", false, "admin@woodcarvingcamp.bg" });
        }
    }
}
