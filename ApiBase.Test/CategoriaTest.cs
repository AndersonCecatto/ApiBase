using ApiBase.Service.Services;
using ApiBase.Test.Mock;
using Xunit;

namespace ApiBase.Test
{
    public class CategoriaTest : BaseMock
    {
        private readonly CategoriaService _categoriaService;

        public CategoriaTest()
        {
            _categoriaService = new CategoriaService(_categoriaRepositoryMock.Object);
        }

        [Fact(DisplayName = "Retornar Lista de Categoria")]
        public void RetornarCategorias()
        {
            var retorno = _categoriaService.GetAll();

            Assert.NotNull(retorno);
        }

        [Fact(DisplayName = "Retornar Categoria Por Id")]
        public void RetornarCategoriaPorId()
        {
            var retorno = _categoriaService.GetById(4);

            Assert.NotNull(retorno);
        }

        [Fact(DisplayName = "Categoria não Encontrada")]
        public void CategoriaNaoEncontradaPorId()
        {
            var retorno = _categoriaService.GetById(2);

            Assert.Null(retorno);
        }
    }
}
