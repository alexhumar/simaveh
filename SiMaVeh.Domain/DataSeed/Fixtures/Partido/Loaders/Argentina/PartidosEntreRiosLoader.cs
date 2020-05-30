using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosEntreRiosLoader : PartidosLoader
    {
        public PartidosEntreRiosLoader(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.EntreRios).Key, new Dictionary<long, string>
            {
                { 243, PartidoEntreRios.Colon },
                { 244, PartidoEntreRios.Concordia },
                { 245, PartidoEntreRios.Diamante },
                { 246, PartidoEntreRios.Federacion },
                { 247, PartidoEntreRios.Federal },
                { 248, PartidoEntreRios.Feliciano },
                { 249, PartidoEntreRios.Gualeguay },
                { 250, PartidoEntreRios.Gualeguaychu },
                { 251, PartidoEntreRios.IslasDelIbicuy },
                { 252, PartidoEntreRios.LaPaz },
                { 253, PartidoEntreRios.Nogoya },
                { 254, PartidoEntreRios.Parana },
                { 255, PartidoEntreRios.SanSalvador },
                { 256, PartidoEntreRios.Tala },
                { 257, PartidoEntreRios.Uruguay },
                { 258, PartidoEntreRios.Victoria },
                { 259, PartidoEntreRios.Villaguay }
            });
        }
    }
}
