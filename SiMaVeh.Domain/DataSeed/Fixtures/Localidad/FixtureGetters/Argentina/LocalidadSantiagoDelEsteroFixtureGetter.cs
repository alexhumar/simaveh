using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    public class LocalidadSantiagoDelEsteroFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadSantiagoDelEsteroFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Aguirre).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3799, LocalidadSantiagoDelEstero.Casares),
                datosEntidadBuilder.Build(3800, LocalidadSantiagoDelEstero.Pinto),
                datosEntidadBuilder.Build(3801, LocalidadSantiagoDelEstero.Malbran)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Alberdi).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3802, LocalidadSantiagoDelEstero.CampoGallo),
                datosEntidadBuilder.Build(3803, LocalidadSantiagoDelEstero.Donadeu),
                datosEntidadBuilder.Build(3804, LocalidadSantiagoDelEstero.Huachana),
                datosEntidadBuilder.Build(3805, LocalidadSantiagoDelEstero.Sachayoj),
                datosEntidadBuilder.Build(3806, LocalidadSantiagoDelEstero.SantosLugares),
                datosEntidadBuilder.Build(3807, LocalidadSantiagoDelEstero.AgustinaLibarona),
                datosEntidadBuilder.Build(3808, LocalidadSantiagoDelEstero.CoronelManuelLeoncioRico),
                datosEntidadBuilder.Build(3809, LocalidadSantiagoDelEstero.ElSetenta),
                datosEntidadBuilder.Build(3810, LocalidadSantiagoDelEstero.LasCarpas),
                datosEntidadBuilder.Build(3811, LocalidadSantiagoDelEstero.SanGregorio),
                datosEntidadBuilder.Build(3812, LocalidadSantiagoDelEstero.VillaPalmar),
                datosEntidadBuilder.Build(3813, LocalidadSantiagoDelEstero.LasParvas),
                datosEntidadBuilder.Build(3814, LocalidadSantiagoDelEstero.Esperanza),
                datosEntidadBuilder.Build(3815, LocalidadSantiagoDelEstero.Overa),
                datosEntidadBuilder.Build(3816, LocalidadSantiagoDelEstero.Ranchitos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Atamisqui).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3817, LocalidadSantiagoDelEstero.VillaAtamisqui),
                datosEntidadBuilder.Build(3818, LocalidadSantiagoDelEstero.EstacionAtamisqui),
                datosEntidadBuilder.Build(3819, LocalidadSantiagoDelEstero.Ancocha),
                datosEntidadBuilder.Build(3820, LocalidadSantiagoDelEstero.Bajadita),
                datosEntidadBuilder.Build(3821, LocalidadSantiagoDelEstero.Boqueron),
                datosEntidadBuilder.Build(3822, LocalidadSantiagoDelEstero.BreaLoma),
                datosEntidadBuilder.Build(3823, LocalidadSantiagoDelEstero.BurroPozo),
                datosEntidadBuilder.Build(3824, LocalidadSantiagoDelEstero.ChilcaLaLoma),
                datosEntidadBuilder.Build(3825, LocalidadSantiagoDelEstero.CodoViejo),
                datosEntidadBuilder.Build(3826, LocalidadSantiagoDelEstero.ColleraHuarcuna),
                datosEntidadBuilder.Build(3827, LocalidadSantiagoDelEstero.GuanacoSombriana),
                datosEntidadBuilder.Build(3828, LocalidadSantiagoDelEstero.Hoyon),
                datosEntidadBuilder.Build(3829, LocalidadSantiagoDelEstero.SanIsidro),
                datosEntidadBuilder.Build(3830, LocalidadSantiagoDelEstero.HuinajAtun),
                datosEntidadBuilder.Build(3831, LocalidadSantiagoDelEstero.Juanillo),
                datosEntidadBuilder.Build(3832, LocalidadSantiagoDelEstero.Lomitas),
                datosEntidadBuilder.Build(3833, LocalidadSantiagoDelEstero.LosSauces),
                datosEntidadBuilder.Build(3834, LocalidadSantiagoDelEstero.LosTolozas),
                datosEntidadBuilder.Build(3835, LocalidadSantiagoDelEstero.Medellin),
                datosEntidadBuilder.Build(3836, LocalidadSantiagoDelEstero.Mochimo),
                datosEntidadBuilder.Build(3837, LocalidadSantiagoDelEstero.Mollares),
                datosEntidadBuilder.Build(3838, LocalidadSantiagoDelEstero.PuertaGrande),
                datosEntidadBuilder.Build(3839, LocalidadSantiagoDelEstero.PuestoDeDiaz),
                datosEntidadBuilder.Build(3840, LocalidadSantiagoDelEstero.PuestoDelRosario),
                datosEntidadBuilder.Build(3841, LocalidadSantiagoDelEstero.SanDionisio),
                datosEntidadBuilder.Build(3842, LocalidadSantiagoDelEstero.SantaIsabel),
                datosEntidadBuilder.Build(3843, LocalidadSantiagoDelEstero.SimbolPozo),
                datosEntidadBuilder.Build(3844, LocalidadSantiagoDelEstero.Soconcho),
                datosEntidadBuilder.Build(3845, LocalidadSantiagoDelEstero.Tasigasta),
                datosEntidadBuilder.Build(3846, LocalidadSantiagoDelEstero.VenturaPampa),
                datosEntidadBuilder.Build(3847, LocalidadSantiagoDelEstero.YacuChiri)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Avellaneda).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3848, LocalidadSantiagoDelEstero.ColoniaDora),
                datosEntidadBuilder.Build(3849, LocalidadSantiagoDelEstero.Herrera),
                datosEntidadBuilder.Build(3850, LocalidadSantiagoDelEstero.Icano),
                datosEntidadBuilder.Build(3851, LocalidadSantiagoDelEstero.Lugones),
                datosEntidadBuilder.Build(3852, LocalidadSantiagoDelEstero.PuntaPozo),
                datosEntidadBuilder.Build(3853, LocalidadSantiagoDelEstero.RealSayana),
                datosEntidadBuilder.Build(3854, LocalidadSantiagoDelEstero.VillaMailin),
                datosEntidadBuilder.Build(3855, LocalidadSantiagoDelEstero.Caloj),
                datosEntidadBuilder.Build(3856, LocalidadSantiagoDelEstero.Percas),
                datosEntidadBuilder.Build(3857, LocalidadSantiagoDelEstero.PuntaCorral),
                datosEntidadBuilder.Build(3858, LocalidadSantiagoDelEstero.Cejas),
                datosEntidadBuilder.Build(3859, LocalidadSantiagoDelEstero.Gramilla),
                datosEntidadBuilder.Build(3860, LocalidadSantiagoDelEstero.Banda),
                datosEntidadBuilder.Build(3861, LocalidadSantiagoDelEstero.Mancapa),
                datosEntidadBuilder.Build(3862, LocalidadSantiagoDelEstero.Puyana),
                datosEntidadBuilder.Build(3863, LocalidadSantiagoDelEstero.TacoAtun),
                datosEntidadBuilder.Build(3864, LocalidadSantiagoDelEstero.SanJose),
                datosEntidadBuilder.Build(3865, LocalidadSantiagoDelEstero.BlancaPozo),
                datosEntidadBuilder.Build(3866, LocalidadSantiagoDelEstero.Caloj),
                datosEntidadBuilder.Build(3867, LocalidadSantiagoDelEstero.CampoAlegre),
                datosEntidadBuilder.Build(3868, LocalidadSantiagoDelEstero.ColoniaAlcira),
                datosEntidadBuilder.Build(3869, LocalidadSantiagoDelEstero.ColoniaIsla),
                datosEntidadBuilder.Build(3870, LocalidadSantiagoDelEstero.ColoniaLibanesa),
                datosEntidadBuilder.Build(3871, LocalidadSantiagoDelEstero.ElBracho),
                datosEntidadBuilder.Build(3872, LocalidadSantiagoDelEstero.PuenteNegro),
                datosEntidadBuilder.Build(3873, LocalidadSantiagoDelEstero.SanAntonioDeCopo),
                datosEntidadBuilder.Build(3874, LocalidadSantiagoDelEstero.SanPedro),
                datosEntidadBuilder.Build(3875, LocalidadSantiagoDelEstero.SanRoque),
                datosEntidadBuilder.Build(3876, LocalidadSantiagoDelEstero.SantoDomingo),
                datosEntidadBuilder.Build(3877, LocalidadSantiagoDelEstero.TalaPozo),
                datosEntidadBuilder.Build(3878, LocalidadSantiagoDelEstero.Vacasnioj),
                datosEntidadBuilder.Build(3879, LocalidadSantiagoDelEstero.Yacasnioj)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Banda).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3880, LocalidadSantiagoDelEstero.LaBanda),
                datosEntidadBuilder.Build(3881, LocalidadSantiagoDelEstero.Clodomira),
                datosEntidadBuilder.Build(3882, LocalidadSantiagoDelEstero.AbraGrande),
                datosEntidadBuilder.Build(3883, LocalidadSantiagoDelEstero.Antaje),
                datosEntidadBuilder.Build(3884, LocalidadSantiagoDelEstero.Ardiles),
                datosEntidadBuilder.Build(3885, LocalidadSantiagoDelEstero.CanadaEscobar),
                datosEntidadBuilder.Build(3886, LocalidadSantiagoDelEstero.ChaupiPozo),
                datosEntidadBuilder.Build(3887, LocalidadSantiagoDelEstero.ElAibe),
                datosEntidadBuilder.Build(3888, LocalidadSantiagoDelEstero.EstacionSimbolar),
                datosEntidadBuilder.Build(3889, LocalidadSantiagoDelEstero.LosQuiroga),
                datosEntidadBuilder.Build(3890, LocalidadSantiagoDelEstero.LaAurora),
                datosEntidadBuilder.Build(3891, LocalidadSantiagoDelEstero.LaDarsena),
                datosEntidadBuilder.Build(3892, LocalidadSantiagoDelEstero.NegraMuerta),
                datosEntidadBuilder.Build(3893, LocalidadSantiagoDelEstero.Tramo16)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Belgrano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3894, LocalidadSantiagoDelEstero.Bandera),
                datosEntidadBuilder.Build(3895, LocalidadSantiagoDelEstero.CuatroBocas),
                datosEntidadBuilder.Build(3896, LocalidadSantiagoDelEstero.FortinInca),
                datosEntidadBuilder.Build(3897, LocalidadSantiagoDelEstero.GuardiaEscolta)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3898, LocalidadSantiagoDelEstero.SantiagoDelEstero),
                datosEntidadBuilder.Build(3899, LocalidadSantiagoDelEstero.ElDean),
                datosEntidadBuilder.Build(3900, LocalidadSantiagoDelEstero.Remes),
                datosEntidadBuilder.Build(3901, LocalidadSantiagoDelEstero.SanBenito),
                datosEntidadBuilder.Build(3902, LocalidadSantiagoDelEstero.SanPedro),
                datosEntidadBuilder.Build(3903, LocalidadSantiagoDelEstero.SantaMaria),
                datosEntidadBuilder.Build(3904, LocalidadSantiagoDelEstero.SolDeMayo),
                datosEntidadBuilder.Build(3905, LocalidadSantiagoDelEstero.VillaZanjon),
                datosEntidadBuilder.Build(3906, LocalidadSantiagoDelEstero.VueltaDeLaBarranca),
                datosEntidadBuilder.Build(3907, LocalidadSantiagoDelEstero.Maco),
                datosEntidadBuilder.Build(3908, LocalidadSantiagoDelEstero.MalPaso),
                datosEntidadBuilder.Build(3909, LocalidadSantiagoDelEstero.Tipiro),
                datosEntidadBuilder.Build(3910, LocalidadSantiagoDelEstero.Antilo),
                datosEntidadBuilder.Build(3911, LocalidadSantiagoDelEstero.Sauzal),
                datosEntidadBuilder.Build(3912, LocalidadSantiagoDelEstero.TunasPuncu),
                datosEntidadBuilder.Build(3913, LocalidadSantiagoDelEstero.SantaRosa),
                datosEntidadBuilder.Build(3914, LocalidadSantiagoDelEstero.Cardosos),
                datosEntidadBuilder.Build(3915, LocalidadSantiagoDelEstero.Yanda),
                datosEntidadBuilder.Build(3916, LocalidadSantiagoDelEstero.TroncoYuraj),
                datosEntidadBuilder.Build(3917, LocalidadSantiagoDelEstero.Rosario),
                datosEntidadBuilder.Build(3918, LocalidadSantiagoDelEstero.BlancoCorral)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Choya).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3919, LocalidadSantiagoDelEstero.Choya),
                datosEntidadBuilder.Build(3920, LocalidadSantiagoDelEstero.Frias),
                datosEntidadBuilder.Build(3921, LocalidadSantiagoDelEstero.Laprida),
                datosEntidadBuilder.Build(3922, LocalidadSantiagoDelEstero.Tapso),
                datosEntidadBuilder.Build(3923, LocalidadSantiagoDelEstero.VillaLaPunta),
                datosEntidadBuilder.Build(3924, LocalidadSantiagoDelEstero.Ancajan),
                datosEntidadBuilder.Build(3925, LocalidadSantiagoDelEstero.ChanarPozo),
                datosEntidadBuilder.Build(3926, LocalidadSantiagoDelEstero.ElMojoncito),
                datosEntidadBuilder.Build(3927, LocalidadSantiagoDelEstero.ElRodeo),
                datosEntidadBuilder.Build(3928, LocalidadSantiagoDelEstero.ElTasial),
                datosEntidadBuilder.Build(3929, LocalidadSantiagoDelEstero.Kilometro55),
                datosEntidadBuilder.Build(3930, LocalidadSantiagoDelEstero.LosRalos),
                datosEntidadBuilder.Build(3931, LocalidadSantiagoDelEstero.Maquijata),
                datosEntidadBuilder.Build(3932, LocalidadSantiagoDelEstero.MonteRedondo),
                datosEntidadBuilder.Build(3933, LocalidadSantiagoDelEstero.PocitoDeLaLoma),
                datosEntidadBuilder.Build(3934, LocalidadSantiagoDelEstero.PozoDeLaPuerta),
                datosEntidadBuilder.Build(3935, LocalidadSantiagoDelEstero.PozoDelSimbol),
                datosEntidadBuilder.Build(3936, LocalidadSantiagoDelEstero.PuertaDeChavez),
                datosEntidadBuilder.Build(3937, LocalidadSantiagoDelEstero.SanJuan),
                datosEntidadBuilder.Build(3938, LocalidadSantiagoDelEstero.SanJusto),
                datosEntidadBuilder.Build(3939, LocalidadSantiagoDelEstero.SanRafael),
                datosEntidadBuilder.Build(3940, LocalidadSantiagoDelEstero.SantaCruz),
                datosEntidadBuilder.Build(3941, LocalidadSantiagoDelEstero.SinchiCana),
                datosEntidadBuilder.Build(3942, LocalidadSantiagoDelEstero.VeinticincoDeMayoDeBanegas),
                datosEntidadBuilder.Build(3943, LocalidadSantiagoDelEstero.VeinticincoDeMayoSud),
                datosEntidadBuilder.Build(3944, LocalidadSantiagoDelEstero.VillaElvira),
                datosEntidadBuilder.Build(3945, LocalidadSantiagoDelEstero.VillaMercedes),
                datosEntidadBuilder.Build(3946, LocalidadSantiagoDelEstero.SolDeMayo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Copo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3947, LocalidadSantiagoDelEstero.MonteQuemado),
                datosEntidadBuilder.Build(3948, LocalidadSantiagoDelEstero.PampaDeLosGuanacos),
                datosEntidadBuilder.Build(3949, LocalidadSantiagoDelEstero.AhiVeremos),
                datosEntidadBuilder.Build(3950, LocalidadSantiagoDelEstero.ElCabure),
                datosEntidadBuilder.Build(3951, LocalidadSantiagoDelEstero.LosPirpintos),
                datosEntidadBuilder.Build(3952, LocalidadSantiagoDelEstero.SanJoseDelBoqueron),
                datosEntidadBuilder.Build(3953, LocalidadSantiagoDelEstero.VillaMatoque)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Figueroa).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3954, LocalidadSantiagoDelEstero.BanderaBajada),
                datosEntidadBuilder.Build(3955, LocalidadSantiagoDelEstero.CaspiCorral),
                datosEntidadBuilder.Build(3956, LocalidadSantiagoDelEstero.ColoniaSanJuan),
                datosEntidadBuilder.Build(3957, LocalidadSantiagoDelEstero.LaCanada),
                datosEntidadBuilder.Build(3958, LocalidadSantiagoDelEstero.LaInvernada),
                datosEntidadBuilder.Build(3959, LocalidadSantiagoDelEstero.VacaHuanuna),
                datosEntidadBuilder.Build(3960, LocalidadSantiagoDelEstero.VillaFigueroa)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.GeneralTaboada).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3961, LocalidadSantiagoDelEstero.Anatuya),
                datosEntidadBuilder.Build(3962, LocalidadSantiagoDelEstero.LosJuries),
                datosEntidadBuilder.Build(3963, LocalidadSantiagoDelEstero.Averias),
                datosEntidadBuilder.Build(3964, LocalidadSantiagoDelEstero.EstacionTacanitas),
                datosEntidadBuilder.Build(3965, LocalidadSantiagoDelEstero.LaSimona),
                datosEntidadBuilder.Build(3966, LocalidadSantiagoDelEstero.LaNena),
                datosEntidadBuilder.Build(3967, LocalidadSantiagoDelEstero.TomasYoung)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Guasayan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3968, LocalidadSantiagoDelEstero.SanPedroDeGuasayan),
                datosEntidadBuilder.Build(3969, LocalidadSantiagoDelEstero.DonaLuisa),
                datosEntidadBuilder.Build(3970, LocalidadSantiagoDelEstero.Guampacha),
                datosEntidadBuilder.Build(3971, LocalidadSantiagoDelEstero.Lavalle),
                datosEntidadBuilder.Build(3972, LocalidadSantiagoDelEstero.SantaCatalina),
                datosEntidadBuilder.Build(3973, LocalidadSantiagoDelEstero.VillaGuasayan)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Jimenez).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3974, LocalidadSantiagoDelEstero.PozoHondo),
                datosEntidadBuilder.Build(3975, LocalidadSantiagoDelEstero.ElArenal),
                datosEntidadBuilder.Build(3976, LocalidadSantiagoDelEstero.ElBobadal),
                datosEntidadBuilder.Build(3977, LocalidadSantiagoDelEstero.ElCharco),
                datosEntidadBuilder.Build(3978, LocalidadSantiagoDelEstero.Gramilla),
                datosEntidadBuilder.Build(3979, LocalidadSantiagoDelEstero.TresCruces)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.JuanFelipeIbarra).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3980, LocalidadSantiagoDelEstero.SunchoCorral),
                datosEntidadBuilder.Build(3981, LocalidadSantiagoDelEstero.ElColorado),
                datosEntidadBuilder.Build(3982, LocalidadSantiagoDelEstero.ElCuadrado),
                datosEntidadBuilder.Build(3983, LocalidadSantiagoDelEstero.Matara),
                datosEntidadBuilder.Build(3984, LocalidadSantiagoDelEstero.Melero),
                datosEntidadBuilder.Build(3985, LocalidadSantiagoDelEstero.PozoDelToba),
                datosEntidadBuilder.Build(3986, LocalidadSantiagoDelEstero.SanAntonioRoldan),
                datosEntidadBuilder.Build(3987, LocalidadSantiagoDelEstero.Vilelas),
                datosEntidadBuilder.Build(3988, LocalidadSantiagoDelEstero.Yuchan)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Loreto).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(3989, LocalidadSantiagoDelEstero.Ayuncha),
                datosEntidadBuilder.Build(3990, LocalidadSantiagoDelEstero.Beltran),
                datosEntidadBuilder.Build(3991, LocalidadSantiagoDelEstero.ChunaAlbardon),
                datosEntidadBuilder.Build(3992, LocalidadSantiagoDelEstero.DienteDelArado),
                datosEntidadBuilder.Build(3993, LocalidadSantiagoDelEstero.JumiPozo),
                datosEntidadBuilder.Build(3994, LocalidadSantiagoDelEstero.LaDormida),
                datosEntidadBuilder.Build(3995, LocalidadSantiagoDelEstero.LaNoria),
                datosEntidadBuilder.Build(3996, LocalidadSantiagoDelEstero.LaRevancha),
                datosEntidadBuilder.Build(3997, LocalidadSantiagoDelEstero.MonteRedondo),
                datosEntidadBuilder.Build(3998, LocalidadSantiagoDelEstero.PuestoDeJuanes),
                datosEntidadBuilder.Build(3999, LocalidadSantiagoDelEstero.PuestoDeSuarez),
                datosEntidadBuilder.Build(4000, LocalidadSantiagoDelEstero.Punua),
                datosEntidadBuilder.Build(4001, LocalidadSantiagoDelEstero.SanGeronimo),
                datosEntidadBuilder.Build(4002, LocalidadSantiagoDelEstero.SanVicente),
                datosEntidadBuilder.Build(4003, LocalidadSantiagoDelEstero.SantaBarbara),
                datosEntidadBuilder.Build(4004, LocalidadSantiagoDelEstero.SauceSolo),
                datosEntidadBuilder.Build(4005, LocalidadSantiagoDelEstero.Taquetuyoj),
                datosEntidadBuilder.Build(4006, LocalidadSantiagoDelEstero.TioPozo),
                datosEntidadBuilder.Build(4007, LocalidadSantiagoDelEstero.VillaVieja)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Mitre).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4008, LocalidadSantiagoDelEstero.FuerteEsperanza),
                datosEntidadBuilder.Build(4009, LocalidadSantiagoDelEstero.Abras),
                datosEntidadBuilder.Build(4010, LocalidadSantiagoDelEstero.VillaUnion),
                datosEntidadBuilder.Build(4011, LocalidadSantiagoDelEstero.Captaros),
                datosEntidadBuilder.Build(4012, LocalidadSantiagoDelEstero.Porongos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Moreno).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4013, LocalidadSantiagoDelEstero.Alhuampa),
                datosEntidadBuilder.Build(4014, LocalidadSantiagoDelEstero.Tintina),
                datosEntidadBuilder.Build(4015, LocalidadSantiagoDelEstero.Aerolito),
                datosEntidadBuilder.Build(4016, LocalidadSantiagoDelEstero.Otumpa),
                datosEntidadBuilder.Build(4017, LocalidadSantiagoDelEstero.Cejolao),
                datosEntidadBuilder.Build(4018, LocalidadSantiagoDelEstero.Quimili),
                datosEntidadBuilder.Build(4019, LocalidadSantiagoDelEstero.Puna),
                datosEntidadBuilder.Build(4020, LocalidadSantiagoDelEstero.SanCristobal),
                datosEntidadBuilder.Build(4021, LocalidadSantiagoDelEstero.LaFortuna),
                datosEntidadBuilder.Build(4022, LocalidadSantiagoDelEstero.Simbolar),
                datosEntidadBuilder.Build(4023, LocalidadSantiagoDelEstero.ElPertigo),
                datosEntidadBuilder.Build(4024, LocalidadSantiagoDelEstero.MistolPampa),
                datosEntidadBuilder.Build(4025, LocalidadSantiagoDelEstero.SanAntonio),
                datosEntidadBuilder.Build(4026, LocalidadSantiagoDelEstero.Milagros),
                datosEntidadBuilder.Build(4027, LocalidadSantiagoDelEstero.Amama),
                datosEntidadBuilder.Build(4028, LocalidadSantiagoDelEstero.Weisburd),
                datosEntidadBuilder.Build(4029, LocalidadSantiagoDelEstero.LasTinajas),
                datosEntidadBuilder.Build(4030, LocalidadSantiagoDelEstero.LiloViejo),
                datosEntidadBuilder.Build(4031, LocalidadSantiagoDelEstero.Hasse),
                datosEntidadBuilder.Build(4032, LocalidadSantiagoDelEstero.Patay),
                datosEntidadBuilder.Build(4033, LocalidadSantiagoDelEstero.Roversi),
                datosEntidadBuilder.Build(4034, LocalidadSantiagoDelEstero.HernanMejiaMiraval),
                datosEntidadBuilder.Build(4035, LocalidadSantiagoDelEstero.Libertad)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.OjoDeAgua).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4036, LocalidadSantiagoDelEstero.VillaOjoDeAgua),
                datosEntidadBuilder.Build(4037, LocalidadSantiagoDelEstero.SolDeJulio),
                datosEntidadBuilder.Build(4038, LocalidadSantiagoDelEstero.El49)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Pellegrini).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4039, LocalidadSantiagoDelEstero.NuevaEsperanza),
                datosEntidadBuilder.Build(4040, LocalidadSantiagoDelEstero.AhiVeremos),
                datosEntidadBuilder.Build(4041, LocalidadSantiagoDelEstero.CampoGrande),
                datosEntidadBuilder.Build(4042, LocalidadSantiagoDelEstero.ElMojon),
                datosEntidadBuilder.Build(4043, LocalidadSantiagoDelEstero.LasDelicias),
                datosEntidadBuilder.Build(4044, LocalidadSantiagoDelEstero.PozoBetbeder),
                datosEntidadBuilder.Build(4045, LocalidadSantiagoDelEstero.QuebrachoCoto),
                datosEntidadBuilder.Build(4046, LocalidadSantiagoDelEstero.Rapelli),
                datosEntidadBuilder.Build(4047, LocalidadSantiagoDelEstero.SantoDomingo),
                datosEntidadBuilder.Build(4048, LocalidadSantiagoDelEstero.VillaMercedes),
                datosEntidadBuilder.Build(4049, LocalidadSantiagoDelEstero.VillaNueva),
                datosEntidadBuilder.Build(4050, LocalidadSantiagoDelEstero.ElSaladillo),
                datosEntidadBuilder.Build(4051, LocalidadSantiagoDelEstero.ElRemate),
                datosEntidadBuilder.Build(4052, LocalidadSantiagoDelEstero.LaFragua),
                datosEntidadBuilder.Build(4053, LocalidadSantiagoDelEstero.SanRamon)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Quebrachos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4054, LocalidadSantiagoDelEstero.RamirezDeVelazco),
                datosEntidadBuilder.Build(4055, LocalidadSantiagoDelEstero.Sumampa),
                datosEntidadBuilder.Build(4056, LocalidadSantiagoDelEstero.Belgrano),
                datosEntidadBuilder.Build(4057, LocalidadSantiagoDelEstero.SumampaViejo),
                datosEntidadBuilder.Build(4058, LocalidadSantiagoDelEstero.VillaQuebrachos),
                datosEntidadBuilder.Build(4059, LocalidadSantiagoDelEstero.SanFrancisco),
                datosEntidadBuilder.Build(4060, LocalidadSantiagoDelEstero.TacoPozo),
                datosEntidadBuilder.Build(4061, LocalidadSantiagoDelEstero.CampoDelCisne),
                datosEntidadBuilder.Build(4062, LocalidadSantiagoDelEstero.HorcoTucucuna)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.RioHondo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4063, LocalidadSantiagoDelEstero.Chauchillas),
                datosEntidadBuilder.Build(4064, LocalidadSantiagoDelEstero.ColoniaTinco),
                datosEntidadBuilder.Build(4065, LocalidadSantiagoDelEstero.LosNunez),
                datosEntidadBuilder.Build(4066, LocalidadSantiagoDelEstero.Pozuelos),
                datosEntidadBuilder.Build(4067, LocalidadSantiagoDelEstero.TermasDeRioHondo),
                datosEntidadBuilder.Build(4068, LocalidadSantiagoDelEstero.VillaRioHondo),
                datosEntidadBuilder.Build(4069, LocalidadSantiagoDelEstero.Vinara)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Rivadavia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4070, LocalidadSantiagoDelEstero.Selva),
                datosEntidadBuilder.Build(4071, LocalidadSantiagoDelEstero.ColoniaAlpina),
                datosEntidadBuilder.Build(4072, LocalidadSantiagoDelEstero.PaloNegro),
                datosEntidadBuilder.Build(4073, LocalidadSantiagoDelEstero.Argentina),
                datosEntidadBuilder.Build(4074, LocalidadSantiagoDelEstero.Malbran)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Robles).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4075, LocalidadSantiagoDelEstero.Beltran),
                datosEntidadBuilder.Build(4076, LocalidadSantiagoDelEstero.ColoniaElSimbolar),
                datosEntidadBuilder.Build(4077, LocalidadSantiagoDelEstero.Fernandez),
                datosEntidadBuilder.Build(4078, LocalidadSantiagoDelEstero.IngenieroForres),
                datosEntidadBuilder.Build(4079, LocalidadSantiagoDelEstero.VillaRobles),
                datosEntidadBuilder.Build(4080, LocalidadSantiagoDelEstero.Vilmer),
                datosEntidadBuilder.Build(4081, LocalidadSantiagoDelEstero.LosBanegas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Salavina).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4082, LocalidadSantiagoDelEstero.CarretaPaso),
                datosEntidadBuilder.Build(4083, LocalidadSantiagoDelEstero.ChilcaJuliana),
                datosEntidadBuilder.Build(4084, LocalidadSantiagoDelEstero.Chinuna),
                datosEntidadBuilder.Build(4085, LocalidadSantiagoDelEstero.LosTelares),
                datosEntidadBuilder.Build(4086, LocalidadSantiagoDelEstero.Sabagasta),
                datosEntidadBuilder.Build(4087, LocalidadSantiagoDelEstero.VillaSalavina),
                datosEntidadBuilder.Build(4088, LocalidadSantiagoDelEstero.Anga),
                datosEntidadBuilder.Build(4089, LocalidadSantiagoDelEstero.Barrancas),
                datosEntidadBuilder.Build(4090, LocalidadSantiagoDelEstero.LosCerrillos),
                datosEntidadBuilder.Build(4091, LocalidadSantiagoDelEstero.Malota),
                datosEntidadBuilder.Build(4092, LocalidadSantiagoDelEstero.MistolPozo),
                datosEntidadBuilder.Build(4093, LocalidadSantiagoDelEstero.PasoDeOscares),
                datosEntidadBuilder.Build(4094, LocalidadSantiagoDelEstero.PuenteDelSaladillo),
                datosEntidadBuilder.Build(4095, LocalidadSantiagoDelEstero.RubiaPaso),
                datosEntidadBuilder.Build(4096, LocalidadSantiagoDelEstero.SantaLucia),
                datosEntidadBuilder.Build(4097, LocalidadSantiagoDelEstero.Sitkioj),
                datosEntidadBuilder.Build(4098, LocalidadSantiagoDelEstero.Veron),
                datosEntidadBuilder.Build(4099, LocalidadSantiagoDelEstero.YacuHurmana),
                datosEntidadBuilder.Build(4100, LocalidadSantiagoDelEstero.Asingasta)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.SanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4101, LocalidadSantiagoDelEstero.BreaPozo),
                datosEntidadBuilder.Build(4102, LocalidadSantiagoDelEstero.EstacionRobles),
                datosEntidadBuilder.Build(4103, LocalidadSantiagoDelEstero.EstacionTaboada),
                datosEntidadBuilder.Build(4104, LocalidadSantiagoDelEstero.AtojPozo),
                datosEntidadBuilder.Build(4105, LocalidadSantiagoDelEstero.AshpaSinchi),
                datosEntidadBuilder.Build(4106, LocalidadSantiagoDelEstero.BarrancasColoradas),
                datosEntidadBuilder.Build(4107, LocalidadSantiagoDelEstero.BreaPozoViejo),
                datosEntidadBuilder.Build(4108, LocalidadSantiagoDelEstero.Cheej),
                datosEntidadBuilder.Build(4109, LocalidadSantiagoDelEstero.ColoniaPinto),
                datosEntidadBuilder.Build(4110, LocalidadSantiagoDelEstero.Diaspa),
                datosEntidadBuilder.Build(4111, LocalidadSantiagoDelEstero.Kilometro25),
                datosEntidadBuilder.Build(4112, LocalidadSantiagoDelEstero.LaBlanca),
                datosEntidadBuilder.Build(4113, LocalidadSantiagoDelEstero.LaHiguera),
                datosEntidadBuilder.Build(4114, LocalidadSantiagoDelEstero.LaVerde),
                datosEntidadBuilder.Build(4115, LocalidadSantiagoDelEstero.LagunaBlanca),
                datosEntidadBuilder.Build(4116, LocalidadSantiagoDelEstero.Linton),
                datosEntidadBuilder.Build(4117, LocalidadSantiagoDelEstero.LosGallegos),
                datosEntidadBuilder.Build(4118, LocalidadSantiagoDelEstero.MajadasSud),
                datosEntidadBuilder.Build(4119, LocalidadSantiagoDelEstero.PampaAtun),
                datosEntidadBuilder.Build(4120, LocalidadSantiagoDelEstero.Percas),
                datosEntidadBuilder.Build(4121, LocalidadSantiagoDelEstero.PerchilBajo),
                datosEntidadBuilder.Build(4122, LocalidadSantiagoDelEstero.PozoMosoj),
                datosEntidadBuilder.Build(4123, LocalidadSantiagoDelEstero.Puestito),
                datosEntidadBuilder.Build(4124, LocalidadSantiagoDelEstero.Quimilioj),
                datosEntidadBuilder.Build(4125, LocalidadSantiagoDelEstero.SanJoseDeFlores),
                datosEntidadBuilder.Build(4126, LocalidadSantiagoDelEstero.SanPascual),
                datosEntidadBuilder.Build(4127, LocalidadSantiagoDelEstero.SunchoPozo),
                datosEntidadBuilder.Build(4128, LocalidadSantiagoDelEstero.TioPozo),
                datosEntidadBuilder.Build(4129, LocalidadSantiagoDelEstero.TresJazmines),
                datosEntidadBuilder.Build(4130, LocalidadSantiagoDelEstero.Tuamilla),
                datosEntidadBuilder.Build(4131, LocalidadSantiagoDelEstero.VillaNueva)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Sarmiento).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4132, LocalidadSantiagoDelEstero.Matara),
                datosEntidadBuilder.Build(4133, LocalidadSantiagoDelEstero.Garza),
                datosEntidadBuilder.Build(4134, LocalidadSantiagoDelEstero.SauceBajada),
                datosEntidadBuilder.Build(4135, LocalidadSantiagoDelEstero.Guaype)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoSantiagoDelEstero.Silipica).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(4136, LocalidadSantiagoDelEstero.Arraga),
                datosEntidadBuilder.Build(4137, LocalidadSantiagoDelEstero.Manogasta),
                datosEntidadBuilder.Build(4138, LocalidadSantiagoDelEstero.NuevaFrancia),
                datosEntidadBuilder.Build(4139, LocalidadSantiagoDelEstero.VillaSilipica),
                datosEntidadBuilder.Build(4140, LocalidadSantiagoDelEstero.BueyRodeo),
                datosEntidadBuilder.Build(4141, LocalidadSantiagoDelEstero.CampoAlegre),
                datosEntidadBuilder.Build(4142, LocalidadSantiagoDelEstero.ChanarPujio),
                datosEntidadBuilder.Build(4143, LocalidadSantiagoDelEstero.CoroPampa),
                datosEntidadBuilder.Build(4144, LocalidadSantiagoDelEstero.Huachana),
                datosEntidadBuilder.Build(4145, LocalidadSantiagoDelEstero.LaAbrita),
                datosEntidadBuilder.Build(4146, LocalidadSantiagoDelEstero.LaHiguera),
                datosEntidadBuilder.Build(4147, LocalidadSantiagoDelEstero.LaRamadita),
                datosEntidadBuilder.Build(4148, LocalidadSantiagoDelEstero.PuestoDelMedio),
                datosEntidadBuilder.Build(4149, LocalidadSantiagoDelEstero.SanAndres),
                datosEntidadBuilder.Build(4150, LocalidadSantiagoDelEstero.SanVicente),
                datosEntidadBuilder.Build(4151, LocalidadSantiagoDelEstero.Simbol),
                datosEntidadBuilder.Build(4152, LocalidadSantiagoDelEstero.Sumamao)
            });
        }
    }
}
