using Application.Interfaces;
using EcoCharge.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application; 

public static class AppModule
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<Interfaces.IEstacaoService, EcoCharge.Application.Services.EstacaoService>();
        return services;
    }
}