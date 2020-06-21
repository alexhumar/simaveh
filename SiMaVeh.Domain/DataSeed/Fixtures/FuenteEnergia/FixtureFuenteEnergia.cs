using SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.FuenteEnergia
{
    /// <summary>
    /// Fixture con informacion de fuentes de energia
    /// </summary>
    public class FixtureFuenteEnergia : IFixtureFuenteEnergia
    {
        private readonly IFuenteEnergiaFixtureGettersProvider fuenteEnergiaFixtureGettersProvider;
        private IEnumerable<DatosFuenteEnergia> fuentesEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fuenteEnergiaFixtureGettersProvider"></param>
        public FixtureFuenteEnergia(IFuenteEnergiaFixtureGettersProvider fuenteEnergiaFixtureGettersProvider)
        {
            this.fuenteEnergiaFixtureGettersProvider = fuenteEnergiaFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Get Fuentes Energia
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosFuenteEnergia> GetFuentesEnergia()
        {
            return fuentesEnergia;
        }

        private void Initialize()
        {
            fuentesEnergia = fuenteEnergiaFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
