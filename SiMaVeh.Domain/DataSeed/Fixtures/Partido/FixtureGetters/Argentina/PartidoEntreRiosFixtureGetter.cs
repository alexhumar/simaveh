using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    class PartidoEntreRiosFixtureGetter : PartidoFixtureGetter
    {
        public PartidoEntreRiosFixtureGetter(IProvinciaFixtureGetter provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.EntreRios).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(243, PartidoEntreRios.Colon),
                datosEntidadBuilder.Build(244, PartidoEntreRios.Concordia),
                datosEntidadBuilder.Build(245, PartidoEntreRios.Diamante),
                datosEntidadBuilder.Build(246, PartidoEntreRios.Federacion),
                datosEntidadBuilder.Build(247, PartidoEntreRios.Federal),
                datosEntidadBuilder.Build(248, PartidoEntreRios.Feliciano),
                datosEntidadBuilder.Build(249, PartidoEntreRios.Gualeguay),
                datosEntidadBuilder.Build(250, PartidoEntreRios.Gualeguaychu),
                datosEntidadBuilder.Build(251, PartidoEntreRios.IslasDelIbicuy),
                datosEntidadBuilder.Build(252, PartidoEntreRios.LaPaz),
                datosEntidadBuilder.Build(253, PartidoEntreRios.Nogoya),
                datosEntidadBuilder.Build(254, PartidoEntreRios.Parana),
                datosEntidadBuilder.Build(255, PartidoEntreRios.SanSalvador),
                datosEntidadBuilder.Build(256, PartidoEntreRios.Tala),
                datosEntidadBuilder.Build(257, PartidoEntreRios.Uruguay),
                datosEntidadBuilder.Build(258, PartidoEntreRios.Victoria),
                datosEntidadBuilder.Build(259, PartidoEntreRios.Villaguay)
            });
        }
    }
}
