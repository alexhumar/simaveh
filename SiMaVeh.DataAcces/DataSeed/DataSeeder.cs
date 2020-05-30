using Microsoft.EntityFrameworkCore;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.DataSeed.Seeders;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.DataSeed
{
    public class DataSeeder : IDataSeeder
    {
        private readonly ISeeder<Pais, long> paisSeeder;
        private readonly ISeeder<Provincia, long> provinciaSeeder;
        private readonly ISeeder<Partido, long> partidoSeeder;
        private readonly ISeeder<Localidad, long> localidadSeeder;
        private readonly ISeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder;
        private readonly ISeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder;

        public DataSeeder()
        {
            paisSeeder = new PaisSeeder();
            provinciaSeeder = new ProvinciaSeeder();
            partidoSeeder = new PartidoSeeder();
            localidadSeeder = new LocalidadSeeder();
            tipoEntidadReparadoraSeeder = new TipoEntidadReparadoraSeeder();
            tipoFuenteEnergiaSeeder = new TipoFuenteEnergiaSeeder();
        }

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
