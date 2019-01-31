using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Validators;

namespace SiMaVeh.Helpers
{
    public class ValidatorRegistrator
    {
        public static void RegisterValidators(IServiceCollection services)
        {
            services.AddTransient<IValidator<Pais>, ValidadorPais>();
            services.AddTransient<IValidator<Provincia>, ValidadorProvincia>();
            services.AddTransient<IValidator<UbicacionPieza>, ValidadorUbicacionPieza>();
        }
    }
}