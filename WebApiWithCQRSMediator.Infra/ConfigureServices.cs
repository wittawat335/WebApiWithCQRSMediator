using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiWithCQRSMediator.Infra
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfraServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
