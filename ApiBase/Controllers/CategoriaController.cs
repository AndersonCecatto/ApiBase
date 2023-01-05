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
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _categoriaService.BuscarTodos());
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir([FromBody] CategoriaDto categoria)
        {
            return Execute(() => _categoriaService.Inserir(categoria));
        }

        [HttpPut]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] CategoriaDto categoria)
        {
            return Execute(() => _categoriaService.Alterar(categoria));
        }

        [HttpGet]
        [Route("Filtrar/nome/{nome}/situacao/{situacao}")]
        public IActionResult Filtrar(string nome, bool situacao)
        {
            return Execute(() => _categoriaService.Filtrar(nome, situacao));
        }
    }
}
