using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosCatamarcaLoader : PartidosLoader
    {
        public PartidosCatamarcaLoader(IProvinciasLoader provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Catamarca).Key, new Dictionary<long, string>
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
