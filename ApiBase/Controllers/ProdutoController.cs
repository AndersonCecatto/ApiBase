using ApiBase.Controllers.Common;
using ApiBase.Domain.Dtos;
using ApiBase.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBase.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : BaseController
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _produtoService.BuscarTodos());
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir([FromBody] ProdutoDto produto)
        {
            return Execute(() => _produtoService.Inserir(produto));
        }

        [HttpPut]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] ProdutoDto produto)
        {
            return Execute(() => _produtoService.Alterar(produto));
        }

        [HttpPost]
        [Route("Filtrar")]
        public IActionResult Filtrar([FromForm] FiltroDto filtrosDto)
        {
            return Execute(() => _produtoService.Filtrar(filtrosDto));
        }
    }
}
