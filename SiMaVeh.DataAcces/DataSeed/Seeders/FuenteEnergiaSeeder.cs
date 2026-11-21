using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de fuente de energia
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureFuenteEnergia"></param>
    public class FuenteEnergiaSeeder(IFixtureFuenteEnergia fixtureFuenteEnergia) : SeederBase<FuenteEnergia>
    {
        private readonly IFixtureFuenteEnergia fixtureFuenteEnergia = fixtureFuenteEnergia;

        /// <summary>
        /// Genera las fuentes de energia default
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<object> GetSeeds()
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
