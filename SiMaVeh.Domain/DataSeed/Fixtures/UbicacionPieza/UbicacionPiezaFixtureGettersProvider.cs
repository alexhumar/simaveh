using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.FixtureGetters;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza
{
    /// <summary>
    /// Provider de fixture getters de ubicaciones de pieza
    /// </summary>
    public class UbicacionPiezaFixtureGettersProvider : IUbicacionPiezaFixtureGettersProvider
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public UbicacionPiezaFixtureGettersProvider(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
        }

        /// <summary>
        /// Retorna los providers de fixture getters de ubicaciones de pieza
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureGetter<DatosUbicacionPieza>> GetFixtureGetters()
        {
            return new List<IFixtureGetter<DatosUbicacionPieza>>
            {
                new UbicacionPiezaFixtureGetter(datosEntidadBuilder)
            };
        }
    }
}
