using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SantaCruzLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SantaCruzLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SantaCruz).Value.Key, new Dictionary<long, string>
            {
                { 440, PartidoSantaCruz.Deseado },
                { 441, PartidoSantaCruz.GuerAike },
                { 442, PartidoSantaCruz.LagoArgentino },
                { 443, PartidoSantaCruz.CorpenAike },
                { 444, PartidoSantaCruz.Magallanes },
                { 445, PartidoSantaCruz.LagoBuenosAires },
                { 446, PartidoSantaCruz.RioChico }
            });
        }
    }
}
