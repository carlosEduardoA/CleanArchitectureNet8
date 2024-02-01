using CleanArchitecture.Application.Behaviors;
using CleanArchitecture.Domain.Alquileres;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration => 
        {
            configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            configuration.AddOpenBehavior(typeof(LogginBehavior<,>));
            configuration.AddOpenBehavior(typeof(ValidationBehavior<,>));
        }); 

        services.AddTransient<PrecioService>();
        services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

        return services;
    }
}