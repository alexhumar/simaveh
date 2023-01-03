using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubSubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Base;
using SiMaVeh.Domain.DataSeed.Fixtures.Partido.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.FixtureGetters.Argentina
{
    public class LocalidadMisionesFixtureGetter : LocalidadFixtureGetter
    {
        public LocalidadMisionesFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder,
            IPartidoFixtureGetter partidoFixtureGetter)
            : base(datosEntidadBuilder, partidoFixtureGetter)
        {
        }

        protected override void Initialize()
        {
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Apostoles).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2755, LocalidadMisiones.Apostoles),
                datosEntidadBuilder.Build(2756, LocalidadMisiones.Azara),
                datosEntidadBuilder.Build(2757, LocalidadMisiones.SanJose),
                datosEntidadBuilder.Build(2758, LocalidadMisiones.TresCapones)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Cainguas).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2759, LocalidadMisiones.AristobuloDelValle),
                datosEntidadBuilder.Build(2760, LocalidadMisiones.DosDeMayo),
                datosEntidadBuilder.Build(2761, LocalidadMisiones.CampoGrande)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Candelaria).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2762, LocalidadMisiones.Bonpland),
                datosEntidadBuilder.Build(2763, LocalidadMisiones.Candelaria),
                datosEntidadBuilder.Build(2764, LocalidadMisiones.CerroCora),
                datosEntidadBuilder.Build(2765, LocalidadMisiones.Loreto),
                datosEntidadBuilder.Build(2766, LocalidadMisiones.Martires),
                datosEntidadBuilder.Build(2767, LocalidadMisiones.Profundidad),
                datosEntidadBuilder.Build(2768, LocalidadMisiones.SantaAna)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Capital).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2769, LocalidadMisiones.Posadas),
                datosEntidadBuilder.Build(2770, LocalidadMisiones.Garupa),
                datosEntidadBuilder.Build(2771, LocalidadMisiones.Fachinal)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Concepcion).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2772, LocalidadMisiones.ConcepcionDeLaSierra),
                datosEntidadBuilder.Build(2773, LocalidadMisiones.SantaMaria)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Eldorado).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2774, LocalidadMisiones.ColoniaDelicia),
                datosEntidadBuilder.Build(2775, LocalidadMisiones.ColoniaVictoria),
                datosEntidadBuilder.Build(2776, LocalidadMisiones.Eldorado),
                datosEntidadBuilder.Build(2777, LocalidadMisiones.NueveDeJulio),
                datosEntidadBuilder.Build(2778, LocalidadMisiones.SantiagoDeLiniers)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.GeneralManuelBelgrano).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2779, LocalidadMisiones.BernardoDeIrigoyen),
                datosEntidadBuilder.Build(2780, LocalidadMisiones.ComandanteAndresito),
                datosEntidadBuilder.Build(2781, LocalidadMisiones.SanAntonio)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Guarani).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2782, LocalidadMisiones.ElSoberbio),
                datosEntidadBuilder.Build(2783, LocalidadMisiones.SanVicente)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Iguazu).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2784, LocalidadMisiones.Wanda),
                datosEntidadBuilder.Build(2785, LocalidadMisiones.PuertoEsperanza),
                datosEntidadBuilder.Build(2786, LocalidadMisiones.PuertoIguazu),
                datosEntidadBuilder.Build(2787, LocalidadMisiones.PuertoLibertad)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.LeandroNAlem).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2788, LocalidadMisiones.Almafuerte),
                datosEntidadBuilder.Build(2789, LocalidadMisiones.ArroyoDelMedio),
                datosEntidadBuilder.Build(2790, LocalidadMisiones.CaaYari),
                datosEntidadBuilder.Build(2791, LocalidadMisiones.CerroAzul),
                datosEntidadBuilder.Build(2792, LocalidadMisiones.DosArroyos),
                datosEntidadBuilder.Build(2793, LocalidadMisiones.GobernadorLopez),
                datosEntidadBuilder.Build(2794, LocalidadMisiones.LeandroNAlem),
                datosEntidadBuilder.Build(2795, LocalidadMisiones.OlegarioVictorAndrade)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.LibertadorGeneralSanMartin).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2796, LocalidadMisiones.Capiovi),
                datosEntidadBuilder.Build(2797, LocalidadMisiones.ElAlcazar),
                datosEntidadBuilder.Build(2798, LocalidadMisiones.Garuhape),
                datosEntidadBuilder.Build(2799, LocalidadMisiones.PuertoLeoni),
                datosEntidadBuilder.Build(2800, LocalidadMisiones.PuertoRico),
                datosEntidadBuilder.Build(2801, LocalidadMisiones.RuizDeMontoya)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Montecarlo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2802, LocalidadMisiones.Caraguatay),
                datosEntidadBuilder.Build(2803, LocalidadMisiones.Montecarlo),
                datosEntidadBuilder.Build(2804, LocalidadMisiones.PuertoPiray)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.Obera).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2805, LocalidadMisiones.CampoRamon),
                datosEntidadBuilder.Build(2806, LocalidadMisiones.CampoViera),
                datosEntidadBuilder.Build(2807, LocalidadMisiones.ColoniaAlberdi),
                datosEntidadBuilder.Build(2808, LocalidadMisiones.GeneralAlvear),
                datosEntidadBuilder.Build(2809, LocalidadMisiones.Guarani),
                datosEntidadBuilder.Build(2810, LocalidadMisiones.LosHelechos),
                datosEntidadBuilder.Build(2811, LocalidadMisiones.Obera),
                datosEntidadBuilder.Build(2812, LocalidadMisiones.Panambi),
                datosEntidadBuilder.Build(2813, LocalidadMisiones.SanMartin)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.SanIgnacio).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2814, LocalidadMisiones.ColoniaPolana),
                datosEntidadBuilder.Build(2815, LocalidadMisiones.Corpus),
                datosEntidadBuilder.Build(2816, LocalidadMisiones.GeneralUrquiza),
                datosEntidadBuilder.Build(2817, LocalidadMisiones.GobernadorRoca),
                datosEntidadBuilder.Build(2818, LocalidadMisiones.HipolitoYrigoyen),
                datosEntidadBuilder.Build(2819, LocalidadMisiones.JardinAmerica),
                datosEntidadBuilder.Build(2820, LocalidadMisiones.SanIgnacio),
                datosEntidadBuilder.Build(2821, LocalidadMisiones.SantoPipo)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.SanJavier).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2822, LocalidadMisiones.FlorentinoAmeghino),
                datosEntidadBuilder.Build(2823, LocalidadMisiones.Itacaruare),
                datosEntidadBuilder.Build(2824, LocalidadMisiones.MojonGrande),
                datosEntidadBuilder.Build(2825, LocalidadMisiones.SanJavier)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.SanPedro).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2826, LocalidadMisiones.SanPedro)
            });
            localidades.Add(partidoFixtureGetter.FindByNombre(PartidoMisiones.VeinticincoDeMayo).Id, new List<DatosEntidad>
            {
                datosEntidadBuilder.Build(2827, LocalidadMisiones.AlbaPosse),
                datosEntidadBuilder.Build(2828, LocalidadMisiones.ColoniaAurora),
                datosEntidadBuilder.Build(2829, LocalidadMisiones.VeinticincoDeMayo)
            });
        }
    }
}
