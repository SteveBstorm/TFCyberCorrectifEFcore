using Microsoft.EntityFrameworkCore;
using MiseEnPlace.Entities;
using MiseEnPlace.EntitiesConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiseEnPlace
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
        }
    }
}
