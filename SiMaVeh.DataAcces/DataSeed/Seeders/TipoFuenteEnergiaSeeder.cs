using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de fuente de energia
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureTipoFuenteEnergia"></param>
    public class TipoFuenteEnergiaSeeder(IFixtureTipoFuenteEnergia fixtureTipoFuenteEnergia) : IDomainSeeder<TipoFuenteEnergia, long>
    {
        private readonly IFixtureTipoFuenteEnergia fixtureTipoFuenteEnergia = fixtureTipoFuenteEnergia;

        /// <summary>
        /// Genera los tipos de fuente de energia default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureTipoFuenteEnergia.GetTiposFuenteEnergia().Select(tipoFuenteEnergiaFixture => new
            {
                tipoFuenteEnergiaFixture.Id,
                tipoFuenteEnergiaFixture.Nombre,
                tipoFuenteEnergiaFixture.Descripcion
            });
        }
    }
}
