using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de fuente de energia
    /// </summary>
    public class TipoFuenteEnergiaSeeder : IDomainSeeder<TipoFuenteEnergia, long>
    {
        private readonly IFixtureTipoFuenteEnergia fixtureTipoFuenteEnergia;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureTipoFuenteEnergia"></param>
        public TipoFuenteEnergiaSeeder(IFixtureTipoFuenteEnergia fixtureTipoFuenteEnergia)
        {
            this.fixtureTipoFuenteEnergia = fixtureTipoFuenteEnergia;
        }

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
