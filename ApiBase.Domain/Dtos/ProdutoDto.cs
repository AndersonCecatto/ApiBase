using ApiBase.Domain.Common;
using ApiBase.Domain.Entities;

namespace ApiBase.Domain.Dtos
{
    public class ProdutoDto : BaseEntity
    {
        public ProdutoDto()
        {
        }

        public ProdutoDto(Produto produto)
        {
            Id = produto.Id;
            Descricao = produto.Descricao;
            Preco = produto.Preco;
            Ativo = produto.Ativo;
            CategoriaId = produto.CategoriaId;
        }

        public string Descricao { get; set; }
        public double Preco { get; set; }
        public bool Ativo { get; set; }
        public long? CategoriaId { get; set; }
    }
}
