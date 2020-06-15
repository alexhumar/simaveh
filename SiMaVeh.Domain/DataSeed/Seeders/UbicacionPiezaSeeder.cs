using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de ubicacion pieza
    /// </summary>
    public class UbicacionPiezaSeeder : IDomainSeeder<UbicacionPieza, string>
    {
        private readonly IFixtureUbicacionPieza fixtureUbicacionPieza;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureUbicacionPieza"></param>
        public UbicacionPiezaSeeder(IFixtureUbicacionPieza fixtureUbicacionPieza)
        {
            this.fixtureUbicacionPieza = fixtureUbicacionPieza;
        }

        /// <summary>
        /// Genera las ubicaciones de pieza default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureUbicacionPieza.GetUbicacionesPieza().Select(ubicacionPiezaFixture => new
            {
                ubicacionPiezaFixture.Izquierda,
                ubicacionPiezaFixture.Superior
            });
        }
    }
}
