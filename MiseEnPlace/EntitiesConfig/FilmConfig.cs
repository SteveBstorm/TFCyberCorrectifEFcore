using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiseEnPlace.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiseEnPlace.EntitiesConfig
{
    class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("Film");
            builder.Property("FilmId").ValueGeneratedOnAdd().IsRequired();
            builder.Property("Titre").IsRequired().HasColumnType("VARCHAR(100)");
            builder.Property("ActeurPrincipal").IsRequired().HasMaxLength(100);
            builder.Property("Genre").IsRequired().HasMaxLength(30);
            builder.Property("Realisateur").IsRequired().HasMaxLength(100);
        }
    }
}
