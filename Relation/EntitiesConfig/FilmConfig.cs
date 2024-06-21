using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Relation.Entities;

namespace Relation.EntitiesConfig
{
    class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("Film");
            builder.Property("FilmId").ValueGeneratedOnAdd().IsRequired();
            builder.Property("Titre").IsRequired().HasColumnType("VARCHAR(100)");            
            builder.Property("Genre").IsRequired().HasMaxLength(30);
            
            
        }
    }
}
