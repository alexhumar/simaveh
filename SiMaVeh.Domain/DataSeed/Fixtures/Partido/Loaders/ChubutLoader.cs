using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class ChubutLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public ChubutLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Chubut).Value.Key, new Dictionary<long, string>
            {
                { 177, PartidoChubut.Biedma },
                { 178, PartidoChubut.Cushamen },
                { 179, PartidoChubut.Escalante },
                { 180, PartidoChubut.FlorentinoAmeghino },
                { 181, PartidoChubut.Futaleufu },
                { 182, PartidoChubut.Gaiman },
                { 183, PartidoChubut.Gastre },
                { 184, PartidoChubut.Languineo },
                { 185, PartidoChubut.Martires },
                { 186, PartidoChubut.PasoDeIndios },
                { 187, PartidoChubut.Rawson },
                { 188, PartidoChubut.RioSenguer },
                { 189, PartidoChubut.Sarmiento },
                { 190, PartidoChubut.Tehuelches },
                { 191, PartidoChubut.Telsen }
            });
        }
    }
}
