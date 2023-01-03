using ApiBase.Domain.Dtos;
using ApiBase.Domain.Entities;
using ApiBase.Domain.Interfaces.Repositories;
using ApiBase.Domain.Interfaces.Services;
using ApiBase.Service.Services.Common;
using System.Collections.Generic;

namespace ApiBase.Service.Services
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
        }

        public Produto Alterar(ProdutoDto produto)
        {
            return Update(new Produto(produto));
        }

        public IEnumerable<ProdutoDto> BuscarTodos()
        {
            var retorno = new List<ProdutoDto>();

            foreach (var produto in _baseRepository.GetAll())
                retorno.Add(new ProdutoDto(produto));

            return retorno;
        }

        public IEnumerable<Produto> Filtrar(FiltroDto filtrosDto)
        {
            return (_baseRepository as IProdutoRepository).Filtrar(filtrosDto);
        }

        public Produto Inserir(ProdutoDto produto) => Add(new Produto(produto));
    }
}