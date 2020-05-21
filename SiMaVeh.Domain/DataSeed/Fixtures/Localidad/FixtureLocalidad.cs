using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Localidades
    /// </summary>
    public class FixtureLocalidad : IFixtureLocalidad
    {
        private readonly ILocalidadLoadersProvider localidadLoadersProvider;
        private Dictionary<long, Dictionary<long, string>> localidades;

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
        public Dictionary<long, Dictionary<long, string>> GetLocalidades()
        {
            return localidades;
        }

        private void Initialize()
        {
            localidades = new Dictionary<long, Dictionary<long, string>>();

            foreach (var loader in localidadLoadersProvider.GetLoaders())
            {
                loader.Load(localidades);
            }
        }
    }
}
