using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.FixtureGetters
{
    /// <summary>
    /// Fixture getter de categoria de marca
    /// </summary>
    public class CategoriaMarcaFixtureGetter : ICategoriaMarcaFixtureGetter
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
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public DatosEntidad FindByNombre(string nombre)
        {
            return categoriasMarca
                .FirstOrDefault(p => p.Nombre == nombre);
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
