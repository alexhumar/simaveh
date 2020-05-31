using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Base
{
    /// <summary>
    /// Provincia fixture getter
    /// </summary>
    public abstract class ProvinciaFixtureGetter : IProvinciaFixtureGetter
    {
        /// <summary>
        /// paisFixtureGetter
        /// </summary>
        protected readonly IPaisFixtureGetter paisFixtureGetter;

        /// <summary>
        /// datosEntidadBuilder
        /// </summary>
        protected readonly IDatosEntidadBuilder datosEntidadBuilder;

        /// <summary>
        /// provincias
        /// </summary>
        protected readonly IDictionary<long, List<DatosEntidad>> provincias;

        /// <summary>
        /// Inicializa las provincias
        /// </summary>
        protected abstract void Initialize();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        /// <param name="paisFixtureGetter"></param>
        public ProvinciaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPaisFixtureGetter paisFixtureGetter)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            this.paisFixtureGetter = paisFixtureGetter;
            provincias = new Dictionary<long, List<DatosEntidad>>();

            Initialize();
        }

        /// <summary>
        /// FindByNombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public DatosEntidad FindByNombre(string nombre)
        {
            return provincias
                .SelectMany(p => p.Value)
                .FirstOrDefault(p => p.Nombre == nombre);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public IDictionary<long, List<DatosEntidad>> Get()
        {
            return provincias;
        }
    }
}
