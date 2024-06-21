using Microsoft.EntityFrameworkCore;
using Relation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Relation
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Personne real = new Personne { Nom = "Lucas", Prenom = "Georges" };
        //    Personne A1 = new Personne { Nom = "Hammil", Prenom = "Mark" };
        //    Personne A2 = new Personne { Nom = "Ford", Prenom = "Harisson" };

        //    Film f = new Film { Annee = 1977, Titre = "Star Wars",PersonneId = 1, Genre = "Sci-fi" };

            using (ExoDataContext dc = new ExoDataContext()) 
            {
                //dc.listePersonne.AddRange(real, A1, A2);
                //try
                //{
                //    dc.AddRange(new Acteur { MonFilm = f, Personne = A1 },
                //                new Acteur { MonFilm = f, Personne = A2 }
                //        );
                //    dc.SaveChanges();
                //}
                //catch (DbUpdateException e)
                //{
                //    Console.WriteLine(e.Message);
                //}
                var film = dc.listeFilms.Include(f => f.Realisateur)
                                        .Include(f => f.Casting)
                                        .ThenInclude(a => a.Personne)
                                        .ToList();
                //test
                foreach (var f1 in film)
                {
                    Console.WriteLine(f1.Titre + " || Réalisé par : " +f1.Realisateur.Prenom + " "+ f1.Realisateur.Nom);
                    Console.WriteLine("Casting :");
                    Console.WriteLine("---------");
                    foreach (var a in f1.Casting)
                    {
                        Console.WriteLine(a.Personne.Prenom + " " + a.Personne.Nom);
                    }
                }
            }

            
            Console.ReadLine();
        }
        
    }
}
