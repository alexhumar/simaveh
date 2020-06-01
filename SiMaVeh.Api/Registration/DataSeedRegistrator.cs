using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
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

            services.AddScoped<IPaisFixtureGetter, PaisFixtureGetter>();
            services.AddScoped<IPaisFixtureGettersProvider, PaisFixtureGettersProvider>();
            services.AddScoped<IFixturePais, FixturePais>();
            services.AddScoped<ISeeder<Pais, long>, PaisSeeder>();

            services.AddScoped<IProvinciaFixtureGettersProvider, ProvinciaFixtureGettersProvider>();
            services.AddScoped<IFixtureProvincia, FixtureProvincia>();
            services.AddScoped<ISeeder<Provincia, long>, ProvinciaSeeder>();

            services.AddScoped<IPartidoFixtureGettersProvider, PartidoFixtureGettersProvider>();
            services.AddScoped<IFixturePartido, FixturePartido>();
            services.AddScoped<ISeeder<Partido, long>, PartidoSeeder>();

            services.AddScoped<ILocalidadFixtureGettersProvider, LocalidadFixtureGettersProvider>();
            services.AddScoped<IFixtureLocalidad, FixtureLocalidad>();
            services.AddScoped<ISeeder<Localidad, long>, LocalidadSeeder>();

            services.AddScoped<ITipoEntidadReparadoraFixtureGettersProvider, TipoEntidadReparadoraFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoEntidadReparadora, FixtureTipoEntidadReparadora>();
            services.AddScoped<ISeeder<TipoEntidadReparadora, long>, TipoEntidadReparadoraSeeder>();

            services.AddScoped<ITipoFuenteEnergiaFixtureGettersProvider, TipoFuenteEnergiaFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoFuenteEnergia, FixtureTipoFuenteEnergia>();
            services.AddScoped<ISeeder<TipoFuenteEnergia, long>, TipoFuenteEnergiaSeeder>();

            services.AddScoped<IDataSeeder, DataSeeder>();
        }
    }
}
