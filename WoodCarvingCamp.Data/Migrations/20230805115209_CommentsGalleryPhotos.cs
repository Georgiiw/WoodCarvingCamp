using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class CommentsGalleryPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_GalleryPhotos_GalleryPhotoId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_GalleryPhotoId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "GalleryPhotoId",
                table: "Comments");

            migrationBuilder.CreateTable(
                name: "CommentGalleryPhoto",
                columns: table => new
                {
                    CommentsId = table.Column<int>(type: "int", nullable: false),
                    GalleryPhotosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentGalleryPhoto", x => new { x.CommentsId, x.GalleryPhotosId });
                    table.ForeignKey(
                        name: "FK_CommentGalleryPhoto_Comments_CommentsId",
                        column: x => x.CommentsId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentGalleryPhoto_GalleryPhotos_GalleryPhotosId",
                        column: x => x.GalleryPhotosId,
                        principalTable: "GalleryPhotos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2f3f8ac-5e37-4fbf-820d-b25f26dc0f02", "AQAAAAEAACcQAAAAEJ2/ZI01HKiZVcqkMJNNIR2HarzuMOKgyY0oD969uCge3p5QRQCDipqU+IH4hz00Sg==", "53d9f0be-1b15-4bc7-b067-6a47d494001d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5faef4fa-31f8-4725-901e-a799f022d6eb", "AQAAAAEAACcQAAAAEIlNhUZFoNGKOsxc0NX0OUPwNb/fZZAhPY+Erly/HQZ88k7lqsi8AJLEiiRfY9CVrg==", "befe4257-dfe4-477b-8990-bb6756ce01f1" });

            migrationBuilder.CreateIndex(
                name: "IX_CommentGalleryPhoto_GalleryPhotosId",
                table: "CommentGalleryPhoto",
                column: "GalleryPhotosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentGalleryPhoto");

            migrationBuilder.AddColumn<int>(
                name: "GalleryPhotoId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90a7def5-78e4-4763-a888-d1129664c6b6", "AQAAAAEAACcQAAAAEOFBqY/MYyqPXGEXr9Vb9MfOQI14J+cSlPaUwvhbYZSNVSaV/G0KH5sdIYxQZG7/Mg==", "3ef729f8-31d8-4da7-bbe9-69d6baaba577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5dce86a-7a5a-443c-8d14-a7ec2757e068", "AQAAAAEAACcQAAAAEOtvVlOlR4MMRocWxGqWuCwd8XegD9IY3ieDNLMtf5u63Ce3Zu75ng3WKbru3nNEJQ==", "c75639b0-a5cb-41d9-9a1c-e996a05f70c4" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GalleryPhotoId",
                table: "Comments",
                column: "GalleryPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_GalleryPhotos_GalleryPhotoId",
                table: "Comments",
                column: "GalleryPhotoId",
                principalTable: "GalleryPhotos",
                principalColumn: "Id");
        }
    }
}
