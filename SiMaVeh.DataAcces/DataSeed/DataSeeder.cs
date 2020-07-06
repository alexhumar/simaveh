using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.DataSeed.Seeders;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.EquipamientoAirbags;
using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoDocumento;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza;
using SiMaVeh.Domain.Models;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags;
using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza;
using SiMaVeh.Domain.Models.Relations;

namespace SiMaVeh.DataAccess.DataSeed
{
    /// <summary>
    /// Data seeder
    /// </summary>
    public class DataSeeder : IDataSeeder
    {
        private readonly IDomainSeeder<Pais, long> paisSeeder;
        private readonly IDomainSeeder<Provincia, long> provinciaSeeder;
        private readonly IDomainSeeder<Partido, long> partidoSeeder;
        private readonly IDomainSeeder<Localidad, long> localidadSeeder;
        private readonly IDomainSeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder;
        private readonly IDomainSeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder;
        private readonly IDomainSeeder<TipoDocumento, long> tipoDocumentoSeeder;
        private readonly IDomainSeeder<TipoTelefono, long> tipoTelefonoSeeder;
        private readonly IDomainSeeder<UbicacionPieza, string> ubicacionPiezaSeeder;
        private readonly IDomainSeeder<EquipamientoAirbags, string> equipamientoAirbagsSeeder;
        private readonly IDomainSeeder<Moneda, string> monedaSeeder;
        private readonly IDomainSeeder<CategoriaMarca, long> categoriaMarcaSeeder;
        private readonly IDomainSeeder<Marca, long> marcaSeeder;
        private readonly ISeeder<MarcaCategoriaMarca> marcaCategoriaMarcaSeeder;
        private readonly IDomainSeeder<FuenteEnergia, long> fuenteEnergiaSeeder;

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
        /// <param name="categoriaMarcaSeeder"></param>
        /// <param name="marcaSeeder"></param>
        /// <param name="marcaCategoriaMarcaSeeder"></param>
        /// <param name="fuenteEnergiaSeeder"></param>
        public DataSeeder(IDomainSeeder<Pais, long> paisSeeder,
            IDomainSeeder<Provincia, long> provinciaSeeder,
            IDomainSeeder<Partido, long> partidoSeeder,
            IDomainSeeder<Localidad, long> localidadSeeder,
            IDomainSeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder,
            IDomainSeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder,
            IDomainSeeder<TipoDocumento, long> tipoDocumentoSeeder,
            IDomainSeeder<TipoTelefono, long> tipoTelefonoSeeder,
            IDomainSeeder<UbicacionPieza, string> ubicacionPiezaSeeder,
            IDomainSeeder<EquipamientoAirbags, string> equipamientoAirbagsSeeder,
            IDomainSeeder<Moneda, string> monedaSeeder,
            IDomainSeeder<CategoriaMarca, long> categoriaMarcaSeeder,
            IDomainSeeder<Marca, long> marcaSeeder,
            ISeeder<MarcaCategoriaMarca> marcaCategoriaMarcaSeeder,
            IDomainSeeder<FuenteEnergia, long> fuenteEnergiaSeeder)
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
            this.marcaSeeder = marcaSeeder;
            this.categoriaMarcaSeeder = categoriaMarcaSeeder;
            this.marcaCategoriaMarcaSeeder = marcaCategoriaMarcaSeeder;
            this.fuenteEnergiaSeeder = fuenteEnergiaSeeder;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataSeeder()
        {
            var calculadorIdEquipamientoAirbags = new CalculadorIdEquipamientoAirbags();
            var calculadorIdUbicacionPieza = new CalculadorIdUbicacionPieza();
            var datosEntidadBuilder = new DatosEntidadBuilder(calculadorIdEquipamientoAirbags, calculadorIdUbicacionPieza);
            var paisFixtureGetter = new PaisFixtureGetter(datosEntidadBuilder);
            var categoriaMarcaFixtureGetter = new CategoriaMarcaFixtureGetter(datosEntidadBuilder);
            var fixtureMarca = new FixtureMarca(new MarcaFixtureGettersProvider(datosEntidadBuilder, categoriaMarcaFixtureGetter));
            var marcaFixtureGetter = new MarcaFixtureGetter(datosEntidadBuilder, categoriaMarcaFixtureGetter);
            var tipoFuenteEnergiaFixtureGetter = new TipoFuenteEnergiaFixtureGetter(datosEntidadBuilder);

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
            categoriaMarcaSeeder = new CategoriaMarcaSeeder(new FixtureCategoriaMarca(new CategoriaMarcaFixtureGettersProvider(datosEntidadBuilder)));
            marcaSeeder = new MarcaSeeder(fixtureMarca);
            marcaCategoriaMarcaSeeder = new MarcaCategoriaMarcaSeeder(fixtureMarca);
            fuenteEnergiaSeeder = new FuenteEnergiaSeeder(new FixtureFuenteEnergia(new FuenteEnergiaFixtureGettersProvider(datosEntidadBuilder, marcaFixtureGetter, tipoFuenteEnergiaFixtureGetter)));
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
            builder.Entity<CategoriaMarca>().HasData(categoriaMarcaSeeder.GetSeeds());
            builder.Entity<Marca>().HasData(marcaSeeder.GetSeeds());
            builder.Entity<MarcaCategoriaMarca>().HasData(marcaCategoriaMarcaSeeder.GetSeeds());
            builder.Entity<FuenteEnergia>().HasData(fuenteEnergiaSeeder.GetSeeds());
        }
    }
}
