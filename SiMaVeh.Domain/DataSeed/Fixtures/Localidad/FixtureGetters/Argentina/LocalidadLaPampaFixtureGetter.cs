using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    internal class LocalidadLaPampaFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadLaPampaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Atreuco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2260, LocalidadLaPampa.Doblas),
                datosEntidadBuilder.Build(2261, LocalidadLaPampa.Macachin),
                datosEntidadBuilder.Build(2262, LocalidadLaPampa.MiguelRiglos),
                datosEntidadBuilder.Build(2263, LocalidadLaPampa.Rolon),
                datosEntidadBuilder.Build(2264, LocalidadLaPampa.TomasManuelDeAnchorena)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.CaleuCaleu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2265, LocalidadLaPampa.LaAdela)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2266, LocalidadLaPampa.Anguil),
                datosEntidadBuilder.Build(2267, LocalidadLaPampa.SantaRosa)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Catrilo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2268, LocalidadLaPampa.Catrilo),
                datosEntidadBuilder.Build(2269, LocalidadLaPampa.Lonquimay),
                datosEntidadBuilder.Build(2270, LocalidadLaPampa.TomasDeAnchorena),
                datosEntidadBuilder.Build(2271, LocalidadLaPampa.Uriburu)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Chalileo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2272, LocalidadLaPampa.SantaIsabel),
                datosEntidadBuilder.Build(2273, LocalidadLaPampa.Victorica)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Chapaleufu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2274, LocalidadLaPampa.BernardoLarroude),
                datosEntidadBuilder.Build(2275, LocalidadLaPampa.Ceballos),
                datosEntidadBuilder.Build(2276, LocalidadLaPampa.CoronelHilarioLagos),
                datosEntidadBuilder.Build(2277, LocalidadLaPampa.IntendenteAlvear),
                datosEntidadBuilder.Build(2278, LocalidadLaPampa.Vertiz),
                datosEntidadBuilder.Build(2279, LocalidadLaPampa.Sarah)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.ChicalCo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2280, LocalidadLaPampa.AlgarroboDelAguila),
                datosEntidadBuilder.Build(2281, LocalidadLaPampa.LaHumada)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Conhelo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2282, LocalidadLaPampa.EduardoCastex),
                datosEntidadBuilder.Build(2283, LocalidadLaPampa.Conhelo),
                datosEntidadBuilder.Build(2284, LocalidadLaPampa.MauricioMayer),
                datosEntidadBuilder.Build(2285, LocalidadLaPampa.MonteNievas),
                datosEntidadBuilder.Build(2286, LocalidadLaPampa.Winifreda),
                datosEntidadBuilder.Build(2287, LocalidadLaPampa.Rucanelo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Curaco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2288, LocalidadLaPampa.Puelches),
                datosEntidadBuilder.Build(2289, LocalidadLaPampa.VeinticincoDeMayo),
                datosEntidadBuilder.Build(2290, LocalidadLaPampa.GobernadorDuval)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Guatrache).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2291, LocalidadLaPampa.Alpachiri),
                datosEntidadBuilder.Build(2292, LocalidadLaPampa.Doblas),
                datosEntidadBuilder.Build(2293, LocalidadLaPampa.GeneralManuelCampos),
                datosEntidadBuilder.Build(2294, LocalidadLaPampa.Guatrache),
                datosEntidadBuilder.Build(2295, LocalidadLaPampa.SantaTeresa),
                datosEntidadBuilder.Build(2296, LocalidadLaPampa.ColoniaSantaMaria),
                datosEntidadBuilder.Build(2297, LocalidadLaPampa.Peru)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Hucal).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2298, LocalidadLaPampa.Abramo),
                datosEntidadBuilder.Build(2299, LocalidadLaPampa.Bernasconi),
                datosEntidadBuilder.Build(2300, LocalidadLaPampa.GeneralSanMartin),
                datosEntidadBuilder.Build(2301, LocalidadLaPampa.JacintoArauz),
                datosEntidadBuilder.Build(2302, LocalidadLaPampa.Peru),
                datosEntidadBuilder.Build(2303, LocalidadLaPampa.Unanue)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.LihuelCalel).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2304, LocalidadLaPampa.GeneralAcha),
                datosEntidadBuilder.Build(2305, LocalidadLaPampa.LaAdela),
                datosEntidadBuilder.Build(2306, LocalidadLaPampa.Puelches),
                datosEntidadBuilder.Build(2307, LocalidadLaPampa.CuchilloCo),
                datosEntidadBuilder.Build(2308, LocalidadLaPampa.GobernadorDuval)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.LimayMahuida).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2309, LocalidadLaPampa.LaReforma),
                datosEntidadBuilder.Build(2310, LocalidadLaPampa.LimayMahuida)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Loventue).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2311, LocalidadLaPampa.Telen),
                datosEntidadBuilder.Build(2312, LocalidadLaPampa.CarroQuemado),
                datosEntidadBuilder.Build(2313, LocalidadLaPampa.LuanToro),
                datosEntidadBuilder.Build(2314, LocalidadLaPampa.Victorica)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Maraco).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2315, LocalidadLaPampa.GeneralPico),
                datosEntidadBuilder.Build(2316, LocalidadLaPampa.Metileo),
                datosEntidadBuilder.Build(2317, LocalidadLaPampa.QuemuQuemu),
                datosEntidadBuilder.Build(2318, LocalidadLaPampa.Vertiz),
                datosEntidadBuilder.Build(2319, LocalidadLaPampa.Agustoni),
                datosEntidadBuilder.Build(2320, LocalidadLaPampa.Speluzzi),
                datosEntidadBuilder.Build(2321, LocalidadLaPampa.Dorila)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Puelen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2322, LocalidadLaPampa.Puelen),
                datosEntidadBuilder.Build(2323, LocalidadLaPampa.VeinticincoDeMayo),
                datosEntidadBuilder.Build(2324, LocalidadLaPampa.CasaDePiedra)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.QuemuQuemu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2325, LocalidadLaPampa.ColoniaBaron),
                datosEntidadBuilder.Build(2326, LocalidadLaPampa.MiguelCane),
                datosEntidadBuilder.Build(2327, LocalidadLaPampa.QuemuQuemu),
                datosEntidadBuilder.Build(2328, LocalidadLaPampa.VillaMirasol),
                datosEntidadBuilder.Build(2329, LocalidadLaPampa.Relmo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Rancul).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2330, LocalidadLaPampa.Caleufu),
                datosEntidadBuilder.Build(2331, LocalidadLaPampa.LaMaruja),
                datosEntidadBuilder.Build(2332, LocalidadLaPampa.Parera),
                datosEntidadBuilder.Build(2333, LocalidadLaPampa.Rancul),
                datosEntidadBuilder.Build(2334, LocalidadLaPampa.Quetrequen),
                datosEntidadBuilder.Build(2335, LocalidadLaPampa.PichiHuinca)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Realico).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2336, LocalidadLaPampa.AltaItalia),
                datosEntidadBuilder.Build(2337, LocalidadLaPampa.EmbajadorMartini),
                datosEntidadBuilder.Build(2338, LocalidadLaPampa.IngenieroLuiggi),
                datosEntidadBuilder.Build(2339, LocalidadLaPampa.Realico),
                datosEntidadBuilder.Build(2340, LocalidadLaPampa.AdolfoVanPraet),
                datosEntidadBuilder.Build(2341, LocalidadLaPampa.Falucho),
                datosEntidadBuilder.Build(2342, LocalidadLaPampa.Maissonave)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Toay).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2343, LocalidadLaPampa.Toay)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Trenel).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2344, LocalidadLaPampa.AltaItalia),
                datosEntidadBuilder.Build(2345, LocalidadLaPampa.Arata),
                datosEntidadBuilder.Build(2346, LocalidadLaPampa.Caleufu),
                datosEntidadBuilder.Build(2347, LocalidadLaPampa.EduardoCastex),
                datosEntidadBuilder.Build(2348, LocalidadLaPampa.EmbajadorMartini),
                datosEntidadBuilder.Build(2349, LocalidadLaPampa.IngenieroLuiggi),
                datosEntidadBuilder.Build(2350, LocalidadLaPampa.Metileo),
                datosEntidadBuilder.Build(2351, LocalidadLaPampa.MonteNievas),
                datosEntidadBuilder.Build(2352, LocalidadLaPampa.Trenel),
                datosEntidadBuilder.Build(2353, LocalidadLaPampa.Vertiz),
                datosEntidadBuilder.Build(2354, LocalidadLaPampa.Speluzzi)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoLaPampa.Utracan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2355, LocalidadLaPampa.AtalivaRoca),
                datosEntidadBuilder.Build(2356, LocalidadLaPampa.GeneralAcha),
                datosEntidadBuilder.Build(2357, LocalidadLaPampa.Quehue),
                datosEntidadBuilder.Build(2358, LocalidadLaPampa.Chacharramendi),
                datosEntidadBuilder.Build(2359, LocalidadLaPampa.ColoniaSantaMaria),
                datosEntidadBuilder.Build(2360, LocalidadLaPampa.Unanue)
            });
        }
    }
}
