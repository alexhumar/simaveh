using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoLaPampaFixtureGetter : PartidoFixtureGetter
    {
        public PartidoLaPampaFixtureGetter(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.LaPampa).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(285, PartidoLaPampa.Atreuco),
                datosEntidadBuilder.Build(286, PartidoLaPampa.CaleuCaleu),
                datosEntidadBuilder.Build(287, PartidoLaPampa.Capital),
                datosEntidadBuilder.Build(288, PartidoLaPampa.Catrilo),
                datosEntidadBuilder.Build(289, PartidoLaPampa.Chalileo),
                datosEntidadBuilder.Build(290, PartidoLaPampa.Chapaleufu),
                datosEntidadBuilder.Build(291, PartidoLaPampa.ChicalCo),
                datosEntidadBuilder.Build(292, PartidoLaPampa.Conhelo),
                datosEntidadBuilder.Build(293, PartidoLaPampa.Curaco),
                datosEntidadBuilder.Build(294, PartidoLaPampa.Guatrache),
                datosEntidadBuilder.Build(295, PartidoLaPampa.Hucal),
                datosEntidadBuilder.Build(296, PartidoLaPampa.LihuelCalel),
                datosEntidadBuilder.Build(297, PartidoLaPampa.LimayMahuida),
                datosEntidadBuilder.Build(298, PartidoLaPampa.Loventue),
                datosEntidadBuilder.Build(299, PartidoLaPampa.Maraco),
                datosEntidadBuilder.Build(300, PartidoLaPampa.Puelen),
                datosEntidadBuilder.Build(301, PartidoLaPampa.QuemuQuemu),
                datosEntidadBuilder.Build(302, PartidoLaPampa.Rancul),
                datosEntidadBuilder.Build(303, PartidoLaPampa.Realico),
                datosEntidadBuilder.Build(304, PartidoLaPampa.Toay),
                datosEntidadBuilder.Build(305, PartidoLaPampa.Trenel),
                datosEntidadBuilder.Build(306, PartidoLaPampa.Utracan)
            });
        }
    }
}
