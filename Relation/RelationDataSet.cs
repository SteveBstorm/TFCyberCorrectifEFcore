using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Relation
{
    public class RelationDataSet : IEntityTypeConfiguration<Acteur>
    {
        public void Configure(EntityTypeBuilder<Acteur> builder)
        {
            builder.HasData
                (
                    new Acteur { ActeurId = 1, FilmId = 1, PersonneId = 3},
                    new Acteur { ActeurId = 2, FilmId = 1, PersonneId = 4},
                    new Acteur { ActeurId = 3, FilmId = 1, PersonneId = 5},
                    new Acteur { ActeurId = 4, FilmId = 2, PersonneId = 3},
                    new Acteur { ActeurId = 5, FilmId = 2, PersonneId = 4},
                    new Acteur { ActeurId = 6, FilmId = 2, PersonneId = 5},
                    new Acteur { ActeurId = 7, FilmId = 3, PersonneId = 3},
                    new Acteur { ActeurId = 8, FilmId = 3, PersonneId = 4},
                    new Acteur { ActeurId = 9, FilmId = 3, PersonneId = 5},
                    new Acteur { ActeurId = 10, FilmId = 4, PersonneId = 1},
                    new Acteur { ActeurId = 11, FilmId = 4, PersonneId = 2},
                    new Acteur { ActeurId = 12, FilmId = 5, PersonneId = 1},
                    new Acteur { ActeurId = 13, FilmId = 5, PersonneId = 6},
                    new Acteur { ActeurId = 14, FilmId = 5, PersonneId = 7},
                    new Acteur { ActeurId = 15, FilmId = 6, PersonneId = 1 },
                    new Acteur { ActeurId = 16, FilmId = 6, PersonneId = 6 },
                    new Acteur { ActeurId = 17, FilmId = 6, PersonneId = 7 },
                    new Acteur { ActeurId = 18, FilmId = 7, PersonneId = 1 },
                    new Acteur { ActeurId = 19, FilmId = 7, PersonneId = 6 },
                    new Acteur { ActeurId = 20, FilmId = 7, PersonneId = 7 }
                );
        }
    }

    public class FilmDataSet : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(
                new Film
                {
                    FilmId = 1,
                    Titre = "Star Wars : Un nouvel espoir",
                    Annee = 1977,
                    Genre = "Science-Fiction",
                    PersonneId = 10
                },
                new Film
                {
                    FilmId = 2,
                    Titre = "Star Wars : L'empire contre-attaque",
                    Annee = 1980,
                    Genre = "Science-Fiction",
                    PersonneId = 10
                },
                new Film
                {
                    FilmId = 3,
                    Titre = "Star Wars : Le retour du Jedi",
                    Annee = 1983,
                    Genre = "Science-Fiction",
                    PersonneId = 10
                },
                new Film
                {
                    FilmId = 4,
                    Titre = "Hooligans",
                    Annee = 2005,
                    Genre = "Société",
                    PersonneId = 8
                },
                new Film
                {
                    FilmId = 5,
                    Titre = "LOTR - La communauté de l'anneau",
                    Annee = 2001,
                    Genre = "Heroic-Fantasy",
                    PersonneId = 9
                },
                new Film
                {
                    FilmId = 6,
                    Titre = "LOTR - Les deux tours",
                    Annee = 2002,
                    Genre = "Heroic-Fantasy",
                    PersonneId = 9
                },
                new Film
                {
                    FilmId = 7,
                    Titre = "LOTR - Le retour du roi",
                    Annee = 2003,
                    Genre = "Heroic-Fantasy",
                    PersonneId = 9
                });
        }
    }

    public class PersonneDataSet : IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            builder.HasData
                (
                    new Personne 
                    { 
                        PersonneId = 1,
                        Prenom = "Elijah",
                        Nom = "Wood"
                    },
                    new Personne
                    {
                        PersonneId = 2,
                        Prenom = "Charlie",
                        Nom = "Hunnam"
                    },
                    new Personne
                    {
                        PersonneId = 3,
                        Prenom = "Harisson",
                        Nom = "Ford"
                    },
                    new Personne
                    {
                        PersonneId = 4,
                        Prenom = "Mark",
                        Nom = "Hammil"
                    },
                    new Personne
                    {
                        PersonneId = 5,
                        Prenom = "Carrie",
                        Nom = "Fisher"
                    },
                    new Personne
                    {
                        PersonneId = 6,
                        Prenom = "Vigo",
                        Nom = "Mortensen"
                    },
                    new Personne
                    {
                        PersonneId = 7,
                        Prenom = "Orlando",
                        Nom = "Bloom"
                    },
                    new Personne
                    {
                        PersonneId = 8,
                        Prenom = "Lexi",
                        Nom = "Alexander"
                    },
                    new Personne
                    {
                        PersonneId = 9,
                        Prenom = "Peter",
                        Nom = "Jackson"
                    },
                    new Personne
                    {
                        PersonneId = 10,
                        Prenom = "Georges",
                        Nom = "Lucas"
                    }
                );
        }
    }
}
