using Microsoft.EntityFrameworkCore;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.DataSeed.Seeders;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.DataSeed
{
    /// <summary>
    /// Data seeder
    /// </summary>
    public class DataSeeder : IDataSeeder
    {
        private readonly ISeeder<Pais, long> paisSeeder;
        private readonly ISeeder<Provincia, long> provinciaSeeder;
        private readonly ISeeder<Partido, long> partidoSeeder;
        private readonly ISeeder<Localidad, long> localidadSeeder;
        private readonly ISeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder;
        private readonly ISeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder;
        private readonly ISeeder<TipoDocumento, long> tipoDocumentoSeeder;
        private readonly ISeeder<TipoTelefono, long> tipoTelefonoSeeder;
        private readonly ISeeder<UbicacionPieza, string> ubicacionPiezaSeeder;
        private readonly ISeeder<EquipamientoAirbags, string> equipamientoAirbagsSeeder;
        private readonly ISeeder<Moneda, string> monedaSeeder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paisSeeder"></param>
        /// <param name="provinciaSeeder"></param>
        /// <param name="partidoSeeder"></param>
        /// <param name="localidadSeeder"></param>
        /// <param name="tipoEntidadReparadoraSeeder"></param>
        /// <param name="tipoFuenteEnergiaSeeder"></param>
        /// <param name="tipoDocumentoSeeder"></param>
        /// <param name="tipoTelefonoSeeder"></param>
        /// <param name="ubicacionPiezaSeeder"></param>
        /// <param name="equipamientoAirbagsSeeder"></param>
        /// <param name="monedaSeeder"></param>
        public DataSeeder(ISeeder<Pais, long> paisSeeder,
            ISeeder<Provincia, long> provinciaSeeder,
            ISeeder<Partido, long> partidoSeeder,
            ISeeder<Localidad, long> localidadSeeder,
            ISeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder,
            ISeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder,
            ISeeder<TipoDocumento, long> tipoDocumentoSeeder,
            ISeeder<TipoTelefono, long> tipoTelefonoSeeder,
            ISeeder<UbicacionPieza, string> ubicacionPiezaSeeder,
            ISeeder<EquipamientoAirbags, string> equipamientoAirbagsSeeder,
            ISeeder<Moneda, string> monedaSeeder)
        {
            this.paisSeeder = paisSeeder;
            this.provinciaSeeder = provinciaSeeder;
            this.partidoSeeder = partidoSeeder;
            this.localidadSeeder = localidadSeeder;
            this.tipoEntidadReparadoraSeeder = tipoEntidadReparadoraSeeder;
            this.tipoFuenteEnergiaSeeder = tipoFuenteEnergiaSeeder;
            this.tipoDocumentoSeeder = tipoDocumentoSeeder;
            this.tipoTelefonoSeeder = tipoTelefonoSeeder;
            this.ubicacionPiezaSeeder = ubicacionPiezaSeeder;
            this.equipamientoAirbagsSeeder = equipamientoAirbagsSeeder;
            this.monedaSeeder = monedaSeeder;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataSeeder()
        {
            var datosEntidadBuilder = new DatosEntidadBuilder();
            var paisFixtureGetter = new PaisFixtureGetter(datosEntidadBuilder);

            paisSeeder = new PaisSeeder(new FixturePais(new PaisFixtureGettersProvider(datosEntidadBuilder)));
            provinciaSeeder = new ProvinciaSeeder(new FixtureProvincia(new ProvinciaFixtureGettersProvider(datosEntidadBuilder, paisFixtureGetter)));
            partidoSeeder = new PartidoSeeder(new FixturePartido(new PartidoFixtureGettersProvider(datosEntidadBuilder, paisFixtureGetter)));
            localidadSeeder = new LocalidadSeeder(new FixtureLocalidad(new LocalidadFixtureGettersProvider(datosEntidadBuilder, paisFixtureGetter)));
            tipoEntidadReparadoraSeeder = new TipoEntidadReparadoraSeeder(new FixtureTipoEntidadReparadora(new TipoEntidadReparadoraFixtureGettersProvider(datosEntidadBuilder)));
            tipoFuenteEnergiaSeeder = new TipoFuenteEnergiaSeeder(new FixtureTipoFuenteEnergia(new TipoFuenteEnergiaFixtureGettersProvider(datosEntidadBuilder)));
            tipoDocumentoSeeder = new TipoDocumentoSeeder(new FixtureTipoDocumento(new TipoDocumentoFixtureGettersProvider(datosEntidadBuilder)));
            tipoTelefonoSeeder = new TipoTelefonoSeeder(new FixtureTipoTelefono(new TipoTelefonoFixtureGettersProvider(datosEntidadBuilder)));
            ubicacionPiezaSeeder = new UbicacionPiezaSeeder(new FixtureUbicacionPieza(new UbicacionPiezaFixtureGettersProvider(datosEntidadBuilder)));
            equipamientoAirbagsSeeder = new EquipamientoAirbagsSeeder(new FixtureEquipamientoAirbags(new EquipamientoAirbagsFixtureGettersProvider(datosEntidadBuilder)));
            monedaSeeder = new MonedaSeeder(new FixtureMoneda(new MonedaFixtureGettersProvider(datosEntidadBuilder)));
        }

        /// <summary>
        /// Seed data
        /// </summary>
        /// <param name="builder"></param>
        public void SeedData(ModelBuilder builder)
        {
            //Para poder aplicar efectivamente los Seeds, hay que generar migrations.
            builder.Entity<Pais>().HasData(paisSeeder.GetSeeds());
            builder.Entity<Provincia>().HasData(provinciaSeeder.GetSeeds());
            builder.Entity<Partido>().HasData(partidoSeeder.GetSeeds());
            builder.Entity<Localidad>().HasData(localidadSeeder.GetSeeds());
            builder.Entity<TipoEntidadReparadora>().HasData(tipoEntidadReparadoraSeeder.GetSeeds());
            builder.Entity<TipoFuenteEnergia>().HasData(tipoFuenteEnergiaSeeder.GetSeeds());
            builder.Entity<TipoDocumento>().HasData(tipoDocumentoSeeder.GetSeeds());
            builder.Entity<TipoTelefono>().HasData(tipoTelefonoSeeder.GetSeeds());
            builder.Entity<UbicacionPieza>().HasData(ubicacionPiezaSeeder.GetSeeds());
            builder.Entity<EquipamientoAirbags>().HasData(equipamientoAirbagsSeeder.GetSeeds());
            builder.Entity<Moneda>().HasData(monedaSeeder.GetSeeds());
        }
    }
}
