using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digiruokalista_Remastered.Migrations
{
    public partial class RavintolanOmistaja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KayttajaID",
                table: "Ravintola",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KayttajaID",
                table: "Ravintola");
        }
    }
}
