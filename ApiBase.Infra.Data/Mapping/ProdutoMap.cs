using ApiBase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBase.Infra.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasColumnName("Descricao").HasColumnType("varchar(250)");
            builder.Property(p => p.Preco).HasColumnName("Preco").HasColumnType("decimal");
            builder.Property(p => p.Ativo).HasColumnName("Situacao").HasColumnType("bool");

            builder.Property(p => p.CategoriaId).HasColumnName("Categoria_Id").HasColumnType("int");
            builder.HasOne(p => p.Categoria);
        }
    }
}
