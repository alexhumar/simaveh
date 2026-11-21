using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora
{
    /// <summary>
    /// Provider de fixture getters de tipos de entidades reparadoras
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="datosEntidadBuilder"></param>
    public class TipoEntidadReparadoraFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder) : ITipoEntidadReparadoraFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder = datosEntidadBuilder;

        /// <summary>
        /// Retorna los providers de fixture getters de tipos de entidades reparadoras
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosEntidad>> GetFixtureGetters()
        {
            return
            [
                new TipoEntidadReparadoraFixtureGetter(datosEntidadBuilder)
            ];
        }
    }
}
