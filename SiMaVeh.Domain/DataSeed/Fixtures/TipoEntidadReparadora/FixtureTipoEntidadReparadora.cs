using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora
{
    /// <summary>
    /// Fixture con informacion de Tipos de Entidades Reparadoras
    /// </summary>
    public class FixtureTipoEntidadReparadora : IFixtureTipoEntidadReparadora
    {
        private readonly ITipoEntidadReparadoraFixtureGettersProvider tipoEntidadReparadoraFixtureGettersProvider;
        private IEnumerable<DatosEntidad> tiposEntidadReparadora;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureTipoEntidadReparadora()
        {
            tipoEntidadReparadoraFixtureGettersProvider = new TipoEntidadReparadoraFixtureGettersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Tipos Entidades Reparadoras
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosEntidad> GetTiposEntidadReparadora()
        {
            return tiposEntidadReparadora;
        }

        private void Initialize()
        {
            tiposEntidadReparadora = tipoEntidadReparadoraFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
