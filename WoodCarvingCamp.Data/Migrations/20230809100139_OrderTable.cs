using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class OrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4634865-1cad-4c44-a2d4-2722fdeabc33", "AQAAAAEAACcQAAAAEFLrgY3xccVJBNWW7QwmCJScuSkY7VguAcWBVP4Hy7tx/8zZU/sYyXRiAck0r06YCg==", "0ee3d05a-45bf-419f-833b-32ac600b389a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15b3085c-0546-44b2-aedd-166121873ad1", "AQAAAAEAACcQAAAAEPV6+0zsE/GnO4K22f1iJvb6ylhDznf1YvgOsJvTMHklJLpQpiNzz+Hq9McBtzHdJA==", "144abb6e-623e-4af6-8b22-053cf272411f" });

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 13, 1, 38, 568, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 13, 1, 38, 568, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 9, 13, 1, 38, 568, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 568, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 8, 9, 13, 1, 38, 568, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(1), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(10), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(31), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(41), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(51), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImageUrl", "Name", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(59), "/Images/ShopImages/Tools Storage.jpg", "Tools Storage", new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(72), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_OrderId",
                table: "CartItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Orders_OrderId",
                table: "CartItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Orders_OrderId",
                table: "CartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_OrderId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "CartItems");

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

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7674), new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7679), new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7685), new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7693), new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7698), new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7704), new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImageUrl", "Name", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7709), "/Images/ShopImages/Gloves two.jpg", "Tools Storage.jpg", new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 8, 8, 21, 4, 5, 497, DateTimeKind.Local).AddTicks(7725) });
        }
    }
}
