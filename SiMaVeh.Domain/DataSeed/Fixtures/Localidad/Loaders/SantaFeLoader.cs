using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class SantaFeLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public SantaFeLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.Rosario).Value.Key, new Dictionary<long, string>
            {
                { 3473, LocalidadSantaFe.Rosario },
                { 3474, LocalidadSantaFe.VillaGobernadorGalvez },
                { 3475, LocalidadSantaFe.GranaderoBaigorria },
                { 3476, LocalidadSantaFe.Perez },
                { 3477, LocalidadSantaFe.Funes },
                { 3478, LocalidadSantaFe.ArroyoSeco },
                { 3479, LocalidadSantaFe.PuebloEsther },
                { 3480, LocalidadSantaFe.Alvarez },
                { 3481, LocalidadSantaFe.Acebal },
                { 3482, LocalidadSantaFe.Zavalla },
                { 3483, LocalidadSantaFe.Fighiera },
                { 3484, LocalidadSantaFe.Alvear },
                { 3485, LocalidadSantaFe.Ibarlucea },
                { 3486, LocalidadSantaFe.GeneralLagos },
                { 3487, LocalidadSantaFe.Soldini },
                { 3488, LocalidadSantaFe.CoronelBogado },
                { 3489, LocalidadSantaFe.Pinero },
                { 3490, LocalidadSantaFe.VillaAmelia },
                { 3491, LocalidadSantaFe.CoronelDominguez },
                { 3492, LocalidadSantaFe.PuebloUranga },
                { 3493, LocalidadSantaFe.CarmenDelSauce },
                { 3494, LocalidadSantaFe.PuebloMunoz },
                { 3495, LocalidadSantaFe.Albarellos },
                { 3496, LocalidadSantaFe.Arminda }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.LaCapital).Value.Key, new Dictionary<long, string>
            {
                { 3497, LocalidadSantaFe.SantaFe },
                { 3498, LocalidadSantaFe.ArroyoAguiar },
                { 3499, LocalidadSantaFe.ArroyoLeyes },
                { 3500, LocalidadSantaFe.Cabal },
                { 3501, LocalidadSantaFe.CampoAndino },
                { 3502, LocalidadSantaFe.Candioti },
                { 3503, LocalidadSantaFe.Emilia },
                { 3504, LocalidadSantaFe.LagunaPaiva },
                { 3505, LocalidadSantaFe.LlambiCampbell },
                { 3506, LocalidadSantaFe.MonteVera },
                { 3507, LocalidadSantaFe.Nelson },
                { 3508, LocalidadSantaFe.Recreo },
                { 3509, LocalidadSantaFe.SanJoseDelRincon },
                { 3510, LocalidadSantaFe.SantoTome },
                { 3511, LocalidadSantaFe.SauceViejo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.GeneralLopez).Value.Key, new Dictionary<long, string>
            {
                { 3512, LocalidadSantaFe.VenadoTuerto },
                { 3513, LocalidadSantaFe.Firmat },
                { 3514, LocalidadSantaFe.Rufino },
                { 3515, LocalidadSantaFe.Wheelwright },
                { 3516, LocalidadSantaFe.VillaCanas },
                { 3517, LocalidadSantaFe.Teodelina },
                { 3518, LocalidadSantaFe.Elortondo },
                { 3519, LocalidadSantaFe.Hughes },
                { 3520, LocalidadSantaFe.SanGregorio },
                { 3521, LocalidadSantaFe.SantaIsabel },
                { 3522, LocalidadSantaFe.MariaTeresa },
                { 3523, LocalidadSantaFe.Murphy },
                { 3524, LocalidadSantaFe.SanctiSpiritu },
                { 3525, LocalidadSantaFe.Chovet },
                { 3526, LocalidadSantaFe.Melincue },
                { 3527, LocalidadSantaFe.Maggiolo },
                { 3528, LocalidadSantaFe.DiegoDeAlvear },
                { 3529, LocalidadSantaFe.Carreras },
                { 3530, LocalidadSantaFe.Carmen },
                { 3531, LocalidadSantaFe.Cafferata },
                { 3532, LocalidadSantaFe.Amenabar },
                { 3533, LocalidadSantaFe.SanEduardo },
                { 3534, LocalidadSantaFe.Labordeboy },
                { 3535, LocalidadSantaFe.CanadaDelUcle },
                { 3536, LocalidadSantaFe.Christophersen },
                { 3537, LocalidadSantaFe.Chapuy },
                { 3538, LocalidadSantaFe.Lazzarino },
                { 3539, LocalidadSantaFe.LaChispa },
                { 3540, LocalidadSantaFe.MiguelTorres },
                { 3541, LocalidadSantaFe.SanFranciscoDeStaFe },
                { 3542, LocalidadSantaFe.AaronCastellanos }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.Castellanos).Value.Key, new Dictionary<long, string>
            {
                { 3543, LocalidadSantaFe.Rafaela },
                { 3544, LocalidadSantaFe.Sunchales },
                { 3545, LocalidadSantaFe.Frontera },
                { 3546, LocalidadSantaFe.SanVicente },
                { 3547, LocalidadSantaFe.HumbertoPrimo },
                { 3548, LocalidadSantaFe.MariaJuana },
                { 3549, LocalidadSantaFe.Lehmann },
                { 3550, LocalidadSantaFe.Josefina },
                { 3551, LocalidadSantaFe.SantaClaraDeSaguier },
                { 3552, LocalidadSantaFe.Ataliva }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.GeneralObligado).Value.Key, new Dictionary<long, string>
            {
                { 3553, LocalidadSantaFe.Avellaneda },
                { 3554, LocalidadSantaFe.LasToscas },
                { 3555, LocalidadSantaFe.Malabrigo },
                { 3556, LocalidadSantaFe.Reconquista },
                { 3557, LocalidadSantaFe.VillaOcampo },
                { 3558, LocalidadSantaFe.ArroyoCeibal },
                { 3559, LocalidadSantaFe.Berna },
                { 3560, LocalidadSantaFe.ElAraza },
                { 3561, LocalidadSantaFe.ElRabon },
                { 3562, LocalidadSantaFe.ElSombrerito },
                { 3563, LocalidadSantaFe.Florencia },
                { 3564, LocalidadSantaFe.GuadalupeNorte },
                { 3565, LocalidadSantaFe.IngenieroChanourdie },
                { 3566, LocalidadSantaFe.LaSarita },
                { 3567, LocalidadSantaFe.Lanteri },
                { 3568, LocalidadSantaFe.LasGarzas },
                { 3569, LocalidadSantaFe.LosLaureles },
                { 3570, LocalidadSantaFe.NicanorMolinas },
                { 3571, LocalidadSantaFe.SanAntonioDeObligado },
                { 3572, LocalidadSantaFe.Tacuarendi },
                { 3573, LocalidadSantaFe.VillaAna },
                { 3574, LocalidadSantaFe.VillaGuillermina }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.SanLorenzo).Value.Key, new Dictionary<long, string>
            {
                { 3575, LocalidadSantaFe.Aldao },
                { 3576, LocalidadSantaFe.CoronelArnold },
                { 3577, LocalidadSantaFe.Fuentes },
                { 3578, LocalidadSantaFe.Pujato },
                { 3579, LocalidadSantaFe.Ricardone },
                { 3580, LocalidadSantaFe.SanJeronimoSud },
                { 3581, LocalidadSantaFe.Timbues },
                { 3582, LocalidadSantaFe.VillaMugueta },
                { 3583, LocalidadSantaFe.LuisPalacios },
                { 3584, LocalidadSantaFe.CapitanBermudez },
                { 3585, LocalidadSantaFe.Carcarana },
                { 3586, LocalidadSantaFe.FrayLuisBeltran },
                { 3587, LocalidadSantaFe.PuertoGeneralSanMartin },
                { 3588, LocalidadSantaFe.Roldan },
                { 3589, LocalidadSantaFe.SanLorenzo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.LasColonias).Value.Key, new Dictionary<long, string>
            {
                { 3590, LocalidadSantaFe.Esperanza },
                { 3591, LocalidadSantaFe.SanCarlosCentro },
                { 3592, LocalidadSantaFe.ColoniaCavour },
                { 3593, LocalidadSantaFe.ColoniaSanJose },
                { 3594, LocalidadSantaFe.Cululu },
                { 3595, LocalidadSantaFe.Elisa },
                { 3596, LocalidadSantaFe.EmpalmeSanCarlos },
                { 3597, LocalidadSantaFe.Felicia },
                { 3598, LocalidadSantaFe.Franck },
                { 3599, LocalidadSantaFe.Grutly },
                { 3600, LocalidadSantaFe.Hipatia },
                { 3601, LocalidadSantaFe.Humboldt },
                { 3602, LocalidadSantaFe.Ituzaingo },
                { 3603, LocalidadSantaFe.JacintoLArauz },
                { 3604, LocalidadSantaFe.LaPelada },
                { 3605, LocalidadSantaFe.LasTunas },
                { 3606, LocalidadSantaFe.MariaLuisa },
                { 3607, LocalidadSantaFe.Matilde },
                { 3608, LocalidadSantaFe.NuevoTorino },
                { 3609, LocalidadSantaFe.Pilar },
                { 3610, LocalidadSantaFe.Progreso },
                { 3611, LocalidadSantaFe.Providencia },
                { 3612, LocalidadSantaFe.PujatoNorte },
                { 3613, LocalidadSantaFe.Rivadavia },
                { 3614, LocalidadSantaFe.SaPereira },
                { 3615, LocalidadSantaFe.SanAgustin },
                { 3616, LocalidadSantaFe.SanCarlosNorte },
                { 3617, LocalidadSantaFe.SanCarlosSud },
                { 3618, LocalidadSantaFe.SanJeronimoDelSauce },
                { 3619, LocalidadSantaFe.SanJeronimoNorte },
                { 3620, LocalidadSantaFe.SanMariano },
                { 3621, LocalidadSantaFe.SantaClaraDeBuenaVista },
                { 3622, LocalidadSantaFe.SantaMariaCentro },
                { 3623, LocalidadSantaFe.SantaMariaNorte },
                { 3624, LocalidadSantaFe.SantoDomingo },
                { 3625, LocalidadSantaFe.Sarmiento },
                { 3626, LocalidadSantaFe.Soutomayor }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.Constitucion).Value.Key, new Dictionary<long, string>
            {
                { 3627, LocalidadSantaFe.VillaConstitucion },
                { 3628, LocalidadSantaFe.Alcorta },
                { 3629, LocalidadSantaFe.Bombal },
                { 3630, LocalidadSantaFe.CanadaRica },
                { 3631, LocalidadSantaFe.Cepeda },
                { 3632, LocalidadSantaFe.EmpalmeVillaConstitucion },
                { 3633, LocalidadSantaFe.GeneralGelly },
                { 3634, LocalidadSantaFe.Godoy },
                { 3635, LocalidadSantaFe.JuanBernabeMolina },
                { 3636, LocalidadSantaFe.Juncal },
                { 3637, LocalidadSantaFe.LaVanguardia },
                { 3638, LocalidadSantaFe.MaximoPaz },
                { 3639, LocalidadSantaFe.Pavon },
                { 3640, LocalidadSantaFe.PavonArriba },
                { 3641, LocalidadSantaFe.Peyrano },
                { 3642, LocalidadSantaFe.Rueda },
                { 3643, LocalidadSantaFe.SantaTeresa },
                { 3644, LocalidadSantaFe.SargentoCabral },
                { 3645, LocalidadSantaFe.Theobald }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.Caseros).Value.Key, new Dictionary<long, string>
            {
                { 3646, LocalidadSantaFe.Casilda },
                { 3647, LocalidadSantaFe.Arequito },
                { 3648, LocalidadSantaFe.Arteaga },
                { 3649, LocalidadSantaFe.Berabevu },
                { 3650, LocalidadSantaFe.Bigand },
                { 3651, LocalidadSantaFe.Chabas },
                { 3652, LocalidadSantaFe.ChanarLadeado },
                { 3653, LocalidadSantaFe.Godeken },
                { 3654, LocalidadSantaFe.LosMolinos },
                { 3655, LocalidadSantaFe.LosNogales },
                { 3656, LocalidadSantaFe.LosQuirquinchos },
                { 3657, LocalidadSantaFe.SanJoseDeLaEsquina },
                { 3658, LocalidadSantaFe.Sanford },
                { 3659, LocalidadSantaFe.Villada }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.SanJeronimo).Value.Key, new Dictionary<long, string>
            {
                { 3660, LocalidadSantaFe.Coronda },
                { 3661, LocalidadSantaFe.Galvez },
                { 3662, LocalidadSantaFe.SanGenaro },
                { 3663, LocalidadSantaFe.Arocena },
                { 3664, LocalidadSantaFe.Barrancas },
                { 3665, LocalidadSantaFe.BernardoDeIrigoyen },
                { 3666, LocalidadSantaFe.CampoPiaggio },
                { 3667, LocalidadSantaFe.Casalegno },
                { 3668, LocalidadSantaFe.Centeno },
                { 3669, LocalidadSantaFe.DesvioArijon },
                { 3670, LocalidadSantaFe.Diaz },
                { 3671, LocalidadSantaFe.Gaboto },
                { 3672, LocalidadSantaFe.Gessler },
                { 3673, LocalidadSantaFe.Larrechea },
                { 3674, LocalidadSantaFe.LomaAlta },
                { 3675, LocalidadSantaFe.Lopez },
                { 3676, LocalidadSantaFe.Maciel },
                { 3677, LocalidadSantaFe.Monje },
                { 3678, LocalidadSantaFe.PuebloIrigoyen },
                { 3679, LocalidadSantaFe.SanEugenio },
                { 3680, LocalidadSantaFe.SanFabian }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.SanCristobal).Value.Key, new Dictionary<long, string>
            {
                { 3681, LocalidadSantaFe.Ceres },
                { 3682, LocalidadSantaFe.SanCristobal },
                { 3683, LocalidadSantaFe.AguaraGrande },
                { 3684, LocalidadSantaFe.Ambrosetti },
                { 3685, LocalidadSantaFe.Arrufo },
                { 3686, LocalidadSantaFe.Capivara },
                { 3687, LocalidadSantaFe.ColoniaAna },
                { 3688, LocalidadSantaFe.ColoniaBossi },
                { 3689, LocalidadSantaFe.ColoniaClara },
                { 3690, LocalidadSantaFe.ColoniaDosRosasYLaLegua },
                { 3691, LocalidadSantaFe.ColoniaRosa },
                { 3692, LocalidadSantaFe.Constanza },
                { 3693, LocalidadSantaFe.Curupaity },
                { 3694, LocalidadSantaFe.Hersilia },
                { 3695, LocalidadSantaFe.Huanqueros },
                { 3696, LocalidadSantaFe.LaCabral },
                { 3697, LocalidadSantaFe.LaLucila },
                { 3698, LocalidadSantaFe.LaRubia },
                { 3699, LocalidadSantaFe.LasAvispas },
                { 3700, LocalidadSantaFe.LasPalmeras },
                { 3701, LocalidadSantaFe.MoisesVille },
                { 3702, LocalidadSantaFe.Monigotes },
                { 3703, LocalidadSantaFe.MonteOscuridad },
                { 3704, LocalidadSantaFe.Nanducita },
                { 3705, LocalidadSantaFe.Palacios },
                { 3706, LocalidadSantaFe.Portugalete },
                { 3707, LocalidadSantaFe.SanGuillermo },
                { 3708, LocalidadSantaFe.Santurce },
                { 3709, LocalidadSantaFe.Soledad },
                { 3710, LocalidadSantaFe.Suardi },
                { 3711, LocalidadSantaFe.VillaSaralegui },
                { 3712, LocalidadSantaFe.VillaTrinidad }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.Iriondo).Value.Key, new Dictionary<long, string>
            {
                { 3713, LocalidadSantaFe.CanadaDeGomez },
                { 3714, LocalidadSantaFe.Totoras },
                { 3715, LocalidadSantaFe.Bustinza },
                { 3716, LocalidadSantaFe.Clarke },
                { 3717, LocalidadSantaFe.Clason },
                { 3718, LocalidadSantaFe.Correa },
                { 3719, LocalidadSantaFe.LucioVLopez },
                { 3720, LocalidadSantaFe.Oliveros },
                { 3721, LocalidadSantaFe.PuebloAndino },
                { 3722, LocalidadSantaFe.SaltoGrande },
                { 3723, LocalidadSantaFe.Serodino },
                { 3724, LocalidadSantaFe.VillaEloisa }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.SanMartin).Value.Key, new Dictionary<long, string>
            {
                { 3725, LocalidadSantaFe.ElTrebol },
                { 3726, LocalidadSantaFe.SanJorge },
                { 3727, LocalidadSantaFe.Sastre },
                { 3728, LocalidadSantaFe.CanadaRosquin },
                { 3729, LocalidadSantaFe.CarlosPellegrini },
                { 3730, LocalidadSantaFe.Casas },
                { 3731, LocalidadSantaFe.Castelar },
                { 3732, LocalidadSantaFe.ColoniaBelgrano },
                { 3733, LocalidadSantaFe.Crispi },
                { 3734, LocalidadSantaFe.Landeta },
                { 3735, LocalidadSantaFe.LasBandurrias },
                { 3736, LocalidadSantaFe.LasPetacas },
                { 3737, LocalidadSantaFe.LosCardos },
                { 3738, LocalidadSantaFe.MariaSusana },
                { 3739, LocalidadSantaFe.Piamonte },
                { 3740, LocalidadSantaFe.SanMartinDeLasEscobas },
                { 3741, LocalidadSantaFe.Traill }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.Vera).Value.Key, new Dictionary<long, string>
            {
                { 3742, LocalidadSantaFe.Calchaqui },
                { 3743, LocalidadSantaFe.Vera },
                { 3744, LocalidadSantaFe.CanadaOmbu },
                { 3745, LocalidadSantaFe.FortinOlmos },
                { 3746, LocalidadSantaFe.Garabato },
                { 3747, LocalidadSantaFe.Golondrina },
                { 3748, LocalidadSantaFe.Intiyaco },
                { 3749, LocalidadSantaFe.LaGallareta },
                { 3750, LocalidadSantaFe.LosAmores },
                { 3751, LocalidadSantaFe.Margarita },
                { 3752, LocalidadSantaFe.Tartagal },
                { 3753, LocalidadSantaFe.Toba }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.Belgrano).Value.Key, new Dictionary<long, string>
            {
                { 3754, LocalidadSantaFe.Armstrong },
                { 3755, LocalidadSantaFe.LasParejas },
                { 3756, LocalidadSantaFe.LasRosas },
                { 3757, LocalidadSantaFe.Bouquet },
                { 3758, LocalidadSantaFe.MontesDeOca },
                { 3759, LocalidadSantaFe.Tortugas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.SanJusto).Value.Key, new Dictionary<long, string>
            {
                { 3760, LocalidadSantaFe.SanJusto },
                { 3761, LocalidadSantaFe.Angeloni },
                { 3762, LocalidadSantaFe.Cayastacito },
                { 3763, LocalidadSantaFe.ColoniaDolores },
                { 3764, LocalidadSantaFe.Esther },
                { 3765, LocalidadSantaFe.GobernadorCrespo },
                { 3766, LocalidadSantaFe.LaCamila },
                { 3767, LocalidadSantaFe.LaCriolla },
                { 3768, LocalidadSantaFe.LaPencaYCaraguata },
                { 3769, LocalidadSantaFe.MarcelinoEscalada },
                { 3770, LocalidadSantaFe.Nare },
                { 3771, LocalidadSantaFe.PedroGomezCello },
                { 3772, LocalidadSantaFe.Ramayon },
                { 3773, LocalidadSantaFe.SanBernardo },
                { 3774, LocalidadSantaFe.SanMartinNorte },
                { 3775, LocalidadSantaFe.Silva },
                { 3776, LocalidadSantaFe.Videla }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.SanJavier).Value.Key, new Dictionary<long, string>
            {
                { 3777, LocalidadSantaFe.SanJavier },
                { 3778, LocalidadSantaFe.Romang },
                { 3779, LocalidadSantaFe.Alejandra },
                { 3780, LocalidadSantaFe.CaciqueAriacaiquin },
                { 3781, LocalidadSantaFe.ColoniaDuran },
                { 3782, LocalidadSantaFe.LaBrava }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.NueveDeJulio).Value.Key, new Dictionary<long, string>
            {
                { 3783, LocalidadSantaFe.Tostado },
                { 3784, LocalidadSantaFe.EstebanRams },
                { 3785, LocalidadSantaFe.GatoColorado },
                { 3786, LocalidadSantaFe.GregoriaPerezDeDenis },
                { 3787, LocalidadSantaFe.JuanDeGaray },
                { 3788, LocalidadSantaFe.Logrono },
                { 3789, LocalidadSantaFe.Montefiore },
                { 3790, LocalidadSantaFe.PozoBorrado },
                { 3791, LocalidadSantaFe.SanBernardo },
                { 3792, LocalidadSantaFe.SantaMargarita },
                { 3793, LocalidadSantaFe.VillaMinetti }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoSantaFe.Garay).Value.Key, new Dictionary<long, string>
            {
                { 3794, LocalidadSantaFe.Cayasta },
                { 3795, LocalidadSantaFe.ColoniaMascias },
                { 3796, LocalidadSantaFe.Helvecia },
                { 3797, LocalidadSantaFe.SaladeroMarianoCabal },
                { 3798, LocalidadSantaFe.SantaRosaDeCalchines }
            });
        }
    }
}
