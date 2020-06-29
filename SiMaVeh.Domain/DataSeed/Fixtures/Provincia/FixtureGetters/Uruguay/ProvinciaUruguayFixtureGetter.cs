using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Uruguay
{
    internal class ProvinciaUruguayFixtureGetter : ProvinciaFixtureGetter
    {
        public ProvinciaUruguayFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPaisFixtureGetter paisFixtureGetter)
            : base(datosEntidadBuilder, paisFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            provincias.Add(paisFixtureGetter.FindByNombre(Constants.Paises.Pais.Uruguay).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(24, ProvinciaUruguay.Artigas),
                datosEntidadBuilder.Build(25, ProvinciaUruguay.Canelones),
                datosEntidadBuilder.Build(26, ProvinciaUruguay.CerroLargo),
                datosEntidadBuilder.Build(27, ProvinciaUruguay.Colonia),
                datosEntidadBuilder.Build(28, ProvinciaUruguay.Durazno),
                datosEntidadBuilder.Build(29, ProvinciaUruguay.Flores),
                datosEntidadBuilder.Build(30, ProvinciaUruguay.Florida),
                datosEntidadBuilder.Build(31, ProvinciaUruguay.Lavalleja),
                datosEntidadBuilder.Build(32, ProvinciaUruguay.Maldonado),
                datosEntidadBuilder.Build(33, ProvinciaUruguay.Montevideo),
                datosEntidadBuilder.Build(34, ProvinciaUruguay.Paysandú),
                datosEntidadBuilder.Build(35, ProvinciaUruguay.RioNegro),
                datosEntidadBuilder.Build(36, ProvinciaUruguay.Rivera),
                datosEntidadBuilder.Build(37, ProvinciaUruguay.Rocha),
                datosEntidadBuilder.Build(38, ProvinciaUruguay.Salto),
                datosEntidadBuilder.Build(39, ProvinciaUruguay.SanJose),
                datosEntidadBuilder.Build(40, ProvinciaUruguay.Soriano),
                datosEntidadBuilder.Build(41, ProvinciaUruguay.Tacuarembó),
                datosEntidadBuilder.Build(42, ProvinciaUruguay.TreintaYTres)
            });
        }
    }
}
