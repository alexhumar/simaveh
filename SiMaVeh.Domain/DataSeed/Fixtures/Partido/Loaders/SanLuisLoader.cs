using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SanLuisLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SanLuisLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SanLuis).Value.Key, new Dictionary<long, string>
            {
                { 431, PartidoSanLuis.Pueyrredon },
                { 432, PartidoSanLuis.Pedernera },
                { 433, PartidoSanLuis.Junin },
                { 434, PartidoSanLuis.Chacabuco },
                { 435, PartidoSanLuis.Ayacucho },
                { 436, PartidoSanLuis.CoronelPringles },
                { 437, PartidoSanLuis.GobernadorDupuy },
                { 438, PartidoSanLuis.LibertadorGeneralSanMartin },
                { 439, PartidoSanLuis.Belgrano }
            });
        }
    }
}
