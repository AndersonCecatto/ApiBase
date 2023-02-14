using ApiBase.Domain.Dtos;
using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBase.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        IEnumerable<Produto> Filtrar(FiltroDto filtroDto);

        IEnumerable<ProdutoDto> BuscarTodos();
    }
}
