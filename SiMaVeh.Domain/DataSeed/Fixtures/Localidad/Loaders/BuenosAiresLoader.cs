using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class BuenosAiresLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public BuenosAiresLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            //TODO: esta es una clase de prueba. Sirve de modelo para ver como generar los loaders de localidades.
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.AdolfoAlsina).Value.Key, new Dictionary<long, string>
            {
                //{ 1, LocalidadBuenosAires.Quilmes },
                //{ 2, LocalidadBuenosAires.Ezpeleta }
            });
        }
    }
}
