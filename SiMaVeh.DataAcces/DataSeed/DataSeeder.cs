using Microsoft.EntityFrameworkCore;
using SiMaVeh.Domain.DataSeed;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.DataSeed
{
    public class DataSeeder : IDataSeeder
    {
        private readonly PaisSeeder paisSeeder;
        private readonly ProvinciaSeeder provinciaSeeder;

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

            var paises = paisSeeder.GetSeeds();
            builder.Entity<Pais>().HasData(paises);
            builder.Entity<Provincia>().HasData(provinciaSeeder.GetSeeds(paises));
        }
    }
}
