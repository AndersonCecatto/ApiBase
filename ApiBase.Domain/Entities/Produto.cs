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
            Situacao = produtoDto.Situacao == "true";
            CategoriaId = produtoDto.CategoriaId == 0 || !produtoDto.CategoriaId.HasValue ? null : produtoDto.CategoriaId;
        }

        public string Descricao { get; set; }
        public double Preco { get; set; }
        public bool Situacao { get; set; }
        public long? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
