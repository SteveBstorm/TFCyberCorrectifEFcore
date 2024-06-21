using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilisation.Entities;

namespace Utilisation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 3
            //Film f = new Film
            //{
            //    Titre = "Pacific Rim",
            //    Annee = 2013,
            //    Realisateur = "Guillermo Del Toro",
            //    Genre = "Science-Fiction",
            //    ActeurPrincipal = "Charlie Hunnam"
            //};
            //using(ExoDataContext dc = new ExoDataContext())
            //{
            //    dc.listeFilms.Add(f);
            //    try 
            //    {
            //        dc.SaveChanges();
            //    }
            //    catch(DbUpdateException e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //    finally {
            //        foreach (Film film in dc.listeFilms)
            //        {
            //            Console.WriteLine(film.Titre);
            //        }
            //    }

            //}
            #endregion

            #region Exercice 4
            //Ne pas oublier d'importer le nuget System.Linq
            //using(ExoDataContext dc = new ExoDataContext())
            //{
            //    var films = dc.listeFilms.Where(x => x.Annee > 2001);
            //    foreach (Film f in films)
            //    {
            //        Console.WriteLine(f.Titre);
            //    }
            //}
            #endregion

            #region Exercice 5
            using (ExoDataContext dc = new ExoDataContext())
            {
                foreach (Film film in dc.listeFilms.Where(x => x.Titre.Contains("Star Wars")))
                {
                    film.ActeurPrincipal = "Harrison Ford";
                }
                try
                {
                    dc.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    foreach (Film film in dc.listeFilms)
                    {
                        Console.WriteLine(film.ActeurPrincipal);
                    }
                }
            }
            #endregion

            #region Exercice 6
            //using (ExoDataContext dc = new ExoDataContext())
            //{
            //    var listeASupprimer = dc.listeFilms.Where(x => x.ActeurPrincipal == "Charlie Hunnam");
            //    foreach (Film film in listeASupprimer)
            //    {
            //        try 
            //        { 
            //            dc.listeFilms.Remove(film); 
            //        }
            //        catch(DbUpdateException e)
            //        {
            //            Console.WriteLine(e.Message);
            //        }
                    
            //    }
            //    foreach (Film film in dc.listeFilms)
            //    {
            //        Console.WriteLine(film.Titre + " - " + film.ActeurPrincipal);
            //    }
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
