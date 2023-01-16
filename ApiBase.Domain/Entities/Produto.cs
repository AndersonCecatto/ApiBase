using ApiBase.Domain.Common;
using ApiBase.Domain.Dtos;

namespace ApiBase.Domain.Entities
{
    public class Produto : BaseEntity
    {
        public Produto()
        {
        }

        public Produto(ProdutoDto produtoDto)
        {
            Id = produtoDto.Id;
            Descricao = produtoDto.Descricao;
            Preco = produtoDto.Preco;
            Ativo = produtoDto.Ativo;
            CategoriaId = produtoDto.CategoriaId == 0 || !produtoDto.CategoriaId.HasValue ? null : produtoDto.CategoriaId;
        }

        public string Descricao { get; set; }
        public double Preco { get; set; }
        public bool Ativo { get; set; }
        public long? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
