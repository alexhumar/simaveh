using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SanLuisLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SanLuisLoader()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SanLuis).Value.Key, new Dictionary<long, string>
            {
                { 430, PartidoSanLuis.Pueyrredon },
                { 431, PartidoSanLuis.Pedernera },
                { 432, PartidoSanLuis.Junin },
                { 433, PartidoSanLuis.Chacabuco },
                { 434, PartidoSanLuis.Ayacucho },
                { 435, PartidoSanLuis.CoronelPringles },
                { 436, PartidoSanLuis.GobernadorDupuy },
                { 437, PartidoSanLuis.LibertadorGeneralSanMartin },
                { 438, PartidoSanLuis.Belgrano }
            });
        }
    }
}
