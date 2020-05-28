using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosMisionesLoader : PartidosLoader
    {
        public PartidosMisionesLoader(IProvinciasLoader provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Misiones).Key, new Dictionary<long, string>
            {
                { 343, PartidoMisiones.Apostoles },
                { 344, PartidoMisiones.Cainguas },
                { 345, PartidoMisiones.Candelaria },
                { 346, PartidoMisiones.Capital },
                { 347, PartidoMisiones.Concepcion },
                { 348, PartidoMisiones.Eldorado },
                { 349, PartidoMisiones.GeneralManuelBelgrano },
                { 350, PartidoMisiones.Guarani },
                { 351, PartidoMisiones.Iguazu },
                { 352, PartidoMisiones.LeandroNAlem },
                { 353, PartidoMisiones.LibertadorGeneralSanMartin },
                { 354, PartidoMisiones.Montecarlo },
                { 355, PartidoMisiones.Obera },
                { 356, PartidoMisiones.SanIgnacio },
                { 357, PartidoMisiones.SanJavier },
                { 358, PartidoMisiones.SanPedro },
                { 359, PartidoMisiones.VeinticincoDeMayo }
            });
        }
    }
}
