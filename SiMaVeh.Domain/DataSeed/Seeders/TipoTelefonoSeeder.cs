using SiMaVeh.Domain.DataSeed.Fixtures.TipoTelefono.Interfaces;
using SiMaVeh.Domain.DataSeed.Interfaces;
using SiMaVeh.Domain.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Seeders
{
    /// <summary>
    /// Seeder de tipo de telefono
    /// </summary>
    public class TipoTelefonoSeeder : ISeeder<TipoTelefono, long>
    {
        private readonly IFixtureTipoTelefono fixtureTipoTelefono;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fixtureTipoTelefono"></param>
        public TipoTelefonoSeeder(IFixtureTipoTelefono fixtureTipoTelefono)
        {
            this.fixtureTipoTelefono = fixtureTipoTelefono;
        }

        /// <summary>
        /// Genera los tipos de telefono default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetSeeds()
        {
            var result = new List<object>();

            foreach (var tipoTelefonoFixture in fixtureTipoTelefono.GetTiposTelefono())
            {
                result.Add(new
                {
                    tipoTelefonoFixture.Id,
                    tipoTelefonoFixture.Nombre,
                    tipoTelefonoFixture.Descripcion
                });
            }

            return result;
        }
    }
}
