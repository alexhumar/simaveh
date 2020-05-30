using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadSanJuanFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadSanJuanFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Albardon).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3261, LocalidadSanJuan.CampoAfuera),
                datosEntidadBuilder.Build(3262, LocalidadSanJuan.GeneralSanMartin),
                datosEntidadBuilder.Build(3263, LocalidadSanJuan.ElRincon),
                datosEntidadBuilder.Build(3264, LocalidadSanJuan.LaCanada),
                datosEntidadBuilder.Build(3265, LocalidadSanJuan.LasLomitas),
                datosEntidadBuilder.Build(3266, LocalidadSanJuan.VillaAmpacama)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Angaco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3267, LocalidadSanJuan.VillaDelSalvador),
                datosEntidadBuilder.Build(3268, LocalidadSanJuan.VillaSefairTalacasto),
                datosEntidadBuilder.Build(3269, LocalidadSanJuan.LasTapias)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Calingasta).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3270, LocalidadSanJuan.Barreal),
                datosEntidadBuilder.Build(3271, LocalidadSanJuan.Calingasta),
                datosEntidadBuilder.Build(3272, LocalidadSanJuan.Tamberias),
                datosEntidadBuilder.Build(3273, LocalidadSanJuan.VillaPituil)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3274, LocalidadSanJuan.Concepcion),
                datosEntidadBuilder.Build(3275, LocalidadSanJuan.Desamparados),
                datosEntidadBuilder.Build(3276, LocalidadSanJuan.SanJuan),
                datosEntidadBuilder.Build(3277, LocalidadSanJuan.Trinidad)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Caucete).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3278, LocalidadSanJuan.Bermejo),
                datosEntidadBuilder.Build(3279, LocalidadSanJuan.CiudadDeCaucete),
                datosEntidadBuilder.Build(3280, LocalidadSanJuan.ElRincon),
                datosEntidadBuilder.Build(3281, LocalidadSanJuan.Marayes),
                datosEntidadBuilder.Build(3282, LocalidadSanJuan.LasTalas),
                datosEntidadBuilder.Build(3283, LocalidadSanJuan.LosMedanos),
                datosEntidadBuilder.Build(3284, LocalidadSanJuan.PieDePalo),
                datosEntidadBuilder.Build(3285, LocalidadSanJuan.Vallecito),
                datosEntidadBuilder.Build(3286, LocalidadSanJuan.VillaIndependencia)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Chimbas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3287, LocalidadSanJuan.ElMogote),
                datosEntidadBuilder.Build(3288, LocalidadSanJuan.BarrioLosTamarindos),
                datosEntidadBuilder.Build(3289, LocalidadSanJuan.VillaObrera),
                datosEntidadBuilder.Build(3290, LocalidadSanJuan.VillaUnion),
                datosEntidadBuilder.Build(3291, LocalidadSanJuan.VillaPaulaAlbarracinDeSarmiento)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Iglesia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3292, LocalidadSanJuan.Angualasto),
                datosEntidadBuilder.Build(3293, LocalidadSanJuan.BellaVista),
                datosEntidadBuilder.Build(3294, LocalidadSanJuan.Colola),
                datosEntidadBuilder.Build(3295, LocalidadSanJuan.Iglesia),
                datosEntidadBuilder.Build(3296, LocalidadSanJuan.LasFlores),
                datosEntidadBuilder.Build(3297, LocalidadSanJuan.Pismanta),
                datosEntidadBuilder.Build(3298, LocalidadSanJuan.Rodeo),
                datosEntidadBuilder.Build(3299, LocalidadSanJuan.Tudcum)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Jachal).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3300, LocalidadSanJuan.SanJoseDeJachal),
                datosEntidadBuilder.Build(3301, LocalidadSanJuan.ElFical),
                datosEntidadBuilder.Build(3302, LocalidadSanJuan.ElMedano),
                datosEntidadBuilder.Build(3303, LocalidadSanJuan.GranChina),
                datosEntidadBuilder.Build(3304, LocalidadSanJuan.Huaco),
                datosEntidadBuilder.Build(3305, LocalidadSanJuan.LaFalda),
                datosEntidadBuilder.Build(3306, LocalidadSanJuan.Mogna),
                datosEntidadBuilder.Build(3307, LocalidadSanJuan.Niquivil),
                datosEntidadBuilder.Build(3308, LocalidadSanJuan.PampaVieja),
                datosEntidadBuilder.Build(3309, LocalidadSanJuan.SanIsidro),
                datosEntidadBuilder.Build(3310, LocalidadSanJuan.Tamberias),
                datosEntidadBuilder.Build(3311, LocalidadSanJuan.VillaMalvinasArgentinas),
                datosEntidadBuilder.Build(3312, LocalidadSanJuan.VillaMercedes)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.NueveDeJulio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3313, LocalidadSanJuan.ColoniaFiorito),
                datosEntidadBuilder.Build(3314, LocalidadSanJuan.LasChacritas),
                datosEntidadBuilder.Build(3315, LocalidadSanJuan.NueveDeJulio),
                datosEntidadBuilder.Build(3316, LocalidadSanJuan.Dibella),
                datosEntidadBuilder.Build(3317, LocalidadSanJuan.JoseDolores),
                datosEntidadBuilder.Build(3318, LocalidadSanJuan.LaMajadita),
                datosEntidadBuilder.Build(3319, LocalidadSanJuan.TierraAdentro),
                datosEntidadBuilder.Build(3320, LocalidadSanJuan.AltoDeSierraEste),
                datosEntidadBuilder.Build(3321, LocalidadSanJuan.RinconCercado)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Pocito).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3322, LocalidadSanJuan.BarrioRuta40),
                datosEntidadBuilder.Build(3323, LocalidadSanJuan.Carpinteria),
                datosEntidadBuilder.Build(3324, LocalidadSanJuan.LaRinconada),
                datosEntidadBuilder.Build(3325, LocalidadSanJuan.QuintoCuartel),
                datosEntidadBuilder.Build(3326, LocalidadSanJuan.VillaAberastain),
                datosEntidadBuilder.Build(3327, LocalidadSanJuan.VillaBarboza),
                datosEntidadBuilder.Build(3328, LocalidadSanJuan.VillaCentenario),
                datosEntidadBuilder.Build(3329, LocalidadSanJuan.VillaNacusi)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Rawson).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3330, LocalidadSanJuan.VillaKrause),
                datosEntidadBuilder.Build(3331, LocalidadSanJuan.Rawson),
                datosEntidadBuilder.Build(3332, LocalidadSanJuan.ElMedanito),
                datosEntidadBuilder.Build(3333, LocalidadSanJuan.VillaBolanos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Rivadavia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3334, LocalidadSanJuan.Rivadavia),
                datosEntidadBuilder.Build(3335, LocalidadSanJuan.Marquesado),
                datosEntidadBuilder.Build(3336, LocalidadSanJuan.LaBebida)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.SanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3337, LocalidadSanJuan.SanIsidro),
                datosEntidadBuilder.Build(3338, LocalidadSanJuan.DosAcequias),
                datosEntidadBuilder.Build(3339, LocalidadSanJuan.LaPuntilla)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.SantaLucia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3340, LocalidadSanJuan.AltoDeSierra),
                datosEntidadBuilder.Build(3341, LocalidadSanJuan.ColoniaGutierrez),
                datosEntidadBuilder.Build(3342, LocalidadSanJuan.SantaLucia),
                datosEntidadBuilder.Build(3343, LocalidadSanJuan.LaLegua),
                datosEntidadBuilder.Build(3344, LocalidadSanJuan.VillaMarini),
                datosEntidadBuilder.Build(3345, LocalidadSanJuan.ColoniaRichetYZapata),
                datosEntidadBuilder.Build(3346, LocalidadSanJuan.ColoniaGutierrez)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Sarmiento).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3347, LocalidadSanJuan.CanadaHonda),
                datosEntidadBuilder.Build(3348, LocalidadSanJuan.Cienaguita),
                datosEntidadBuilder.Build(3349, LocalidadSanJuan.ColoniaFiscal),
                datosEntidadBuilder.Build(3350, LocalidadSanJuan.Divisadero),
                datosEntidadBuilder.Build(3351, LocalidadSanJuan.Guanacache),
                datosEntidadBuilder.Build(3352, LocalidadSanJuan.LasLagunas),
                datosEntidadBuilder.Build(3353, LocalidadSanJuan.LosBerros),
                datosEntidadBuilder.Build(3354, LocalidadSanJuan.Pedernal),
                datosEntidadBuilder.Build(3355, LocalidadSanJuan.PuntaDelMedano),
                datosEntidadBuilder.Build(3356, LocalidadSanJuan.MediaAgua)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Ullum).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3357, LocalidadSanJuan.VillaAurora),
                datosEntidadBuilder.Build(3358, LocalidadSanJuan.VillaIbanez),
                datosEntidadBuilder.Build(3359, LocalidadSanJuan.ElChilote)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.ValleFertil).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3360, LocalidadSanJuan.Astica),
                datosEntidadBuilder.Build(3361, LocalidadSanJuan.BaldesDelRosario),
                datosEntidadBuilder.Build(3362, LocalidadSanJuan.Chucuma),
                datosEntidadBuilder.Build(3363, LocalidadSanJuan.LosBaldecitos),
                datosEntidadBuilder.Build(3364, LocalidadSanJuan.Usno),
                datosEntidadBuilder.Build(3365, LocalidadSanJuan.VillaSanAgustin)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.VeinticincoDeMayo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3366, LocalidadSanJuan.ElEncon),
                datosEntidadBuilder.Build(3367, LocalidadSanJuan.LaChimbera),
                datosEntidadBuilder.Build(3368, LocalidadSanJuan.Tupeli),
                datosEntidadBuilder.Build(3369, LocalidadSanJuan.VillaBorjas),
                datosEntidadBuilder.Build(3370, LocalidadSanJuan.VillaElTango),
                datosEntidadBuilder.Build(3371, LocalidadSanJuan.SantaRosa)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSanJuan.Zonda).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3372, LocalidadSanJuan.VillaBasilioNievas),
                datosEntidadBuilder.Build(3373, LocalidadSanJuan.VillaTacu)
            });
        }
    }
}
