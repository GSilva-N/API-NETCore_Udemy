using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class CepMap : IEntityTypeConfiguration<CepEntity>
    {
        public void Configure(EntityTypeBuilder<CepEntity> builder)
        {
            builder.ToTable("CepTable");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Cep);
            builder.HasOne(m => m.Municipio)
                .WithMany(c => c.Ceps);
        }
    }
}
