using Microsoft.EntityFrameworkCore.Migrations;

namespace Utilisation.Migrations
{
    public partial class AddDataSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Film");
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Annee = table.Column<int>(nullable: false),
                    ActeurPrincipal = table.Column<string>(maxLength: 100, nullable: false),
                    Genre = table.Column<string>(maxLength: 30, nullable: false),
                    Realisateur = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmId", "ActeurPrincipal", "Annee", "Genre", "Realisateur", "Titre" },
                values: new object[,]
                {
                    { 1, "Mark Hammil", 1977, "Science-Fiction", "Georges Lucas", "Star Wars : Un nouvel espoir" },
                    { 2, "Mark Hammil", 1980, "Science-Fiction", "Georges Lucas", "Star Wars : L'empire contre-attaque" },
                    { 3, "Mark Hammil", 1983, "Science-Fiction", "Georges Lucas", "Star Wars : Le retour du Jedi" },
                    { 4, "Charlie Hunnam", 2005, "Société", "Lexi Alexander", "Hooligans" },
                    { 5, "Elijah Wood", 2001, "Heroic-Fantasy", "Peter Jackson", "LOTR - La communauté de l'anneau" },
                    { 6, "Elijah Wood", 2002, "Heroic-Fantasy", "Peter Jackson", "LOTR - Les deux tours" },
                    { 7, "Elijah Wood", 2003, "Heroic-Fantasy", "Peter Jackson", "LOTR - Le retour du roi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
