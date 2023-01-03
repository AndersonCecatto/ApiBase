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
            Situacao = produto.Situacao == true ? "ATIVO" : "INATIVO";
            CategoriaId = produto.CategoriaId;
        }

        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Situacao { get; set; }
        public long? CategoriaId { get; set; }
    }
}
