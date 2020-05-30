using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosFormosaLoader : PartidosLoader
    {
        public PartidosFormosaLoader(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Formosa).Key, new Dictionary<long, string>
            {
                { 260, PartidoFormosa.Bermejo },
                { 261, PartidoFormosa.Formosa },
                { 262, PartidoFormosa.Laishi },
                { 263, PartidoFormosa.Matacos },
                { 264, PartidoFormosa.Patino },
                { 265, PartidoFormosa.Pilagas },
                { 266, PartidoFormosa.Pilcomayo },
                { 267, PartidoFormosa.Pirane },
                { 268, PartidoFormosa.RamonLista }
            });
        }
    }
}
