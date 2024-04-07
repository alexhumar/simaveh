using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Marca
{
    /// <summary>
    /// Provider de fixture getters de marcas
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="datosEntidadBuilder"></param>
    /// <param name="categoriaMarcaFixtureGetter"></param>
    public class MarcaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder,
        ICategoriaMarcaFixtureGetter categoriaMarcaFixtureGetter) : IMarcaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder = datosEntidadBuilder;
        private readonly ICategoriaMarcaFixtureGetter categoriaMarcaFixtureGetter = categoriaMarcaFixtureGetter;

        /// <summary>
        /// Retorna los providers de fixture getters de marcas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosMarca>> GetFixtureGetters()
        {
            return
            [
                new MarcaFixtureGetter(datosEntidadBuilder, categoriaMarcaFixtureGetter)
            ];
        }
    }
}
