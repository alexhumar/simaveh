using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class LaPampaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public LaPampaLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Atreuco).Value.Key, new Dictionary<long, string>
            {
                { 2260, LocalidadLaPampa.Doblas },
                { 2261, LocalidadLaPampa.Macachin },
                { 2262, LocalidadLaPampa.MiguelRiglos },
                { 2263, LocalidadLaPampa.Rolon },
                { 2264, LocalidadLaPampa.TomasManuelDeAnchorena }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.CaleuCaleu).Value.Key, new Dictionary<long, string>
            {
                { 2265, LocalidadLaPampa.LaAdela }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Capital).Value.Key, new Dictionary<long, string>
            {
                { 2266, LocalidadLaPampa.Anguil },
                { 2267, LocalidadLaPampa.SantaRosa }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Catrilo).Value.Key, new Dictionary<long, string>
            {
                { 2268, LocalidadLaPampa.Catrilo },
                { 2269, LocalidadLaPampa.Lonquimay },
                { 2270, LocalidadLaPampa.TomasDeAnchorena },
                { 2271, LocalidadLaPampa.Uriburu }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Chalileo).Value.Key, new Dictionary<long, string>
            {
                { 2272, LocalidadLaPampa.SantaIsabel },
                { 2273, LocalidadLaPampa.Victorica }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Chapaleufu).Value.Key, new Dictionary<long, string>
            {
                { 2274, LocalidadLaPampa.BernardoLarroude },
                { 2275, LocalidadLaPampa.Ceballos },
                { 2276, LocalidadLaPampa.CoronelHilarioLagos },
                { 2277, LocalidadLaPampa.IntendenteAlvear },
                { 2278, LocalidadLaPampa.Vertiz },
                { 2279, LocalidadLaPampa.Sarah }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.ChicalCo).Value.Key, new Dictionary<long, string>
            {
                { 2280, LocalidadLaPampa.AlgarroboDelAguila },
                { 2281, LocalidadLaPampa.LaHumada }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Conhelo).Value.Key, new Dictionary<long, string>
            {
                { 2282, LocalidadLaPampa.EduardoCastex },
                { 2283, LocalidadLaPampa.Conhelo },
                { 2284, LocalidadLaPampa.MauricioMayer },
                { 2285, LocalidadLaPampa.MonteNievas },
                { 2286, LocalidadLaPampa.Winifreda },
                { 2287, LocalidadLaPampa.Rucanelo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Curaco).Value.Key, new Dictionary<long, string>
            {
                { 2288, LocalidadLaPampa.Puelches },
                { 2289, LocalidadLaPampa.VeinticincoDeMayo },
                { 2290, LocalidadLaPampa.GobernadorDuval }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Guatrache).Value.Key, new Dictionary<long, string>
            {
                { 2291, LocalidadLaPampa.Alpachiri },
                { 2292, LocalidadLaPampa.Doblas },
                { 2293, LocalidadLaPampa.GeneralManuelCampos },
                { 2294, LocalidadLaPampa.Guatrache },
                { 2295, LocalidadLaPampa.SantaTeresa },
                { 2296, LocalidadLaPampa.ColoniaSantaMaria },
                { 2297, LocalidadLaPampa.Peru }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Hucal).Value.Key, new Dictionary<long, string>
            {
                { 2298, LocalidadLaPampa.Abramo },
                { 2299, LocalidadLaPampa.Bernasconi },
                { 2300, LocalidadLaPampa.GeneralSanMartin },
                { 2301, LocalidadLaPampa.JacintoArauz },
                { 2302, LocalidadLaPampa.Peru },
                { 2303, LocalidadLaPampa.Unanue }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.LihuelCalel).Value.Key, new Dictionary<long, string>
            {
                { 2304, LocalidadLaPampa.GeneralAcha },
                { 2305, LocalidadLaPampa.LaAdela },
                { 2306, LocalidadLaPampa.Puelches },
                { 2307, LocalidadLaPampa.CuchilloCo },
                { 2308, LocalidadLaPampa.GobernadorDuval }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.LimayMahuida).Value.Key, new Dictionary<long, string>
            {
                { 2309, LocalidadLaPampa.LaReforma },
                { 2310, LocalidadLaPampa.LimayMahuida }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Loventue).Value.Key, new Dictionary<long, string>
            {
                { 2311, LocalidadLaPampa.Telen },
                { 2312, LocalidadLaPampa.CarroQuemado },
                { 2313, LocalidadLaPampa.LuanToro },
                { 2314, LocalidadLaPampa.Victorica }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Maraco).Value.Key, new Dictionary<long, string>
            {
                { 2315, LocalidadLaPampa.GeneralPico },
                { 2316, LocalidadLaPampa.Metileo },
                { 2317, LocalidadLaPampa.QuemuQuemu },
                { 2318, LocalidadLaPampa.Vertiz },
                { 2319, LocalidadLaPampa.Agustoni },
                { 2320, LocalidadLaPampa.Speluzzi },
                { 2321, LocalidadLaPampa.Dorila }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Puelen).Value.Key, new Dictionary<long, string>
            {
                { 2322, LocalidadLaPampa.Puelen },
                { 2323, LocalidadLaPampa.VeinticincoDeMayo },
                { 2324, LocalidadLaPampa.CasaDePiedra }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.QuemuQuemu).Value.Key, new Dictionary<long, string>
            {
                { 2325, LocalidadLaPampa.ColoniaBaron },
                { 2326, LocalidadLaPampa.MiguelCane },
                { 2327, LocalidadLaPampa.QuemuQuemu },
                { 2328, LocalidadLaPampa.VillaMirasol },
                { 2329, LocalidadLaPampa.Relmo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Rancul).Value.Key, new Dictionary<long, string>
            {
                { 2330, LocalidadLaPampa.Caleufu },
                { 2331, LocalidadLaPampa.LaMaruja },
                { 2332, LocalidadLaPampa.Parera },
                { 2333, LocalidadLaPampa.Rancul },
                { 2334, LocalidadLaPampa.Quetrequen },
                { 2335, LocalidadLaPampa.PichiHuinca }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Realico).Value.Key, new Dictionary<long, string>
            {
                { 2336, LocalidadLaPampa.AltaItalia },
                { 2337, LocalidadLaPampa.EmbajadorMartini },
                { 2338, LocalidadLaPampa.IngenieroLuiggi },
                { 2339, LocalidadLaPampa.Realico },
                { 2340, LocalidadLaPampa.AdolfoVanPraet },
                { 2341, LocalidadLaPampa.Falucho },
                { 2342, LocalidadLaPampa.Maissonave }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Toay).Value.Key, new Dictionary<long, string>
            {
                { 2343, LocalidadLaPampa.Toay }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Trenel).Value.Key, new Dictionary<long, string>
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
            dictionary.Add(fixturePartido.FindByNombre(PartidoLaPampa.Utracan).Value.Key, new Dictionary<long, string>
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
