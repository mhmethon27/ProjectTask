using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blog2.Migrations
{
    public partial class ml : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "comments",
                newName: "UserName");

            migrationBuilder.AlterColumn<int>(
                name: "islike",
                table: "comments",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "isdislike",
                table: "comments",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "comments");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "comments",
                newName: "UserId");

            migrationBuilder.AlterColumn<bool>(
                name: "islike",
                table: "comments",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "isdislike",
                table: "comments",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
