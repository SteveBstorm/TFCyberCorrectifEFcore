using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Relation.Entities
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Titre { get; set; }
        public int Annee { get; set; }
        public string Genre { get; set; }
        //Définition d'une Many-to-One
        public int? PersonneId { get; set; }
        //Propriétés de navigation
        public Personne Realisateur { get; set; }
        //Many-to-Many (avec classe intermédiaire)
        public List<Acteur> Casting { get; set; }
    }
}
