using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class EntreRiosLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public EntreRiosLoader()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.EntreRios).Value.Key, new Dictionary<long, string>
            {
                { 242, PartidoEntreRios.Colon },
                { 243, PartidoEntreRios.Concordia },
                { 244, PartidoEntreRios.Diamante },
                { 245, PartidoEntreRios.Federacion },
                { 246, PartidoEntreRios.Federal },
                { 247, PartidoEntreRios.Feliciano },
                { 248, PartidoEntreRios.Gualeguay },
                { 249, PartidoEntreRios.Gualeguaychu },
                { 250, PartidoEntreRios.IslasDelIbicuy },
                { 251, PartidoEntreRios.LaPaz },
                { 252, PartidoEntreRios.Nogoya },
                { 253, PartidoEntreRios.Parana },
                { 254, PartidoEntreRios.SanSalvador },
                { 255, PartidoEntreRios.Tala },
                { 256, PartidoEntreRios.Uruguay },
                { 257, PartidoEntreRios.Victoria },
                { 258, PartidoEntreRios.Villaguay }
            });
        }
    }
}
