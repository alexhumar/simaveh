using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora
{
    /// <summary>
    /// Provider de fixture getters de Tipos de Entidades Reparadoras
    /// </summary>
    public class TipoEntidadReparadoraFixtureGettersProvider : ITipoEntidadReparadoraFixtureGettersProvider
    {
        /// <summary>
        /// Retorna los providers de fixture getters de tipos de entidades reparadoras
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosEntidad>> GetFixtureGetters()
        {
            return new List<IFixtureGetter<DatosEntidad>>
            {
                new TipoEntidadReparadoraFixtureGetter()
            };
        }
    }
}
