using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    internal class PartidoRioNegroFixtureGetter : PartidoFixtureGetter
    {
        public PartidoRioNegroFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.RioNegro).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(376, PartidoRioNegro.AdolfoAlsina),
                datosEntidadBuilder.Build(377, PartidoRioNegro.Avellaneda),
                datosEntidadBuilder.Build(378, PartidoRioNegro.Bariloche),
                datosEntidadBuilder.Build(379, PartidoRioNegro.Conesa),
                datosEntidadBuilder.Build(380, PartidoRioNegro.ElCuy),
                datosEntidadBuilder.Build(381, PartidoRioNegro.GeneralRoca),
                datosEntidadBuilder.Build(382, PartidoRioNegro.NueveDeJulio),
                datosEntidadBuilder.Build(383, PartidoRioNegro.Norquinco),
                datosEntidadBuilder.Build(384, PartidoRioNegro.PichiMahuida),
                datosEntidadBuilder.Build(385, PartidoRioNegro.Pilcaniyeu),
                datosEntidadBuilder.Build(386, PartidoRioNegro.SanAntonio),
                datosEntidadBuilder.Build(387, PartidoRioNegro.Valcheta),
                datosEntidadBuilder.Build(388, PartidoRioNegro.VeinticincoDeMayo)
            });
        }
    }
}
