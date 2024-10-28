using Application.Interfaces;
using Application.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices (this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DatabaseContext>(cfg => { cfg.UseSqlServer(configuration.GetConnectionString("csBooking")); });

        services.AddScoped(typeof(IRepository<>), typeof(Repositories.Repositories<>));
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
        return services;
    }
}
