using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad
{
    /// <summary>
    /// Fixture con informacion de Localidades
    /// </summary>
    public class FixtureLocalidad : IFixtureLocalidad
    {
        private readonly ILocalidadLoadersProvider localidadLoadersProvider;
        private IDictionary<long, IDictionary<long, string>> localidades;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixtureLocalidad()
        {
            localidadLoadersProvider = new LocalidadLoadersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Localidades
        /// </summary>
        /// <returns></returns>
        public IDictionary<long, IDictionary<long, string>> GetLocalidades()
        {
            return localidades;
        }

        private void Initialize()
        {
            localidades = localidadLoadersProvider
                .GetLoaders()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
