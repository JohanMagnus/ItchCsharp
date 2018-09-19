using Microsoft.EntityFrameworkCore.Migrations;

namespace Samuraj.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "Battle",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Battle",
                newName: "BattleId");
        }
    }
}
