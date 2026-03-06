using Domain.Interfaces;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure;

public static class InfraModule 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EcoChargeDbContext>(options =>
            options.UseInMemoryDatabase("EcoChargeDb"));

        services.AddScoped<Domain.Interfaces.IEstacaoRepository, Repositories.EstacaoRepository>();
        services.AddScoped<Domain.Interfaces.IUnitOfWork, Repositories.UnitOfWork>();

        return services;
    }
}


