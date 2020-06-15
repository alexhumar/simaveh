using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de moneda
    /// </summary>
    public class MonedaSeeder : IDomainSeeder<Moneda, string>
    {
        private readonly IFixtureMoneda fixtureMoneda;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureMoneda"></param>
        public MonedaSeeder(IFixtureMoneda fixtureMoneda)
        {
            this.fixtureMoneda = fixtureMoneda;
        }

        /// <summary>
        /// Genera las monedas default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureMoneda.GetMonedas().Select(monedaFixture => new
            {
                monedaFixture.Id,
                monedaFixture.Nombre
            });
        }
    }
}
