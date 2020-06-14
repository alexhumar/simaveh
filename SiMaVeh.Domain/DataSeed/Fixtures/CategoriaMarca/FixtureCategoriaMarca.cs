using SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.CategoriaMarca
{
    /// <summary>
    /// Fixture con informacion de categorias de marca
    /// </summary>
    public class FixtureCategoriaMarca : IFixtureCategoriaMarca
    {
        private readonly ICategoriaMarcaFixtureGettersProvider categoriaMarcaFixtureGettersProvider;
        private IEnumerable<DatosEntidad> categoriasMarca;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="categoriaMarcaFixtureGettersProvider"></param>
        public FixtureCategoriaMarca(ICategoriaMarcaFixtureGettersProvider categoriaMarcaFixtureGettersProvider)
        {
            this.categoriaMarcaFixtureGettersProvider = categoriaMarcaFixtureGettersProvider;

            Initialize();
        }

        /// <summary>
        /// Retorna las marcas default
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DatosEntidad> GetCategoriasMarca()
        {
            return categoriasMarca;
        }

        private void Initialize()
        {
            categoriasMarca = categoriaMarcaFixtureGettersProvider
                .GetFixtureGetters()
                .SelectMany(l => l.Get());
        }
    }
}
