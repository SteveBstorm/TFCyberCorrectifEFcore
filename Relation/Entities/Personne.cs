using System;
using System.Collections.Generic;
using System.Text;

namespace Relation.Entities
{
    public class Personne
    {
        public int PersonneId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        //Propriété de navigation
        public List<Acteur> Biographie { get; set; }
    }
}
