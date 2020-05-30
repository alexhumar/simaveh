using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad
{
    /// <summary>
    /// Fixture con informacion de Localidades
    /// </summary>
    public class FixtureLocalidad : IFixtureLocalidad
    {
        private readonly ILocalidadFixtureGettersProvider localidadFixtureGettersProvider;
        private IDictionary<long, List<DatosEntidad>> localidades;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureLocalidad()
        {
            localidadFixtureGettersProvider = new LocalidadFixtureGettersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Localidades
        /// </summary>
        /// <returns></returns>
        public IDictionary<long, List<DatosEntidad>> GetLocalidades()
        {
            return localidades;
        }

        private void Initialize()
        {
            localidades = localidadFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
