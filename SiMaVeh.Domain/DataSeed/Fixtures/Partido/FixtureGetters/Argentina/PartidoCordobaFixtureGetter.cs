using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoCordobaFixtureGetter : PartidoFixtureGetter
    {
        public PartidoCordobaFixtureGetter(IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Cordoba).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(192, PartidoCordoba.Calamuchita),
                datosEntidadBuilder.Build(193, PartidoCordoba.Capital),
                datosEntidadBuilder.Build(194, PartidoCordoba.Colon),
                datosEntidadBuilder.Build(195, PartidoCordoba.CruzDelEje),
                datosEntidadBuilder.Build(196, PartidoCordoba.GeneralRoca),
                datosEntidadBuilder.Build(197, PartidoCordoba.GeneralSanMartin),
                datosEntidadBuilder.Build(198, PartidoCordoba.Ischilin),
                datosEntidadBuilder.Build(199, PartidoCordoba.JuarezCelman),
                datosEntidadBuilder.Build(200, PartidoCordoba.MarcosJuarez),
                datosEntidadBuilder.Build(201, PartidoCordoba.Minas),
                datosEntidadBuilder.Build(202, PartidoCordoba.Pocho),
                datosEntidadBuilder.Build(203, PartidoCordoba.PresidenteRoqueSaenzPena),
                datosEntidadBuilder.Build(204, PartidoCordoba.Punilla),
                datosEntidadBuilder.Build(205, PartidoCordoba.RioCuarto),
                datosEntidadBuilder.Build(206, PartidoCordoba.RioPrimero),
                datosEntidadBuilder.Build(207, PartidoCordoba.RioSeco),
                datosEntidadBuilder.Build(208, PartidoCordoba.RioSegundo),
                datosEntidadBuilder.Build(209, PartidoCordoba.SanAlberto),
                datosEntidadBuilder.Build(210, PartidoCordoba.SanJavier),
                datosEntidadBuilder.Build(211, PartidoCordoba.SanJusto),
                datosEntidadBuilder.Build(212, PartidoCordoba.SantaMaria),
                datosEntidadBuilder.Build(213, PartidoCordoba.Sobremonte),
                datosEntidadBuilder.Build(214, PartidoCordoba.TerceroArriba),
                datosEntidadBuilder.Build(215, PartidoCordoba.Totoral),
                datosEntidadBuilder.Build(216, PartidoCordoba.Tulumba),
                datosEntidadBuilder.Build(217, PartidoCordoba.Union)
            });
        }
    }
}
