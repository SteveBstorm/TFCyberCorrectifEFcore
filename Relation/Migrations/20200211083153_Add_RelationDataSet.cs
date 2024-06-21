using Microsoft.EntityFrameworkCore.Migrations;

namespace Relation.Migrations
{
    public partial class Add_RelationDataSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    PersonneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.PersonneId);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Annee = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(maxLength: 30, nullable: false),
                    PersonneId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK_Film_Personne_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personne",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Acteur",
                columns: table => new
                {
                    ActeurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonneId = table.Column<int>(nullable: true),
                    FilmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acteur", x => x.ActeurId);
                    table.ForeignKey(
                        name: "FK_Acteur_Film_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acteur_Personne_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personne",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "PersonneId", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, "Wood", "Elijah" },
                    { 2, "Hunnam", "Charlie" },
                    { 3, "Ford", "Harisson" },
                    { 4, "Hammil", "Mark" },
                    { 5, "Fisher", "Carrie" },
                    { 6, "Mortensen", "Vigo" },
                    { 7, "Bloom", "Orlando" },
                    { 8, "Alexander", "Lexi" },
                    { 9, "Jackson", "Peter" },
                    { 10, "Lucas", "Georges" }
                });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmId", "Annee", "Genre", "PersonneId", "Titre" },
                values: new object[,]
                {
                    { 4, 2005, "Société", 8, "Hooligans" },
                    { 5, 2001, "Heroic-Fantasy", 9, "LOTR - La communauté de l'anneau" },
                    { 6, 2002, "Heroic-Fantasy", 9, "LOTR - Les deux tours" },
                    { 7, 2003, "Heroic-Fantasy", 9, "LOTR - Le retour du roi" },
                    { 1, 1977, "Science-Fiction", 10, "Star Wars : Un nouvel espoir" },
                    { 2, 1980, "Science-Fiction", 10, "Star Wars : L'empire contre-attaque" },
                    { 3, 1983, "Science-Fiction", 10, "Star Wars : Le retour du Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Acteur",
                columns: new[] { "ActeurId", "FilmId", "PersonneId" },
                values: new object[,]
                {
                    { 10, 4, 1 },
                    { 7, 3, 3 },
                    { 6, 2, 5 },
                    { 5, 2, 4 },
                    { 4, 2, 3 },
                    { 3, 1, 5 },
                    { 2, 1, 4 },
                    { 1, 1, 3 },
                    { 20, 7, 7 },
                    { 19, 7, 6 },
                    { 18, 7, 1 },
                    { 17, 6, 7 },
                    { 16, 6, 6 },
                    { 15, 6, 1 },
                    { 14, 5, 7 },
                    { 13, 5, 6 },
                    { 12, 5, 1 },
                    { 11, 4, 2 },
                    { 8, 3, 4 },
                    { 9, 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acteur_FilmId",
                table: "Acteur",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Acteur_PersonneId",
                table: "Acteur",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_PersonneId",
                table: "Film",
                column: "PersonneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acteur");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
