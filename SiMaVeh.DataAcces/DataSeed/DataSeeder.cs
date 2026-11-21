using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.DataAccess.DataSeed
{
    /// <summary>
    /// Data seeder: aplica todos los seeders registrados (descubiertos por escaneo del ensamblado).
    /// Para agregar datos de seed alcanza con crear una clase que herede de SeederBase.
    /// </summary>
    /// <param name="aplicadoresSeed"></param>
    public class DataSeeder(IEnumerable<IAplicadorSeed> aplicadoresSeed) : IDataSeeder
    {
        private readonly IEnumerable<IAplicadorSeed> aplicadoresSeed = aplicadoresSeed;

        /// <summary>
        /// Seed data
        /// </summary>
        /// <param name="builder"></param>
        public void SeedData(ModelBuilder builder)
        {
            //Para poder aplicar efectivamente los Seeds, hay que generar migrations.
            foreach (var aplicadorSeed in aplicadoresSeed)
            {
                aplicadorSeed.Aplicar(builder);
            }
        }
    }
}
