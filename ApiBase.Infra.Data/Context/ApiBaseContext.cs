using ApiBase.Domain.Entities;
using ApiBase.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ApiBase.Infra.Data.Context
{
    public class ApiBaseContext : DbContext
    {
        public ApiBaseContext(DbContextOptions<ApiBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Categoria>(new CategoriaMap().Configure);
        }
    }
}
