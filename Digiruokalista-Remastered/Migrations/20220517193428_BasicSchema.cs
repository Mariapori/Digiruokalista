using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Digiruokalista_Remastered.Migrations
{
    public partial class BasicSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ravintola",
                columns: table => new
                {
                    RavintolaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nimi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    yTunnus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Puhelinnumero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ravintola", x => x.RavintolaID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kategoriat",
                columns: table => new
                {
                    KategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nimi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RavintolaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriat", x => x.KategoriaID);
                    table.ForeignKey(
                        name: "FK_Kategoriat_Ravintola_RavintolaID",
                        column: x => x.RavintolaID,
                        principalTable: "Ravintola",
                        principalColumn: "RavintolaID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ruuat",
                columns: table => new
                {
                    RuokaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnnosNro = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KategoriaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruuat", x => x.RuokaID);
                    table.ForeignKey(
                        name: "FK_Ruuat_Kategoriat_KategoriaID",
                        column: x => x.KategoriaID,
                        principalTable: "Kategoriat",
                        principalColumn: "KategoriaID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hinnat",
                columns: table => new
                {
                    HintaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Kuvaus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Summa = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    RuokaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hinnat", x => x.HintaID);
                    table.ForeignKey(
                        name: "FK_Hinnat_Ruuat_RuokaID",
                        column: x => x.RuokaID,
                        principalTable: "Ruuat",
                        principalColumn: "RuokaID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Hinnat_RuokaID",
                table: "Hinnat",
                column: "RuokaID");

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriat_RavintolaID",
                table: "Kategoriat",
                column: "RavintolaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ruuat_KategoriaID",
                table: "Ruuat",
                column: "KategoriaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hinnat");

            migrationBuilder.DropTable(
                name: "Ruuat");

            migrationBuilder.DropTable(
                name: "Kategoriat");

            migrationBuilder.DropTable(
                name: "Ravintola");
        }
    }
}
