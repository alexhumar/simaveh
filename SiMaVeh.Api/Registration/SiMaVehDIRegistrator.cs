using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.Api.Controllers.Parametrization;
using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Api.Model;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.DataAccess.DataSeed.Seeders;
using SiMaVeh.Domain.BusinessLogic.Entities;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Api.Registration
{
    internal class SiMaVehDIRegistrator
    {
        public static void RegisterDI(IServiceCollection services)
        {
            services.AddScoped<IRelatedEntityGetter, RelatedEntityGetter>();
            services.AddScoped<IEntityTypeGetter, EntityTypeGetter>();
            services.AddScoped<IControllerParameter, ControllerParameter>();
            services.AddScoped<PaisSeeder, PaisSeeder>();
            services.AddScoped<ProvinciaSeeder, ProvinciaSeeder>();
            services.AddScoped<IDataSeeder, DataSeeder>();

            ValidatorRegistrator.RegisterValidators(services);
            DataSeedRegistrator.RegisterDataSeeds(services);
        }
    }
}
