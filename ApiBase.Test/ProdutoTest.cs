using ApiBase.Service.Services;
using ApiBase.Test.Mock;
using Xunit;

namespace ApiBase.Test
{
    public class ProdutoTest : BaseMock
    {
        private readonly ProdutoService _produtoService; 

        public ProdutoTest()
        {
            _produtoService = new ProdutoService(_produtoRepositoryMock.Object);
        }

        [Fact(DisplayName = "Retorna Lista de Produtos")]
        public void RetornarProdutos()
        {
            var retorno =_produtoService.GetAll();

            Assert.NotNull(retorno);
        }

        [Fact(DisplayName = "Retornar Produto por Id")]
        public void RetornarProdutoPorId()
        {
            var retorno = _produtoService.GetById(1);

            Assert.NotNull(retorno);
        }

        [Fact(DisplayName = "Produto não Encontrado")]
        public void ProdutoNaoEncontradoPorId()
        {
            var retorno = _produtoService.GetById(2);

            Assert.Null(retorno);
        }
    }
}
