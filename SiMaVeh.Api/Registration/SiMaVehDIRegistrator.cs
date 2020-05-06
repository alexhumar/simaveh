using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.DataSeed;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using SiMaVeh.Helpers;

namespace SiMaVeh.Api.Registration
{
    public class SiMaVehDIRegistrator
    {
        public static void RegisterDI(IServiceCollection services)
        {
            services.AddScoped<IEntityGetter, EntityGetter>();
            services.AddScoped<IControllerParameter, ControllerParameter>();
            services.AddScoped<ISeeder<Pais>, PaisSeeder>();
            services.AddScoped<ISeeder<Provincia>, ProvinciaSeeder>();
            services.AddScoped<IDataSeeder, DataSeeder>();

            ValidatorRegistrator.RegisterValidators(services);
        }
    }
}
