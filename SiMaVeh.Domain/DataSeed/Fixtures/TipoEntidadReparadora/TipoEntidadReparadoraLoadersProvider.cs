using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Loaders;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora
{
    /// <summary>
    /// Provider de Loaders de Tipos de Entidades Reparadoras
    /// </summary>
    public class TipoEntidadReparadoraLoadersProvider : ITipoEntidadReparadoraLoadersProvider
    {
        /// <summary>
        /// Retorna los providers de loaders de tipos de entidades reparadoras
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFixtureKeyValueLoader<long, DatosEntidad>> GetLoaders()
        {
            return new List<IFixtureKeyValueLoader<long, DatosEntidad>>
            {
                new TipoEntidadReparadoraLoader()
            };
        }
    }
}
