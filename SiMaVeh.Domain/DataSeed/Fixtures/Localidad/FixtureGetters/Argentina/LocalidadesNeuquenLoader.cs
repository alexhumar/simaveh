using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesNeuquenLoader : LocalidadFixtureGetter
    {
        public LocalidadesNeuquenLoader(IPartidoFixtureGetter partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Alumine).Key, new Dictionary<long, string>
            {
                { 2830, LocalidadNeuquen.Alumine },
                { 2831, LocalidadNeuquen.VillaPehuenia }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Anelo).Key, new Dictionary<long, string>
            {
                { 2832, LocalidadNeuquen.Anelo },
                { 2833, LocalidadNeuquen.SanPatricioDelChanar }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.CatanLil).Key, new Dictionary<long, string>
            {
                { 2834, LocalidadNeuquen.LasColoradas }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.ChosMalal).Key, new Dictionary<long, string>
            {
                { 2835, LocalidadNeuquen.ChosMalal },
                { 2836, LocalidadNeuquen.TricaoMalal },
                { 2837, LocalidadNeuquen.CoyucoCochico },
                { 2838, LocalidadNeuquen.VillaCuriLeuvu }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.CollonCura).Key, new Dictionary<long, string>
            {
                { 2839, LocalidadNeuquen.PiedraDelAguila },
                { 2840, LocalidadNeuquen.SantoTomas }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Confluencia).Key, new Dictionary<long, string>
            {
                { 2841, LocalidadNeuquen.Centenario },
                { 2842, LocalidadNeuquen.CutralCo },
                { 2843, LocalidadNeuquen.VillaElChocon },
                { 2844, LocalidadNeuquen.Neuquen },
                { 2845, LocalidadNeuquen.PlazaHuincul },
                { 2846, LocalidadNeuquen.Plottier },
                { 2847, LocalidadNeuquen.SauzalBonito },
                { 2848, LocalidadNeuquen.Senillosa },
                { 2849, LocalidadNeuquen.VistaAlegre }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Huiliches).Key, new Dictionary<long, string>
            {
                { 2850, LocalidadNeuquen.JuninDeLosAndes },
                { 2851, LocalidadNeuquen.AucaPan },
                { 2852, LocalidadNeuquen.Atreuco },
                { 2853, LocalidadNeuquen.Chiquilihuin },
                { 2854, LocalidadNeuquen.Malleo },
                { 2855, LocalidadNeuquen.Tropezon },
                { 2856, LocalidadNeuquen.PuertoTromen },
                { 2857, LocalidadNeuquen.TresPuentes },
                { 2858, LocalidadNeuquen.CampoGrande }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Lacar).Key, new Dictionary<long, string>
            {
                { 2859, LocalidadNeuquen.SanMartinDeLosAndes },
                { 2860, LocalidadNeuquen.Chimehuin },
                { 2861, LocalidadNeuquen.PasoDeLosIndios },
                { 2862, LocalidadNeuquen.PuertoHuaHum },
                { 2863, LocalidadNeuquen.QuilaQuina },
                { 2864, LocalidadNeuquen.VegaMaipu },
                { 2865, LocalidadNeuquen.Lolog },
                { 2866, LocalidadNeuquen.LagoHermoso },
                { 2867, LocalidadNeuquen.Caleufu }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Loncopue).Key, new Dictionary<long, string>
            {
                { 2868, LocalidadNeuquen.Loncopue },
                { 2869, LocalidadNeuquen.CajonDeAlmanza },
                { 2870, LocalidadNeuquen.Chorriaca },
                { 2871, LocalidadNeuquen.Huitrin },
                { 2872, LocalidadNeuquen.Hunca },
                { 2873, LocalidadNeuquen.Pichaihue },
                { 2874, LocalidadNeuquen.Muchilinco },
                { 2875, LocalidadNeuquen.Quintuco },
                { 2876, LocalidadNeuquen.Huarenchenque }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.LosLagos).Key, new Dictionary<long, string>
            {
                { 2877, LocalidadNeuquen.VillaLaAngostura },
                { 2878, LocalidadNeuquen.VillaTraful },
                { 2879, LocalidadNeuquen.Confluencia },
                { 2880, LocalidadNeuquen.CuyinManzano },
                { 2881, LocalidadNeuquen.ElPortezuelo },
                { 2882, LocalidadNeuquen.NahuelHuapi },
                { 2883, LocalidadNeuquen.Huemul },
                { 2884, LocalidadNeuquen.PasoCoihue },
                { 2885, LocalidadNeuquen.PichiTraful },
                { 2886, LocalidadNeuquen.PuertoHuemul },
                { 2887, LocalidadNeuquen.PuertoAnchorena },
                { 2888, LocalidadNeuquen.RucaMalen },
                { 2889, LocalidadNeuquen.VillaLlanquin }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Minas).Key, new Dictionary<long, string>
            {
                { 2890, LocalidadNeuquen.Andacollo },
                { 2891, LocalidadNeuquen.Huinganco },
                { 2892, LocalidadNeuquen.LasOvejas },
                { 2893, LocalidadNeuquen.LosMiches },
                { 2894, LocalidadNeuquen.Guanacos },
                { 2895, LocalidadNeuquen.ManzanoAmargo },
                { 2896, LocalidadNeuquen.Varvarco },
                { 2897, LocalidadNeuquen.VillaDelNahueve },
                { 2898, LocalidadNeuquen.BellaVista }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Norquin).Key, new Dictionary<long, string>
            {
                { 2899, LocalidadNeuquen.CaviahueCopahue },
                { 2900, LocalidadNeuquen.ElCholar },
                { 2901, LocalidadNeuquen.ElHuecu },
                { 2902, LocalidadNeuquen.Taquimilan }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Pehuenches).Key, new Dictionary<long, string>
            {
                { 2903, LocalidadNeuquen.Barrancas },
                { 2904, LocalidadNeuquen.ButaRanquil },
                { 2905, LocalidadNeuquen.RinconDeLosSauces },
                { 2906, LocalidadNeuquen.OctavioPico }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.PicunLeufu).Key, new Dictionary<long, string>
            {
                { 2907, LocalidadNeuquen.PicunLeufu },
                { 2908, LocalidadNeuquen.PasoAguerre },
                { 2909, LocalidadNeuquen.ElSauce }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Picunches).Key, new Dictionary<long, string>
            {
                { 2910, LocalidadNeuquen.CovuncoAbajo },
                { 2911, LocalidadNeuquen.LasLajas },
                { 2912, LocalidadNeuquen.BajadaDelAgrio },
                { 2913, LocalidadNeuquen.QuiliMalal }
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoNeuquen.Zapala).Key, new Dictionary<long, string>
            {
                { 2914, LocalidadNeuquen.MarianoMoreno },
                { 2915, LocalidadNeuquen.Zapala },
                { 2916, LocalidadNeuquen.VillaDelPuentePicunLeufu },
                { 2917, LocalidadNeuquen.LosCatutos },
                { 2918, LocalidadNeuquen.RamonMCastro },
                { 2919, LocalidadNeuquen.CovuncoAbajo }
            });
        }
    }
}
