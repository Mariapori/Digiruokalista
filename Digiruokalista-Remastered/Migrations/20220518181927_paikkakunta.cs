using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digiruokalista_Remastered.Migrations
{
    public partial class paikkakunta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Paikkakunta",
                table: "Ravintola",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paikkakunta",
                table: "Ravintola");
        }
    }
}
