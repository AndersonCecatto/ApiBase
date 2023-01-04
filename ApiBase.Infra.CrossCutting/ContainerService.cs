using ApiBase.Domain.Interfaces.Repositories;
using ApiBase.Domain.Interfaces.Repositories.Common;
using ApiBase.Domain.Interfaces.Services;
using ApiBase.Infra.Data.Repositories;
using ApiBase.Infra.Data.Repositories.Common;
using ApiBase.Service.Services;
using ApiBase.Service.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBase.Infra.CrossCutting
{
    public static class ContainerService
    {
        public static IServiceCollection AddApplicationServicesCollections(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddServices();
            services.AddRepositories();
            services.AddValidators();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<ICategoriaService, CategoriaService>();

            return services;
        }

        private static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<ProdutoValidator>();
            services.AddValidatorsFromAssemblyContaining<CategoriaValidator>();

            return services;
        }
    }
}
