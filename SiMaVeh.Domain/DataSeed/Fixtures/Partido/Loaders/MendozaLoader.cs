using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class MendozaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public MendozaLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Mendoza).Value.Key, new Dictionary<long, string>
            {
                { 324, PartidoMendoza.Capital },
                { 325, PartidoMendoza.GeneralAlvear },
                { 326, PartidoMendoza.GodoyCruz },
                { 327, PartidoMendoza.Guaymallen },
                { 328, PartidoMendoza.Junin },
                { 329, PartidoMendoza.LaPaz },
                { 330, PartidoMendoza.LasHeras },
                { 331, PartidoMendoza.Lavalle },
                { 332, PartidoMendoza.LujanDeCuyo },
                { 333, PartidoMendoza.Maipu },
                { 334, PartidoMendoza.Malargue },
                { 335, PartidoMendoza.Rivadavia },
                { 336, PartidoMendoza.SanCarlos },
                { 337, PartidoMendoza.GeneralSanMartin },
                { 338, PartidoMendoza.SanRafael },
                { 339, PartidoMendoza.SantaRosa },
                { 340, PartidoMendoza.Tunuyan },
                { 341, PartidoMendoza.Tupungato }
            });
        }
    }
}
