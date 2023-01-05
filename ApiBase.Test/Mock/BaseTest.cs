using ApiBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBase.Test.Mock
{
    public abstract class BaseTest
    {
        protected static IEnumerable<Produto> GetProdutos()
            => new List<Produto>()
            {
                new Produto
                {
                    Id = 1,
                    CategoriaId = 1,
                    Categoria = new Categoria
                    {
                        Id = 1,
                        Descricao = "Derivados",
                        Situacao = true,
                    },
                    Descricao = "Leite",
                    Preco = 4.25,
                    Situacao = true
                },
                new Produto
                {
                    Id = 2,
                    CategoriaId = null,
                    Categoria = null,
                    Descricao = "Queijo",
                    Preco = 10.25,
                    Situacao = true
                },
                new Produto
                {
                    Id = 3,
                    CategoriaId = 2,
                    Categoria = new Categoria
                    {
                        Id = 2,
                        Descricao = "Refrigerantes",
                        Situacao = true,
                    },
                    Descricao = "Coca-Cola",
                    Preco = 9.50,
                    Situacao = true
                }
            };

        protected static Produto GetProduto()
            => new()
            {
                Id = 1,
                CategoriaId = 1,
                Categoria = new Categoria
                {
                    Id = 3,
                    Descricao = "Carnes",
                    Situacao = true,
                },
                Descricao = "Frango",
                Preco = 12.90,
                Situacao = true
            };

        protected static Categoria GetCategoria()
            => new()
            {
                Id = 4,
                Descricao = "Sorvetes",
                Situacao = true,
            };

        protected static IEnumerable<Categoria> GetCategorias()
            => new List<Categoria>()
            {
                GetCategoria(),
                new Categoria
                {
                    Id = 2,
                    Descricao = "Refrigerantes",
                    Situacao = true,
                },
                new Categoria
                {
                    Id = 1,
                    Descricao = "Derivados",
                    Situacao = true,
                }
            };
    }
}
