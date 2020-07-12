using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.DataAccess.DataSeed.Seeders;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Helpers;

namespace SiMaVeh.Api.Registration
{
    internal class SiMaVehDIRegistrator
    {
        public static void RegisterDI(IServiceCollection services)
        {
            services.AddScoped<IEntityGetter, EntityGetter>();
            services.AddScoped<IControllerParameter, ControllerParameter>();
            services.AddScoped<PaisSeeder, PaisSeeder>();
            services.AddScoped<ProvinciaSeeder, ProvinciaSeeder>();
            services.AddScoped<IDataSeeder, DataSeeder>();

            ValidatorRegistrator.RegisterValidators(services);
            DataSeedRegistrator.RegisterDataSeeds(services);
        }
    }
}
