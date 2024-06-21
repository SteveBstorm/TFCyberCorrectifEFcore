using Microsoft.EntityFrameworkCore;
using Utilisation.Entities;
using Utilisation.EntitiesConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utilisation
{
    public class ExoDataContext : DbContext 
    {
        public DbSet<Film> listeFilms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-RGPQP6I\TFTIC2014;Initial Catalog=ExerciceEFCore;User ID=sa;Password=steve1983;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmConfig());
            modelBuilder.ApplyConfiguration(new DataSet());
        }
    }
}
