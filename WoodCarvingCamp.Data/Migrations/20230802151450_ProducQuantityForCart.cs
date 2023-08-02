using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class ProducQuantityForCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1a35dc6-8cf2-40a8-a4f8-8da24e60aead", "AQAAAAEAACcQAAAAEFJOYDSNfrYX4fZ0EaHtr5Gv0YfbUnshQldrYzES4Wpa9no7vkkgH+5Y49iYDjGaHw==", "a341645f-00db-4310-aad5-8dc29d418071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5020a510-a8ac-472b-8fb4-e83aab91f644", "AQAAAAEAACcQAAAAELEMi+IQSRLh2R71r5fMFvYPRF/LckJ5IuVJKRqmMVN2KVVgQ3AuB0BdMc3ITsktxA==", "73ef28de-564f-4eb1-921c-5a331e6fecf8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartQuantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c56e81d-3c89-4257-b740-0a031b947c98", "AQAAAAEAACcQAAAAEN22mHcrO94Zx487Y/ltdR8HzGExGY82y+rYIy9Yvp4ZL+8Q1LIUkupQosyB9qjORg==", "17a65028-0858-45c9-9c38-7bccbdec6bb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64a60bd4-798b-49bd-a79f-87a46a08d049", "AQAAAAEAACcQAAAAEIlQjOYKzakDYbqEXum94PPNbs3Gt1Nou7AqCgSX4HlQl7lqnwaypCjXCCLh0a3b3Q==", "7c3442fa-669d-4058-803d-b6433c955042" });
        }
    }
}
