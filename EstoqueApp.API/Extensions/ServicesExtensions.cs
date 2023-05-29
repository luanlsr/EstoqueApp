using EstoqueApp.Application.Interfaces;
using EstoqueApp.Application.Services;

namespace EstoqueApp.API.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IEstoqueAppServices, EstoqueAppService>();
            services.AddTransient<IProdutoAppServices, ProdutoAppService>();

            return services;
        }
    }
}
