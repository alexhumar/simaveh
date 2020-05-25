using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    class MisionesLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public MisionesLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Apostoles).Value.Key, new Dictionary<long, string>
            {
                { 2755, LocalidadMisiones.Apostoles },
                { 2756, LocalidadMisiones.Azara },
                { 2757, LocalidadMisiones.SanJose },
                { 2758, LocalidadMisiones.TresCapones }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Cainguas).Value.Key, new Dictionary<long, string>
            {
                { 2759, LocalidadMisiones.AristobuloDelValle },
                { 2760, LocalidadMisiones.DosDeMayo },
                { 2761, LocalidadMisiones.CampoGrande }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Candelaria).Value.Key, new Dictionary<long, string>
            {
                { 2762, LocalidadMisiones.Bonpland },
                { 2763, LocalidadMisiones.Candelaria },
                { 2764, LocalidadMisiones.CerroCora },
                { 2765, LocalidadMisiones.Loreto },
                { 2766, LocalidadMisiones.Martires },
                { 2767, LocalidadMisiones.Profundidad },
                { 2768, LocalidadMisiones.SantaAna }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Capital).Value.Key, new Dictionary<long, string>
            {
                { 2769, LocalidadMisiones.Posadas },
                { 2770, LocalidadMisiones.Garupa },
                { 2771, LocalidadMisiones.Fachinal }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Concepcion).Value.Key, new Dictionary<long, string>
            {
                { 2772, LocalidadMisiones.ConcepcionDeLaSierra },
                { 2773, LocalidadMisiones.SantaMaria }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Eldorado).Value.Key, new Dictionary<long, string>
            {
                { 2774, LocalidadMisiones.ColoniaDelicia },
                { 2775, LocalidadMisiones.ColoniaVictoria },
                { 2776, LocalidadMisiones.Eldorado },
                { 2777, LocalidadMisiones.NueveDeJulio },
                { 2778, LocalidadMisiones.SantiagoDeLiniers }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.GeneralManuelBelgrano).Value.Key, new Dictionary<long, string>
            {
                { 2779, LocalidadMisiones.BernardoDeIrigoyen },
                { 2780, LocalidadMisiones.ComandanteAndresito },
                { 2781, LocalidadMisiones.SanAntonio }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Guarani).Value.Key, new Dictionary<long, string>
            {
                { 2782, LocalidadMisiones.ElSoberbio },
                { 2783, LocalidadMisiones.SanVicente }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Iguazu).Value.Key, new Dictionary<long, string>
            {
                { 2784, LocalidadMisiones.Wanda },
                { 2785, LocalidadMisiones.PuertoEsperanza },
                { 2786, LocalidadMisiones.PuertoIguazu },
                { 2787, LocalidadMisiones.PuertoLibertad }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.LeandroNAlem).Value.Key, new Dictionary<long, string>
            {
                { 2788, LocalidadMisiones.Almafuerte },
                { 2789, LocalidadMisiones.ArroyoDelMedio },
                { 2790, LocalidadMisiones.CaaYari },
                { 2791, LocalidadMisiones.CerroAzul },
                { 2792, LocalidadMisiones.DosArroyos },
                { 2793, LocalidadMisiones.GobernadorLopez },
                { 2794, LocalidadMisiones.LeandroNAlem },
                { 2795, LocalidadMisiones.OlegarioVictorAndrade }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.LibertadorGeneralSanMartin).Value.Key, new Dictionary<long, string>
            {
                { 2796, LocalidadMisiones.Capiovi },
                { 2797, LocalidadMisiones.ElAlcazar },
                { 2798, LocalidadMisiones.Garuhape },
                { 2799, LocalidadMisiones.PuertoLeoni },
                { 2800, LocalidadMisiones.PuertoRico },
                { 2801, LocalidadMisiones.RuizDeMontoya }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Montecarlo).Value.Key, new Dictionary<long, string>
            {
                { 2802, LocalidadMisiones.Caraguatay },
                { 2803, LocalidadMisiones.Montecarlo },
                { 2804, LocalidadMisiones.PuertoPiray }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.Obera).Value.Key, new Dictionary<long, string>
            {
                { 2805, LocalidadMisiones.CampoRamon },
                { 2806, LocalidadMisiones.CampoViera },
                { 2807, LocalidadMisiones.ColoniaAlberdi },
                { 2808, LocalidadMisiones.GeneralAlvear },
                { 2809, LocalidadMisiones.Guarani },
                { 2810, LocalidadMisiones.LosHelechos },
                { 2811, LocalidadMisiones.Obera },
                { 2812, LocalidadMisiones.Panambi },
                { 2813, LocalidadMisiones.SanMartin }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.SanIgnacio).Value.Key, new Dictionary<long, string>
            {
                { 2814, LocalidadMisiones.ColoniaPolana },
                { 2815, LocalidadMisiones.Corpus },
                { 2816, LocalidadMisiones.GeneralUrquiza },
                { 2817, LocalidadMisiones.GobernadorRoca },
                { 2818, LocalidadMisiones.HipolitoYrigoyen },
                { 2819, LocalidadMisiones.JardinAmerica },
                { 2820, LocalidadMisiones.SanIgnacio },
                { 2821, LocalidadMisiones.SantoPipo }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.SanJavier).Value.Key, new Dictionary<long, string>
            {
                { 2822, LocalidadMisiones.FlorentinoAmeghino },
                { 2823, LocalidadMisiones.Itacaruare },
                { 2824, LocalidadMisiones.MojonGrande },
                { 2825, LocalidadMisiones.SanJavier }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.SanPedro).Value.Key, new Dictionary<long, string>
            {
                { 2826, LocalidadMisiones.SanPedro }
            });
            dictionary.Add(fixturePartido.FindByNombre(PartidoMisiones.VeinticincoDeMayo).Value.Key, new Dictionary<long, string>
            {
                { 2827, LocalidadMisiones.AlbaPosse },
                { 2828, LocalidadMisiones.ColoniaAurora },
                { 2829, LocalidadMisiones.VeinticincoDeMayo }
            });
        }
    }
}
