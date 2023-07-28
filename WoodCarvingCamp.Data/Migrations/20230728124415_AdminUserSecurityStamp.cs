using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class AdminUserSecurityStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5a130b21-0e15-47a1-ad91-9c91b6f9aa88"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cd54a44e-7b8e-4bf1-a21a-5c65c375b149"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("43bc0bd0-c88b-4dcf-9b06-28f3d15e1547"), 0, "cb0d8939-d094-47db-be86-3165a46587b1", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEBeD5vQG9FpTf6QKLyQhyYK4TnslLf6vfU7QgF/NYxWHw/ZbLaPYo0cwae9JEgdP4w==", null, false, "08e93d7c-e97b-48eb-8c1c-a23c8ab00bbd", false, "stefcho@abv.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9da6c903-33ba-4fd5-bb73-cee3c4b45613"), 0, "bbc7639f-3602-41a9-b79e-55b738cd2062", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEBfCboqTz3pdxayJNwPsDgPET0SfPYbRqnjx0GoiXnTyTu+LeFqlEjeUW7PGuJD+zQ==", null, false, "61c82727-2b58-432e-bf11-a9f646444d66", false, "admin@woodcarvingcamp.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("5a130b21-0e15-47a1-ad91-9c91b6f9aa88"), 0, "976e4204-1dc5-4c70-8704-0690fa113188", "stefcho@abv.bg", false, "Stefcho", "Stefanov", false, null, "stefcho@abv.bg", "stefcho@abv.bg", "AQAAAAEAACcQAAAAEK5CkNPBO0UXyM3eTdQnImJVI7YVAl2ml8nMw5yjSW1ZGw+BzEF4kvgyV0/k1IEm/g==", null, false, null, false, "stefcho@abv.bg" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cd54a44e-7b8e-4bf1-a21a-5c65c375b149"), 0, "959feb1b-94e0-4c72-b938-99ef3ccba596", "admin@woodcarvingcamp.bg", false, "Admin", "Adminov", false, null, "admin@woodcarvingcamp.bg", "admin@woodcarvingcamp.bg", "AQAAAAEAACcQAAAAEJQwxe0jhLFzp9e/yRoQSnn4ljvV4EEpiQzfTRk5hHeklT+y6v7LU9SHwPdSHCBwSQ==", null, false, null, false, "admin@woodcarvingcamp.bg" });
        }
    }
}
