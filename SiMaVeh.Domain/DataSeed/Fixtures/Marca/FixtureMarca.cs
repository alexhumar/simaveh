using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Marca
{
    /// <summary>
    /// Fixture con informacion de marcas
    /// </summary>
    public class FixtureMarca : IFixtureMarca
    {
        private readonly IMarcaFixtureGettersProvider marcaFixtureGettersProvider;
        private IEnumerable<DatosMarca> marcas;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marcaFixtureGettersProvider"></param>
        public FixtureMarca(IMarcaFixtureGettersProvider marcaFixtureGettersProvider)
        {
            this.marcaFixtureGettersProvider = marcaFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Retorna las marcas default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosMarca> GetMarcas()
        {
            return marcas;
        }

        private void Initialize()
        {
            marcas = marcaFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
