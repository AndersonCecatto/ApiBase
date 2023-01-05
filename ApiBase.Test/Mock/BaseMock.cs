using ApiBase.Domain.Interfaces.Repositories;
using Moq;

namespace ApiBase.Test.Mock
{
    public abstract class BaseMock : BaseTest
    {
        protected Mock<IProdutoRepository> _produtoRepositoryMock;
        protected Mock<ICategoriaRepository> _categoriaRepositoryMock;

        public BaseMock()
        {
            _categoriaRepositoryMock = new Mock<ICategoriaRepository>();
            _produtoRepositoryMock = new Mock<IProdutoRepository>();
            
            _produtoRepositoryMock.Setup(x => x.GetAll()).Returns(GetProdutos());
            _produtoRepositoryMock.Setup(x => x.Find(It.Is<long>(x => x == 1))).Returns(GetProduto());

            _categoriaRepositoryMock.Setup(x => x.GetAll()).Returns(GetCategorias());
            _categoriaRepositoryMock.Setup(x => x.Find(It.Is<long>(x => x == 4))).Returns(GetCategoria);
        }
    }
}
