using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadSantaFeFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadSantaFeFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.Rosario).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3473, LocalidadSantaFe.Rosario),
                datosEntidadBuilder.Build(3474, LocalidadSantaFe.VillaGobernadorGalvez),
                datosEntidadBuilder.Build(3475, LocalidadSantaFe.GranaderoBaigorria),
                datosEntidadBuilder.Build(3476, LocalidadSantaFe.Perez),
                datosEntidadBuilder.Build(3477, LocalidadSantaFe.Funes),
                datosEntidadBuilder.Build(3478, LocalidadSantaFe.ArroyoSeco),
                datosEntidadBuilder.Build(3479, LocalidadSantaFe.PuebloEsther),
                datosEntidadBuilder.Build(3480, LocalidadSantaFe.Alvarez),
                datosEntidadBuilder.Build(3481, LocalidadSantaFe.Acebal),
                datosEntidadBuilder.Build(3482, LocalidadSantaFe.Zavalla),
                datosEntidadBuilder.Build(3483, LocalidadSantaFe.Fighiera),
                datosEntidadBuilder.Build(3484, LocalidadSantaFe.Alvear),
                datosEntidadBuilder.Build(3485, LocalidadSantaFe.Ibarlucea),
                datosEntidadBuilder.Build(3486, LocalidadSantaFe.GeneralLagos),
                datosEntidadBuilder.Build(3487, LocalidadSantaFe.Soldini),
                datosEntidadBuilder.Build(3488, LocalidadSantaFe.CoronelBogado),
                datosEntidadBuilder.Build(3489, LocalidadSantaFe.Pinero),
                datosEntidadBuilder.Build(3490, LocalidadSantaFe.VillaAmelia),
                datosEntidadBuilder.Build(3491, LocalidadSantaFe.CoronelDominguez),
                datosEntidadBuilder.Build(3492, LocalidadSantaFe.PuebloUranga),
                datosEntidadBuilder.Build(3493, LocalidadSantaFe.CarmenDelSauce),
                datosEntidadBuilder.Build(3494, LocalidadSantaFe.PuebloMunoz),
                datosEntidadBuilder.Build(3495, LocalidadSantaFe.Albarellos),
                datosEntidadBuilder.Build(3496, LocalidadSantaFe.Arminda)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.LaCapital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3497, LocalidadSantaFe.SantaFe),
                datosEntidadBuilder.Build(3498, LocalidadSantaFe.ArroyoAguiar),
                datosEntidadBuilder.Build(3499, LocalidadSantaFe.ArroyoLeyes),
                datosEntidadBuilder.Build(3500, LocalidadSantaFe.Cabal),
                datosEntidadBuilder.Build(3501, LocalidadSantaFe.CampoAndino),
                datosEntidadBuilder.Build(3502, LocalidadSantaFe.Candioti),
                datosEntidadBuilder.Build(3503, LocalidadSantaFe.Emilia),
                datosEntidadBuilder.Build(3504, LocalidadSantaFe.LagunaPaiva),
                datosEntidadBuilder.Build(3505, LocalidadSantaFe.LlambiCampbell),
                datosEntidadBuilder.Build(3506, LocalidadSantaFe.MonteVera),
                datosEntidadBuilder.Build(3507, LocalidadSantaFe.Nelson),
                datosEntidadBuilder.Build(3508, LocalidadSantaFe.Recreo),
                datosEntidadBuilder.Build(3509, LocalidadSantaFe.SanJoseDelRincon),
                datosEntidadBuilder.Build(3510, LocalidadSantaFe.SantoTome),
                datosEntidadBuilder.Build(3511, LocalidadSantaFe.SauceViejo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.GeneralLopez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3512, LocalidadSantaFe.VenadoTuerto),
                datosEntidadBuilder.Build(3513, LocalidadSantaFe.Firmat),
                datosEntidadBuilder.Build(3514, LocalidadSantaFe.Rufino),
                datosEntidadBuilder.Build(3515, LocalidadSantaFe.Wheelwright),
                datosEntidadBuilder.Build(3516, LocalidadSantaFe.VillaCanas),
                datosEntidadBuilder.Build(3517, LocalidadSantaFe.Teodelina),
                datosEntidadBuilder.Build(3518, LocalidadSantaFe.Elortondo),
                datosEntidadBuilder.Build(3519, LocalidadSantaFe.Hughes),
                datosEntidadBuilder.Build(3520, LocalidadSantaFe.SanGregorio),
                datosEntidadBuilder.Build(3521, LocalidadSantaFe.SantaIsabel),
                datosEntidadBuilder.Build(3522, LocalidadSantaFe.MariaTeresa),
                datosEntidadBuilder.Build(3523, LocalidadSantaFe.Murphy),
                datosEntidadBuilder.Build(3524, LocalidadSantaFe.SanctiSpiritu),
                datosEntidadBuilder.Build(3525, LocalidadSantaFe.Chovet),
                datosEntidadBuilder.Build(3526, LocalidadSantaFe.Melincue),
                datosEntidadBuilder.Build(3527, LocalidadSantaFe.Maggiolo),
                datosEntidadBuilder.Build(3528, LocalidadSantaFe.DiegoDeAlvear),
                datosEntidadBuilder.Build(3529, LocalidadSantaFe.Carreras),
                datosEntidadBuilder.Build(3530, LocalidadSantaFe.Carmen),
                datosEntidadBuilder.Build(3531, LocalidadSantaFe.Cafferata),
                datosEntidadBuilder.Build(3532, LocalidadSantaFe.Amenabar),
                datosEntidadBuilder.Build(3533, LocalidadSantaFe.SanEduardo),
                datosEntidadBuilder.Build(3534, LocalidadSantaFe.Labordeboy),
                datosEntidadBuilder.Build(3535, LocalidadSantaFe.CanadaDelUcle),
                datosEntidadBuilder.Build(3536, LocalidadSantaFe.Christophersen),
                datosEntidadBuilder.Build(3537, LocalidadSantaFe.Chapuy),
                datosEntidadBuilder.Build(3538, LocalidadSantaFe.Lazzarino),
                datosEntidadBuilder.Build(3539, LocalidadSantaFe.LaChispa),
                datosEntidadBuilder.Build(3540, LocalidadSantaFe.MiguelTorres),
                datosEntidadBuilder.Build(3541, LocalidadSantaFe.SanFranciscoDeStaFe),
                datosEntidadBuilder.Build(3542, LocalidadSantaFe.AaronCastellanos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.Castellanos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3543, LocalidadSantaFe.Rafaela),
                datosEntidadBuilder.Build(3544, LocalidadSantaFe.Sunchales),
                datosEntidadBuilder.Build(3545, LocalidadSantaFe.Frontera),
                datosEntidadBuilder.Build(3546, LocalidadSantaFe.SanVicente),
                datosEntidadBuilder.Build(3547, LocalidadSantaFe.HumbertoPrimo),
                datosEntidadBuilder.Build(3548, LocalidadSantaFe.MariaJuana),
                datosEntidadBuilder.Build(3549, LocalidadSantaFe.Lehmann),
                datosEntidadBuilder.Build(3550, LocalidadSantaFe.Josefina),
                datosEntidadBuilder.Build(3551, LocalidadSantaFe.SantaClaraDeSaguier),
                datosEntidadBuilder.Build(3552, LocalidadSantaFe.Ataliva)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.GeneralObligado).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3553, LocalidadSantaFe.Avellaneda),
                datosEntidadBuilder.Build(3554, LocalidadSantaFe.LasToscas),
                datosEntidadBuilder.Build(3555, LocalidadSantaFe.Malabrigo),
                datosEntidadBuilder.Build(3556, LocalidadSantaFe.Reconquista),
                datosEntidadBuilder.Build(3557, LocalidadSantaFe.VillaOcampo),
                datosEntidadBuilder.Build(3558, LocalidadSantaFe.ArroyoCeibal),
                datosEntidadBuilder.Build(3559, LocalidadSantaFe.Berna),
                datosEntidadBuilder.Build(3560, LocalidadSantaFe.ElAraza),
                datosEntidadBuilder.Build(3561, LocalidadSantaFe.ElRabon),
                datosEntidadBuilder.Build(3562, LocalidadSantaFe.ElSombrerito),
                datosEntidadBuilder.Build(3563, LocalidadSantaFe.Florencia),
                datosEntidadBuilder.Build(3564, LocalidadSantaFe.GuadalupeNorte),
                datosEntidadBuilder.Build(3565, LocalidadSantaFe.IngenieroChanourdie),
                datosEntidadBuilder.Build(3566, LocalidadSantaFe.LaSarita),
                datosEntidadBuilder.Build(3567, LocalidadSantaFe.Lanteri),
                datosEntidadBuilder.Build(3568, LocalidadSantaFe.LasGarzas),
                datosEntidadBuilder.Build(3569, LocalidadSantaFe.LosLaureles),
                datosEntidadBuilder.Build(3570, LocalidadSantaFe.NicanorMolinas),
                datosEntidadBuilder.Build(3571, LocalidadSantaFe.SanAntonioDeObligado),
                datosEntidadBuilder.Build(3572, LocalidadSantaFe.Tacuarendi),
                datosEntidadBuilder.Build(3573, LocalidadSantaFe.VillaAna),
                datosEntidadBuilder.Build(3574, LocalidadSantaFe.VillaGuillermina)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.SanLorenzo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3575, LocalidadSantaFe.Aldao),
                datosEntidadBuilder.Build(3576, LocalidadSantaFe.CoronelArnold),
                datosEntidadBuilder.Build(3577, LocalidadSantaFe.Fuentes),
                datosEntidadBuilder.Build(3578, LocalidadSantaFe.Pujato),
                datosEntidadBuilder.Build(3579, LocalidadSantaFe.Ricardone),
                datosEntidadBuilder.Build(3580, LocalidadSantaFe.SanJeronimoSud),
                datosEntidadBuilder.Build(3581, LocalidadSantaFe.Timbues),
                datosEntidadBuilder.Build(3582, LocalidadSantaFe.VillaMugueta),
                datosEntidadBuilder.Build(3583, LocalidadSantaFe.LuisPalacios),
                datosEntidadBuilder.Build(3584, LocalidadSantaFe.CapitanBermudez),
                datosEntidadBuilder.Build(3585, LocalidadSantaFe.Carcarana),
                datosEntidadBuilder.Build(3586, LocalidadSantaFe.FrayLuisBeltran),
                datosEntidadBuilder.Build(3587, LocalidadSantaFe.PuertoGeneralSanMartin),
                datosEntidadBuilder.Build(3588, LocalidadSantaFe.Roldan),
                datosEntidadBuilder.Build(3589, LocalidadSantaFe.SanLorenzo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.LasColonias).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3590, LocalidadSantaFe.Esperanza),
                datosEntidadBuilder.Build(3591, LocalidadSantaFe.SanCarlosCentro),
                datosEntidadBuilder.Build(3592, LocalidadSantaFe.ColoniaCavour),
                datosEntidadBuilder.Build(3593, LocalidadSantaFe.ColoniaSanJose),
                datosEntidadBuilder.Build(3594, LocalidadSantaFe.Cululu),
                datosEntidadBuilder.Build(3595, LocalidadSantaFe.Elisa),
                datosEntidadBuilder.Build(3596, LocalidadSantaFe.EmpalmeSanCarlos),
                datosEntidadBuilder.Build(3597, LocalidadSantaFe.Felicia),
                datosEntidadBuilder.Build(3598, LocalidadSantaFe.Franck),
                datosEntidadBuilder.Build(3599, LocalidadSantaFe.Grutly),
                datosEntidadBuilder.Build(3600, LocalidadSantaFe.Hipatia),
                datosEntidadBuilder.Build(3601, LocalidadSantaFe.Humboldt),
                datosEntidadBuilder.Build(3602, LocalidadSantaFe.Ituzaingo),
                datosEntidadBuilder.Build(3603, LocalidadSantaFe.JacintoLArauz),
                datosEntidadBuilder.Build(3604, LocalidadSantaFe.LaPelada),
                datosEntidadBuilder.Build(3605, LocalidadSantaFe.LasTunas),
                datosEntidadBuilder.Build(3606, LocalidadSantaFe.MariaLuisa),
                datosEntidadBuilder.Build(3607, LocalidadSantaFe.Matilde),
                datosEntidadBuilder.Build(3608, LocalidadSantaFe.NuevoTorino),
                datosEntidadBuilder.Build(3609, LocalidadSantaFe.Pilar),
                datosEntidadBuilder.Build(3610, LocalidadSantaFe.Progreso),
                datosEntidadBuilder.Build(3611, LocalidadSantaFe.Providencia),
                datosEntidadBuilder.Build(3612, LocalidadSantaFe.PujatoNorte),
                datosEntidadBuilder.Build(3613, LocalidadSantaFe.Rivadavia),
                datosEntidadBuilder.Build(3614, LocalidadSantaFe.SaPereira),
                datosEntidadBuilder.Build(3615, LocalidadSantaFe.SanAgustin),
                datosEntidadBuilder.Build(3616, LocalidadSantaFe.SanCarlosNorte),
                datosEntidadBuilder.Build(3617, LocalidadSantaFe.SanCarlosSud),
                datosEntidadBuilder.Build(3618, LocalidadSantaFe.SanJeronimoDelSauce),
                datosEntidadBuilder.Build(3619, LocalidadSantaFe.SanJeronimoNorte),
                datosEntidadBuilder.Build(3620, LocalidadSantaFe.SanMariano),
                datosEntidadBuilder.Build(3621, LocalidadSantaFe.SantaClaraDeBuenaVista),
                datosEntidadBuilder.Build(3622, LocalidadSantaFe.SantaMariaCentro),
                datosEntidadBuilder.Build(3623, LocalidadSantaFe.SantaMariaNorte),
                datosEntidadBuilder.Build(3624, LocalidadSantaFe.SantoDomingo),
                datosEntidadBuilder.Build(3625, LocalidadSantaFe.Sarmiento),
                datosEntidadBuilder.Build(3626, LocalidadSantaFe.Soutomayor)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.Constitucion).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3627, LocalidadSantaFe.VillaConstitucion),
                datosEntidadBuilder.Build(3628, LocalidadSantaFe.Alcorta),
                datosEntidadBuilder.Build(3629, LocalidadSantaFe.Bombal),
                datosEntidadBuilder.Build(3630, LocalidadSantaFe.CanadaRica),
                datosEntidadBuilder.Build(3631, LocalidadSantaFe.Cepeda),
                datosEntidadBuilder.Build(3632, LocalidadSantaFe.EmpalmeVillaConstitucion),
                datosEntidadBuilder.Build(3633, LocalidadSantaFe.GeneralGelly),
                datosEntidadBuilder.Build(3634, LocalidadSantaFe.Godoy),
                datosEntidadBuilder.Build(3635, LocalidadSantaFe.JuanBernabeMolina),
                datosEntidadBuilder.Build(3636, LocalidadSantaFe.Juncal),
                datosEntidadBuilder.Build(3637, LocalidadSantaFe.LaVanguardia),
                datosEntidadBuilder.Build(3638, LocalidadSantaFe.MaximoPaz),
                datosEntidadBuilder.Build(3639, LocalidadSantaFe.Pavon),
                datosEntidadBuilder.Build(3640, LocalidadSantaFe.PavonArriba),
                datosEntidadBuilder.Build(3641, LocalidadSantaFe.Peyrano),
                datosEntidadBuilder.Build(3642, LocalidadSantaFe.Rueda),
                datosEntidadBuilder.Build(3643, LocalidadSantaFe.SantaTeresa),
                datosEntidadBuilder.Build(3644, LocalidadSantaFe.SargentoCabral),
                datosEntidadBuilder.Build(3645, LocalidadSantaFe.Theobald)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.Caseros).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3646, LocalidadSantaFe.Casilda),
                datosEntidadBuilder.Build(3647, LocalidadSantaFe.Arequito),
                datosEntidadBuilder.Build(3648, LocalidadSantaFe.Arteaga),
                datosEntidadBuilder.Build(3649, LocalidadSantaFe.Berabevu),
                datosEntidadBuilder.Build(3650, LocalidadSantaFe.Bigand),
                datosEntidadBuilder.Build(3651, LocalidadSantaFe.Chabas),
                datosEntidadBuilder.Build(3652, LocalidadSantaFe.ChanarLadeado),
                datosEntidadBuilder.Build(3653, LocalidadSantaFe.Godeken),
                datosEntidadBuilder.Build(3654, LocalidadSantaFe.LosMolinos),
                datosEntidadBuilder.Build(3655, LocalidadSantaFe.LosNogales),
                datosEntidadBuilder.Build(3656, LocalidadSantaFe.LosQuirquinchos),
                datosEntidadBuilder.Build(3657, LocalidadSantaFe.SanJoseDeLaEsquina),
                datosEntidadBuilder.Build(3658, LocalidadSantaFe.Sanford),
                datosEntidadBuilder.Build(3659, LocalidadSantaFe.Villada)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.SanJeronimo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3660, LocalidadSantaFe.Coronda),
                datosEntidadBuilder.Build(3661, LocalidadSantaFe.Galvez),
                datosEntidadBuilder.Build(3662, LocalidadSantaFe.SanGenaro),
                datosEntidadBuilder.Build(3663, LocalidadSantaFe.Arocena),
                datosEntidadBuilder.Build(3664, LocalidadSantaFe.Barrancas),
                datosEntidadBuilder.Build(3665, LocalidadSantaFe.BernardoDeIrigoyen),
                datosEntidadBuilder.Build(3666, LocalidadSantaFe.CampoPiaggio),
                datosEntidadBuilder.Build(3667, LocalidadSantaFe.Casalegno),
                datosEntidadBuilder.Build(3668, LocalidadSantaFe.Centeno),
                datosEntidadBuilder.Build(3669, LocalidadSantaFe.DesvioArijon),
                datosEntidadBuilder.Build(3670, LocalidadSantaFe.Diaz),
                datosEntidadBuilder.Build(3671, LocalidadSantaFe.Gaboto),
                datosEntidadBuilder.Build(3672, LocalidadSantaFe.Gessler),
                datosEntidadBuilder.Build(3673, LocalidadSantaFe.Larrechea),
                datosEntidadBuilder.Build(3674, LocalidadSantaFe.LomaAlta),
                datosEntidadBuilder.Build(3675, LocalidadSantaFe.Lopez),
                datosEntidadBuilder.Build(3676, LocalidadSantaFe.Maciel),
                datosEntidadBuilder.Build(3677, LocalidadSantaFe.Monje),
                datosEntidadBuilder.Build(3678, LocalidadSantaFe.PuebloIrigoyen),
                datosEntidadBuilder.Build(3679, LocalidadSantaFe.SanEugenio),
                datosEntidadBuilder.Build(3680, LocalidadSantaFe.SanFabian)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.SanCristobal).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3681, LocalidadSantaFe.Ceres),
                datosEntidadBuilder.Build(3682, LocalidadSantaFe.SanCristobal),
                datosEntidadBuilder.Build(3683, LocalidadSantaFe.AguaraGrande),
                datosEntidadBuilder.Build(3684, LocalidadSantaFe.Ambrosetti),
                datosEntidadBuilder.Build(3685, LocalidadSantaFe.Arrufo),
                datosEntidadBuilder.Build(3686, LocalidadSantaFe.Capivara),
                datosEntidadBuilder.Build(3687, LocalidadSantaFe.ColoniaAna),
                datosEntidadBuilder.Build(3688, LocalidadSantaFe.ColoniaBossi),
                datosEntidadBuilder.Build(3689, LocalidadSantaFe.ColoniaClara),
                datosEntidadBuilder.Build(3690, LocalidadSantaFe.ColoniaDosRosasYLaLegua),
                datosEntidadBuilder.Build(3691, LocalidadSantaFe.ColoniaRosa),
                datosEntidadBuilder.Build(3692, LocalidadSantaFe.Constanza),
                datosEntidadBuilder.Build(3693, LocalidadSantaFe.Curupaity),
                datosEntidadBuilder.Build(3694, LocalidadSantaFe.Hersilia),
                datosEntidadBuilder.Build(3695, LocalidadSantaFe.Huanqueros),
                datosEntidadBuilder.Build(3696, LocalidadSantaFe.LaCabral),
                datosEntidadBuilder.Build(3697, LocalidadSantaFe.LaLucila),
                datosEntidadBuilder.Build(3698, LocalidadSantaFe.LaRubia),
                datosEntidadBuilder.Build(3699, LocalidadSantaFe.LasAvispas),
                datosEntidadBuilder.Build(3700, LocalidadSantaFe.LasPalmeras),
                datosEntidadBuilder.Build(3701, LocalidadSantaFe.MoisesVille),
                datosEntidadBuilder.Build(3702, LocalidadSantaFe.Monigotes),
                datosEntidadBuilder.Build(3703, LocalidadSantaFe.MonteOscuridad),
                datosEntidadBuilder.Build(3704, LocalidadSantaFe.Nanducita),
                datosEntidadBuilder.Build(3705, LocalidadSantaFe.Palacios),
                datosEntidadBuilder.Build(3706, LocalidadSantaFe.Portugalete),
                datosEntidadBuilder.Build(3707, LocalidadSantaFe.SanGuillermo),
                datosEntidadBuilder.Build(3708, LocalidadSantaFe.Santurce),
                datosEntidadBuilder.Build(3709, LocalidadSantaFe.Soledad),
                datosEntidadBuilder.Build(3710, LocalidadSantaFe.Suardi),
                datosEntidadBuilder.Build(3711, LocalidadSantaFe.VillaSaralegui),
                datosEntidadBuilder.Build(3712, LocalidadSantaFe.VillaTrinidad)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.Iriondo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3713, LocalidadSantaFe.CanadaDeGomez),
                datosEntidadBuilder.Build(3714, LocalidadSantaFe.Totoras),
                datosEntidadBuilder.Build(3715, LocalidadSantaFe.Bustinza),
                datosEntidadBuilder.Build(3716, LocalidadSantaFe.Clarke),
                datosEntidadBuilder.Build(3717, LocalidadSantaFe.Clason),
                datosEntidadBuilder.Build(3718, LocalidadSantaFe.Correa),
                datosEntidadBuilder.Build(3719, LocalidadSantaFe.LucioVLopez),
                datosEntidadBuilder.Build(3720, LocalidadSantaFe.Oliveros),
                datosEntidadBuilder.Build(3721, LocalidadSantaFe.PuebloAndino),
                datosEntidadBuilder.Build(3722, LocalidadSantaFe.SaltoGrande),
                datosEntidadBuilder.Build(3723, LocalidadSantaFe.Serodino),
                datosEntidadBuilder.Build(3724, LocalidadSantaFe.VillaEloisa)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.SanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3725, LocalidadSantaFe.ElTrebol),
                datosEntidadBuilder.Build(3726, LocalidadSantaFe.SanJorge),
                datosEntidadBuilder.Build(3727, LocalidadSantaFe.Sastre),
                datosEntidadBuilder.Build(3728, LocalidadSantaFe.CanadaRosquin),
                datosEntidadBuilder.Build(3729, LocalidadSantaFe.CarlosPellegrini),
                datosEntidadBuilder.Build(3730, LocalidadSantaFe.Casas),
                datosEntidadBuilder.Build(3731, LocalidadSantaFe.Castelar),
                datosEntidadBuilder.Build(3732, LocalidadSantaFe.ColoniaBelgrano),
                datosEntidadBuilder.Build(3733, LocalidadSantaFe.Crispi),
                datosEntidadBuilder.Build(3734, LocalidadSantaFe.Landeta),
                datosEntidadBuilder.Build(3735, LocalidadSantaFe.LasBandurrias),
                datosEntidadBuilder.Build(3736, LocalidadSantaFe.LasPetacas),
                datosEntidadBuilder.Build(3737, LocalidadSantaFe.LosCardos),
                datosEntidadBuilder.Build(3738, LocalidadSantaFe.MariaSusana),
                datosEntidadBuilder.Build(3739, LocalidadSantaFe.Piamonte),
                datosEntidadBuilder.Build(3740, LocalidadSantaFe.SanMartinDeLasEscobas),
                datosEntidadBuilder.Build(3741, LocalidadSantaFe.Traill)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.Vera).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3742, LocalidadSantaFe.Calchaqui),
                datosEntidadBuilder.Build(3743, LocalidadSantaFe.Vera),
                datosEntidadBuilder.Build(3744, LocalidadSantaFe.CanadaOmbu),
                datosEntidadBuilder.Build(3745, LocalidadSantaFe.FortinOlmos),
                datosEntidadBuilder.Build(3746, LocalidadSantaFe.Garabato),
                datosEntidadBuilder.Build(3747, LocalidadSantaFe.Golondrina),
                datosEntidadBuilder.Build(3748, LocalidadSantaFe.Intiyaco),
                datosEntidadBuilder.Build(3749, LocalidadSantaFe.LaGallareta),
                datosEntidadBuilder.Build(3750, LocalidadSantaFe.LosAmores),
                datosEntidadBuilder.Build(3751, LocalidadSantaFe.Margarita),
                datosEntidadBuilder.Build(3752, LocalidadSantaFe.Tartagal),
                datosEntidadBuilder.Build(3753, LocalidadSantaFe.Toba)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.Belgrano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3754, LocalidadSantaFe.Armstrong),
                datosEntidadBuilder.Build(3755, LocalidadSantaFe.LasParejas),
                datosEntidadBuilder.Build(3756, LocalidadSantaFe.LasRosas),
                datosEntidadBuilder.Build(3757, LocalidadSantaFe.Bouquet),
                datosEntidadBuilder.Build(3758, LocalidadSantaFe.MontesDeOca),
                datosEntidadBuilder.Build(3759, LocalidadSantaFe.Tortugas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.SanJusto).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3760, LocalidadSantaFe.SanJusto),
                datosEntidadBuilder.Build(3761, LocalidadSantaFe.Angeloni),
                datosEntidadBuilder.Build(3762, LocalidadSantaFe.Cayastacito),
                datosEntidadBuilder.Build(3763, LocalidadSantaFe.ColoniaDolores),
                datosEntidadBuilder.Build(3764, LocalidadSantaFe.Esther),
                datosEntidadBuilder.Build(3765, LocalidadSantaFe.GobernadorCrespo),
                datosEntidadBuilder.Build(3766, LocalidadSantaFe.LaCamila),
                datosEntidadBuilder.Build(3767, LocalidadSantaFe.LaCriolla),
                datosEntidadBuilder.Build(3768, LocalidadSantaFe.LaPencaYCaraguata),
                datosEntidadBuilder.Build(3769, LocalidadSantaFe.MarcelinoEscalada),
                datosEntidadBuilder.Build(3770, LocalidadSantaFe.Nare),
                datosEntidadBuilder.Build(3771, LocalidadSantaFe.PedroGomezCello),
                datosEntidadBuilder.Build(3772, LocalidadSantaFe.Ramayon),
                datosEntidadBuilder.Build(3773, LocalidadSantaFe.SanBernardo),
                datosEntidadBuilder.Build(3774, LocalidadSantaFe.SanMartinNorte),
                datosEntidadBuilder.Build(3775, LocalidadSantaFe.Silva),
                datosEntidadBuilder.Build(3776, LocalidadSantaFe.Videla)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.SanJavier).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3777, LocalidadSantaFe.SanJavier),
                datosEntidadBuilder.Build(3778, LocalidadSantaFe.Romang),
                datosEntidadBuilder.Build(3779, LocalidadSantaFe.Alejandra),
                datosEntidadBuilder.Build(3780, LocalidadSantaFe.CaciqueAriacaiquin),
                datosEntidadBuilder.Build(3781, LocalidadSantaFe.ColoniaDuran),
                datosEntidadBuilder.Build(3782, LocalidadSantaFe.LaBrava)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.NueveDeJulio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3783, LocalidadSantaFe.Tostado),
                datosEntidadBuilder.Build(3784, LocalidadSantaFe.EstebanRams),
                datosEntidadBuilder.Build(3785, LocalidadSantaFe.GatoColorado),
                datosEntidadBuilder.Build(3786, LocalidadSantaFe.GregoriaPerezDeDenis),
                datosEntidadBuilder.Build(3787, LocalidadSantaFe.JuanDeGaray),
                datosEntidadBuilder.Build(3788, LocalidadSantaFe.Logrono),
                datosEntidadBuilder.Build(3789, LocalidadSantaFe.Montefiore),
                datosEntidadBuilder.Build(3790, LocalidadSantaFe.PozoBorrado),
                datosEntidadBuilder.Build(3791, LocalidadSantaFe.SanBernardo),
                datosEntidadBuilder.Build(3792, LocalidadSantaFe.SantaMargarita),
                datosEntidadBuilder.Build(3793, LocalidadSantaFe.VillaMinetti)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantaFe.Garay).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3794, LocalidadSantaFe.Cayasta),
                datosEntidadBuilder.Build(3795, LocalidadSantaFe.ColoniaMascias),
                datosEntidadBuilder.Build(3796, LocalidadSantaFe.Helvecia),
                datosEntidadBuilder.Build(3797, LocalidadSantaFe.SaladeroMarianoCabal),
                datosEntidadBuilder.Build(3798, LocalidadSantaFe.SantaRosaDeCalchines)
            });
        }
    }
}
