using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Relation.EntitiesConfig
{
    public class ActeurConfig : IEntityTypeConfiguration<Acteur>
    {
        public void Configure(EntityTypeBuilder<Acteur> builder)
        {
            builder.HasKey(a => a.ActeurId );
            builder.Property("ActeurId").ValueGeneratedOnAdd();

            builder.HasOne(a => a.Personne)
                   .WithMany(mp => mp.Biographie)
                   .HasForeignKey(fk => fk.PersonneId).IsRequired(false)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(f => f.MonFilm)
                   .WithMany(mf => mf.Casting)
                   .HasForeignKey(fk => fk.FilmId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
