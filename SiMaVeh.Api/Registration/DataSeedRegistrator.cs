using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces;
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

            services.AddScoped<ITipoDocumentoFixtureGettersProvider, TipoDocumentoFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoDocumento, FixtureTipoDocumento>();
            services.AddScoped<ISeeder<TipoDocumento, long>, TipoDocumentoSeeder>();

            services.AddScoped<ITipoTelefonoFixtureGettersProvider, TipoTelefonoFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoTelefono, FixtureTipoTelefono>();
            services.AddScoped<ISeeder<TipoTelefono, long>, TipoTelefonoSeeder>();

            services.AddScoped<IUbicacionPiezaFixtureGettersProvider, UbicacionPiezaFixtureGettersProvider>();
            services.AddScoped<IFixtureUbicacionPieza, FixtureUbicacionPieza>();
            services.AddScoped<ISeeder<UbicacionPieza, string>, UbicacionPiezaSeeder>();

            services.AddScoped<IEquipamientoAirbagsFixtureGettersProvider, EquipamientoAirbagsFixtureGettersProvider>();
            services.AddScoped<IFixtureEquipamientoAirbags, FixtureEquipamientoAirbags>();
            services.AddScoped<ISeeder<EquipamientoAirbags, string>, EquipamientoAirbagsSeeder>();

            services.AddScoped<IMonedaFixtureGettersProvider, MonedaFixtureGettersProvider>();
            services.AddScoped<IFixtureMoneda, FixtureMoneda>();
            services.AddScoped<ISeeder<Moneda, string>, MonedaSeeder>();

            services.AddScoped<IMarcaFixtureGettersProvider, MarcaFixtureGettersProvider>();
            services.AddScoped<IFixtureMarca, FixtureMarca>();
            services.AddScoped<ISeeder<Marca, long>, MarcaSeeder>();

            services.AddScoped<ICategoriaMarcaFixtureGettersProvider, CategoriaMarcaFixtureGettersProvider>();
            services.AddScoped<IFixtureCategoriaMarca, FixtureCategoriaMarca>();
            services.AddScoped<ISeeder<CategoriaMarca, long>, CategoriaMarcaSeeder>();

            services.AddScoped<IDataSeeder, DataSeeder>();
        }
    }
}
