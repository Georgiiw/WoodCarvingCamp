using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    public partial class PhotoIdChangedToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhotoId",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhotoId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
