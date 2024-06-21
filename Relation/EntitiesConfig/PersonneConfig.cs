using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Relation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Relation.EntitiesConfig
{
    public class PersonneConfig : IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            builder.ToTable("Personne");

            builder.Property("PersonneId").ValueGeneratedOnAdd();

           
        }
    }
}
