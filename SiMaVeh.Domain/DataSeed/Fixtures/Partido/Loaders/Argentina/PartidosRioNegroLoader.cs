using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosRioNegroLoader : PartidosLoader
    {
        public PartidosRioNegroLoader(IProvinciasLoader<long, long, string> provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.RioNegro).Key, new Dictionary<long, string>
            {
                { 376, PartidoRioNegro.AdolfoAlsina },
                { 377, PartidoRioNegro.Avellaneda },
                { 378, PartidoRioNegro.Bariloche },
                { 379, PartidoRioNegro.Conesa },
                { 380, PartidoRioNegro.ElCuy },
                { 381, PartidoRioNegro.GeneralRoca },
                { 382, PartidoRioNegro.NueveDeJulio },
                { 383, PartidoRioNegro.Norquinco },
                { 384, PartidoRioNegro.PichiMahuida },
                { 385, PartidoRioNegro.Pilcaniyeu },
                { 386, PartidoRioNegro.SanAntonio },
                { 387, PartidoRioNegro.Valcheta },
                { 388, PartidoRioNegro.VeinticincoDeMayo }
            });
        }
    }
}
