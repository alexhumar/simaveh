using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    internal class LocalidadSantaCruzFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadSantaCruzFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaCruz.CorpenAike).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3438, LocalidadSantaCruz.ComandanteLuisPiedrabuena),
                datosEntidadBuilder.Build(3439, LocalidadSantaCruz.PuertoSantaCruz),
                datosEntidadBuilder.Build(3440, LocalidadSantaCruz.PuertoDePuntaQuilla),
                datosEntidadBuilder.Build(3441, LocalidadSantaCruz.RioChico)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaCruz.Deseado).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3442, LocalidadSantaCruz.CaletaOlivia),
                datosEntidadBuilder.Build(3443, LocalidadSantaCruz.CanadonSeco),
                datosEntidadBuilder.Build(3444, LocalidadSantaCruz.FitzRoy),
                datosEntidadBuilder.Build(3445, LocalidadSantaCruz.GobernadorMoyano),
                datosEntidadBuilder.Build(3446, LocalidadSantaCruz.Jaramillo),
                datosEntidadBuilder.Build(3447, LocalidadSantaCruz.KoluelKayke),
                datosEntidadBuilder.Build(3448, LocalidadSantaCruz.LasHeras),
                datosEntidadBuilder.Build(3449, LocalidadSantaCruz.PicoTruncado),
                datosEntidadBuilder.Build(3450, LocalidadSantaCruz.PuertoDeseado),
                datosEntidadBuilder.Build(3451, LocalidadSantaCruz.Tellier)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaCruz.GuerAike).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3452, LocalidadSantaCruz.ElTurbio),
                datosEntidadBuilder.Build(3453, LocalidadSantaCruz.Esperanza),
                datosEntidadBuilder.Build(3454, LocalidadSantaCruz.JuliaDufour),
                datosEntidadBuilder.Build(3455, LocalidadSantaCruz.Mina3),
                datosEntidadBuilder.Build(3456, LocalidadSantaCruz.RioGallegos),
                datosEntidadBuilder.Build(3457, LocalidadSantaCruz.RioTurbio),
                datosEntidadBuilder.Build(3458, LocalidadSantaCruz.RospentekAike),
                datosEntidadBuilder.Build(3459, LocalidadSantaCruz.VeintiochoDeNoviembre),
                datosEntidadBuilder.Build(3460, LocalidadSantaCruz.GuerAike)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaCruz.LagoArgentino).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3461, LocalidadSantaCruz.ElCalafate),
                datosEntidadBuilder.Build(3462, LocalidadSantaCruz.ElChalten),
                datosEntidadBuilder.Build(3463, LocalidadSantaCruz.TresLagos),
                datosEntidadBuilder.Build(3464, LocalidadSantaCruz.PuertoBandera)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaCruz.LagoBuenosAires).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3465, LocalidadSantaCruz.LosAntiguos),
                datosEntidadBuilder.Build(3466, LocalidadSantaCruz.PeritoMoreno)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaCruz.Magallanes).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3467, LocalidadSantaCruz.PuertoSanJulian),
                datosEntidadBuilder.Build(3468, LocalidadSantaCruz.ElSalado),
                datosEntidadBuilder.Build(3469, LocalidadSantaCruz.BellaVista)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaCruz.RioChico).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3470, LocalidadSantaCruz.BajoCaracoles),
                datosEntidadBuilder.Build(3471, LocalidadSantaCruz.GobernadorGregores),
                datosEntidadBuilder.Build(3472, LocalidadSantaCruz.HipolitoYrigoyen)
            });
        }
    }
}
