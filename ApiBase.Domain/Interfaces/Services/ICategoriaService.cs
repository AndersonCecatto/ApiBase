using ApiBase.Domain.Dtos;
using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBase.Domain.Interfaces.Services
{
    public interface ICategoriaService : IBaseService<Categoria>
    {
        IEnumerable<CategoriaDto> BuscarTodos();

        Categoria Inserir(CategoriaDto categoria);

        Categoria Alterar(CategoriaDto categoria);

        IEnumerable<Categoria> Filtrar(string nome, bool situacao);
    }
}
