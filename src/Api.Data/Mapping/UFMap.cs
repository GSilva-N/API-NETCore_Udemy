using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping
{
    public class UFMap : IEntityTypeConfiguration<UFEntity>
    {
        public void Configure(EntityTypeBuilder<UFEntity> builder)
        {
            builder.ToTable("UFTable");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.SiglaUF)
                .IsUnique();
        }
    }
}
