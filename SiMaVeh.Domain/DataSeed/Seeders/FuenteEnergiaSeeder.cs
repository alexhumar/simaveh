using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de fuente de energia
    /// </summary>
    public class FuenteEnergiaSeeder : IDomainSeeder<FuenteEnergia, long>
    {
        private readonly IFixtureFuenteEnergia fixtureFuenteEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureFuenteEnergia"></param>
        public FuenteEnergiaSeeder(IFixtureFuenteEnergia fixtureFuenteEnergia)
        {
            this.fixtureFuenteEnergia = fixtureFuenteEnergia;
        }

        /// <summary>
        /// Genera las fuentes de energia default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureFuenteEnergia.GetFuentesEnergia().Select(fuenteEnergiaFixture => new
            {
                fuenteEnergiaFixture.Id,
                fuenteEnergiaFixture.Nombre,
                MarcaId = fuenteEnergiaFixture.Marca.Id,
                TipoFuenteEnergiaId = fuenteEnergiaFixture.TipoFuenteEnergia.Id
            });
        }
    }
}
