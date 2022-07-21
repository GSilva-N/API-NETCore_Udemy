using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class MunicipioMap : IEntityTypeConfiguration<MunicipioEntity>
    {
        public void Configure(EntityTypeBuilder<MunicipioEntity> builder)
        {
            builder.ToTable("MunicipioTable");
            builder.HasKey(m => m.Id);
            builder.HasIndex(m => m.CodigoIBGE);
            builder.HasOne(m => m.UF)
                .WithMany(u => u.Municipios);
        }
    }
}
