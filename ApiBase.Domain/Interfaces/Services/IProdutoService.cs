using ApiBase.Domain.Dtos;
using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBase.Domain.Interfaces.Services
{
    public interface IProdutoService : IBaseService<Produto>
    {
        IEnumerable<ProdutoDto> BuscarTodos();

        Produto Inserir(ProdutoDto produto);

        Produto Alterar(ProdutoDto produto);

        IEnumerable<Produto> Filtrar(FiltroDto filtrosDto);
    }
}
