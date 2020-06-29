using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono
{
    /// <summary>
    /// Fixture con informacion de tipos de telefono
    /// </summary>
    public class FixtureTipoTelefono : IFixtureTipoTelefono
    {
        private readonly ITipoTelefonoFixtureGettersProvider tipoTelefonoFixtureGettersProvider;
        private IEnumerable<DatosEntidad> tiposTelefono;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tipoTelefonoFixtureGettersProvider"></param>
        public FixtureTipoTelefono(ITipoTelefonoFixtureGettersProvider tipoTelefonoFixtureGettersProvider)
        {
            this.tipoTelefonoFixtureGettersProvider = tipoTelefonoFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Retorna los tipos de telefono default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosEntidad> GetTiposTelefono()
        {
            return tiposTelefono;
        }

        private void Initialize()
        {
            tiposTelefono = tipoTelefonoFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
