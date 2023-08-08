using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class ProductsAndGalleryPhotosSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9048b446-567a-43c8-8e53-13e4e3c22416", "AQAAAAEAACcQAAAAEM6bL43c56df6qqvfgYztkRu/I6civYYFR7mD/GNIW8xdNCSsfSgWhUIAtocXF+9/w==", "7e2fc50a-33c0-409b-a3c8-f71afcb19246" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "534f21d4-5665-4e1f-835b-b0029ac55a8d", "AQAAAAEAACcQAAAAEL1nTYQOoMNm6ROHIB2DflJ/Wc0ZmpaplEVJ+SDYnETtYmJpVQGPJgKz/CjF2O0Jtg==", "fae8e72a-be35-4e51-9f14-1cd67c75807f" });

            migrationBuilder.InsertData(
                table: "GalleryPhotos",
                columns: new[] { "Id", "CreatedOn", "Description", "ImageUrl" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7369), "Beautiful flower carved in wood.", "/images/GalleryImages/flower carved in wood.jpeg" },
                    { 2, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7426), "Jesus Face - Just Extraordinary.", "/images/GalleryImages/Jesus Face.jpeg" },
                    { 3, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7430), "Owl - Amazing work.", "/images/GalleryImages/Owl.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "ImageUrl", "Name", "Price", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7660), "Woodworking chisels range from small hand tools for tiny details, to large chisels used to remove big sections of wood, in 'roughing out' the shape of a pattern or design.", "/Images/ShopImages/Chisel one.jpg", "5 Piece - Set Starter - Carving Chisels", 49.99m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7665) },
                    { 2, 2, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7674), "Hook Carving Knife good for carcing spoons or making special details on your special projects", "/Images/ShopImages/Knife one.jpg", "Hook Carving Knife", 15.99m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7676) },
                    { 3, 2, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7679), "Set of four knife made to help you carve your perfect project!", "/Images/ShopImages/Knife two.jpg", "Hook Carving Knifes Set", 45.99m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7681) },
                    { 4, 2, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7685), "The one knife you need the most - the basic carving knife to start your journey!", "/Images/ShopImages/Knife three.jpg", "Carving Knife", 9.99m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7687) },
                    { 5, 1, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7693), "Set of four knife made to help you carve your perfect project!", "/Images/ShopImages/Chisel two.jpg", "Small Carving Chisel For Wood Carving", 9.99m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7695) },
                    { 6, 3, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7698), "Really good gloves to avoid accidentally cuts and injuries!", "/Images/ShopImages/Gloves one.jpg", "Level 6a Resistant Cut Gloves", 20.00m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7701) },
                    { 7, 3, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7704), "Really good gloves to avoid accidentally cuts and injuries!", "/Images/ShopImages/Gloves two.jpg", "Wood Carving Gloves", 15.49m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7706) },
                    { 8, 5, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7709), "Tools storage to store your knifes, chisels and other accessories!", "/Images/ShopImages/Tools Storage.jpg", "Tools Storage", 30.49m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7711) },
                    { 9, 4, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7722), "Kepp your knifes sharp to make shure you have the perfect expirince while doing your projects!", "/Images/ShopImages/Sharpening stone.jpg", "Sharpening stone", 30.49m, new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7725) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d363fb87-6d30-4576-a9f9-0c7a86ca8541", "AQAAAAEAACcQAAAAED9PNOB1sKooyrb2jajplfRBuho5H8sCO//I0A2oPhv7u2sj60VPOMo8LaWicpuq1w==", "71c4ec70-4a9d-4f8c-bae4-4510ef4cc9b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2254ea8d-c0bb-4f95-926f-613caee8d968", "AQAAAAEAACcQAAAAEIRaqw8oN4LGf8VUAy5FpMQ93QWIREXQP//wb2hrk4SjagLRrdtrpvjZ9oj9iKg2Sw==", "3539617e-92f4-4365-b49e-dac6910e7645" });
        }
    }
}
