using Microsoft.EntityFrameworkCore.Migrations;

namespace Samuraj.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Start",
                table: "Battle",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "End",
                table: "Battle",
                newName: "EndDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Battle",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Battle",
                newName: "End");
        }
    }
}
