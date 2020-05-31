using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.DataSeed.Seeders;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Api.Registration
{
    internal class DataSeedRegistrator
    {
        public static void RegisterDataSeeds(IServiceCollection services)
        {
            services.AddScoped<IDatosEntidadBuilder, DatosEntidadBuilder>();

            services.AddScoped<IPaisFixtureGettersProvider, PaisFixtureGettersProvider>();
            services.AddScoped<IFixturePais, FixturePais>();
            services.AddScoped<ISeeder<Pais, long>, PaisSeeder>();

            services.AddScoped<ITipoEntidadReparadoraFixtureGettersProvider, TipoEntidadReparadoraFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoEntidadReparadora, FixtureTipoEntidadReparadora>();
            services.AddScoped<ISeeder<TipoEntidadReparadora, long>, TipoEntidadReparadoraSeeder>();

            services.AddScoped<IDataSeeder, DataSeeder>();
        }
    }
}
