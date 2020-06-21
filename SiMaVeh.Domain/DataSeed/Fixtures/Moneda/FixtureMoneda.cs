using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Moneda
{
    /// <summary>
    /// Fixture con informacion de monedas
    /// </summary>
    public class FixtureMoneda : IFixtureMoneda
    {
        private readonly IMonedaFixtureGettersProvider monedaFixtureGettersProvider;
        private IEnumerable<DatosMoneda> monedas;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="monedaFixtureGettersProvider"></param>
        public FixtureMoneda(IMonedaFixtureGettersProvider monedaFixtureGettersProvider)
        {
            this.monedaFixtureGettersProvider = monedaFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Get Monedas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosMoneda> GetMonedas()
        {
            return monedas;
        }

        private void Initialize()
        {
            monedas = monedaFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
