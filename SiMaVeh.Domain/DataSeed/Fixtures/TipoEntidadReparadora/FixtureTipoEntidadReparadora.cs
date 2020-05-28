using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora
{
    /// <summary>
    /// Fixture con informacion de Tipos de Entidades Reparadoras
    /// </summary>
    public class FixtureTipoEntidadReparadora : IFixtureTipoEntidadReparadora
    {
        private readonly ITipoEntidadReparadoraLoadersProvider tipoEntidadReparadoraLoadersProvider;
        private IDictionary<long, string> tiposEntidadReparadora;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureTipoEntidadReparadora()
        {
            tipoEntidadReparadoraLoadersProvider = new TipoEntidadReparadoraLoadersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Tipos Entidades Reparadoras
        /// </summary>
        /// <returns></returns>
        public IDictionary<long, string> GetTiposEntidadReparadora()
        {
            return tiposEntidadReparadora;
        }

        private void Initialize()
        {
            tiposEntidadReparadora = tipoEntidadReparadoraLoadersProvider
                .GetLoaders()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
