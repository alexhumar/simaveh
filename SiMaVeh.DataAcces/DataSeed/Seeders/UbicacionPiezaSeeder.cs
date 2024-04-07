using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.UbicacionPieza.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.DataAccess.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de ubicacion pieza
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    /// <param name="fixtureUbicacionPieza"></param>
    public class UbicacionPiezaSeeder(IFixtureUbicacionPieza fixtureUbicacionPieza) : IDomainSeeder<UbicacionPieza, string>
    {
        private readonly IFixtureUbicacionPieza fixtureUbicacionPieza = fixtureUbicacionPieza;

        /// <summary>
        /// Genera las ubicaciones de pieza default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            return fixtureUbicacionPieza.GetUbicacionesPieza().Select(ubicacionPiezaFixture => new
            {
                ubicacionPiezaFixture.Id,
                ubicacionPiezaFixture.Izquierda,
                ubicacionPiezaFixture.Superior
            });
        }
    }
}
