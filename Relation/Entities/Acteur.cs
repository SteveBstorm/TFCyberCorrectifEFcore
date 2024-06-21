using System;
using System.Collections.Generic;
using System.Text;

namespace Relation.Entities
{
    public class Acteur
    {
        public int ActeurId { get; set; }
        public int? PersonneId { get; set; }
        //Propriété de navigation
        public Personne Personne { get; set; }
        public int FilmId { get; set; }
        //Propriété de navigation
        public Film MonFilm { get; set; }
    }
}
