using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SanJuanLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SanJuanLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SanJuan).Value.Key, new Dictionary<long, string>
            {
                { 412, PartidoSanJuan.Albardon },
                { 413, PartidoSanJuan.Angaco },
                { 414, PartidoSanJuan.Calingasta },
                { 415, PartidoSanJuan.Capital },
                { 416, PartidoSanJuan.Caucete },
                { 417, PartidoSanJuan.Chimbas },
                { 418, PartidoSanJuan.Iglesia },
                { 419, PartidoSanJuan.Jachal },
                { 420, PartidoSanJuan.NueveDeJulio },
                { 421, PartidoSanJuan.Pocito },
                { 422, PartidoSanJuan.Rawson },
                { 423, PartidoSanJuan.Rivadavia },
                { 424, PartidoSanJuan.SanMartin },
                { 425, PartidoSanJuan.SantaLucia },
                { 426, PartidoSanJuan.Sarmiento },
                { 427, PartidoSanJuan.Ullum },
                { 428, PartidoSanJuan.ValleFertil },
                { 429, PartidoSanJuan.VeinticincoDeMayo },
                { 430, PartidoSanJuan.Zonda }
            });
        }
    }
}
