using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    public class LocalidadNeuquenFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadNeuquenFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Alumine).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2830, LocalidadNeuquen.Alumine),
                datosEntidadBuilder.Build(2831, LocalidadNeuquen.VillaPehuenia)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Anelo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2832, LocalidadNeuquen.Anelo),
                datosEntidadBuilder.Build(2833, LocalidadNeuquen.SanPatricioDelChanar)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.CatanLil).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2834, LocalidadNeuquen.LasColoradas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.ChosMalal).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2835, LocalidadNeuquen.ChosMalal),
                datosEntidadBuilder.Build(2836, LocalidadNeuquen.TricaoMalal),
                datosEntidadBuilder.Build(2837, LocalidadNeuquen.CoyucoCochico),
                datosEntidadBuilder.Build(2838, LocalidadNeuquen.VillaCuriLeuvu)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.CollonCura).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2839, LocalidadNeuquen.PiedraDelAguila),
                datosEntidadBuilder.Build(2840, LocalidadNeuquen.SantoTomas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Confluencia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2841, LocalidadNeuquen.Centenario),
                datosEntidadBuilder.Build(2842, LocalidadNeuquen.CutralCo),
                datosEntidadBuilder.Build(2843, LocalidadNeuquen.VillaElChocon),
                datosEntidadBuilder.Build(2844, LocalidadNeuquen.Neuquen),
                datosEntidadBuilder.Build(2845, LocalidadNeuquen.PlazaHuincul),
                datosEntidadBuilder.Build(2846, LocalidadNeuquen.Plottier),
                datosEntidadBuilder.Build(2847, LocalidadNeuquen.SauzalBonito),
                datosEntidadBuilder.Build(2848, LocalidadNeuquen.Senillosa),
                datosEntidadBuilder.Build(2849, LocalidadNeuquen.VistaAlegre)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Huiliches).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2850, LocalidadNeuquen.JuninDeLosAndes),
                datosEntidadBuilder.Build(2851, LocalidadNeuquen.AucaPan),
                datosEntidadBuilder.Build(2852, LocalidadNeuquen.Atreuco),
                datosEntidadBuilder.Build(2853, LocalidadNeuquen.Chiquilihuin),
                datosEntidadBuilder.Build(2854, LocalidadNeuquen.Malleo),
                datosEntidadBuilder.Build(2855, LocalidadNeuquen.Tropezon),
                datosEntidadBuilder.Build(2856, LocalidadNeuquen.PuertoTromen),
                datosEntidadBuilder.Build(2857, LocalidadNeuquen.TresPuentes),
                datosEntidadBuilder.Build(2858, LocalidadNeuquen.CampoGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Lacar).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2859, LocalidadNeuquen.SanMartinDeLosAndes),
                datosEntidadBuilder.Build(2860, LocalidadNeuquen.Chimehuin),
                datosEntidadBuilder.Build(2861, LocalidadNeuquen.PasoDeLosIndios),
                datosEntidadBuilder.Build(2862, LocalidadNeuquen.PuertoHuaHum),
                datosEntidadBuilder.Build(2863, LocalidadNeuquen.QuilaQuina),
                datosEntidadBuilder.Build(2864, LocalidadNeuquen.VegaMaipu),
                datosEntidadBuilder.Build(2865, LocalidadNeuquen.Lolog),
                datosEntidadBuilder.Build(2866, LocalidadNeuquen.LagoHermoso),
                datosEntidadBuilder.Build(2867, LocalidadNeuquen.Caleufu)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Loncopue).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2868, LocalidadNeuquen.Loncopue),
                datosEntidadBuilder.Build(2869, LocalidadNeuquen.CajonDeAlmanza),
                datosEntidadBuilder.Build(2870, LocalidadNeuquen.Chorriaca),
                datosEntidadBuilder.Build(2871, LocalidadNeuquen.Huitrin),
                datosEntidadBuilder.Build(2872, LocalidadNeuquen.Hunca),
                datosEntidadBuilder.Build(2873, LocalidadNeuquen.Pichaihue),
                datosEntidadBuilder.Build(2874, LocalidadNeuquen.Muchilinco),
                datosEntidadBuilder.Build(2875, LocalidadNeuquen.Quintuco),
                datosEntidadBuilder.Build(2876, LocalidadNeuquen.Huarenchenque)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.LosLagos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2877, LocalidadNeuquen.VillaLaAngostura),
                datosEntidadBuilder.Build(2878, LocalidadNeuquen.VillaTraful),
                datosEntidadBuilder.Build(2879, LocalidadNeuquen.Confluencia),
                datosEntidadBuilder.Build(2880, LocalidadNeuquen.CuyinManzano),
                datosEntidadBuilder.Build(2881, LocalidadNeuquen.ElPortezuelo),
                datosEntidadBuilder.Build(2882, LocalidadNeuquen.NahuelHuapi),
                datosEntidadBuilder.Build(2883, LocalidadNeuquen.Huemul),
                datosEntidadBuilder.Build(2884, LocalidadNeuquen.PasoCoihue),
                datosEntidadBuilder.Build(2885, LocalidadNeuquen.PichiTraful),
                datosEntidadBuilder.Build(2886, LocalidadNeuquen.PuertoHuemul),
                datosEntidadBuilder.Build(2887, LocalidadNeuquen.PuertoAnchorena),
                datosEntidadBuilder.Build(2888, LocalidadNeuquen.RucaMalen),
                datosEntidadBuilder.Build(2889, LocalidadNeuquen.VillaLlanquin)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Minas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2890, LocalidadNeuquen.Andacollo),
                datosEntidadBuilder.Build(2891, LocalidadNeuquen.Huinganco),
                datosEntidadBuilder.Build(2892, LocalidadNeuquen.LasOvejas),
                datosEntidadBuilder.Build(2893, LocalidadNeuquen.LosMiches),
                datosEntidadBuilder.Build(2894, LocalidadNeuquen.Guanacos),
                datosEntidadBuilder.Build(2895, LocalidadNeuquen.ManzanoAmargo),
                datosEntidadBuilder.Build(2896, LocalidadNeuquen.Varvarco),
                datosEntidadBuilder.Build(2897, LocalidadNeuquen.VillaDelNahueve),
                datosEntidadBuilder.Build(2898, LocalidadNeuquen.BellaVista)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Norquin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2899, LocalidadNeuquen.CaviahueCopahue),
                datosEntidadBuilder.Build(2900, LocalidadNeuquen.ElCholar),
                datosEntidadBuilder.Build(2901, LocalidadNeuquen.ElHuecu),
                datosEntidadBuilder.Build(2902, LocalidadNeuquen.Taquimilan)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Pehuenches).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2903, LocalidadNeuquen.Barrancas),
                datosEntidadBuilder.Build(2904, LocalidadNeuquen.ButaRanquil),
                datosEntidadBuilder.Build(2905, LocalidadNeuquen.RinconDeLosSauces),
                datosEntidadBuilder.Build(2906, LocalidadNeuquen.OctavioPico)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.PicunLeufu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2907, LocalidadNeuquen.PicunLeufu),
                datosEntidadBuilder.Build(2908, LocalidadNeuquen.PasoAguerre),
                datosEntidadBuilder.Build(2909, LocalidadNeuquen.ElSauce)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Picunches).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2910, LocalidadNeuquen.CovuncoAbajo),
                datosEntidadBuilder.Build(2911, LocalidadNeuquen.LasLajas),
                datosEntidadBuilder.Build(2912, LocalidadNeuquen.BajadaDelAgrio),
                datosEntidadBuilder.Build(2913, LocalidadNeuquen.QuiliMalal)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Zapala).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2914, LocalidadNeuquen.MarianoMoreno),
                datosEntidadBuilder.Build(2915, LocalidadNeuquen.Zapala),
                datosEntidadBuilder.Build(2916, LocalidadNeuquen.VillaDelPuentePicunLeufu),
                datosEntidadBuilder.Build(2917, LocalidadNeuquen.LosCatutos),
                datosEntidadBuilder.Build(2918, LocalidadNeuquen.RamonMCastro),
                datosEntidadBuilder.Build(2919, LocalidadNeuquen.CovuncoAbajo)
            });
        }
    }
}
