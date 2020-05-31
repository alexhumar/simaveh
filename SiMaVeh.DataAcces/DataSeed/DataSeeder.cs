using Microsoft.EntityFrameworkCore;
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paisSeeder"></param>
        /// <param name="provinciaSeeder"></param>
        /// <param name="partidoSeeder"></param>
        /// <param name="localidadSeeder"></param>
        /// <param name="tipoEntidadReparadoraSeeder"></param>
        /// <param name="tipoFuenteEnergiaSeeder"></param>
        public DataSeeder(ISeeder<Pais, long> paisSeeder,
            ISeeder<Provincia, long> provinciaSeeder,
            ISeeder<Partido, long> partidoSeeder,
            ISeeder<Localidad, long> localidadSeeder,
            ISeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder,
            ISeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder)
        {
            this.paisSeeder = paisSeeder;
            this.provinciaSeeder = provinciaSeeder;
            this.partidoSeeder = partidoSeeder;
            this.localidadSeeder = localidadSeeder;
            this.tipoEntidadReparadoraSeeder = tipoEntidadReparadoraSeeder;
            this.tipoFuenteEnergiaSeeder = tipoFuenteEnergiaSeeder;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataSeeder()
        {
            paisSeeder = new PaisSeeder();
            provinciaSeeder = new ProvinciaSeeder();
            partidoSeeder = new PartidoSeeder();
            localidadSeeder = new LocalidadSeeder();
            tipoEntidadReparadoraSeeder = new TipoEntidadReparadoraSeeder();
            tipoFuenteEnergiaSeeder = new TipoFuenteEnergiaSeeder();
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
        }
    }
}
