using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    class LocalidadMendozaFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadMendozaFixtureGetter(IPartidoFixtureGetter partidoFixtureGetter)
            : base(partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2542, LocalidadMendoza.Mendoza)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.GeneralAlvear).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2543, LocalidadMendoza.Canalejas),
                datosEntidadBuilder.Build(2544, LocalidadMendoza.Carmensa),
                datosEntidadBuilder.Build(2545, LocalidadMendoza.Cochico),
                datosEntidadBuilder.Build(2546, LocalidadMendoza.CorralDeLorca),
                datosEntidadBuilder.Build(2547, LocalidadMendoza.ElCeibo),
                datosEntidadBuilder.Build(2548, LocalidadMendoza.ElJuncalito),
                datosEntidadBuilder.Build(2549, LocalidadMendoza.GeneralAlvear),
                datosEntidadBuilder.Build(2550, LocalidadMendoza.GasparCampos),
                datosEntidadBuilder.Build(2551, LocalidadMendoza.Goico),
                datosEntidadBuilder.Build(2552, LocalidadMendoza.LaEscandinava),
                datosEntidadBuilder.Build(2553, LocalidadMendoza.LaMora),
                datosEntidadBuilder.Build(2554, LocalidadMendoza.LineaDePoste),
                datosEntidadBuilder.Build(2555, LocalidadMendoza.LosCampamentos),
                datosEntidadBuilder.Build(2556, LocalidadMendoza.LosCompartos),
                datosEntidadBuilder.Build(2557, LocalidadMendoza.MediaLuna),
                datosEntidadBuilder.Build(2558, LocalidadMendoza.Ovejeria),
                datosEntidadBuilder.Build(2559, LocalidadMendoza.PampaDelTigre),
                datosEntidadBuilder.Build(2560, LocalidadMendoza.PosteDeHierro),
                datosEntidadBuilder.Build(2561, LocalidadMendoza.ElNevado),
                datosEntidadBuilder.Build(2562, LocalidadMendoza.ElDesvio),
                datosEntidadBuilder.Build(2563, LocalidadMendoza.Bowen)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.GodoyCruz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2564, LocalidadMendoza.GobernadorBenegas),
                datosEntidadBuilder.Build(2565, LocalidadMendoza.GodoyCruz),
                datosEntidadBuilder.Build(2566, LocalidadMendoza.LasTortugas),
                datosEntidadBuilder.Build(2567, LocalidadMendoza.PresidenteSarmiento),
                datosEntidadBuilder.Build(2568, LocalidadMendoza.SanFranciscoDelMonte),
                datosEntidadBuilder.Build(2569, LocalidadMendoza.SanVicente)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Guaymallen).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2570, LocalidadMendoza.Belgrano),
                datosEntidadBuilder.Build(2571, LocalidadMendoza.ElBermejo),
                datosEntidadBuilder.Build(2572, LocalidadMendoza.BuenaNueva),
                datosEntidadBuilder.Build(2573, LocalidadMendoza.CapillaDelRosario),
                datosEntidadBuilder.Build(2574, LocalidadMendoza.ColoniaMolina),
                datosEntidadBuilder.Build(2575, LocalidadMendoza.ColoniaSegovia),
                datosEntidadBuilder.Build(2576, LocalidadMendoza.Dorrego),
                datosEntidadBuilder.Build(2577, LocalidadMendoza.ElSauce),
                datosEntidadBuilder.Build(2578, LocalidadMendoza.Guaymallen),
                datosEntidadBuilder.Build(2579, LocalidadMendoza.JesusNazareno),
                datosEntidadBuilder.Build(2580, LocalidadMendoza.Kilometro8),
                datosEntidadBuilder.Build(2581, LocalidadMendoza.Kilometro11),
                datosEntidadBuilder.Build(2582, LocalidadMendoza.LaPrimavera),
                datosEntidadBuilder.Build(2583, LocalidadMendoza.LasCanas),
                datosEntidadBuilder.Build(2584, LocalidadMendoza.LosCorralitos),
                datosEntidadBuilder.Build(2585, LocalidadMendoza.NuevaCiudad),
                datosEntidadBuilder.Build(2586, LocalidadMendoza.PedroMolina),
                datosEntidadBuilder.Build(2587, LocalidadMendoza.PuenteDeHierro),
                datosEntidadBuilder.Build(2588, LocalidadMendoza.RodeoDeLaCruz),
                datosEntidadBuilder.Build(2589, LocalidadMendoza.SanFranciscoDelMonte),
                datosEntidadBuilder.Build(2590, LocalidadMendoza.SanJose),
                datosEntidadBuilder.Build(2591, LocalidadMendoza.VillaNueva)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Junin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2592, LocalidadMendoza.AlgarroboGrande),
                datosEntidadBuilder.Build(2593, LocalidadMendoza.AltoVerde),
                datosEntidadBuilder.Build(2594, LocalidadMendoza.Ciudad),
                datosEntidadBuilder.Build(2595, LocalidadMendoza.IngenieroGiagnoni),
                datosEntidadBuilder.Build(2596, LocalidadMendoza.LaColonia),
                datosEntidadBuilder.Build(2597, LocalidadMendoza.LosBarriales),
                datosEntidadBuilder.Build(2598, LocalidadMendoza.Medrano),
                datosEntidadBuilder.Build(2599, LocalidadMendoza.MundoNuevo),
                datosEntidadBuilder.Build(2600, LocalidadMendoza.Phillips),
                datosEntidadBuilder.Build(2601, LocalidadMendoza.RodriguezPena)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.LaPaz).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2602, LocalidadMendoza.Desaguadero),
                datosEntidadBuilder.Build(2603, LocalidadMendoza.LaPazNorte),
                datosEntidadBuilder.Build(2604, LocalidadMendoza.LaPazSur),
                datosEntidadBuilder.Build(2605, LocalidadMendoza.VillaAntigua),
                datosEntidadBuilder.Build(2606, LocalidadMendoza.VillaCabecera)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.LasHeras).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2607, LocalidadMendoza.Capdevilla),
                datosEntidadBuilder.Build(2608, LocalidadMendoza.LaCieneguita),
                datosEntidadBuilder.Build(2609, LocalidadMendoza.ElAlgarrobal),
                datosEntidadBuilder.Build(2610, LocalidadMendoza.ElBorbollon),
                datosEntidadBuilder.Build(2611, LocalidadMendoza.ElChallao),
                datosEntidadBuilder.Build(2612, LocalidadMendoza.ElPastal),
                datosEntidadBuilder.Build(2613, LocalidadMendoza.ElPlumerillo),
                datosEntidadBuilder.Build(2614, LocalidadMendoza.ElResguardo),
                datosEntidadBuilder.Build(2615, LocalidadMendoza.ElZapallar),
                datosEntidadBuilder.Build(2616, LocalidadMendoza.LasCuevas),
                datosEntidadBuilder.Build(2617, LocalidadMendoza.LasHeras),
                datosEntidadBuilder.Build(2618, LocalidadMendoza.Panquehua),
                datosEntidadBuilder.Build(2619, LocalidadMendoza.UspallataYAltaMontana)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Lavalle).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2620, LocalidadMendoza.CostaDeAraujo),
                datosEntidadBuilder.Build(2621, LocalidadMendoza.ElCarmen),
                datosEntidadBuilder.Build(2622, LocalidadMendoza.ElChilcal),
                datosEntidadBuilder.Build(2623, LocalidadMendoza.ElPlumero),
                datosEntidadBuilder.Build(2624, LocalidadMendoza.ElVergel),
                datosEntidadBuilder.Build(2625, LocalidadMendoza.GustavoAndre),
                datosEntidadBuilder.Build(2626, LocalidadMendoza.Jocoli),
                datosEntidadBuilder.Build(2627, LocalidadMendoza.JocoliViejo),
                datosEntidadBuilder.Build(2628, LocalidadMendoza.LaAsuncion),
                datosEntidadBuilder.Build(2629, LocalidadMendoza.LaHolanda),
                datosEntidadBuilder.Build(2630, LocalidadMendoza.LaPalmera),
                datosEntidadBuilder.Build(2631, LocalidadMendoza.LaPega),
                datosEntidadBuilder.Build(2632, LocalidadMendoza.LasVioletas),
                datosEntidadBuilder.Build(2633, LocalidadMendoza.LagunasDelRosario),
                datosEntidadBuilder.Build(2634, LocalidadMendoza.Paramillo),
                datosEntidadBuilder.Build(2635, LocalidadMendoza.SanFrancisco),
                datosEntidadBuilder.Build(2636, LocalidadMendoza.SanJose),
                datosEntidadBuilder.Build(2637, LocalidadMendoza.SanMiguel),
                datosEntidadBuilder.Build(2638, LocalidadMendoza.TresDeMayo),
                datosEntidadBuilder.Build(2639, LocalidadMendoza.VillaTulumaya),
                datosEntidadBuilder.Build(2640, LocalidadMendoza.OscarMendoza)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.LujanDeCuyo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2641, LocalidadMendoza.Agrelo),
                datosEntidadBuilder.Build(2642, LocalidadMendoza.Cacheuta),
                datosEntidadBuilder.Build(2643, LocalidadMendoza.Carrodilla),
                datosEntidadBuilder.Build(2644, LocalidadMendoza.ChacrasDeCoria),
                datosEntidadBuilder.Build(2645, LocalidadMendoza.ElCarrizal),
                datosEntidadBuilder.Build(2646, LocalidadMendoza.Industrial),
                datosEntidadBuilder.Build(2647, LocalidadMendoza.LaPuntilla),
                datosEntidadBuilder.Build(2648, LocalidadMendoza.LasCompuertas),
                datosEntidadBuilder.Build(2649, LocalidadMendoza.LujanDeCuyo),
                datosEntidadBuilder.Build(2650, LocalidadMendoza.MayorDrummond),
                datosEntidadBuilder.Build(2651, LocalidadMendoza.Perdriel),
                datosEntidadBuilder.Build(2652, LocalidadMendoza.Potrerillos),
                datosEntidadBuilder.Build(2653, LocalidadMendoza.Ugarteche),
                datosEntidadBuilder.Build(2654, LocalidadMendoza.Vistalba),
                datosEntidadBuilder.Build(2655, LocalidadMendoza.VertientesDelPedemonte)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Maipu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2656, LocalidadMendoza.Coquimbito),
                datosEntidadBuilder.Build(2657, LocalidadMendoza.CruzDePiedra),
                datosEntidadBuilder.Build(2658, LocalidadMendoza.FrayLuisBeltran),
                datosEntidadBuilder.Build(2659, LocalidadMendoza.GeneralGutierrez),
                datosEntidadBuilder.Build(2660, LocalidadMendoza.GeneralOrtega),
                datosEntidadBuilder.Build(2661, LocalidadMendoza.Barrancas),
                datosEntidadBuilder.Build(2662, LocalidadMendoza.Lunlunta),
                datosEntidadBuilder.Build(2663, LocalidadMendoza.Luzuriaga),
                datosEntidadBuilder.Build(2664, LocalidadMendoza.Maipu),
                datosEntidadBuilder.Build(2665, LocalidadMendoza.RodeoDelMedio),
                datosEntidadBuilder.Build(2666, LocalidadMendoza.Russell),
                datosEntidadBuilder.Build(2667, LocalidadMendoza.SanRoque)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Malargue).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2668, LocalidadMendoza.AguaEscondida),
                datosEntidadBuilder.Build(2669, LocalidadMendoza.Malargue),
                datosEntidadBuilder.Build(2670, LocalidadMendoza.RioBarrancas),
                datosEntidadBuilder.Build(2671, LocalidadMendoza.RioGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Rivadavia).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2672, LocalidadMendoza.Andrade),
                datosEntidadBuilder.Build(2673, LocalidadMendoza.ElMirador),
                datosEntidadBuilder.Build(2674, LocalidadMendoza.LaCentral),
                datosEntidadBuilder.Build(2675, LocalidadMendoza.LaLibertad),
                datosEntidadBuilder.Build(2676, LocalidadMendoza.LosArboles),
                datosEntidadBuilder.Build(2677, LocalidadMendoza.LosCampamentos),
                datosEntidadBuilder.Build(2678, LocalidadMendoza.LosHuarpes),
                datosEntidadBuilder.Build(2679, LocalidadMendoza.Medrano),
                datosEntidadBuilder.Build(2680, LocalidadMendoza.MundoNuevo),
                datosEntidadBuilder.Build(2681, LocalidadMendoza.Reduccion),
                datosEntidadBuilder.Build(2682, LocalidadMendoza.Rivadavia),
                datosEntidadBuilder.Build(2683, LocalidadMendoza.SantaMariaDeOro),
                datosEntidadBuilder.Build(2684, LocalidadMendoza.SanIsidro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.SanCarlos).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2685, LocalidadMendoza.Chilecito),
                datosEntidadBuilder.Build(2686, LocalidadMendoza.EugenioBustos),
                datosEntidadBuilder.Build(2687, LocalidadMendoza.LaConsulta),
                datosEntidadBuilder.Build(2688, LocalidadMendoza.Pareditas),
                datosEntidadBuilder.Build(2689, LocalidadMendoza.TresEsquinas),
                datosEntidadBuilder.Build(2690, LocalidadMendoza.VillaDeSanCarlos)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.GeneralSanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2691, LocalidadMendoza.AltoSalvador),
                datosEntidadBuilder.Build(2692, LocalidadMendoza.AltoVerde),
                datosEntidadBuilder.Build(2693, LocalidadMendoza.BuenOrden),
                datosEntidadBuilder.Build(2694, LocalidadMendoza.Chapanay),
                datosEntidadBuilder.Build(2695, LocalidadMendoza.Chivilcoy),
                datosEntidadBuilder.Build(2696, LocalidadMendoza.ElCentral),
                datosEntidadBuilder.Build(2697, LocalidadMendoza.ElDivisadero),
                datosEntidadBuilder.Build(2698, LocalidadMendoza.ElEspino),
                datosEntidadBuilder.Build(2699, LocalidadMendoza.ElRamblon),
                datosEntidadBuilder.Build(2700, LocalidadMendoza.IngenieroGiagnoni),
                datosEntidadBuilder.Build(2701, LocalidadMendoza.LasChimbas),
                datosEntidadBuilder.Build(2702, LocalidadMendoza.Montecaseros),
                datosEntidadBuilder.Build(2703, LocalidadMendoza.NuevaCalifornia),
                datosEntidadBuilder.Build(2704, LocalidadMendoza.Palmira),
                datosEntidadBuilder.Build(2705, LocalidadMendoza.SanMartin),
                datosEntidadBuilder.Build(2706, LocalidadMendoza.TresPortenas)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.SanRafael).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2707, LocalidadMendoza.CanadaSeca),
                datosEntidadBuilder.Build(2708, LocalidadMendoza.CuadroBenegas),
                datosEntidadBuilder.Build(2709, LocalidadMendoza.CuadroNacional),
                datosEntidadBuilder.Build(2710, LocalidadMendoza.ElCerrito),
                datosEntidadBuilder.Build(2711, LocalidadMendoza.ElSosneado),
                datosEntidadBuilder.Build(2712, LocalidadMendoza.ElNihuil),
                datosEntidadBuilder.Build(2713, LocalidadMendoza.Goudge),
                datosEntidadBuilder.Build(2714, LocalidadMendoza.JaimePrats),
                datosEntidadBuilder.Build(2715, LocalidadMendoza.LaLlave),
                datosEntidadBuilder.Build(2716, LocalidadMendoza.LasMalvinas),
                datosEntidadBuilder.Build(2717, LocalidadMendoza.LasParedes),
                datosEntidadBuilder.Build(2718, LocalidadMendoza.MonteComan),
                datosEntidadBuilder.Build(2719, LocalidadMendoza.PuntaDelAgua),
                datosEntidadBuilder.Build(2720, LocalidadMendoza.RamaCaida),
                datosEntidadBuilder.Build(2721, LocalidadMendoza.RealDelPadre),
                datosEntidadBuilder.Build(2722, LocalidadMendoza.SanRafael),
                datosEntidadBuilder.Build(2723, LocalidadMendoza.VillaVeinticincoDeMayo),
                datosEntidadBuilder.Build(2724, LocalidadMendoza.VillaAtuel)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.SantaRosa).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2725, LocalidadMendoza.DoceDeOctubre),
                datosEntidadBuilder.Build(2726, LocalidadMendoza.LaDormida),
                datosEntidadBuilder.Build(2727, LocalidadMendoza.LasCatitas),
                datosEntidadBuilder.Build(2728, LocalidadMendoza.Nacunan),
                datosEntidadBuilder.Build(2729, LocalidadMendoza.SantaRosa)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Tunuyan).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2730, LocalidadMendoza.CampoDeLosAndes),
                datosEntidadBuilder.Build(2731, LocalidadMendoza.ColoniaLasRosas),
                datosEntidadBuilder.Build(2732, LocalidadMendoza.ElAlgarrobo),
                datosEntidadBuilder.Build(2733, LocalidadMendoza.ElTotoral),
                datosEntidadBuilder.Build(2734, LocalidadMendoza.LaPrimavera),
                datosEntidadBuilder.Build(2735, LocalidadMendoza.LasPintadas),
                datosEntidadBuilder.Build(2736, LocalidadMendoza.LosArboles),
                datosEntidadBuilder.Build(2737, LocalidadMendoza.LosChacayes),
                datosEntidadBuilder.Build(2738, LocalidadMendoza.LosSauces),
                datosEntidadBuilder.Build(2739, LocalidadMendoza.Tunuyan),
                datosEntidadBuilder.Build(2740, LocalidadMendoza.VillaSeca),
                datosEntidadBuilder.Build(2741, LocalidadMendoza.VistaFlores)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMendoza.Tupungato).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2742, LocalidadMendoza.Anchoris),
                datosEntidadBuilder.Build(2743, LocalidadMendoza.CordonDelPlata),
                datosEntidadBuilder.Build(2744, LocalidadMendoza.ElPeral),
                datosEntidadBuilder.Build(2745, LocalidadMendoza.ElZampal),
                datosEntidadBuilder.Build(2746, LocalidadMendoza.ElZampalito),
                datosEntidadBuilder.Build(2747, LocalidadMendoza.Gualtallary),
                datosEntidadBuilder.Build(2748, LocalidadMendoza.LaArboleda),
                datosEntidadBuilder.Build(2749, LocalidadMendoza.LaCarrera),
                datosEntidadBuilder.Build(2750, LocalidadMendoza.SanJose),
                datosEntidadBuilder.Build(2751, LocalidadMendoza.SantaClara),
                datosEntidadBuilder.Build(2752, LocalidadMendoza.Tupungato),
                datosEntidadBuilder.Build(2753, LocalidadMendoza.VillaBastias),
                datosEntidadBuilder.Build(2754, LocalidadMendoza.Zapata)
            });
        }
    }
}
