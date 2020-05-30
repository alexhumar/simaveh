using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosSaltaLoader : PartidosLoader
    {
        public PartidosSaltaLoader(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Salta).Key, new Dictionary<long, string>
            {
                { 389, PartidoSalta.Anta },
                { 390, PartidoSalta.Cachi },
                { 391, PartidoSalta.Cafayate },
                { 392, PartidoSalta.Capital },
                { 393, PartidoSalta.Cerrillos },
                { 394, PartidoSalta.Chicoana },
                { 395, PartidoSalta.GeneralGuemes },
                { 396, PartidoSalta.GeneralJoseDeSanMartin },
                { 397, PartidoSalta.Guachipas },
                { 398, PartidoSalta.Iruya },
                { 399, PartidoSalta.LaCaldera },
                { 400, PartidoSalta.LaCandelaria },
                { 401, PartidoSalta.LaPoma },
                { 402, PartidoSalta.LaVina },
                { 403, PartidoSalta.LosAndes },
                { 404, PartidoSalta.Metan },
                { 405, PartidoSalta.Molinos },
                { 406, PartidoSalta.Oran },
                { 407, PartidoSalta.Rivadavia },
                { 408, PartidoSalta.RosarioDeLaFrontera },
                { 409, PartidoSalta.RosarioDeLerma },
                { 410, PartidoSalta.SanCarlos },
                { 411, PartidoSalta.SantaVictoria }
            });
        }
    }
}
