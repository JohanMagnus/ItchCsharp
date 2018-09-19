using Microsoft.EntityFrameworkCore.Migrations;

namespace Fruits.Migrations
{
    public partial class AddedColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "fruits1",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "fruits1");
        }
    }
}
