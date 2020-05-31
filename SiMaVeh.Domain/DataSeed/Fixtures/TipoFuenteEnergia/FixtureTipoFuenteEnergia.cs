using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia
{
    /// <summary>
    /// Fixture con informacion de tipos de fuentes de energia
    /// </summary>
    public class FixtureTipoFuenteEnergia : IFixtureTipoFuenteEnergia
    {
        private readonly ITipoFuenteEnergiaFixtureGettersProvider tipoFuenteEnergiaFixtureGettersProvider;
        private IEnumerable<DatosEntidad> tiposFuenteEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tipoFuenteEnergiaFixtureGettersProvider"></param>
        public FixtureTipoFuenteEnergia(ITipoFuenteEnergiaFixtureGettersProvider tipoFuenteEnergiaFixtureGettersProvider)
        {
            this.tipoFuenteEnergiaFixtureGettersProvider = tipoFuenteEnergiaFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Retorna los tipos de fuente de energia default
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
