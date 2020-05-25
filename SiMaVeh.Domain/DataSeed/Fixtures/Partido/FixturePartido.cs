using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido
{
    /// <summary>
    /// Fixture con informacion de Provincias
    /// </summary>
    public class FixturePartido : IFixturePartido
    {
        private readonly IPartidoLoadersProvider partidoLoadersProvider;
        private Dictionary<long, Dictionary<long, string>> partidos;

        /// <summary>
        /// Constructor
        /// </summary>
        public FixturePartido()
        {
            partidoLoadersProvider = new PartidoLoadersProvider();

            Initialize();
        }

        /// <summary>
        /// Get Provincias
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, Dictionary<long, string>> GetPartidos()
        {
            return partidos;
        }

        /// <summary>
        /// Find by Nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public KeyValuePair<long, string>? FindByNombre(string nombre)
        {
            //TODO: quizas esto se pueda refinar centralizandolo en una clase base.
            KeyValuePair<long, string>? result = null;

            foreach (var localidadesPartidos in partidos)
            {
                KeyValuePair<long, string>? provincia = localidadesPartidos.Value.FirstOrDefault(v => v.Value == nombre);

                if (provincia != null)
                {
                    result = provincia;
                    break;
                }
            }

            return result;
        }

        private void Initialize()
        {
            partidos = partidoLoadersProvider
                .GetLoaders()
                .SelectMany(l => l.Get())
                .ToDictionary(x => x.Key, y => y.Value);
        }
    }
}
