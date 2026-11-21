using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de moneda
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureMoneda"></param>
    public class MonedaSeeder(IFixtureMoneda fixtureMoneda) : SeederBase<Moneda>
    {
        private readonly IFixtureMoneda fixtureMoneda = fixtureMoneda;

        /// <summary>
        /// Genera las monedas default
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<object> GetSeeds()
        {
            return fixtureMoneda.GetMonedas().Select(monedaFixture => new
            {
                monedaFixture.Id,
                monedaFixture.Nombre
            });
        }
    }
}
