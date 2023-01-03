using ApiBase.Domain.Common;
using ApiBase.Domain.Dtos;

namespace ApiBase.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public Categoria()
        {
        }

        public Categoria(CategoriaDto categoria)
        {
            Id = categoria.Id;
            Descricao = categoria.Descricao;
            Situacao = categoria.Situacao.ToUpper() == "TRUE";
        }

        public string Descricao { get; set; }
        public bool Situacao { get; set; }
    }
}
