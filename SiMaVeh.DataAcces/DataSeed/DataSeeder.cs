using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.DataAccess.Model.Relations;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.DataSeed
{
    /// <summary>
    /// Data seeder
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
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
    public class DataSeeder(IDomainSeeder<Pais, long> paisSeeder,
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
        IDomainSeeder<FuenteEnergia, long> fuenteEnergiaSeeder) : IDataSeeder
    {
        private readonly IDomainSeeder<Pais, long> paisSeeder = paisSeeder;
        private readonly IDomainSeeder<Provincia, long> provinciaSeeder = provinciaSeeder;
        private readonly IDomainSeeder<Partido, long> partidoSeeder = partidoSeeder;
        private readonly IDomainSeeder<Localidad, long> localidadSeeder = localidadSeeder;
        private readonly IDomainSeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder = tipoEntidadReparadoraSeeder;
        private readonly IDomainSeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder = tipoFuenteEnergiaSeeder;
        private readonly IDomainSeeder<TipoDocumento, long> tipoDocumentoSeeder = tipoDocumentoSeeder;
        private readonly IDomainSeeder<TipoTelefono, long> tipoTelefonoSeeder = tipoTelefonoSeeder;
        private readonly IDomainSeeder<UbicacionPieza, string> ubicacionPiezaSeeder = ubicacionPiezaSeeder;
        private readonly IDomainSeeder<EquipamientoAirbags, string> equipamientoAirbagsSeeder = equipamientoAirbagsSeeder;
        private readonly IDomainSeeder<Moneda, string> monedaSeeder = monedaSeeder;
        private readonly IDomainSeeder<CategoriaMarca, long> categoriaMarcaSeeder = categoriaMarcaSeeder;
        private readonly IDomainSeeder<Marca, long> marcaSeeder = marcaSeeder;
        private readonly ISeeder<MarcaCategoriaMarca> marcaCategoriaMarcaSeeder = marcaCategoriaMarcaSeeder;
        private readonly IDomainSeeder<FuenteEnergia, long> fuenteEnergiaSeeder = fuenteEnergiaSeeder;

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
