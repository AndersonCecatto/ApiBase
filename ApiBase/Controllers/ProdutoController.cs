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
        [HttpGet]
        public IActionResult BuscarTodos([FromServices] IProdutoService produtoService)
        {
            return Execute(() => produtoService.BuscarTodos());
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(
            [FromServices] IProdutoService produtoService,
            [FromBody] ProdutoDto produto)
        {
            return Execute(() => produtoService.Inserir(produto));
        }

        [HttpPut]
        [Route("alterar")]
        public IActionResult Alterar(
            [FromServices] IProdutoService produtoService,
            [FromBody] ProdutoDto produto)
        {
            return Execute(() => produtoService.Alterar(produto));
        }

        [HttpPost]
        [Route("Filtrar")]
        public IActionResult Filtrar(
            [FromServices] IProdutoService produtoService,
            [FromForm] FiltroDto filtrosDto)
        {
            return Execute(() => produtoService.Filtrar(filtrosDto));
        }
    }
}
