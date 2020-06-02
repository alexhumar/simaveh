using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza
{
    /// <summary>
    /// Fixture con informacion de ubicaciones de pieza
    /// </summary>
    public class FixtureUbicacionPieza : IFixtureUbicacionPieza
    {
        private readonly IUbicacionPiezaFixtureGettersProvider ubicacionPiezaFixtureGettersProvider;
        private IEnumerable<DatosUbicacionPieza> ubicacionesPieza;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ubicacionPiezaFixtureGettersProvider"></param>
        public FixtureUbicacionPieza(IUbicacionPiezaFixtureGettersProvider ubicacionPiezaFixtureGettersProvider)
        {
            this.ubicacionPiezaFixtureGettersProvider = ubicacionPiezaFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Retorna las ubicaciones de pieza default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosUbicacionPieza> GetUbicacionesPieza()
        {
            return ubicacionesPieza;
        }

        private void Initialize()
        {
            ubicacionesPieza = ubicacionPiezaFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
