using Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection service,
        IConfiguration configuration)
    {
        service.AddDbContext<BaseDbContext>(opt =>
        {
            opt.UseInMemoryDatabase("rentACar");
        });
        service.AddScoped<IBrandRepository, BrandRepository>();
        return service;
    }
}