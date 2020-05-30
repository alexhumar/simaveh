using SiMaVeh.Domain.DataSeed.Fixtures.Builders;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Pais.Loaders
{
    class PaisFixtureGetter : IPaisFixtureGetter
    {
        private readonly DatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosEntidad> paises;

        public PaisFixtureGetter()
        {
            datosEntidadBuilder = new DatosEntidadBuilder();
            paises = new List<DatosEntidad>();

            Initialize();
        }

        public ICollection<DatosEntidad> Get()
        {
            return paises;
        }

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
