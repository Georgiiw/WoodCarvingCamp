using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class SeedingCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2917cc5-f7df-4fd7-98a0-efeba8a0774a", "AQAAAAEAACcQAAAAEK6Av47R78fC1U3C2ZGO7/FEhes8xxL5uJpIm62Fg5WK6qmg2Z9hzAfhD3+ZUE9K3A==", "8b57d055-bd02-44d2-afcc-4a7d826c778d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3816073e-e50b-4496-9458-3f7fda6e8f28", "AQAAAAEAACcQAAAAEKDo6oc9Haxg7ieC2GWLv5s0TSJBObKaaIuYkUvw5YLUZiJ4rdbReFmfIK0+wFgg8A==", "f72db24c-7e73-429a-b7c8-1c18ff521172" });

            migrationBuilder.InsertData(
                table: "CarvingCourses",
                columns: new[] { "Id", "AddedOn", "ApplicationUserId", "Description", "ImageUrl", "IsPaid", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 11, 19, 20, 51, 753, DateTimeKind.Utc).AddTicks(1250), null, "Learn how to carve curved snake", "/images/CourseImages/Snake carving course.png", true, "Snake carving course", 19.99m },
                    { 2, new DateTime(2023, 8, 11, 19, 20, 51, 753, DateTimeKind.Utc).AddTicks(1290), null, "Learn how to carve wooden mini statues", "/images/CourseImages/WoodenMiniStatues.png", false, "Mini statues carving course", null }
                });

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "GalleryPhotos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2623), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2647), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2672), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2678), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 8, 11, 22, 20, 51, 753, DateTimeKind.Local).AddTicks(2693) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarvingCourses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarvingCourses",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
