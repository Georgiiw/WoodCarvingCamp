using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class CommentCreatorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "832851a2-dc4f-4bec-8031-68b3371cb62a", "AQAAAAEAACcQAAAAENvY3p2tuWYxTqa3fyMb6IJYtzc4KUiQiGFX+OaQ4LetAA1SgUMUe5xUEPyhMi2akg==", "3fc137ec-aa78-4d81-9b78-193b45bd5b45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00f9ec33-7f73-40a8-bab0-18659665dd64", "AQAAAAEAACcQAAAAEFSbGPkaaU2/Q17LrYE08l1mNZiJuQDIgMImWBfBiOHuiE+j3gTzACyYCr5vbQzWSQ==", "7ec2f125-6e78-4195-a217-c6711179c55c" });

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(257), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(275), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(289), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(308), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(314), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(322), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(334), new DateTime(2023, 8, 10, 17, 12, 11, 666, DateTimeKind.Local).AddTicks(337) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorName",
                table: "Comments");

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
                column: "CreatedOn",
                value: new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9198));

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
    }
}
