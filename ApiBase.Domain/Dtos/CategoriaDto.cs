using ApiBase.Domain.Common;
using ApiBase.Domain.Entities;

namespace ApiBase.Domain.Dtos
{
    public class CategoriaDto : BaseEntity
    {
        public CategoriaDto()
        {
        }

        public CategoriaDto(Categoria categoria)
        {
            Id = categoria.Id;
            Descricao = categoria.Descricao;
            Situacao = categoria.Situacao == true ? "ATIVO" : "INATIVO";
        }

        public string Descricao { get; set; }
        public string Situacao { get; set; }
    }
}
