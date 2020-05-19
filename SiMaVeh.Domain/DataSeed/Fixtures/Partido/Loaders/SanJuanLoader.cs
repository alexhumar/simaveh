using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SanJuanLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SanJuanLoader()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SanJuan).Value.Key, new Dictionary<long, string>
            {
                { 411, PartidoSanJuan.Albardon },
                { 412, PartidoSanJuan.Angaco },
                { 413, PartidoSanJuan.Calingasta },
                { 414, PartidoSanJuan.Capital },
                { 415, PartidoSanJuan.Caucete },
                { 416, PartidoSanJuan.Chimbas },
                { 417, PartidoSanJuan.Iglesia },
                { 418, PartidoSanJuan.Jachal },
                { 419, PartidoSanJuan.NueveDeJulio },
                { 420, PartidoSanJuan.Pocito },
                { 421, PartidoSanJuan.Rawson },
                { 422, PartidoSanJuan.Rivadavia },
                { 423, PartidoSanJuan.SanMartin },
                { 424, PartidoSanJuan.SantaLucia },
                { 425, PartidoSanJuan.Sarmiento },
                { 426, PartidoSanJuan.Ullum },
                { 427, PartidoSanJuan.ValleFertil },
                { 428, PartidoSanJuan.VeinticincoDeMayo },
                { 429, PartidoSanJuan.Zonda }
            });
        }
    }
}
