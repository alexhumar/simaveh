using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosSantaCruzLoader : PartidosLoader
    {
        public PartidosSantaCruzLoader(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.SantaCruz).Key, new Dictionary<long, string>
            {
                { 440, PartidoSantaCruz.Deseado },
                { 441, PartidoSantaCruz.GuerAike },
                { 442, PartidoSantaCruz.LagoArgentino },
                { 443, PartidoSantaCruz.CorpenAike },
                { 444, PartidoSantaCruz.Magallanes },
                { 445, PartidoSantaCruz.LagoBuenosAires },
                { 446, PartidoSantaCruz.RioChico }
            });
        }
    }
}
