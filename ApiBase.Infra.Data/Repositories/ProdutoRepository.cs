using ApiBase.Domain.Dtos;
using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces.Repositories;
using ApiBase.Infra.Data.Context;
using ApiBase.Infra.Data.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBase.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
        }

        public IEnumerable<ProdutoDto> BuscarTodos()
        {
            return _apiBaseContext.Set<Produto>()
                                  .Include(x => x.Categoria)
                                  .Select(x => new ProdutoDto(x));
        }

        public IEnumerable<Produto> Filtrar(FiltroDto filtroDto)
        {
            var contexto = _apiBaseContext.Set<Produto>().Include(x => x.Categoria).Where(x => x.Ativo == filtroDto.SituacaoProduto).AsQueryable();

            if (filtroDto.CategoriaId.HasValue && filtroDto.CategoriaId != 0)
                contexto = contexto.Where(x => x.CategoriaId == filtroDto.CategoriaId);
            if (filtroDto.DescricaoProduto != string.Empty)
                contexto = contexto.Where(x => x.Descricao.ToUpper().Contains(filtroDto.DescricaoProduto.ToUpper()));

            return contexto;
        }
    }
}
