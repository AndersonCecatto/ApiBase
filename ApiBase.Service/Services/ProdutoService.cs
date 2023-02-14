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
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto Alterar(ProdutoDto produto)
        {
            return Update(new Produto(produto));
        }

        public IEnumerable<ProdutoDto> BuscarTodos()
        {
            return _produtoRepository.BuscarTodos();
        }

        public IEnumerable<Produto> Filtrar(FiltroDto filtrosDto)
        {
            return (_baseRepository as IProdutoRepository).Filtrar(filtrosDto);
        }

        public Produto Inserir(ProdutoDto produto) => Add(new Produto(produto));
    }
}