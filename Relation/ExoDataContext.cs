using Microsoft.EntityFrameworkCore;
using Relation.Entities;
using Relation.EntitiesConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Relation
{
    public class ExoDataContext : DbContext 
    {
        public DbSet<Film> listeFilms { get; set; }
        public DbSet<Personne> listePersonne { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-RGPQP6I\TFTIC2014;Initial Catalog=ExerciceEFCore;User ID=sa;Password=steve1983;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmConfig());
            modelBuilder.ApplyConfiguration(new PersonneConfig());
            modelBuilder.ApplyConfiguration(new ActeurConfig());
            modelBuilder.ApplyConfiguration(new FilmDataSet());
            modelBuilder.ApplyConfiguration(new PersonneDataSet());
            modelBuilder.ApplyConfiguration(new RelationDataSet());

            //modelBuilder.ApplyConfiguration(new DataSet());
        }
    }
}
