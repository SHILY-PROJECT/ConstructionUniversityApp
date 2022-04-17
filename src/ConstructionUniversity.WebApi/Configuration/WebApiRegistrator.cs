using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using ConstructionUniversity.WebApi.Models.Teachers.Validators;

namespace ConstructionUniversity.WebApi.Configuration;

public static class WebApiRegistrator
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        services
            .AddAutoMapper(typeof(MapperProfile))
            .AddValidatorsFromAssemblyContaining<Startup>(ServiceLifetime.Transient);

        return services;
    }
}