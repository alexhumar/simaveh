using SiMaVeh.Domain.DataSeed.Fixtures.TipoFuenteEnergia.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de fuente de energia
    /// </summary>
    public class TipoFuenteEnergiaSeeder : ISeeder<TipoFuenteEnergia, long>
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
            var result = new List<object>();

            foreach (var tipoFuenteEnergiaFixture in fixtureTipoFuenteEnergia.GetTiposFuenteEnergia())
            {
                result.Add(new
                {
                    tipoFuenteEnergiaFixture.Id,
                    tipoFuenteEnergiaFixture.Nombre,
                    tipoFuenteEnergiaFixture.Descripcion
                });
            }

            return result;
        }
    }
}
