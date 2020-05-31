using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais.FixtureGetters
{
    /// <summary>
    /// Fixture getter de pais
    /// </summary>
    public class PaisFixtureGetter : IPaisFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> paises;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public PaisFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            paises = new List<DatosEntidad>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosEntidad> Get()
        {
            return paises;
        }

        /// <summary>
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public DatosEntidad FindByNombre(string nombre)
        {
            return paises.FirstOrDefault(p => p.Nombre == nombre);
        }

        private void Initialize()
        {
            paises.Add(datosEntidadBuilder.Build(1, Constants.Paises.Pais.Argentina));
            paises.Add(datosEntidadBuilder.Build(2, Constants.Paises.Pais.Uruguay));
        }
    }
}
