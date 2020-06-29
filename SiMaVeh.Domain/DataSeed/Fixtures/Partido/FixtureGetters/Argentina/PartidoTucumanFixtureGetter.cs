using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    internal class PartidoTucumanFixtureGetter : PartidoFixtureGetter
    {
        public PartidoTucumanFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.Tucuman).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(498, PartidoTucuman.Burruyacu),
                datosEntidadBuilder.Build(499, PartidoTucuman.Capital),
                datosEntidadBuilder.Build(500, PartidoTucuman.Chicligasta),
                datosEntidadBuilder.Build(501, PartidoTucuman.CruzAlta),
                datosEntidadBuilder.Build(502, PartidoTucuman.Famailla),
                datosEntidadBuilder.Build(503, PartidoTucuman.Graneros),
                datosEntidadBuilder.Build(504, PartidoTucuman.JuanBautistaAlberdi),
                datosEntidadBuilder.Build(505, PartidoTucuman.LaCocha),
                datosEntidadBuilder.Build(506, PartidoTucuman.Leales),
                datosEntidadBuilder.Build(507, PartidoTucuman.Lules),
                datosEntidadBuilder.Build(508, PartidoTucuman.Monteros),
                datosEntidadBuilder.Build(509, PartidoTucuman.RioChico),
                datosEntidadBuilder.Build(510, PartidoTucuman.Simoca),
                datosEntidadBuilder.Build(511, PartidoTucuman.TafiDelValle),
                datosEntidadBuilder.Build(512, PartidoTucuman.TafiViejo),
                datosEntidadBuilder.Build(513, PartidoTucuman.Trancas),
                datosEntidadBuilder.Build(514, PartidoTucuman.YerbaBuena)
            });
        }
    }
}
