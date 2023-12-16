using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryProject.Migrations
{
    public partial class addingCoverImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "coverImage",
                table: "CD",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "coverImage",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "coverImage",
                table: "CD");

            migrationBuilder.DropColumn(
                name: "coverImage",
                table: "Book");
        }
    }
}
