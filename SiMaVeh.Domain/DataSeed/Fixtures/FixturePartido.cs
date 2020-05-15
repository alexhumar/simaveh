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
                    { 2, NombrePartidoBuenosAires.AdolfoGonzalesChaves },
                    { 3, NombrePartidoBuenosAires.Alberti },
                    { 4, NombrePartidoBuenosAires.AlmiranteBrown },
                    { 5, NombrePartidoBuenosAires.Arrecifes },
                    { 6, NombrePartidoBuenosAires.Avellaneda },
                    { 7, NombrePartidoBuenosAires.Ayacucho },
                    { 8, NombrePartidoBuenosAires.Azul },
                    { 9, NombrePartidoBuenosAires.BahiaBlanca },
                    { 10, NombrePartidoBuenosAires.Balcarce },
                    { 11, NombrePartidoBuenosAires.Baradero },
                    { 12, NombrePartidoBuenosAires.BenitoJuarez },
                    { 13, NombrePartidoBuenosAires.Berazategui },
                    { 14, NombrePartidoBuenosAires.Berisso },
                    { 15, NombrePartidoBuenosAires.Bolivar },
                    { 16, NombrePartidoBuenosAires.Bragado },
                    { 17, NombrePartidoBuenosAires.Brandsen },
                    { 18, NombrePartidoBuenosAires.Campana },
                    { 19, NombrePartidoBuenosAires.Canuelas },
                    { 20, NombrePartidoBuenosAires.CapitanSarmiento },
                    { 21, NombrePartidoBuenosAires.CarlosCasares },
                    { 22, NombrePartidoBuenosAires.CarlosTejedor },
                    { 23, NombrePartidoBuenosAires.CarmendeAreco },
                    { 24, NombrePartidoBuenosAires.Castelli },
                    { 25, NombrePartidoBuenosAires.Chacabuco },
                    { 26, NombrePartidoBuenosAires.Chascomus },
                    { 27, NombrePartidoBuenosAires.Chivilcoy },
                    { 28, NombrePartidoBuenosAires.Colon },
                    { 29, NombrePartidoBuenosAires.CoronelDorrego },
                    { 30, NombrePartidoBuenosAires.CoronelPringles },
                    { 31, NombrePartidoBuenosAires.CoronelRosales },
                    { 32, NombrePartidoBuenosAires.CoronelSuarez },
                    { 33, NombrePartidoBuenosAires.Daireaux },
                    { 34, NombrePartidoBuenosAires.Dolores },
                    { 35, NombrePartidoBuenosAires.Ensenada },
                    { 36, NombrePartidoBuenosAires.Escobar },
                    { 37, NombrePartidoBuenosAires.EstebanEcheverria },
                    { 38, NombrePartidoBuenosAires.ExaltacionDeLaCruz },
                    { 39, NombrePartidoBuenosAires.Ezeiza },
                    { 40, NombrePartidoBuenosAires.FlorencioVarela },
                    { 41, NombrePartidoBuenosAires.FlorentinoAmeghino },
                    { 42, NombrePartidoBuenosAires.GeneralAlvarado },
                    { 43, NombrePartidoBuenosAires.GeneralAlvear },
                    { 44, NombrePartidoBuenosAires.GeneralArenales },
                    { 45, NombrePartidoBuenosAires.GeneralBelgrano },
                    { 46, NombrePartidoBuenosAires.GeneralGuido },
                    { 47, NombrePartidoBuenosAires.GeneralJuanMadariaga },
                    { 48, NombrePartidoBuenosAires.GeneralLaMadrid },
                    { 49, NombrePartidoBuenosAires.GeneralLasHeras },
                    { 50, NombrePartidoBuenosAires.GeneralLavalle },
                    { 51, NombrePartidoBuenosAires.GeneralPaz },
                    { 52, NombrePartidoBuenosAires.GeneralPinto },
                    { 53, NombrePartidoBuenosAires.GeneralPueyrredón },
                    { 54, NombrePartidoBuenosAires.GeneralRodriguez },
                    { 55, NombrePartidoBuenosAires.GeneralSanMartin },
                    { 56, NombrePartidoBuenosAires.GeneralViamonte },
                    { 57, NombrePartidoBuenosAires.GeneralVillegas },
                    { 58, NombrePartidoBuenosAires.Guamini },
                    { 59, NombrePartidoBuenosAires.HipolitoYrigoyen },
                    { 60, NombrePartidoBuenosAires.Hurlingham },
                    { 61, NombrePartidoBuenosAires.Ituzaingo },
                    { 62, NombrePartidoBuenosAires.JoseCPaz },
                    { 63, NombrePartidoBuenosAires.Junin },
                    { 64, NombrePartidoBuenosAires.LaCosta },
                    { 65, NombrePartidoBuenosAires.LaMatanza },
                    { 66, NombrePartidoBuenosAires.LaPlata },
                    { 67, NombrePartidoBuenosAires.Lanus },
                    { 68, NombrePartidoBuenosAires.Laprida },
                    { 69, NombrePartidoBuenosAires.LasFlores },
                    { 70, NombrePartidoBuenosAires.LeandroNAlem },
                    { 71, NombrePartidoBuenosAires.Lezama },
                    { 72, NombrePartidoBuenosAires.Lincoln },
                    { 73, NombrePartidoBuenosAires.Loberia },
                    { 74, NombrePartidoBuenosAires.Lobos },
                    { 75, NombrePartidoBuenosAires.LomasdeZamora },
                    { 76, NombrePartidoBuenosAires.Lujan },
                    { 77, NombrePartidoBuenosAires.Magdalena },
                    { 78, NombrePartidoBuenosAires.Maipu },
                    { 79, NombrePartidoBuenosAires.MalvinasArgentinas },
                    { 80, NombrePartidoBuenosAires.MarChiquita },
                    { 81, NombrePartidoBuenosAires.MarcosPaz },
                    { 82, NombrePartidoBuenosAires.Mercedes },
                    { 83, NombrePartidoBuenosAires.Merlo },
                    { 84, NombrePartidoBuenosAires.Monte },
                    { 85, NombrePartidoBuenosAires.MonteHermoso },
                    { 86, NombrePartidoBuenosAires.Moreno },
                    { 87, NombrePartidoBuenosAires.Moron },
                    { 88, NombrePartidoBuenosAires.Navarro },
                    { 89, NombrePartidoBuenosAires.Necochea },
                    { 90, NombrePartidoBuenosAires.NuevedeJulio },
                    { 91, NombrePartidoBuenosAires.Olavarria },
                    { 92, NombrePartidoBuenosAires.Patagones },
                    { 93, NombrePartidoBuenosAires.Pehuajo },
                    { 94, NombrePartidoBuenosAires.Pellegrini },
                    { 95, NombrePartidoBuenosAires.Pergamino },
                    { 96, NombrePartidoBuenosAires.Pila },
                    { 97, NombrePartidoBuenosAires.Pilar },
                    { 98, NombrePartidoBuenosAires.Pinamar },
                    { 99, NombrePartidoBuenosAires.PresidentePeron },
                    { 100, NombrePartidoBuenosAires.Puan },
                    { 101, NombrePartidoBuenosAires.PuntaIndio },
                    { 102, NombrePartidoBuenosAires.Quilmes },
                    { 103, NombrePartidoBuenosAires.Ramallo },
                    { 104, NombrePartidoBuenosAires.Rauch },
                    { 105, NombrePartidoBuenosAires.Rivadavia },
                    { 106, NombrePartidoBuenosAires.Rojas },
                    { 107, NombrePartidoBuenosAires.RoquePerez },
                    { 108, NombrePartidoBuenosAires.Saavedra },
                    { 109, NombrePartidoBuenosAires.Saladillo },
                    { 110, NombrePartidoBuenosAires.Salliquelo },
                    { 111, NombrePartidoBuenosAires.Salto },
                    { 112, NombrePartidoBuenosAires.SanAndresDeGiles },
                    { 113, NombrePartidoBuenosAires.SanAntonioDeAreco },
                    { 114, NombrePartidoBuenosAires.SanCayetano },
                    { 115, NombrePartidoBuenosAires.SanFernando },
                    { 116, NombrePartidoBuenosAires.SanIsidro },
                    { 117, NombrePartidoBuenosAires.SanMiguel },
                    { 118, NombrePartidoBuenosAires.SanNicolas },
                    { 119, NombrePartidoBuenosAires.SanPedro },
                    { 120, NombrePartidoBuenosAires.SanVicente },
                    { 121, NombrePartidoBuenosAires.Suipacha },
                    { 122, NombrePartidoBuenosAires.Tandil },
                    { 123, NombrePartidoBuenosAires.Tapalque },
                    { 124, NombrePartidoBuenosAires.Tigre },
                    { 125, NombrePartidoBuenosAires.Tordillo },
                    { 126, NombrePartidoBuenosAires.Tornquist },
                    { 127, NombrePartidoBuenosAires.TrenqueLauquen },
                    { 128, NombrePartidoBuenosAires.TresArroyos },
                    { 129, NombrePartidoBuenosAires.TresDeFebrero },
                    { 130, NombrePartidoBuenosAires.TresLomas },
                    { 131, NombrePartidoBuenosAires.VeinticincoDeMayo },
                    { 132, NombrePartidoBuenosAires.VicenteLopez },
                    { 133, NombrePartidoBuenosAires.VillaGesell },
                    { 134, NombrePartidoBuenosAires.Villarino },
                    { 135, NombrePartidoBuenosAires.Zarate }
                }
            },
            {
                fixtureProvincia.FindByNombre(NombreProvinciaArgentina.Catamarca).Value.Key, new Dictionary<long, string>
                {
                    { 136, NombrePartidoCatamarca.Ambato },
                    { 137, NombrePartidoCatamarca.Ancasti },
                    { 138, NombrePartidoCatamarca.Andalgal },
                    { 139, NombrePartidoCatamarca.AntofagastaDeLaSierra },
                    { 140, NombrePartidoCatamarca.Belen },
                    { 141, NombrePartidoCatamarca.Capayan },
                    { 142, NombrePartidoCatamarca.Capital },
                    { 143, NombrePartidoCatamarca.ElAlto },
                    { 144, NombrePartidoCatamarca.FrayMamertoEsquiu },
                    { 145, NombrePartidoCatamarca.LaPaz },
                    { 146, NombrePartidoCatamarca.Paclin },
                    { 147, NombrePartidoCatamarca.Poman },
                    { 148, NombrePartidoCatamarca.SantaMaria },
                    { 149, NombrePartidoCatamarca.SantaRosa },
                    { 150, NombrePartidoCatamarca.Tinogasta },
                    { 151, NombrePartidoCatamarca.ValleViejo }
                }
            },
            {
                fixtureProvincia.FindByNombre(NombreProvinciaArgentina.Chaco).Value.Key, new Dictionary<long, string>
                {
                    { 152, NombrePartidoChaco.AlmiranteBrown },
                    { 153, NombrePartidoChaco.Bermejo },
                    { 154, NombrePartidoChaco.Chacabuco },
                    { 155, NombrePartidoChaco.ComandanteFernandez },
                    { 156, NombrePartidoChaco.DoceDeOctubre },
                    { 157, NombrePartidoChaco.DosDeAbril },
                    { 158, NombrePartidoChaco.FrayJustoSantaMariaDeOro },
                    { 159, NombrePartidoChaco.GeneralBelgrano },
                    { 160, NombrePartidoChaco.GeneralDonovan },
                    { 161, NombrePartidoChaco.GeneralGuemes },
                    { 162, NombrePartidoChaco.Independencia },
                    { 163, NombrePartidoChaco.Libertad },
                    { 164, NombrePartidoChaco.LibertadorGeneralSanMartín },
                    { 165, NombrePartidoChaco.Maipu },
                    { 166, NombrePartidoChaco.MayorLuisJorgeFontana },
                    { 167, NombrePartidoChaco.NuevedeJulio },
                    { 168, NombrePartidoChaco.OHiggins },
                    { 169, NombrePartidoChaco.PresidenciaDeLaPlaza },
                    { 170, NombrePartidoChaco.PrimeroDeMayo },
                    { 171, NombrePartidoChaco.Quitilipi },
                    { 172, NombrePartidoChaco.SanFernando },
                    { 173, NombrePartidoChaco.SanLorenzo },
                    { 174, NombrePartidoChaco.SargentoCabral },
                    { 175, NombrePartidoChaco.Tapenaga },
                    { 176, NombrePartidoChaco.VeinticincoDeMayo }
                }
            },
            {
                fixtureProvincia.FindByNombre(NombreProvinciaArgentina.Chubut).Value.Key, new Dictionary<long, string>
                {

                    { 177, NombrePartidoChubut.Biedma },
                    { 178, NombrePartidoChubut.Cushamen },
                    { 179, NombrePartidoChubut.Escalante },
                    { 180, NombrePartidoChubut.FlorentinoAmeghino },
                    { 181, NombrePartidoChubut.Futaleufu },
                    { 182, NombrePartidoChubut.Gaiman },
                    { 183, NombrePartidoChubut.Gastre },
                    { 184, NombrePartidoChubut.Languineo },
                    { 185, NombrePartidoChubut.Martires },
                    { 186, NombrePartidoChubut.PasoDeIndios },
                    { 187, NombrePartidoChubut.Rawson },
                    { 188, NombrePartidoChubut.RioSenguer },
                    { 189, NombrePartidoChubut.Sarmiento },
                    { 190, NombrePartidoChubut.Tehuelches },
                    { 191, NombrePartidoChubut.Telsen }
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
