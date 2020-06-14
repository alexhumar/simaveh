using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.FixtureGetters
{
    /// <summary>
    /// Fixture getter de categoria de marca
    /// </summary>
    internal class CategoriaMarcaFixtureGetter : ICategoriaMarcaFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> categoriasMarca;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public CategoriaMarcaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            categoriasMarca = new List<DatosEntidad>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosEntidad> Get()
        {
            return categoriasMarca;
        }

        private void Initialize()
        {
            categoriasMarca.Add(datosEntidadBuilder.Build(1, Constants.CategoriasMarca.CategoriaMarca.Automovil));
            categoriasMarca.Add(datosEntidadBuilder.Build(2, Constants.CategoriasMarca.CategoriaMarca.Fluido));
            categoriasMarca.Add(datosEntidadBuilder.Build(3, Constants.CategoriasMarca.CategoriaMarca.FuenteEnergia));
            categoriasMarca.Add(datosEntidadBuilder.Build(4, Constants.CategoriasMarca.CategoriaMarca.Lubricante));
            categoriasMarca.Add(datosEntidadBuilder.Build(5, Constants.CategoriasMarca.CategoriaMarca.Neumatico));
            categoriasMarca.Add(datosEntidadBuilder.Build(6, Constants.CategoriasMarca.CategoriaMarca.Repuesto));
        }
    }
}
