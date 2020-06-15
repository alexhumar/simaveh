using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Marca.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Marca.FixtureGetters
{
    /// <summary>
    /// Fixture getter de marca
    /// </summary>
    internal class MarcaFixtureGetter : IMarcaFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICategoriaMarcaFixtureGetter categoriaMarcaFixtureGetter;
        private readonly ICollection<DatosMarca> marcas;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        /// <param name="categoriaMarcaFixtureGetter"></param>
        public MarcaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            ICategoriaMarcaFixtureGetter categoriaMarcaFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            this.categoriaMarcaFixtureGetter = categoriaMarcaFixtureGetter;
            marcas = new List<DatosMarca>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosMarca> Get()
        {
            return marcas;
        }

        private void Initialize()
        {
            //TODO: implementar bien, esto es una prueba de concepto.
            var categoriaAutomovil = categoriaMarcaFixtureGetter.FindByNombre(Constants.CategoriasMarca.CategoriaMarca.Automovil);

            marcas.Add(datosEntidadBuilder.Build(1, "Marca de automovil, por ejemplo", new List<DatosEntidad> { categoriaAutomovil }));
        }
    }
}
