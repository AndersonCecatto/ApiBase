﻿using ApiBase.Domain.Entities;
using ApiBase.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ApiBase.Infra.Data.Mapping
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasColumnName("Descricao").HasColumnType("varchar(250)");
            builder.Property(p => p.Situacao).HasColumnName("Situacao").HasColumnType("bool");

        }
    }
}
