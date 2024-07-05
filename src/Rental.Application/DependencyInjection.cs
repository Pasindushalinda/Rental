using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Rental.Application.Abstractions.Behaviors;
using Rental.Domain.Bookings;

namespace Rental.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);

                config.AddOpenBehavior(typeof(LoggingBehavior<,>));

                config.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });

            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

            services.AddTransient<PricingService>();

            return services;
        }

    }
}
