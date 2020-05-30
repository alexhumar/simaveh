using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Loaders;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais
{
    /// <summary>
    /// Provider de fixture getters de Pais
    /// </summary>
    public class PaisFixtureGettersProvider : IPaisFixtureGettersProvider
    {
        /// <summary>
        /// Retorna los providers de fixture getters de pais
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureGetter<DatosEntidad>>
            {
                new PaisFixtureGetter()
            };
        }
    }
}
