using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesSaltaLoader : LocalidadesLoader
    {
        public LocalidadesSaltaLoader(IPartidosLoader<long, long, string> partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Anta).Key, new Dictionary<long, string>
            {
                { 3041, LocalidadSalta.ApolinarioSaravia },
                { 3042, LocalidadSalta.ElQuebrachal },
                { 3043, LocalidadSalta.GeneralPizarro },
                { 3044, LocalidadSalta.JoaquinVictorGonzalez },
                { 3045, LocalidadSalta.LasLajitas },
                { 3046, LocalidadSalta.Vinalito },
                { 3047, LocalidadSalta.Tolloche },
                { 3048, LocalidadSalta.NuestraSenoraDeTalavera },
                { 3049, LocalidadSalta.Macapillo },
                { 3050, LocalidadSalta.Gaona },
                { 3051, LocalidadSalta.Ceibalito },
                { 3052, LocalidadSalta.Chorroarin },
                { 3053, LocalidadSalta.Ebro },
                { 3054, LocalidadSalta.CurvaDelTurco },
                { 3055, LocalidadSalta.SantoDomingo },
                { 3056, LocalidadSalta.LasFlores },
                { 3057, LocalidadSalta.LasFlacas },
                { 3058, LocalidadSalta.LuisBurella },
                { 3059, LocalidadSalta.CoronelMollinedo },
                { 3060, LocalidadSalta.Palermo },
                { 3061, LocalidadSalta.RioDelValle },
                { 3062, LocalidadSalta.Centro25DeJunio },
                { 3063, LocalidadSalta.CoronelOlleros },
                { 3064, LocalidadSalta.PiqueteCabado }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Cachi).Key, new Dictionary<long, string>
            {
                { 3065, LocalidadSalta.Cachi },
                { 3066, LocalidadSalta.Payogasta },
                { 3067, LocalidadSalta.ElVallecito },
                { 3068, LocalidadSalta.Escalchi },
                { 3069, LocalidadSalta.SanJoseDeEscalchi },
                { 3070, LocalidadSalta.CachiAdentro },
                { 3071, LocalidadSalta.LaPaya }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Cafayate).Key, new Dictionary<long, string>
            {
                { 3072, LocalidadSalta.Cafayate },
                { 3073, LocalidadSalta.Tolombon },
                { 3074, LocalidadSalta.LasConchas },
                { 3075, LocalidadSalta.SantaBarbara }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Capital).Key, new Dictionary<long, string>
            {
                { 3076, LocalidadSalta.Salta }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Cerrillos).Key, new Dictionary<long, string>
            {
                { 3077, LocalidadSalta.Cerrillos },
                { 3078, LocalidadSalta.LaMerced },
                { 3079, LocalidadSalta.SanAgustin },
                { 3080, LocalidadSalta.VillaLosAlamos },
                { 3081, LocalidadSalta.Sumalao },
                { 3082, LocalidadSalta.LasPalmas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Chicoana).Key, new Dictionary<long, string>
            {
                { 3083, LocalidadSalta.Chicoana },
                { 3084, LocalidadSalta.ElCarril },
                { 3085, LocalidadSalta.Escoipe },
                { 3086, LocalidadSalta.Vinaco },
                { 3087, LocalidadSalta.Calvimonte },
                { 3088, LocalidadSalta.AguaNegra },
                { 3089, LocalidadSalta.ElMaray },
                { 3090, LocalidadSalta.ElNogalar },
                { 3091, LocalidadSalta.LaZanja },
                { 3092, LocalidadSalta.Pulares },
                { 3093, LocalidadSalta.SanFernandoDeEscoipe },
                { 3094, LocalidadSalta.SanMartin },
                { 3095, LocalidadSalta.Chivilme },
                { 3096, LocalidadSalta.BellaVista },
                { 3097, LocalidadSalta.Penaflor },
                { 3098, LocalidadSalta.PotreroDeDiaz },
                { 3099, LocalidadSalta.Simbolar },
                { 3100, LocalidadSalta.Maroma }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.GeneralGuemes).Key, new Dictionary<long, string>
            {
                { 3101, LocalidadSalta.CampoSanto },
                { 3102, LocalidadSalta.ElBordo },
                { 3103, LocalidadSalta.GeneralGuemes },
                { 3104, LocalidadSalta.Cobos },
                { 3105, LocalidadSalta.CabezaDeBuey },
                { 3106, LocalidadSalta.Palomitas },
                { 3107, LocalidadSalta.Betania },
                { 3108, LocalidadSalta.CruzQuemada },
                { 3109, LocalidadSalta.ElSalto },
                { 3110, LocalidadSalta.Km1094 },
                { 3111, LocalidadSalta.LasMesitas },
                { 3112, LocalidadSalta.VirgilioTedin },
                { 3113, LocalidadSalta.LosSauces }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.GeneralJoseDeSanMartin).Key, new Dictionary<long, string>
            {
                { 3114, LocalidadSalta.Tartagal },
                { 3115, LocalidadSalta.Embarcacion },
                { 3116, LocalidadSalta.SalvadorMazza },
                { 3117, LocalidadSalta.GeneralMosconi },
                { 3118, LocalidadSalta.Aguaray },
                { 3119, LocalidadSalta.CoronelCornejo },
                { 3120, LocalidadSalta.CampamentoVespucio },
                { 3121, LocalidadSalta.GeneralBallivian },
                { 3122, LocalidadSalta.Dragones },
                { 3123, LocalidadSalta.Yacuy },
                { 3124, LocalidadSalta.MisionChaquena },
                { 3125, LocalidadSalta.MisionKilometro6 },
                { 3126, LocalidadSalta.Hickman },
                { 3127, LocalidadSalta.CampoDuran },
                { 3128, LocalidadSalta.MisionTierrasFiscales },
                { 3129, LocalidadSalta.Piquirenda },
                { 3130, LocalidadSalta.Tranquitas },
                { 3131, LocalidadSalta.Capiazuti },
                { 3132, LocalidadSalta.PadreLozano },
                { 3133, LocalidadSalta.Tobantirenda },
                { 3134, LocalidadSalta.Carboncito },
                { 3135, LocalidadSalta.Campichuelo },
                { 3136, LocalidadSalta.Pacara },
                { 3137, LocalidadSalta.Recaredo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Guachipas).Key, new Dictionary<long, string>
            {
                { 3138, LocalidadSalta.Guachipas },
                { 3139, LocalidadSalta.Alemania },
                { 3140, LocalidadSalta.Cebilar },
                { 3141, LocalidadSalta.PampaGrande },
                { 3142, LocalidadSalta.LasJuntas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Iruya).Key, new Dictionary<long, string>
            {
                { 3143, LocalidadSalta.Colanzuli },
                { 3144, LocalidadSalta.Chiyayoc },
                { 3145, LocalidadSalta.RodeoColorado },
                { 3146, LocalidadSalta.SanJuan },
                { 3147, LocalidadSalta.VolcanHigueras }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.LaCaldera).Key, new Dictionary<long, string>
            {
                { 3148, LocalidadSalta.LaCaldera },
                { 3149, LocalidadSalta.Vaqueros },
                { 3150, LocalidadSalta.LaCalderilla },
                { 3151, LocalidadSalta.LosYacones },
                { 3152, LocalidadSalta.PotreroDeCastilla }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.LaCandelaria).Key, new Dictionary<long, string>
            {
                { 3153, LocalidadSalta.ElJardin },
                { 3154, LocalidadSalta.ElTala },
                { 3155, LocalidadSalta.LaCandelaria }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.LaPoma).Key, new Dictionary<long, string>
            {
                { 3156, LocalidadSalta.EsquinaDeGuardia },
                { 3157, LocalidadSalta.LaPoma },
                { 3158, LocalidadSalta.Cobres },
                { 3159, LocalidadSalta.ElSaladillo },
                { 3160, LocalidadSalta.ElTrigal },
                { 3161, LocalidadSalta.ElVolcan },
                { 3162, LocalidadSalta.Munano },
                { 3163, LocalidadSalta.Potrerillos },
                { 3164, LocalidadSalta.Tipan },
                { 3165, LocalidadSalta.CerroNegro },
                { 3166, LocalidadSalta.ElRodeo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.LaVina).Key, new Dictionary<long, string>
            {
                { 3167, LocalidadSalta.CoronelMoldes },
                { 3168, LocalidadSalta.LaVina },
                { 3169, LocalidadSalta.Ampascachi },
                { 3170, LocalidadSalta.Talapampa },
                { 3171, LocalidadSalta.CabraCorral },
                { 3172, LocalidadSalta.ElCarmen },
                { 3173, LocalidadSalta.Osma },
                { 3174, LocalidadSalta.VeinteDeFebrero },
                { 3175, LocalidadSalta.Saladillo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.LosAndes).Key, new Dictionary<long, string>
            {
                { 3176, LocalidadSalta.SanAntonioDeLosCobres },
                { 3177, LocalidadSalta.Olacapato },
                { 3178, LocalidadSalta.SantaRosaDeLosPastosGrandes },
                { 3179, LocalidadSalta.TolarGrande },
                { 3180, LocalidadSalta.Caipe },
                { 3181, LocalidadSalta.Chuculaqui },
                { 3182, LocalidadSalta.LagunaSeca },
                { 3183, LocalidadSalta.LosPatos },
                { 3184, LocalidadSalta.MinaLaCasualidad },
                { 3185, LocalidadSalta.MinaTincalado },
                { 3186, LocalidadSalta.QuebradaDelAgua },
                { 3187, LocalidadSalta.SalarDePocitos },
                { 3188, LocalidadSalta.Socompa },
                { 3189, LocalidadSalta.TacaTaca },
                { 3190, LocalidadSalta.Unquillar },
                { 3191, LocalidadSalta.VegaDeArizaro }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Metan).Key, new Dictionary<long, string>
            {
                { 3192, LocalidadSalta.SanJoseDeMetan },
                { 3193, LocalidadSalta.ElGalpon },
                { 3194, LocalidadSalta.RioPiedras },
                { 3195, LocalidadSalta.ElTunal },
                { 3196, LocalidadSalta.Lumbreras },
                { 3197, LocalidadSalta.LosRosales },
                { 3198, LocalidadSalta.MetanViejo },
                { 3199, LocalidadSalta.SanJoseDeLaOrquera },
                { 3200, LocalidadSalta.PresaElTunal }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Molinos).Key, new Dictionary<long, string>
            {
                { 3201, LocalidadSalta.Molinos },
                { 3202, LocalidadSalta.Seclantas },
                { 3203, LocalidadSalta.LaPuerta },
                { 3204, LocalidadSalta.Colome },
                { 3205, LocalidadSalta.Luracatao },
                { 3206, LocalidadSalta.Brealito },
                { 3207, LocalidadSalta.SeclantasAdentro },
                { 3208, LocalidadSalta.Tacuil },
                { 3209, LocalidadSalta.ElChurcal },
                { 3210, LocalidadSalta.LaAguadita },
                { 3211, LocalidadSalta.Amaicha },
                { 3212, LocalidadSalta.ElRefugio }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Oran).Key, new Dictionary<long, string>
            {
                { 3213, LocalidadSalta.SanRamonDeLaNuevaOran },
                { 3214, LocalidadSalta.Pichanal },
                { 3215, LocalidadSalta.ColoniaSantaRosa },
                { 3216, LocalidadSalta.HipolitoYrigoyen },
                { 3217, LocalidadSalta.Urundel },
                { 3218, LocalidadSalta.AguasBlancas }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.Rivadavia).Key, new Dictionary<long, string>
            {
                { 3219, LocalidadSalta.CoronelJuanSola },
                { 3220, LocalidadSalta.Rivadavia },
                { 3221, LocalidadSalta.SantaVictoriaEste },
                { 3222, LocalidadSalta.LaUnion },
                { 3223, LocalidadSalta.LosBlancos },
                { 3224, LocalidadSalta.SantaMaria },
                { 3225, LocalidadSalta.AltoDeLaSierra },
                { 3226, LocalidadSalta.SantaRosa },
                { 3227, LocalidadSalta.CapitanJuanPage },
                { 3228, LocalidadSalta.PlumaDePato }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.RosarioDeLaFrontera).Key, new Dictionary<long, string>
            {
                { 3229, LocalidadSalta.RosarioDeLaFrontera },
                { 3230, LocalidadSalta.Antilla },
                { 3231, LocalidadSalta.CopoQuile },
                { 3232, LocalidadSalta.ElPotrero },
                { 3233, LocalidadSalta.ElNaranjo },
                { 3234, LocalidadSalta.SanFelipe }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.RosarioDeLerma).Key, new Dictionary<long, string>
            {
                { 3235, LocalidadSalta.CampoQuijano },
                { 3236, LocalidadSalta.RosarioDeLerma },
                { 3237, LocalidadSalta.LaSilleta },
                { 3238, LocalidadSalta.PuertaTastil },
                { 3239, LocalidadSalta.SantaRosaDeTastil }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.SanCarlos).Key, new Dictionary<long, string>
            {
                { 3240, LocalidadSalta.Angastaco },
                { 3241, LocalidadSalta.Animana },
                { 3242, LocalidadSalta.SanCarlos },
                { 3243, LocalidadSalta.ElBarrial },
                { 3244, LocalidadSalta.Jasimana },
                { 3245, LocalidadSalta.LaAngostura },
                { 3246, LocalidadSalta.MinaDonOtto },
                { 3247, LocalidadSalta.Monteverde },
                { 3248, LocalidadSalta.Pucara },
                { 3249, LocalidadSalta.SantaRosa },
                { 3250, LocalidadSalta.Amblayo },
                { 3251, LocalidadSalta.ParajeCorralito },
                { 3252, LocalidadSalta.ParajeSanAntonio },
                { 3253, LocalidadSalta.Payogastilla }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoSalta.SantaVictoria).Key, new Dictionary<long, string>
            {
                { 3254, LocalidadSalta.SantaVictoriaOeste },
                { 3255, LocalidadSalta.LosToldos },
                { 3256, LocalidadSalta.Nazareno },
                { 3257, LocalidadSalta.Poscaya },
                { 3258, LocalidadSalta.CampoLaCruz },
                { 3259, LocalidadSalta.SanMarcos },
                { 3260, LocalidadSalta.Acoyte }
            });
        }
    }
}
