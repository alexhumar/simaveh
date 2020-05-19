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

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SantaCruz).Value.Key, new Dictionary<long, string>
            {
                { 439, PartidoSantaCruz.Deseado },
                { 440, PartidoSantaCruz.GuerAike },
                { 441, PartidoSantaCruz.LagoArgentino },
                { 442, PartidoSantaCruz.CorpenAike },
                { 443, PartidoSantaCruz.Magallanes },
                { 444, PartidoSantaCruz.LagoBuenosAires },
                { 445, PartidoSantaCruz.RioChico }
            });
        }
    }
}
