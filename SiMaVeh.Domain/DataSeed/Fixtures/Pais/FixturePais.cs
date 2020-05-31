using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais
{
    /// <summary>
    /// Fixture con informacion de Paises
    /// </summary>
    public class FixturePais : IFixturePais
    {
        private readonly IPaisFixtureGettersProvider paisFixtureGettersProvider;
        private IEnumerable<DatosEntidad> paises;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paisFixtureGettersProvider"></param>
        public FixturePais(IPaisFixtureGettersProvider paisFixtureGettersProvider)
        {
            this.paisFixtureGettersProvider = paisFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Get Paises
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosEntidad> GetPaises()
        {
            return paises;
        }

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public DatosEntidad FindByNombre(string nombre)
        {
            return paises.FirstOrDefault(p => p.Nombre == nombre);
        }

        private void Initialize()
        {
            paises = paisFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
