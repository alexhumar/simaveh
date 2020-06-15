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
    public class MarcaFixtureGettersProvider : IMarcaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICategoriaMarcaFixtureGetter categoriaMarcaFixtureGetter;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        /// <param name="categoriaMarcaFixtureGetter"></param>
        public MarcaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder,
            ICategoriaMarcaFixtureGetter categoriaMarcaFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            this.categoriaMarcaFixtureGetter = categoriaMarcaFixtureGetter;
        }

        /// <summary>
        /// Retorna los providers de fixture getters de marcas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosMarca>> GetFixtureGetters()
        {
            return new List<IFixtureGetter<DatosMarca>>
            {
                new MarcaFixtureGetter(datosEntidadBuilder, categoriaMarcaFixtureGetter)
            };
        }
    }
}
