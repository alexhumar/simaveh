using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Pais.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Provincia.FixtureGetters.Argentina
{
    internal class ProvinciaArgentinaFixtureGetter : ProvinciaFixtureGetter
    {
        public ProvinciaArgentinaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPaisFixtureGetter paisFixtureGetter)
            : base(datosEntidadBuilder, paisFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            provincias.Add(paisFixtureGetter.FindByNombre(Constants.Paises.Pais.Argentina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(1, ProvinciaArgentina.BuenosAires),
                datosEntidadBuilder.Build(2, ProvinciaArgentina.Catamarca),
                datosEntidadBuilder.Build(3, ProvinciaArgentina.Chaco),
                datosEntidadBuilder.Build(4, ProvinciaArgentina.Chubut),
                datosEntidadBuilder.Build(5, ProvinciaArgentina.Cordoba),
                datosEntidadBuilder.Build(6, ProvinciaArgentina.Corrientes),
                datosEntidadBuilder.Build(7, ProvinciaArgentina.EntreRios),
                datosEntidadBuilder.Build(8, ProvinciaArgentina.Formosa),
                datosEntidadBuilder.Build(9, ProvinciaArgentina.Jujuy),
                datosEntidadBuilder.Build(10, ProvinciaArgentina.LaPampa),
                datosEntidadBuilder.Build(11, ProvinciaArgentina.LaRioja),
                datosEntidadBuilder.Build(12, ProvinciaArgentina.Mendoza),
                datosEntidadBuilder.Build(13, ProvinciaArgentina.Misiones),
                datosEntidadBuilder.Build(14, ProvinciaArgentina.Neuquen),
                datosEntidadBuilder.Build(15, ProvinciaArgentina.RioNegro),
                datosEntidadBuilder.Build(16, ProvinciaArgentina.Salta),
                datosEntidadBuilder.Build(17, ProvinciaArgentina.SanJuan),
                datosEntidadBuilder.Build(18, ProvinciaArgentina.SanLuis),
                datosEntidadBuilder.Build(19, ProvinciaArgentina.SantaCruz),
                datosEntidadBuilder.Build(20, ProvinciaArgentina.SantaFe),
                datosEntidadBuilder.Build(21, ProvinciaArgentina.SantiagoDelEstero),
                datosEntidadBuilder.Build(22, ProvinciaArgentina.TierraDelFuego),
                datosEntidadBuilder.Build(23, ProvinciaArgentina.Tucuman)
            });
        }
    }
}
