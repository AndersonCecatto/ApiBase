using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces.Repositories.Common;
using System.Collections.Generic;

namespace ApiBase.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        IEnumerable<Categoria> Filtrar(string nome, bool situacao);
    }
}
