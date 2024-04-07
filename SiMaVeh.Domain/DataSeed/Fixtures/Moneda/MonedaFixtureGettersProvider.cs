using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Moneda
{
    /// <summary>
    /// Provider de fixture getters de monedas
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="datosEntidadBuilder"></param>
    public class MonedaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder) : IMonedaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder = datosEntidadBuilder;

        /// <summary>
        /// Retorna los providers de fixture getters de moneda
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosMoneda>> GetFixtureGetters()
        {
            return
            [
                new MonedaFixtureGetter(datosEntidadBuilder)
            ];
        }
    }
}
