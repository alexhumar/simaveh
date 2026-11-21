using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca
{
    /// <summary>
    /// Provider de fixture getters de categorias de marca
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="datosEntidadBuilder"></param>
    public class CategoriaMarcaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder) : ICategoriaMarcaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder = datosEntidadBuilder;

        /// <summary>
        /// Retorna los providers de fixture getters de categorias de marca
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosEntidad>> GetFixtureGetters()
        {
            return
            [
                new CategoriaMarcaFixtureGetter(datosEntidadBuilder)
            ];
        }
    }
}
