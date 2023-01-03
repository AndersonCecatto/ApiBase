using ApiBase.Controllers.Common;
using ApiBase.Domain.Dtos;
using ApiBase.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiBase.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : BaseController
    {

        [HttpGet]
        public IActionResult BuscarTodos([FromServices] ICategoriaService categoriaService)
        {
            return Execute(() => categoriaService.BuscarTodos());
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(
            [FromServices] ICategoriaService categoriaService,
            [FromBody] CategoriaDto categoria)
        {
            return Execute(() => categoriaService.Inserir(categoria));
        }

        [HttpPut]
        [Route("alterar")]
        public IActionResult Alterar(
            [FromServices] ICategoriaService categoriaService,
            [FromBody] CategoriaDto categoria)
        {
            return Execute(() => categoriaService.Alterar(categoria));
        }

        [HttpGet]
        [Route("Filtrar/nome/{nome}/situacao/{situacao}")]
        public IActionResult Filtrar(
            [FromServices] ICategoriaService categoriaService, 
            string nome, bool situacao)
        {
            return Execute(() => categoriaService.Filtrar(nome, situacao));
        }
    }
}
