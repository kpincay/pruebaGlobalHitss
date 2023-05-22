using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prueba.Application.Common.Interfaces;
using Prueba.Application.Features.Cliente.Interfaces;
using Prueba.Persistence.Contexts;
using Prueba.Persistence.Repository;

namespace Prueba.Persistence;
public static class ServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));


        #region Repositories

        services.AddTransient(typeof(IRepositoryAsync<>),typeof(CustomRepositoryAsync<>));
        services.AddTransient<IClienteService, ClienteService>();

        #endregion
        return services;
    }
}