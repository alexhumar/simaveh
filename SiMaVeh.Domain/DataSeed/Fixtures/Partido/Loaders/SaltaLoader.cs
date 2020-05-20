using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SaltaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SaltaLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Salta).Value.Key, new Dictionary<long, string>
            {
                { 388, PartidoSalta.Anta },
                { 389, PartidoSalta.Cachi },
                { 390, PartidoSalta.Cafayate },
                { 391, PartidoSalta.Capital },
                { 392, PartidoSalta.Cerrillos },
                { 393, PartidoSalta.Chicoana },
                { 394, PartidoSalta.GeneralGuemes },
                { 395, PartidoSalta.GeneralJoseDeSanMartin },
                { 396, PartidoSalta.Guachipas },
                { 397, PartidoSalta.Iruya },
                { 398, PartidoSalta.LaCaldera },
                { 399, PartidoSalta.LaCandelaria },
                { 400, PartidoSalta.LaPoma },
                { 401, PartidoSalta.LaVina },
                { 402, PartidoSalta.LosAndes },
                { 403, PartidoSalta.Metan },
                { 404, PartidoSalta.Molinos },
                { 405, PartidoSalta.Oran },
                { 406, PartidoSalta.Rivadavia },
                { 407, PartidoSalta.RosarioDeLaFrontera },
                { 408, PartidoSalta.RosarioDeLerma },
                { 409, PartidoSalta.SanCarlos },
                { 410, PartidoSalta.SantaVictoria }
            });
        }
    }
}
