using ApiBase.Domain.Dtos;
using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces.Repositories;
using ApiBase.Domain.Interfaces.Services;
using ApiBase.Service.Services.Common;
using System.Collections.Generic;

namespace ApiBase.Service.Services
{
    public class CategoriaService : BaseService<Categoria>, ICategoriaService
    {
        public CategoriaService(ICategoriaRepository categoriaRepository) : base(categoriaRepository)
        {
        }
        public IEnumerable<CategoriaDto> BuscarTodos()
        {
            var retorno = new List<CategoriaDto>();

            foreach (var categoria in _baseRepository.GetAll())
                retorno.Add(new CategoriaDto(categoria));

             return retorno;
        }

        public Categoria Inserir(CategoriaDto categoria) => Add(new Categoria(categoria));

        public Categoria Alterar(CategoriaDto categoria)
        {
            return Update(new Categoria(categoria));
        }

        public IEnumerable<Categoria> Filtrar(string nome, bool situacao)
        {
            return (_baseRepository as ICategoriaRepository).Filtrar(nome, situacao);
        }
    }
}
