using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class CatamarcaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public CatamarcaLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Catamarca).Value.Key, new Dictionary<long, string>
            {
                { 136, PartidoCatamarca.Ambato },
                { 137, PartidoCatamarca.Ancasti },
                { 138, PartidoCatamarca.Andalgala },
                { 139, PartidoCatamarca.AntofagastaDeLaSierra },
                { 140, PartidoCatamarca.Belen },
                { 141, PartidoCatamarca.Capayan },
                { 142, PartidoCatamarca.Capital },
                { 143, PartidoCatamarca.ElAlto },
                { 144, PartidoCatamarca.FrayMamertoEsquiu },
                { 145, PartidoCatamarca.LaPaz },
                { 146, PartidoCatamarca.Paclin },
                { 147, PartidoCatamarca.Poman },
                { 148, PartidoCatamarca.SantaMaria },
                { 149, PartidoCatamarca.SantaRosa },
                { 150, PartidoCatamarca.Tinogasta },
                { 151, PartidoCatamarca.ValleViejo }
            });
        }
    }
}
