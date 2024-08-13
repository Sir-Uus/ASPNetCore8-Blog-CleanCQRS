using System;
using Domain.Repository;
using Infrastructure.Data;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureService(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddDbContext<BlogDbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
        );

        services.AddTransient<IBlogRepository, BlogRepository>();

        return services;
    }
}
