using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class MisionesLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public MisionesLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Misiones).Value.Key, new Dictionary<long, string>
            {
                { 342, PartidoMisiones.Apostoles },
                { 343, PartidoMisiones.Cainguas },
                { 344, PartidoMisiones.Candelaria },
                { 345, PartidoMisiones.Capital },
                { 346, PartidoMisiones.Concepcion },
                { 347, PartidoMisiones.Eldorado },
                { 348, PartidoMisiones.GeneralManuelBelgrano },
                { 349, PartidoMisiones.Guarani },
                { 350, PartidoMisiones.Iguazu },
                { 351, PartidoMisiones.LeandroNAlem },
                { 352, PartidoMisiones.LibertadorGeneralSanMartin },
                { 353, PartidoMisiones.Montecarlo },
                { 354, PartidoMisiones.Obera },
                { 355, PartidoMisiones.SanIgnacio },
                { 356, PartidoMisiones.SanJavier },
                { 357, PartidoMisiones.SanPedro },
                { 358, PartidoMisiones.VeinticincoDeMayo }
            });
        }
    }
}
