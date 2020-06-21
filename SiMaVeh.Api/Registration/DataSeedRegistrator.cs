using Microsoft.Extensions.DependencyInjection;
using SiMaVeh.DataAccess.DataSeed;
using SiMaVeh.DataAccess.DataSeed.Seeders;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.FixtureGetters;
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
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.DataSeed.Seeders;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags.Interfaces;
using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza;
using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.Models.Relations;

namespace SiMaVeh.Api.Registration
{
    internal class DataSeedRegistrator
    {
        public static void RegisterDataSeeds(IServiceCollection services)
        {
            services.AddScoped<ICalculadorIdEquipamientoAirbags, CalculadorIdEquipamientoAirbags>();
            services.AddScoped<ICalculadorIdUbicacionPieza, CalculadorIdUbicacionPieza>();

            services.AddScoped<IDatosEntidadBuilder, DatosEntidadBuilder>();

            services.AddScoped<IPaisFixtureGetter, PaisFixtureGetter>();
            services.AddScoped<IPaisFixtureGettersProvider, PaisFixtureGettersProvider>();
            services.AddScoped<IFixturePais, FixturePais>();
            services.AddScoped<IDomainSeeder<Pais, long>, PaisSeeder>();

            services.AddScoped<IProvinciaFixtureGettersProvider, ProvinciaFixtureGettersProvider>();
            services.AddScoped<IFixtureProvincia, FixtureProvincia>();
            services.AddScoped<IDomainSeeder<Provincia, long>, ProvinciaSeeder>();

            services.AddScoped<IPartidoFixtureGettersProvider, PartidoFixtureGettersProvider>();
            services.AddScoped<IFixturePartido, FixturePartido>();
            services.AddScoped<IDomainSeeder<Partido, long>, PartidoSeeder>();

            services.AddScoped<ILocalidadFixtureGettersProvider, LocalidadFixtureGettersProvider>();
            services.AddScoped<IFixtureLocalidad, FixtureLocalidad>();
            services.AddScoped<IDomainSeeder<Localidad, long>, LocalidadSeeder>();

            services.AddScoped<ITipoEntidadReparadoraFixtureGettersProvider, TipoEntidadReparadoraFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoEntidadReparadora, FixtureTipoEntidadReparadora>();
            services.AddScoped<IDomainSeeder<TipoEntidadReparadora, long>, TipoEntidadReparadoraSeeder>();

            services.AddScoped<ITipoFuenteEnergiaFixtureGetter, TipoFuenteEnergiaFixtureGetter>();
            services.AddScoped<ITipoFuenteEnergiaFixtureGettersProvider, TipoFuenteEnergiaFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoFuenteEnergia, FixtureTipoFuenteEnergia>();
            services.AddScoped<IDomainSeeder<TipoFuenteEnergia, long>, TipoFuenteEnergiaSeeder>();

            services.AddScoped<ITipoDocumentoFixtureGettersProvider, TipoDocumentoFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoDocumento, FixtureTipoDocumento>();
            services.AddScoped<IDomainSeeder<TipoDocumento, long>, TipoDocumentoSeeder>();

            services.AddScoped<ITipoTelefonoFixtureGettersProvider, TipoTelefonoFixtureGettersProvider>();
            services.AddScoped<IFixtureTipoTelefono, FixtureTipoTelefono>();
            services.AddScoped<IDomainSeeder<TipoTelefono, long>, TipoTelefonoSeeder>();

            services.AddScoped<IUbicacionPiezaFixtureGettersProvider, UbicacionPiezaFixtureGettersProvider>();
            services.AddScoped<IFixtureUbicacionPieza, FixtureUbicacionPieza>();
            services.AddScoped<IDomainSeeder<UbicacionPieza, string>, UbicacionPiezaSeeder>();

            services.AddScoped<IEquipamientoAirbagsFixtureGettersProvider, EquipamientoAirbagsFixtureGettersProvider>();
            services.AddScoped<IFixtureEquipamientoAirbags, FixtureEquipamientoAirbags>();
            services.AddScoped<IDomainSeeder<EquipamientoAirbags, string>, EquipamientoAirbagsSeeder>();

            services.AddScoped<IMonedaFixtureGettersProvider, MonedaFixtureGettersProvider>();
            services.AddScoped<IFixtureMoneda, FixtureMoneda>();
            services.AddScoped<IDomainSeeder<Moneda, string>, MonedaSeeder>();

            services.AddScoped<ICategoriaMarcaFixtureGetter, CategoriaMarcaFixtureGetter>();
            services.AddScoped<ICategoriaMarcaFixtureGettersProvider, CategoriaMarcaFixtureGettersProvider>();
            services.AddScoped<IFixtureCategoriaMarca, FixtureCategoriaMarca>();
            services.AddScoped<IDomainSeeder<CategoriaMarca, long>, CategoriaMarcaSeeder>();

            services.AddScoped<IMarcaFixtureGetter, MarcaFixtureGetter>();
            services.AddScoped<IMarcaFixtureGettersProvider, MarcaFixtureGettersProvider>();
            services.AddScoped<IFixtureMarca, FixtureMarca>();
            services.AddScoped<IDomainSeeder<Marca, long>, MarcaSeeder>();

            services.AddScoped<ISeeder<MarcaCategoriaMarca>, MarcaCategoriaMarcaSeeder>();

            services.AddScoped<IFuenteEnergiaFixtureGettersProvider, FuenteEnergiaFixtureGettersProvider>();
            services.AddScoped<IFixtureFuenteEnergia, FixtureFuenteEnergia>();
            services.AddScoped<IDomainSeeder<FuenteEnergia, long>, FuenteEnergiaSeeder>();

            services.AddScoped<IDataSeeder, DataSeeder>();
        }
    }
}
