using Microsoft.EntityFrameworkCore.Migrations;

namespace MiseEnPlace.Migrations
{
    public partial class FirstDeploy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Annee = table.Column<int>(nullable: false),
                    ActeurPrincipal = table.Column<string>(maxLength: 100, nullable: false),
                    Realisateur = table.Column<string>(maxLength: 100, nullable: false),
                    Genre = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
