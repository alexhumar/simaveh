using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesSantiagoDelEsteroLoader : LocalidadesLoader
    {
        public LocalidadesSantiagoDelEsteroLoader(IPartidosLoader<long, long, string> partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Aguirre).Key, new Dictionary<long, string>
            {
                { 3799, LocalidadSantiagoDelEstero.Casares },
                { 3800, LocalidadSantiagoDelEstero.Pinto },
                { 3801, LocalidadSantiagoDelEstero.Malbran }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Alberdi).Key, new Dictionary<long, string>
            {
                { 3802, LocalidadSantiagoDelEstero.CampoGallo },
                { 3803, LocalidadSantiagoDelEstero.Donadeu },
                { 3804, LocalidadSantiagoDelEstero.Huachana },
                { 3805, LocalidadSantiagoDelEstero.Sachayoj },
                { 3806, LocalidadSantiagoDelEstero.SantosLugares },
                { 3807, LocalidadSantiagoDelEstero.AgustinaLibarona },
                { 3808, LocalidadSantiagoDelEstero.CoronelManuelLeoncioRico },
                { 3809, LocalidadSantiagoDelEstero.ElSetenta },
                { 3810, LocalidadSantiagoDelEstero.LasCarpas },
                { 3811, LocalidadSantiagoDelEstero.SanGregorio },
                { 3812, LocalidadSantiagoDelEstero.VillaPalmar },
                { 3813, LocalidadSantiagoDelEstero.LasParvas },
                { 3814, LocalidadSantiagoDelEstero.Esperanza },
                { 3815, LocalidadSantiagoDelEstero.Overa },
                { 3816, LocalidadSantiagoDelEstero.Ranchitos }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Atamisqui).Key, new Dictionary<long, string>
            {
                { 3817, LocalidadSantiagoDelEstero.VillaAtamisqui },
                { 3818, LocalidadSantiagoDelEstero.EstacionAtamisqui },
                { 3819, LocalidadSantiagoDelEstero.Ancocha },
                { 3820, LocalidadSantiagoDelEstero.Bajadita },
                { 3821, LocalidadSantiagoDelEstero.Boqueron },
                { 3822, LocalidadSantiagoDelEstero.BreaLoma },
                { 3823, LocalidadSantiagoDelEstero.BurroPozo },
                { 3824, LocalidadSantiagoDelEstero.ChilcaLaLoma },
                { 3825, LocalidadSantiagoDelEstero.CodoViejo },
                { 3826, LocalidadSantiagoDelEstero.ColleraHuarcuna },
                { 3827, LocalidadSantiagoDelEstero.GuanacoSombriana },
                { 3828, LocalidadSantiagoDelEstero.Hoyon },
                { 3829, LocalidadSantiagoDelEstero.SanIsidro },
                { 3830, LocalidadSantiagoDelEstero.HuinajAtun },
                { 3831, LocalidadSantiagoDelEstero.Juanillo },
                { 3832, LocalidadSantiagoDelEstero.Lomitas },
                { 3833, LocalidadSantiagoDelEstero.LosSauces },
                { 3834, LocalidadSantiagoDelEstero.LosTolozas },
                { 3835, LocalidadSantiagoDelEstero.Medellin },
                { 3836, LocalidadSantiagoDelEstero.Mochimo },
                { 3837, LocalidadSantiagoDelEstero.Mollares },
                { 3838, LocalidadSantiagoDelEstero.PuertaGrande },
                { 3839, LocalidadSantiagoDelEstero.PuestoDeDiaz },
                { 3840, LocalidadSantiagoDelEstero.PuestoDelRosario },
                { 3841, LocalidadSantiagoDelEstero.SanDionisio },
                { 3842, LocalidadSantiagoDelEstero.SantaIsabel },
                { 3843, LocalidadSantiagoDelEstero.SimbolPozo },
                { 3844, LocalidadSantiagoDelEstero.Soconcho },
                { 3845, LocalidadSantiagoDelEstero.Tasigasta },
                { 3846, LocalidadSantiagoDelEstero.VenturaPampa },
                { 3847, LocalidadSantiagoDelEstero.YacuChiri }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Avellaneda).Key, new Dictionary<long, string>
            {
                { 3848, LocalidadSantiagoDelEstero.ColoniaDora },
                { 3849, LocalidadSantiagoDelEstero.Herrera },
                { 3850, LocalidadSantiagoDelEstero.Icano },
                { 3851, LocalidadSantiagoDelEstero.Lugones },
                { 3852, LocalidadSantiagoDelEstero.PuntaPozo },
                { 3853, LocalidadSantiagoDelEstero.RealSayana },
                { 3854, LocalidadSantiagoDelEstero.VillaMailin },
                { 3855, LocalidadSantiagoDelEstero.Caloj },
                { 3856, LocalidadSantiagoDelEstero.Percas },
                { 3857, LocalidadSantiagoDelEstero.PuntaCorral },
                { 3858, LocalidadSantiagoDelEstero.Cejas },
                { 3859, LocalidadSantiagoDelEstero.Gramilla },
                { 3860, LocalidadSantiagoDelEstero.Banda },
                { 3861, LocalidadSantiagoDelEstero.Mancapa },
                { 3862, LocalidadSantiagoDelEstero.Puyana },
                { 3863, LocalidadSantiagoDelEstero.TacoAtun },
                { 3864, LocalidadSantiagoDelEstero.SanJose },
                { 3865, LocalidadSantiagoDelEstero.BlancaPozo },
                { 3866, LocalidadSantiagoDelEstero.Caloj },
                { 3867, LocalidadSantiagoDelEstero.CampoAlegre },
                { 3868, LocalidadSantiagoDelEstero.ColoniaAlcira },
                { 3869, LocalidadSantiagoDelEstero.ColoniaIsla },
                { 3870, LocalidadSantiagoDelEstero.ColoniaLibanesa },
                { 3871, LocalidadSantiagoDelEstero.ElBracho },
                { 3872, LocalidadSantiagoDelEstero.PuenteNegro },
                { 3873, LocalidadSantiagoDelEstero.SanAntonioDeCopo },
                { 3874, LocalidadSantiagoDelEstero.SanPedro },
                { 3875, LocalidadSantiagoDelEstero.SanRoque },
                { 3876, LocalidadSantiagoDelEstero.SantoDomingo },
                { 3877, LocalidadSantiagoDelEstero.TalaPozo },
                { 3878, LocalidadSantiagoDelEstero.Vacasnioj },
                { 3879, LocalidadSantiagoDelEstero.Yacasnioj }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Banda).Key, new Dictionary<long, string>
            {
                { 3880, LocalidadSantiagoDelEstero.LaBanda },
                { 3881, LocalidadSantiagoDelEstero.Clodomira },
                { 3882, LocalidadSantiagoDelEstero.AbraGrande },
                { 3883, LocalidadSantiagoDelEstero.Antaje },
                { 3884, LocalidadSantiagoDelEstero.Ardiles },
                { 3885, LocalidadSantiagoDelEstero.CanadaEscobar },
                { 3886, LocalidadSantiagoDelEstero.ChaupiPozo },
                { 3887, LocalidadSantiagoDelEstero.ElAibe },
                { 3888, LocalidadSantiagoDelEstero.EstacionSimbolar },
                { 3889, LocalidadSantiagoDelEstero.LosQuiroga },
                { 3890, LocalidadSantiagoDelEstero.LaAurora },
                { 3891, LocalidadSantiagoDelEstero.LaDarsena },
                { 3892, LocalidadSantiagoDelEstero.NegraMuerta },
                { 3893, LocalidadSantiagoDelEstero.Tramo16 }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Belgrano).Key, new Dictionary<long, string>
            {
                { 3894, LocalidadSantiagoDelEstero.Bandera },
                { 3895, LocalidadSantiagoDelEstero.CuatroBocas },
                { 3896, LocalidadSantiagoDelEstero.FortinInca },
                { 3897, LocalidadSantiagoDelEstero.GuardiaEscolta }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Capital).Key, new Dictionary<long, string>
            {
                { 3898, LocalidadSantiagoDelEstero.SantiagoDelEstero },
                { 3899, LocalidadSantiagoDelEstero.ElDean },
                { 3900, LocalidadSantiagoDelEstero.Remes },
                { 3901, LocalidadSantiagoDelEstero.SanBenito },
                { 3902, LocalidadSantiagoDelEstero.SanPedro },
                { 3903, LocalidadSantiagoDelEstero.SantaMaria },
                { 3904, LocalidadSantiagoDelEstero.SolDeMayo },
                { 3905, LocalidadSantiagoDelEstero.VillaZanjon },
                { 3906, LocalidadSantiagoDelEstero.VueltaDeLaBarranca },
                { 3907, LocalidadSantiagoDelEstero.Maco },
                { 3908, LocalidadSantiagoDelEstero.MalPaso },
                { 3909, LocalidadSantiagoDelEstero.Tipiro },
                { 3910, LocalidadSantiagoDelEstero.Antilo },
                { 3911, LocalidadSantiagoDelEstero.Sauzal },
                { 3912, LocalidadSantiagoDelEstero.TunasPuncu },
                { 3913, LocalidadSantiagoDelEstero.SantaRosa },
                { 3914, LocalidadSantiagoDelEstero.Cardosos },
                { 3915, LocalidadSantiagoDelEstero.Yanda },
                { 3916, LocalidadSantiagoDelEstero.TroncoYuraj },
                { 3917, LocalidadSantiagoDelEstero.Rosario },
                { 3918, LocalidadSantiagoDelEstero.BlancoCorral }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Choya).Key, new Dictionary<long, string>
            {
                { 3919, LocalidadSantiagoDelEstero.Choya },
                { 3920, LocalidadSantiagoDelEstero.Frias },
                { 3921, LocalidadSantiagoDelEstero.Laprida },
                { 3922, LocalidadSantiagoDelEstero.Tapso },
                { 3923, LocalidadSantiagoDelEstero.VillaLaPunta },
                { 3924, LocalidadSantiagoDelEstero.Ancajan },
                { 3925, LocalidadSantiagoDelEstero.ChanarPozo },
                { 3926, LocalidadSantiagoDelEstero.ElMojoncito },
                { 3927, LocalidadSantiagoDelEstero.ElRodeo },
                { 3928, LocalidadSantiagoDelEstero.ElTasial },
                { 3929, LocalidadSantiagoDelEstero.Kilometro55 },
                { 3930, LocalidadSantiagoDelEstero.LosRalos },
                { 3931, LocalidadSantiagoDelEstero.Maquijata },
                { 3932, LocalidadSantiagoDelEstero.MonteRedondo },
                { 3933, LocalidadSantiagoDelEstero.PocitoDeLaLoma },
                { 3934, LocalidadSantiagoDelEstero.PozoDeLaPuerta },
                { 3935, LocalidadSantiagoDelEstero.PozoDelSimbol },
                { 3936, LocalidadSantiagoDelEstero.PuertaDeChavez },
                { 3937, LocalidadSantiagoDelEstero.SanJuan },
                { 3938, LocalidadSantiagoDelEstero.SanJusto },
                { 3939, LocalidadSantiagoDelEstero.SanRafael },
                { 3940, LocalidadSantiagoDelEstero.SantaCruz },
                { 3941, LocalidadSantiagoDelEstero.SinchiCana },
                { 3942, LocalidadSantiagoDelEstero.VeinticincoDeMayoDeBanegas },
                { 3943, LocalidadSantiagoDelEstero.VeinticincoDeMayoSud },
                { 3944, LocalidadSantiagoDelEstero.VillaElvira },
                { 3945, LocalidadSantiagoDelEstero.VillaMercedes },
                { 3946, LocalidadSantiagoDelEstero.SolDeMayo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Copo).Key, new Dictionary<long, string>
            {
                { 3947, LocalidadSantiagoDelEstero.MonteQuemado },
                { 3948, LocalidadSantiagoDelEstero.PampaDeLosGuanacos },
                { 3949, LocalidadSantiagoDelEstero.AhiVeremos },
                { 3950, LocalidadSantiagoDelEstero.ElCabure },
                { 3951, LocalidadSantiagoDelEstero.LosPirpintos },
                { 3952, LocalidadSantiagoDelEstero.SanJoseDelBoqueron },
                { 3953, LocalidadSantiagoDelEstero.VillaMatoque }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Figueroa).Key, new Dictionary<long, string>
            {
                { 3954, LocalidadSantiagoDelEstero.BanderaBajada },
                { 3955, LocalidadSantiagoDelEstero.CaspiCorral },
                { 3956, LocalidadSantiagoDelEstero.ColoniaSanJuan },
                { 3957, LocalidadSantiagoDelEstero.LaCanada },
                { 3958, LocalidadSantiagoDelEstero.LaInvernada },
                { 3959, LocalidadSantiagoDelEstero.VacaHuanuna },
                { 3960, LocalidadSantiagoDelEstero.VillaFigueroa }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.GeneralTaboada).Key, new Dictionary<long, string>
            {
                { 3961, LocalidadSantiagoDelEstero.Anatuya },
                { 3962, LocalidadSantiagoDelEstero.LosJuries },
                { 3963, LocalidadSantiagoDelEstero.Averias },
                { 3964, LocalidadSantiagoDelEstero.EstacionTacanitas },
                { 3965, LocalidadSantiagoDelEstero.LaSimona },
                { 3966, LocalidadSantiagoDelEstero.LaNena },
                { 3967, LocalidadSantiagoDelEstero.TomasYoung }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Guasayan).Key, new Dictionary<long, string>
            {
                { 3968, LocalidadSantiagoDelEstero.SanPedroDeGuasayan },
                { 3969, LocalidadSantiagoDelEstero.DonaLuisa },
                { 3970, LocalidadSantiagoDelEstero.Guampacha },
                { 3971, LocalidadSantiagoDelEstero.Lavalle },
                { 3972, LocalidadSantiagoDelEstero.SantaCatalina },
                { 3973, LocalidadSantiagoDelEstero.VillaGuasayan }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Jimenez).Key, new Dictionary<long, string>
            {
                { 3974, LocalidadSantiagoDelEstero.PozoHondo },
                { 3975, LocalidadSantiagoDelEstero.ElArenal },
                { 3976, LocalidadSantiagoDelEstero.ElBobadal },
                { 3977, LocalidadSantiagoDelEstero.ElCharco },
                { 3978, LocalidadSantiagoDelEstero.Gramilla },
                { 3979, LocalidadSantiagoDelEstero.TresCruces }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.JuanFelipeIbarra).Key, new Dictionary<long, string>
            {
                { 3980, LocalidadSantiagoDelEstero.SunchoCorral },
                { 3981, LocalidadSantiagoDelEstero.ElColorado },
                { 3982, LocalidadSantiagoDelEstero.ElCuadrado },
                { 3983, LocalidadSantiagoDelEstero.Matara },
                { 3984, LocalidadSantiagoDelEstero.Melero },
                { 3985, LocalidadSantiagoDelEstero.PozoDelToba },
                { 3986, LocalidadSantiagoDelEstero.SanAntonioRoldan },
                { 3987, LocalidadSantiagoDelEstero.Vilelas },
                { 3988, LocalidadSantiagoDelEstero.Yuchan }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Loreto).Key, new Dictionary<long, string>
            {
                { 3989, LocalidadSantiagoDelEstero.Ayuncha },
                { 3990, LocalidadSantiagoDelEstero.Beltran },
                { 3991, LocalidadSantiagoDelEstero.ChunaAlbardon },
                { 3992, LocalidadSantiagoDelEstero.DienteDelArado },
                { 3993, LocalidadSantiagoDelEstero.JumiPozo },
                { 3994, LocalidadSantiagoDelEstero.LaDormida },
                { 3995, LocalidadSantiagoDelEstero.LaNoria },
                { 3996, LocalidadSantiagoDelEstero.LaRevancha },
                { 3997, LocalidadSantiagoDelEstero.MonteRedondo },
                { 3998, LocalidadSantiagoDelEstero.PuestoDeJuanes },
                { 3999, LocalidadSantiagoDelEstero.PuestoDeSuarez },
                { 4000, LocalidadSantiagoDelEstero.Punua },
                { 4001, LocalidadSantiagoDelEstero.SanGeronimo },
                { 4002, LocalidadSantiagoDelEstero.SanVicente },
                { 4003, LocalidadSantiagoDelEstero.SantaBarbara },
                { 4004, LocalidadSantiagoDelEstero.SauceSolo },
                { 4005, LocalidadSantiagoDelEstero.Taquetuyoj },
                { 4006, LocalidadSantiagoDelEstero.TioPozo },
                { 4007, LocalidadSantiagoDelEstero.VillaVieja }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Mitre).Key, new Dictionary<long, string>
            {
                { 4008, LocalidadSantiagoDelEstero.FuerteEsperanza },
                { 4009, LocalidadSantiagoDelEstero.Abras },
                { 4010, LocalidadSantiagoDelEstero.VillaUnion },
                { 4011, LocalidadSantiagoDelEstero.Captaros },
                { 4012, LocalidadSantiagoDelEstero.Porongos }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Moreno).Key, new Dictionary<long, string>
            {
                { 4013, LocalidadSantiagoDelEstero.Alhuampa },
                { 4014, LocalidadSantiagoDelEstero.Tintina },
                { 4015, LocalidadSantiagoDelEstero.Aerolito },
                { 4016, LocalidadSantiagoDelEstero.Otumpa },
                { 4017, LocalidadSantiagoDelEstero.Cejolao },
                { 4018, LocalidadSantiagoDelEstero.Quimili },
                { 4019, LocalidadSantiagoDelEstero.Puna },
                { 4020, LocalidadSantiagoDelEstero.SanCristobal },
                { 4021, LocalidadSantiagoDelEstero.LaFortuna },
                { 4022, LocalidadSantiagoDelEstero.Simbolar },
                { 4023, LocalidadSantiagoDelEstero.ElPertigo },
                { 4024, LocalidadSantiagoDelEstero.MistolPampa },
                { 4025, LocalidadSantiagoDelEstero.SanAntonio },
                { 4026, LocalidadSantiagoDelEstero.Milagros },
                { 4027, LocalidadSantiagoDelEstero.Amama },
                { 4028, LocalidadSantiagoDelEstero.Weisburd },
                { 4029, LocalidadSantiagoDelEstero.LasTinajas },
                { 4030, LocalidadSantiagoDelEstero.LiloViejo },
                { 4031, LocalidadSantiagoDelEstero.Hasse },
                { 4032, LocalidadSantiagoDelEstero.Patay },
                { 4033, LocalidadSantiagoDelEstero.Roversi },
                { 4034, LocalidadSantiagoDelEstero.HernanMejiaMiraval },
                { 4035, LocalidadSantiagoDelEstero.Libertad }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.OjoDeAgua).Key, new Dictionary<long, string>
            {
                { 4036, LocalidadSantiagoDelEstero.VillaOjoDeAgua },
                { 4037, LocalidadSantiagoDelEstero.SolDeJulio },
                { 4038, LocalidadSantiagoDelEstero.El49 }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Pellegrini).Key, new Dictionary<long, string>
            {
                { 4039, LocalidadSantiagoDelEstero.NuevaEsperanza },
                { 4040, LocalidadSantiagoDelEstero.AhiVeremos },
                { 4041, LocalidadSantiagoDelEstero.CampoGrande },
                { 4042, LocalidadSantiagoDelEstero.ElMojon },
                { 4043, LocalidadSantiagoDelEstero.LasDelicias },
                { 4044, LocalidadSantiagoDelEstero.PozoBetbeder },
                { 4045, LocalidadSantiagoDelEstero.QuebrachoCoto },
                { 4046, LocalidadSantiagoDelEstero.Rapelli },
                { 4047, LocalidadSantiagoDelEstero.SantoDomingo },
                { 4048, LocalidadSantiagoDelEstero.VillaMercedes },
                { 4049, LocalidadSantiagoDelEstero.VillaNueva },
                { 4050, LocalidadSantiagoDelEstero.ElSaladillo },
                { 4051, LocalidadSantiagoDelEstero.ElRemate },
                { 4052, LocalidadSantiagoDelEstero.LaFragua },
                { 4053, LocalidadSantiagoDelEstero.SanRamon }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Quebrachos).Key, new Dictionary<long, string>
            {
                { 4054, LocalidadSantiagoDelEstero.RamirezDeVelazco },
                { 4055, LocalidadSantiagoDelEstero.Sumampa },
                { 4056, LocalidadSantiagoDelEstero.Belgrano },
                { 4057, LocalidadSantiagoDelEstero.SumampaViejo },
                { 4058, LocalidadSantiagoDelEstero.VillaQuebrachos },
                { 4059, LocalidadSantiagoDelEstero.SanFrancisco },
                { 4060, LocalidadSantiagoDelEstero.TacoPozo },
                { 4061, LocalidadSantiagoDelEstero.CampoDelCisne },
                { 4062, LocalidadSantiagoDelEstero.HorcoTucucuna }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.RioHondo).Key, new Dictionary<long, string>
            {
                { 4063, LocalidadSantiagoDelEstero.Chauchillas },
                { 4064, LocalidadSantiagoDelEstero.ColoniaTinco },
                { 4065, LocalidadSantiagoDelEstero.LosNunez },
                { 4066, LocalidadSantiagoDelEstero.Pozuelos },
                { 4067, LocalidadSantiagoDelEstero.TermasDeRioHondo },
                { 4068, LocalidadSantiagoDelEstero.VillaRioHondo },
                { 4069, LocalidadSantiagoDelEstero.Vinara }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Rivadavia).Key, new Dictionary<long, string>
            {
                { 4070, LocalidadSantiagoDelEstero.Selva },
                { 4071, LocalidadSantiagoDelEstero.ColoniaAlpina },
                { 4072, LocalidadSantiagoDelEstero.PaloNegro },
                { 4073, LocalidadSantiagoDelEstero.Argentina },
                { 4074, LocalidadSantiagoDelEstero.Malbran }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Robles).Key, new Dictionary<long, string>
            {
                { 4075, LocalidadSantiagoDelEstero.Beltran },
                { 4076, LocalidadSantiagoDelEstero.ColoniaElSimbolar },
                { 4077, LocalidadSantiagoDelEstero.Fernandez },
                { 4078, LocalidadSantiagoDelEstero.IngenieroForres },
                { 4079, LocalidadSantiagoDelEstero.VillaRobles },
                { 4080, LocalidadSantiagoDelEstero.Vilmer },
                { 4081, LocalidadSantiagoDelEstero.LosBanegas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Salavina).Key, new Dictionary<long, string>
            {
                { 4082, LocalidadSantiagoDelEstero.CarretaPaso },
                { 4083, LocalidadSantiagoDelEstero.ChilcaJuliana },
                { 4084, LocalidadSantiagoDelEstero.Chinuna },
                { 4085, LocalidadSantiagoDelEstero.LosTelares },
                { 4086, LocalidadSantiagoDelEstero.Sabagasta },
                { 4087, LocalidadSantiagoDelEstero.VillaSalavina },
                { 4088, LocalidadSantiagoDelEstero.Anga },
                { 4089, LocalidadSantiagoDelEstero.Barrancas },
                { 4090, LocalidadSantiagoDelEstero.LosCerrillos },
                { 4091, LocalidadSantiagoDelEstero.Malota },
                { 4092, LocalidadSantiagoDelEstero.MistolPozo },
                { 4093, LocalidadSantiagoDelEstero.PasoDeOscares },
                { 4094, LocalidadSantiagoDelEstero.PuenteDelSaladillo },
                { 4095, LocalidadSantiagoDelEstero.RubiaPaso },
                { 4096, LocalidadSantiagoDelEstero.SantaLucia },
                { 4097, LocalidadSantiagoDelEstero.Sitkioj },
                { 4098, LocalidadSantiagoDelEstero.Veron },
                { 4099, LocalidadSantiagoDelEstero.YacuHurmana },
                { 4100, LocalidadSantiagoDelEstero.Asingasta }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.SanMartin).Key, new Dictionary<long, string>
            {
                { 4101, LocalidadSantiagoDelEstero.BreaPozo },
                { 4102, LocalidadSantiagoDelEstero.EstacionRobles },
                { 4103, LocalidadSantiagoDelEstero.EstacionTaboada },
                { 4104, LocalidadSantiagoDelEstero.AtojPozo },
                { 4105, LocalidadSantiagoDelEstero.AshpaSinchi },
                { 4106, LocalidadSantiagoDelEstero.BarrancasColoradas },
                { 4107, LocalidadSantiagoDelEstero.BreaPozoViejo },
                { 4108, LocalidadSantiagoDelEstero.Cheej },
                { 4109, LocalidadSantiagoDelEstero.ColoniaPinto },
                { 4110, LocalidadSantiagoDelEstero.Diaspa },
                { 4111, LocalidadSantiagoDelEstero.Kilometro25 },
                { 4112, LocalidadSantiagoDelEstero.LaBlanca },
                { 4113, LocalidadSantiagoDelEstero.LaHiguera },
                { 4114, LocalidadSantiagoDelEstero.LaVerde },
                { 4115, LocalidadSantiagoDelEstero.LagunaBlanca },
                { 4116, LocalidadSantiagoDelEstero.Linton },
                { 4117, LocalidadSantiagoDelEstero.LosGallegos },
                { 4118, LocalidadSantiagoDelEstero.MajadasSud },
                { 4119, LocalidadSantiagoDelEstero.PampaAtun },
                { 4120, LocalidadSantiagoDelEstero.Percas },
                { 4121, LocalidadSantiagoDelEstero.PerchilBajo },
                { 4122, LocalidadSantiagoDelEstero.PozoMosoj },
                { 4123, LocalidadSantiagoDelEstero.Puestito },
                { 4124, LocalidadSantiagoDelEstero.Quimilioj },
                { 4125, LocalidadSantiagoDelEstero.SanJoseDeFlores },
                { 4126, LocalidadSantiagoDelEstero.SanPascual },
                { 4127, LocalidadSantiagoDelEstero.SunchoPozo },
                { 4128, LocalidadSantiagoDelEstero.TioPozo },
                { 4129, LocalidadSantiagoDelEstero.TresJazmines },
                { 4130, LocalidadSantiagoDelEstero.Tuamilla },
                { 4131, LocalidadSantiagoDelEstero.VillaNueva }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Sarmiento).Key, new Dictionary<long, string>
            {
                { 4132, LocalidadSantiagoDelEstero.Matara },
                { 4133, LocalidadSantiagoDelEstero.Garza },
                { 4134, LocalidadSantiagoDelEstero.SauceBajada },
                { 4135, LocalidadSantiagoDelEstero.Guaype }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSantiagoDelEstero.Silipica).Key, new Dictionary<long, string>
            {
                { 4136, LocalidadSantiagoDelEstero.Arraga },
                { 4137, LocalidadSantiagoDelEstero.Manogasta },
                { 4138, LocalidadSantiagoDelEstero.NuevaFrancia },
                { 4139, LocalidadSantiagoDelEstero.VillaSilipica },
                { 4140, LocalidadSantiagoDelEstero.BueyRodeo },
                { 4141, LocalidadSantiagoDelEstero.CampoAlegre },
                { 4142, LocalidadSantiagoDelEstero.ChanarPujio },
                { 4143, LocalidadSantiagoDelEstero.CoroPampa },
                { 4144, LocalidadSantiagoDelEstero.Huachana },
                { 4145, LocalidadSantiagoDelEstero.LaAbrita },
                { 4146, LocalidadSantiagoDelEstero.LaHiguera },
                { 4147, LocalidadSantiagoDelEstero.LaRamadita },
                { 4148, LocalidadSantiagoDelEstero.PuestoDelMedio },
                { 4149, LocalidadSantiagoDelEstero.SanAndres },
                { 4150, LocalidadSantiagoDelEstero.SanVicente },
                { 4151, LocalidadSantiagoDelEstero.Simbol },
                { 4152, LocalidadSantiagoDelEstero.Sumamao }
            });
        }
    }
}
