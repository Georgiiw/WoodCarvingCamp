using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class PhotoIdToComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45342d0c-ee45-49a9-881d-b72c33b1991c", "AQAAAAEAACcQAAAAEH3DEkYIk31DEwuA0m5bDobX7DG1fxiIzKz545DuxV/y5wTgb1bgOvW/fjjzK+MHBQ==", "d9a48a55-2c8c-465e-aa74-f48e62703ae9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce258bd0-4edd-4404-aa60-aafcbddd3962", "AQAAAAEAACcQAAAAEAS1ZkQ6LJBRXWmD3Iyn/rwfrudX6YV+dqh+CNkkOdnCl3t6/3Dajynt1fCxuGttHw==", "9cba314d-4196-4879-bfe2-0d54c0f3229f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Comments");

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
        }
    }
}
