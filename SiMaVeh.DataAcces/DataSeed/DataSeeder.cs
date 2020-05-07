using Microsoft.EntityFrameworkCore;
using SiMaVeh.Domain.DataSeed;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.DataSeed
{
    public class DataSeeder : IDataSeeder
    {
        private readonly ISeeder<Pais> paisSeeder;
        private readonly ISeeder<Provincia> provinciaSeeder;

        public DataSeeder()
        {
            paisSeeder = new PaisSeeder();
            provinciaSeeder = new ProvinciaSeeder();
        }

        public void SeedData(ModelBuilder builder)
        {
            //TODO - Para poder aplicar efectivamente los Seeds, hay que generar migrations.
            //Para eso, primero hay que revisar los modelos, ya que seguramente haya que incluir los Id de las tablas relacionadas
            //como propiedades del modelo.
            builder.Entity<Pais>().HasData(paisSeeder.GetSeeds());
            builder.Entity<Provincia>().HasData(provinciaSeeder.GetSeeds());
        }
    }
}
