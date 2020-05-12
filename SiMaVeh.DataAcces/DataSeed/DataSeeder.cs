using Microsoft.EntityFrameworkCore;
using SiMaVeh.Domain.DataSeed;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.DataSeed
{
    public class DataSeeder : IDataSeeder
    {
        private readonly ISeeder<Pais, long> paisSeeder;
        private readonly ISeeder<Provincia, long> provinciaSeeder;

        public DataSeeder()
        {
            paisSeeder = new PaisSeeder();
            provinciaSeeder = new ProvinciaSeeder();
        }

        public void SeedData(ModelBuilder builder)
        {
            //Para poder aplicar efectivamente los Seeds, hay que generar migrations.
            builder.Entity<Pais>().HasData(paisSeeder.GetSeeds());
            builder.Entity<Provincia>().HasData(provinciaSeeder.GetSeeds());
        }
    }
}
