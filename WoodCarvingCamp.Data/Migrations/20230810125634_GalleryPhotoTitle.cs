using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class GalleryPhotoTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "GalleryPhotos",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d192385-ea84-4622-8b63-306cf3c2fe6a", "AQAAAAEAACcQAAAAECusDS7shjRFtEd6VyZEncr9V3OKfzPOgZaXQj2oHCvb1Iup5VObj2HjSWOn+enCpw==", "9c7145e5-d5a0-418c-a347-d7647153710c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c730c5-c396-4bdc-a7f9-471f0ac919c6", "AQAAAAEAACcQAAAAEPSei9MiLXXJ1VWT/GDcVM5JalMSfYs4fETx0UGQHg1hCN9S5qqsHT84aHshnaNDqw==", "0a64a102-2c20-4e86-8ad1-2427adb983f8" });

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Title" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9146), "Beautiful flower carved in wood." });

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Title" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9194), "Jesus Face - Just Extraordinary." });

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Title" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9198), "Owl - Amazing work." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9357), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9369), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9375), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9389), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9395), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9400), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9405), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9413), new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9415) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "GalleryPhotos");

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
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(59), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(72), new DateTime(2023, 8, 9, 13, 1, 38, 569, DateTimeKind.Local).AddTicks(75) });
        }
    }
}
