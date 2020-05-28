using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesSantaCruzLoader : LocalidadesLoader
    {
        public LocalidadesSantaCruzLoader(IPartidosLoader partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidosLoader.FindByNombre(PartidoSantaCruz.CorpenAike).Key, new Dictionary<long, string>
            {
                { 3438, LocalidadSantaCruz.ComandanteLuisPiedrabuena },
                { 3439, LocalidadSantaCruz.PuertoSantaCruz },
                { 3440, LocalidadSantaCruz.PuertoDePuntaQuilla },
                { 3441, LocalidadSantaCruz.RioChico }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantaCruz.Deseado).Key, new Dictionary<long, string>
            {
                { 3442, LocalidadSantaCruz.CaletaOlivia },
                { 3443, LocalidadSantaCruz.CanadonSeco },
                { 3444, LocalidadSantaCruz.FitzRoy },
                { 3445, LocalidadSantaCruz.GobernadorMoyano },
                { 3446, LocalidadSantaCruz.Jaramillo },
                { 3447, LocalidadSantaCruz.KoluelKayke },
                { 3448, LocalidadSantaCruz.LasHeras },
                { 3449, LocalidadSantaCruz.PicoTruncado },
                { 3450, LocalidadSantaCruz.PuertoDeseado },
                { 3451, LocalidadSantaCruz.Tellier }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantaCruz.GuerAike).Key, new Dictionary<long, string>
            {
                { 3452, LocalidadSantaCruz.ElTurbio },
                { 3453, LocalidadSantaCruz.Esperanza },
                { 3454, LocalidadSantaCruz.JuliaDufour },
                { 3455, LocalidadSantaCruz.Mina3 },
                { 3456, LocalidadSantaCruz.RioGallegos },
                { 3457, LocalidadSantaCruz.RioTurbio },
                { 3458, LocalidadSantaCruz.RospentekAike },
                { 3459, LocalidadSantaCruz.VeintiochoDeNoviembre },
                { 3460, LocalidadSantaCruz.GuerAike }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantaCruz.LagoArgentino).Key, new Dictionary<long, string>
            {
                { 3461, LocalidadSantaCruz.ElCalafate },
                { 3462, LocalidadSantaCruz.ElChalten },
                { 3463, LocalidadSantaCruz.TresLagos },
                { 3464, LocalidadSantaCruz.PuertoBandera }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantaCruz.LagoBuenosAires).Key, new Dictionary<long, string>
            {
                { 3465, LocalidadSantaCruz.LosAntiguos },
                { 3466, LocalidadSantaCruz.PeritoMoreno }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantaCruz.Magallanes).Key, new Dictionary<long, string>
            {
                { 3467, LocalidadSantaCruz.PuertoSanJulian },
                { 3468, LocalidadSantaCruz.ElSalado },
                { 3469, LocalidadSantaCruz.BellaVista }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantaCruz.RioChico).Key, new Dictionary<long, string>
            {
                { 3470, LocalidadSantaCruz.BajoCaracoles },
                { 3471, LocalidadSantaCruz.GobernadorGregores },
                { 3472, LocalidadSantaCruz.HipolitoYrigoyen }
            });
        }
    }
}
