using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia
{
    /// <summary>
    /// Fixture con informacion de Tipos de Fuentes de Energia
    /// </summary>
    public class FixtureTipoFuenteEnergia : IFixtureTipoFuenteEnergia
    {
        private readonly ITipoFuenteEnergiaFixtureGettersProvider tipoFuenteEnergiaFixtureGettersProvider;
        private IEnumerable<DatosEntidad> tiposFuenteEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureTipoFuenteEnergia()
        {
            tipoFuenteEnergiaFixtureGettersProvider = new TipoFuenteEnergiaFixtureGettersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Tipos Fuente Energia
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosEntidad> GetTiposFuenteEnergia()
        {
            return tiposFuenteEnergia;
        }

        private void Initialize()
        {
            tiposFuenteEnergia = tipoFuenteEnergiaFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
