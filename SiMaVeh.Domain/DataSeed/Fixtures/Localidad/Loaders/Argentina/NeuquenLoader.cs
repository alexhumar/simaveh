using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class NeuquenLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public NeuquenLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Alumine).Value.Key, new Dictionary<long, string>
            {
                { 2830, LocalidadNeuquen.Alumine },
                { 2831, LocalidadNeuquen.VillaPehuenia }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Anelo).Value.Key, new Dictionary<long, string>
            {
                { 2832, LocalidadNeuquen.Anelo },
                { 2833, LocalidadNeuquen.SanPatricioDelChanar }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.CatanLil).Value.Key, new Dictionary<long, string>
            {
                { 2834, LocalidadNeuquen.LasColoradas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.ChosMalal).Value.Key, new Dictionary<long, string>
            {
                { 2835, LocalidadNeuquen.ChosMalal },
                { 2836, LocalidadNeuquen.TricaoMalal },
                { 2837, LocalidadNeuquen.CoyucoCochico },
                { 2838, LocalidadNeuquen.VillaCuriLeuvu }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.CollonCura).Value.Key, new Dictionary<long, string>
            {
                { 2839, LocalidadNeuquen.PiedraDelAguila },
                { 2840, LocalidadNeuquen.SantoTomas }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Confluencia).Value.Key, new Dictionary<long, string>
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
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Huiliches).Value.Key, new Dictionary<long, string>
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
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Lacar).Value.Key, new Dictionary<long, string>
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
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Loncopue).Value.Key, new Dictionary<long, string>
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
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.LosLagos).Value.Key, new Dictionary<long, string>
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
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Minas).Value.Key, new Dictionary<long, string>
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
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Norquin).Value.Key, new Dictionary<long, string>
            {
                { 2899, LocalidadNeuquen.CaviahueCopahue },
                { 2900, LocalidadNeuquen.ElCholar },
                { 2901, LocalidadNeuquen.ElHuecu },
                { 2902, LocalidadNeuquen.Taquimilan }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Pehuenches).Value.Key, new Dictionary<long, string>
            {
                { 2903, LocalidadNeuquen.Barrancas },
                { 2904, LocalidadNeuquen.ButaRanquil },
                { 2905, LocalidadNeuquen.RinconDeLosSauces },
                { 2906, LocalidadNeuquen.OctavioPico }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.PicunLeufu).Value.Key, new Dictionary<long, string>
            {
                { 2907, LocalidadNeuquen.PicunLeufu },
                { 2908, LocalidadNeuquen.PasoAguerre },
                { 2909, LocalidadNeuquen.ElSauce }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Picunches).Value.Key, new Dictionary<long, string>
            {
                { 2910, LocalidadNeuquen.CovuncoAbajo },
                { 2911, LocalidadNeuquen.LasLajas },
                { 2912, LocalidadNeuquen.BajadaDelAgrio },
                { 2913, LocalidadNeuquen.QuiliMalal }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoNeuquen.Zapala).Value.Key, new Dictionary<long, string>
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
