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

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Formosa).Value.Key, new Dictionary<long, string>
            {
                { 260, PartidoFormosa.Bermejo },
                { 261, PartidoFormosa.Formosa },
                { 262, PartidoFormosa.Laishi },
                { 263, PartidoFormosa.Matacos },
                { 264, PartidoFormosa.Patino },
                { 265, PartidoFormosa.Pilagas },
                { 266, PartidoFormosa.Pilcomayo },
                { 267, PartidoFormosa.Pirane },
                { 268, PartidoFormosa.RamonLista }
            });
        }
    }
}
