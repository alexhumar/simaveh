using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.FixtureGetters.Argentina
{
    internal class PartidoSantaCruzFixtureGetter : PartidoFixtureGetter
    {
        public PartidoSantaCruzFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IProvinciaFixtureGetter provinciaFixtureGetter)
            : base(datosEntidadBuilder, provinciaFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciaFixtureGetter.FindByNombre(ProvinciaArgentina.SantaCruz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(440, PartidoSantaCruz.Deseado),
                datosEntidadBuilder.Build(441, PartidoSantaCruz.GuerAike),
                datosEntidadBuilder.Build(442, PartidoSantaCruz.LagoArgentino),
                datosEntidadBuilder.Build(443, PartidoSantaCruz.CorpenAike),
                datosEntidadBuilder.Build(444, PartidoSantaCruz.Magallanes),
                datosEntidadBuilder.Build(445, PartidoSantaCruz.LagoBuenosAires),
                datosEntidadBuilder.Build(446, PartidoSantaCruz.RioChico)
            });
        }
    }
}
