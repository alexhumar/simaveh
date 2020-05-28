using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders.Argentina
{
    class LocalidadesLaPampaLoader : LocalidadesLoader
    {
        public LocalidadesLaPampaLoader(IPartidosLoader partidosLoader)
            : base(partidosLoader)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Atreuco).Key, new Dictionary<long, string>
            {
                { 2260, LocalidadLaPampa.Doblas },
                { 2261, LocalidadLaPampa.Macachin },
                { 2262, LocalidadLaPampa.MiguelRiglos },
                { 2263, LocalidadLaPampa.Rolon },
                { 2264, LocalidadLaPampa.TomasManuelDeAnchorena }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.CaleuCaleu).Key, new Dictionary<long, string>
            {
                { 2265, LocalidadLaPampa.LaAdela }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Capital).Key, new Dictionary<long, string>
            {
                { 2266, LocalidadLaPampa.Anguil },
                { 2267, LocalidadLaPampa.SantaRosa }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Catrilo).Key, new Dictionary<long, string>
            {
                { 2268, LocalidadLaPampa.Catrilo },
                { 2269, LocalidadLaPampa.Lonquimay },
                { 2270, LocalidadLaPampa.TomasDeAnchorena },
                { 2271, LocalidadLaPampa.Uriburu }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Chalileo).Key, new Dictionary<long, string>
            {
                { 2272, LocalidadLaPampa.SantaIsabel },
                { 2273, LocalidadLaPampa.Victorica }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Chapaleufu).Key, new Dictionary<long, string>
            {
                { 2274, LocalidadLaPampa.BernardoLarroude },
                { 2275, LocalidadLaPampa.Ceballos },
                { 2276, LocalidadLaPampa.CoronelHilarioLagos },
                { 2277, LocalidadLaPampa.IntendenteAlvear },
                { 2278, LocalidadLaPampa.Vertiz },
                { 2279, LocalidadLaPampa.Sarah }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.ChicalCo).Key, new Dictionary<long, string>
            {
                { 2280, LocalidadLaPampa.AlgarroboDelAguila },
                { 2281, LocalidadLaPampa.LaHumada }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Conhelo).Key, new Dictionary<long, string>
            {
                { 2282, LocalidadLaPampa.EduardoCastex },
                { 2283, LocalidadLaPampa.Conhelo },
                { 2284, LocalidadLaPampa.MauricioMayer },
                { 2285, LocalidadLaPampa.MonteNievas },
                { 2286, LocalidadLaPampa.Winifreda },
                { 2287, LocalidadLaPampa.Rucanelo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Curaco).Key, new Dictionary<long, string>
            {
                { 2288, LocalidadLaPampa.Puelches },
                { 2289, LocalidadLaPampa.VeinticincoDeMayo },
                { 2290, LocalidadLaPampa.GobernadorDuval }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Guatrache).Key, new Dictionary<long, string>
            {
                { 2291, LocalidadLaPampa.Alpachiri },
                { 2292, LocalidadLaPampa.Doblas },
                { 2293, LocalidadLaPampa.GeneralManuelCampos },
                { 2294, LocalidadLaPampa.Guatrache },
                { 2295, LocalidadLaPampa.SantaTeresa },
                { 2296, LocalidadLaPampa.ColoniaSantaMaria },
                { 2297, LocalidadLaPampa.Peru }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Hucal).Key, new Dictionary<long, string>
            {
                { 2298, LocalidadLaPampa.Abramo },
                { 2299, LocalidadLaPampa.Bernasconi },
                { 2300, LocalidadLaPampa.GeneralSanMartin },
                { 2301, LocalidadLaPampa.JacintoArauz },
                { 2302, LocalidadLaPampa.Peru },
                { 2303, LocalidadLaPampa.Unanue }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.LihuelCalel).Key, new Dictionary<long, string>
            {
                { 2304, LocalidadLaPampa.GeneralAcha },
                { 2305, LocalidadLaPampa.LaAdela },
                { 2306, LocalidadLaPampa.Puelches },
                { 2307, LocalidadLaPampa.CuchilloCo },
                { 2308, LocalidadLaPampa.GobernadorDuval }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.LimayMahuida).Key, new Dictionary<long, string>
            {
                { 2309, LocalidadLaPampa.LaReforma },
                { 2310, LocalidadLaPampa.LimayMahuida }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Loventue).Key, new Dictionary<long, string>
            {
                { 2311, LocalidadLaPampa.Telen },
                { 2312, LocalidadLaPampa.CarroQuemado },
                { 2313, LocalidadLaPampa.LuanToro },
                { 2314, LocalidadLaPampa.Victorica }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Maraco).Key, new Dictionary<long, string>
            {
                { 2315, LocalidadLaPampa.GeneralPico },
                { 2316, LocalidadLaPampa.Metileo },
                { 2317, LocalidadLaPampa.QuemuQuemu },
                { 2318, LocalidadLaPampa.Vertiz },
                { 2319, LocalidadLaPampa.Agustoni },
                { 2320, LocalidadLaPampa.Speluzzi },
                { 2321, LocalidadLaPampa.Dorila }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Puelen).Key, new Dictionary<long, string>
            {
                { 2322, LocalidadLaPampa.Puelen },
                { 2323, LocalidadLaPampa.VeinticincoDeMayo },
                { 2324, LocalidadLaPampa.CasaDePiedra }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.QuemuQuemu).Key, new Dictionary<long, string>
            {
                { 2325, LocalidadLaPampa.ColoniaBaron },
                { 2326, LocalidadLaPampa.MiguelCane },
                { 2327, LocalidadLaPampa.QuemuQuemu },
                { 2328, LocalidadLaPampa.VillaMirasol },
                { 2329, LocalidadLaPampa.Relmo }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Rancul).Key, new Dictionary<long, string>
            {
                { 2330, LocalidadLaPampa.Caleufu },
                { 2331, LocalidadLaPampa.LaMaruja },
                { 2332, LocalidadLaPampa.Parera },
                { 2333, LocalidadLaPampa.Rancul },
                { 2334, LocalidadLaPampa.Quetrequen },
                { 2335, LocalidadLaPampa.PichiHuinca }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Realico).Key, new Dictionary<long, string>
            {
                { 2336, LocalidadLaPampa.AltaItalia },
                { 2337, LocalidadLaPampa.EmbajadorMartini },
                { 2338, LocalidadLaPampa.IngenieroLuiggi },
                { 2339, LocalidadLaPampa.Realico },
                { 2340, LocalidadLaPampa.AdolfoVanPraet },
                { 2341, LocalidadLaPampa.Falucho },
                { 2342, LocalidadLaPampa.Maissonave }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Toay).Key, new Dictionary<long, string>
            {
                { 2343, LocalidadLaPampa.Toay }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Trenel).Key, new Dictionary<long, string>
            {
                { 2344, LocalidadLaPampa.AltaItalia },
                { 2345, LocalidadLaPampa.Arata },
                { 2346, LocalidadLaPampa.Caleufu },
                { 2347, LocalidadLaPampa.EduardoCastex },
                { 2348, LocalidadLaPampa.EmbajadorMartini },
                { 2349, LocalidadLaPampa.IngenieroLuiggi },
                { 2350, LocalidadLaPampa.Metileo },
                { 2351, LocalidadLaPampa.MonteNievas },
                { 2352, LocalidadLaPampa.Trenel },
                { 2353, LocalidadLaPampa.Vertiz },
                { 2354, LocalidadLaPampa.Speluzzi }
            });
            localidades.Add(partidosLoader.FindByNombre(PartidoLaPampa.Utracan).Key, new Dictionary<long, string>
            {
                { 2355, LocalidadLaPampa.AtalivaRoca },
                { 2356, LocalidadLaPampa.GeneralAcha },
                { 2357, LocalidadLaPampa.Quehue },
                { 2358, LocalidadLaPampa.Chacharramendi },
                { 2359, LocalidadLaPampa.ColoniaSantaMaria },
                { 2360, LocalidadLaPampa.Unanue }
            });
        }
    }
}
