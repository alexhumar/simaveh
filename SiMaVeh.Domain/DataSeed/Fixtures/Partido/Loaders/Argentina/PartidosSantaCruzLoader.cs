using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosSantaCruzLoader : PartidosLoader
    {
        public PartidosSantaCruzLoader(IProvinciasLoader<long, long, string> provinciasLoader)
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
