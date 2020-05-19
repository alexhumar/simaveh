using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class FormosaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public FormosaLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Formosa).Value.Key, new Dictionary<long, string>
            {
                { 259, PartidoFormosa.Bermejo },
                { 260, PartidoFormosa.Formosa },
                { 261, PartidoFormosa.Laishi },
                { 262, PartidoFormosa.Matacos },
                { 263, PartidoFormosa.Patino },
                { 264, PartidoFormosa.Pilagas },
                { 265, PartidoFormosa.Pilcomayo },
                { 266, PartidoFormosa.Pirane },
                { 267, PartidoFormosa.RamonLista }
            });
        }
    }
}
