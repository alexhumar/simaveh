using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures
{
    /// <summary>
    /// Fixture con informacion de Provincias
    /// </summary>
    public class FixturePartido : IFixturePartido
    {
        private readonly IFixtureProvincia fixtureProvincia;

        private Dictionary<long, Dictionary<long, string>> Partidos => new Dictionary<long, Dictionary<long, string>>()
        {
            {
                fixtureProvincia.FindByNombre(NombreProvinciaArgentina.BuenosAires).Value.Key, new Dictionary<long, string>
                {
                    { 1, NombrePartidoBuenosAires.AdolfoAlsina },
                    { 1, NombrePartidoBuenosAires.AdolfoGonzalesChaves },
                    { 1, NombrePartidoBuenosAires.Alberti },
                    { 1, NombrePartidoBuenosAires.AlmiranteBrown },
                    { 1, NombrePartidoBuenosAires.Arrecifes },
                    { 1, NombrePartidoBuenosAires.Avellaneda },
                    { 1, NombrePartidoBuenosAires.Ayacucho },
                    { 1, NombrePartidoBuenosAires.Azul },
                    { 1, NombrePartidoBuenosAires.BahiaBlanca },
                    { 1, NombrePartidoBuenosAires.Balcarce },
                    { 1, NombrePartidoBuenosAires.Baradero },
                    { 1, NombrePartidoBuenosAires.BenitoJuarez },
                    { 1, NombrePartidoBuenosAires.Berazategui },
                    { 1, NombrePartidoBuenosAires.Berisso },
                    { 1, NombrePartidoBuenosAires.Bolivar },
                    { 1, NombrePartidoBuenosAires.Bragado },
                    { 1, NombrePartidoBuenosAires.Brandsen },
                    { 1, NombrePartidoBuenosAires.Campana },
                    { 1, NombrePartidoBuenosAires.Canuelas },
                    { 1, NombrePartidoBuenosAires.CapitanSarmiento },
                    { 1, NombrePartidoBuenosAires.CarlosCasares },
                    { 1, NombrePartidoBuenosAires.CarlosTejedor },
                    { 1, NombrePartidoBuenosAires.CarmendeAreco },
                    { 1, NombrePartidoBuenosAires.Castelli },
                    { 1, NombrePartidoBuenosAires.Chacabuco },
                    { 1, NombrePartidoBuenosAires.Chascomus },
                    { 1, NombrePartidoBuenosAires.Chivilcoy },
                    { 1, NombrePartidoBuenosAires.Colon },
                    { 1, NombrePartidoBuenosAires.CoronelDorrego },
                    { 1, NombrePartidoBuenosAires.CoronelPringles },
                    { 1, NombrePartidoBuenosAires.CoronelRosales },
                    { 1, NombrePartidoBuenosAires.CoronelSuarez },
                    { 1, NombrePartidoBuenosAires.Daireaux },
                    { 1, NombrePartidoBuenosAires.Dolores },
                    { 1, NombrePartidoBuenosAires.Ensenada },
                    { 1, NombrePartidoBuenosAires.Escobar },
                    { 1, NombrePartidoBuenosAires.EstebanEcheverria },
                    { 1, NombrePartidoBuenosAires.ExaltacionDeLaCruz },
                    { 1, NombrePartidoBuenosAires.Ezeiza },
                    { 1, NombrePartidoBuenosAires.FlorencioVarela },
                    { 1, NombrePartidoBuenosAires.FlorentinoAmeghino },
                    { 1, NombrePartidoBuenosAires.GeneralAlvarado },
                    { 1, NombrePartidoBuenosAires.GeneralAlvear },
                    { 1, NombrePartidoBuenosAires.GeneralArenales },
                    { 1, NombrePartidoBuenosAires.GeneralBelgrano },
                    { 1, NombrePartidoBuenosAires.GeneralGuido },
                    { 1, NombrePartidoBuenosAires.GeneralJuanMadariaga },
                    { 1, NombrePartidoBuenosAires.GeneralLaMadrid },
                    { 1, NombrePartidoBuenosAires.GeneralLasHeras },
                    { 1, NombrePartidoBuenosAires.GeneralLavalle },
                    { 1, NombrePartidoBuenosAires.GeneralPaz },
                    { 1, NombrePartidoBuenosAires.GeneralPinto },
                    { 1, NombrePartidoBuenosAires.GeneralPueyrredón },
                    { 1, NombrePartidoBuenosAires.GeneralRodriguez },
                    { 1, NombrePartidoBuenosAires.GeneralSanMartin },
                    { 1, NombrePartidoBuenosAires.GeneralViamonte },
                    { 1, NombrePartidoBuenosAires.GeneralVillegas },
                    { 1, NombrePartidoBuenosAires.Guamini },
                    { 1, NombrePartidoBuenosAires.HipolitoYrigoyen },
                    { 1, NombrePartidoBuenosAires.Hurlingham },
                    { 1, NombrePartidoBuenosAires.Ituzaingo },
                    { 1, NombrePartidoBuenosAires.JoseCPaz },
                    { 1, NombrePartidoBuenosAires.Junin },
                    { 1, NombrePartidoBuenosAires.LaCosta },
                    { 1, NombrePartidoBuenosAires.LaMatanza },
                    { 1, NombrePartidoBuenosAires.LaPlata },
                    { 1, NombrePartidoBuenosAires.Lanus },
                    { 1, NombrePartidoBuenosAires.Laprida },
                    { 1, NombrePartidoBuenosAires.LasFlores },
                    { 1, NombrePartidoBuenosAires.LeandroNAlem },
                    { 1, NombrePartidoBuenosAires.Lezama },
                    { 1, NombrePartidoBuenosAires.Lincoln },
                    { 1, NombrePartidoBuenosAires.Loberia },
                    { 1, NombrePartidoBuenosAires.Lobos },
                    { 1, NombrePartidoBuenosAires.LomasdeZamora },
                    { 1, NombrePartidoBuenosAires.Lujan },
                    { 1, NombrePartidoBuenosAires.Magdalena },
                    { 1, NombrePartidoBuenosAires.Maipu },
                    { 1, NombrePartidoBuenosAires.MalvinasArgentinas },
                    { 1, NombrePartidoBuenosAires.MarChiquita },
                    { 1, NombrePartidoBuenosAires.MarcosPaz },
                    { 1, NombrePartidoBuenosAires.Mercedes },
                    { 1, NombrePartidoBuenosAires.Merlo },
                    { 1, NombrePartidoBuenosAires.Monte },
                    { 1, NombrePartidoBuenosAires.MonteHermoso },
                    { 1, NombrePartidoBuenosAires.Moreno },
                    { 1, NombrePartidoBuenosAires.Moron },
                    { 1, NombrePartidoBuenosAires.Navarro },
                    { 1, NombrePartidoBuenosAires.Necochea },
                    { 1, NombrePartidoBuenosAires.NuevedeJulio },
                    { 1, NombrePartidoBuenosAires.Olavarria },
                    { 1, NombrePartidoBuenosAires.Patagones },
                    { 1, NombrePartidoBuenosAires.Pehuajo },
                    { 1, NombrePartidoBuenosAires.Pellegrini },
                    { 1, NombrePartidoBuenosAires.Pergamino },
                    { 1, NombrePartidoBuenosAires.Pila },
                    { 1, NombrePartidoBuenosAires.Pilar },
                    { 1, NombrePartidoBuenosAires.Pinamar },
                    { 1, NombrePartidoBuenosAires.PresidentePeron },
                    { 1, NombrePartidoBuenosAires.Puan },
                    { 1, NombrePartidoBuenosAires.PuntaIndio },
                    { 1, NombrePartidoBuenosAires.Quilmes },
                    { 1, NombrePartidoBuenosAires.Ramallo },
                    { 1, NombrePartidoBuenosAires.Rauch },
                    { 1, NombrePartidoBuenosAires.Rivadavia },
                    { 1, NombrePartidoBuenosAires.Rojas },
                    { 1, NombrePartidoBuenosAires.RoquePerez },
                    { 1, NombrePartidoBuenosAires.Saavedra },
                    { 1, NombrePartidoBuenosAires.Saladillo },
                    { 1, NombrePartidoBuenosAires.Salliquelo },
                    { 1, NombrePartidoBuenosAires.Salto },
                    { 1, NombrePartidoBuenosAires.SanAndresDeGiles },
                    { 1, NombrePartidoBuenosAires.SanAntonioDeAreco },
                    { 1, NombrePartidoBuenosAires.SanCayetano },
                    { 1, NombrePartidoBuenosAires.SanFernando },
                    { 1, NombrePartidoBuenosAires.SanIsidro },
                    { 1, NombrePartidoBuenosAires.SanMiguel },
                    { 1, NombrePartidoBuenosAires.SanNicolas },
                    { 1, NombrePartidoBuenosAires.SanPedro },
                    { 1, NombrePartidoBuenosAires.SanVicente },
                    { 1, NombrePartidoBuenosAires.Suipacha },
                    { 1, NombrePartidoBuenosAires.Tandil },
                    { 1, NombrePartidoBuenosAires.Tapalque },
                    { 1, NombrePartidoBuenosAires.Tigre },
                    { 1, NombrePartidoBuenosAires.Tordillo },
                    { 1, NombrePartidoBuenosAires.Tornquist },
                    { 1, NombrePartidoBuenosAires.TrenqueLauquen },
                    { 1, NombrePartidoBuenosAires.TresArroyos },
                    { 1, NombrePartidoBuenosAires.TresDeFebrero },
                    { 1, NombrePartidoBuenosAires.TresLomas },
                    { 1, NombrePartidoBuenosAires.VeinticincoDeMayo },
                    { 1, NombrePartidoBuenosAires.VicenteLopez },
                    { 1, NombrePartidoBuenosAires.VillaGesell },
                    { 1, NombrePartidoBuenosAires.Villarino },
                    { 1, NombrePartidoBuenosAires.Zarate }
                }
            }
        };

        /// <summary>
        /// Constructor
        /// </summary>
        public FixturePartido()
        {
            fixtureProvincia = new FixtureProvincia();
        }

        /// <summary>
        /// Get Provincias
        /// </summary>
        /// <returns></returns>
        public Dictionary<long, Dictionary<long, string>> GetPartidos()
        {
            return Partidos;
        }
    }
}
