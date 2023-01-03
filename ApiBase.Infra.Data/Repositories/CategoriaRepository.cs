using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces.Repositories;
using ApiBase.Infra.Data.Context;
using ApiBase.Infra.Data.Repositories.Common;
using System.Collections.Generic;
using System.Linq;

namespace ApiBase.Infra.Data.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
        }

        public IEnumerable<Categoria> Filtrar(string nome, bool situacao)
        {
            var context = _apiBaseContext.Set<Categoria>().Where(x => x.Situacao == situacao);

            if (nome != null || nome != string.Empty)
                context = context.Where(x => x.Descricao.ToUpper().Contains(nome.ToUpper()));

            return context;
        }
    }
}
