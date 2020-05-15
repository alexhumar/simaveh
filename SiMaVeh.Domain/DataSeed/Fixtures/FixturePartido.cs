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
                fixtureProvincia.FindByNombre(ProvinciaArgentina.BuenosAires).Value.Key, new Dictionary<long, string>
                {
                    { 1, PartidoBuenosAires.AdolfoAlsina },
                    { 2, PartidoBuenosAires.AdolfoGonzalesChaves },
                    { 3, PartidoBuenosAires.Alberti },
                    { 4, PartidoBuenosAires.AlmiranteBrown },
                    { 5, PartidoBuenosAires.Arrecifes },
                    { 6, PartidoBuenosAires.Avellaneda },
                    { 7, PartidoBuenosAires.Ayacucho },
                    { 8, PartidoBuenosAires.Azul },
                    { 9, PartidoBuenosAires.BahiaBlanca },
                    { 10, PartidoBuenosAires.Balcarce },
                    { 11, PartidoBuenosAires.Baradero },
                    { 12, PartidoBuenosAires.BenitoJuarez },
                    { 13, PartidoBuenosAires.Berazategui },
                    { 14, PartidoBuenosAires.Berisso },
                    { 15, PartidoBuenosAires.Bolivar },
                    { 16, PartidoBuenosAires.Bragado },
                    { 17, PartidoBuenosAires.Brandsen },
                    { 18, PartidoBuenosAires.Campana },
                    { 19, PartidoBuenosAires.Canuelas },
                    { 20, PartidoBuenosAires.CapitanSarmiento },
                    { 21, PartidoBuenosAires.CarlosCasares },
                    { 22, PartidoBuenosAires.CarlosTejedor },
                    { 23, PartidoBuenosAires.CarmendeAreco },
                    { 24, PartidoBuenosAires.Castelli },
                    { 25, PartidoBuenosAires.Chacabuco },
                    { 26, PartidoBuenosAires.Chascomus },
                    { 27, PartidoBuenosAires.Chivilcoy },
                    { 28, PartidoBuenosAires.Colon },
                    { 29, PartidoBuenosAires.CoronelDorrego },
                    { 30, PartidoBuenosAires.CoronelPringles },
                    { 31, PartidoBuenosAires.CoronelRosales },
                    { 32, PartidoBuenosAires.CoronelSuarez },
                    { 33, PartidoBuenosAires.Daireaux },
                    { 34, PartidoBuenosAires.Dolores },
                    { 35, PartidoBuenosAires.Ensenada },
                    { 36, PartidoBuenosAires.Escobar },
                    { 37, PartidoBuenosAires.EstebanEcheverria },
                    { 38, PartidoBuenosAires.ExaltacionDeLaCruz },
                    { 39, PartidoBuenosAires.Ezeiza },
                    { 40, PartidoBuenosAires.FlorencioVarela },
                    { 41, PartidoBuenosAires.FlorentinoAmeghino },
                    { 42, PartidoBuenosAires.GeneralAlvarado },
                    { 43, PartidoBuenosAires.GeneralAlvear },
                    { 44, PartidoBuenosAires.GeneralArenales },
                    { 45, PartidoBuenosAires.GeneralBelgrano },
                    { 46, PartidoBuenosAires.GeneralGuido },
                    { 47, PartidoBuenosAires.GeneralJuanMadariaga },
                    { 48, PartidoBuenosAires.GeneralLaMadrid },
                    { 49, PartidoBuenosAires.GeneralLasHeras },
                    { 50, PartidoBuenosAires.GeneralLavalle },
                    { 51, PartidoBuenosAires.GeneralPaz },
                    { 52, PartidoBuenosAires.GeneralPinto },
                    { 53, PartidoBuenosAires.GeneralPueyrredón },
                    { 54, PartidoBuenosAires.GeneralRodriguez },
                    { 55, PartidoBuenosAires.GeneralSanMartin },
                    { 56, PartidoBuenosAires.GeneralViamonte },
                    { 57, PartidoBuenosAires.GeneralVillegas },
                    { 58, PartidoBuenosAires.Guamini },
                    { 59, PartidoBuenosAires.HipolitoYrigoyen },
                    { 60, PartidoBuenosAires.Hurlingham },
                    { 61, PartidoBuenosAires.Ituzaingo },
                    { 62, PartidoBuenosAires.JoseCPaz },
                    { 63, PartidoBuenosAires.Junin },
                    { 64, PartidoBuenosAires.LaCosta },
                    { 65, PartidoBuenosAires.LaMatanza },
                    { 66, PartidoBuenosAires.LaPlata },
                    { 67, PartidoBuenosAires.Lanus },
                    { 68, PartidoBuenosAires.Laprida },
                    { 69, PartidoBuenosAires.LasFlores },
                    { 70, PartidoBuenosAires.LeandroNAlem },
                    { 71, PartidoBuenosAires.Lezama },
                    { 72, PartidoBuenosAires.Lincoln },
                    { 73, PartidoBuenosAires.Loberia },
                    { 74, PartidoBuenosAires.Lobos },
                    { 75, PartidoBuenosAires.LomasdeZamora },
                    { 76, PartidoBuenosAires.Lujan },
                    { 77, PartidoBuenosAires.Magdalena },
                    { 78, PartidoBuenosAires.Maipu },
                    { 79, PartidoBuenosAires.MalvinasArgentinas },
                    { 80, PartidoBuenosAires.MarChiquita },
                    { 81, PartidoBuenosAires.MarcosPaz },
                    { 82, PartidoBuenosAires.Mercedes },
                    { 83, PartidoBuenosAires.Merlo },
                    { 84, PartidoBuenosAires.Monte },
                    { 85, PartidoBuenosAires.MonteHermoso },
                    { 86, PartidoBuenosAires.Moreno },
                    { 87, PartidoBuenosAires.Moron },
                    { 88, PartidoBuenosAires.Navarro },
                    { 89, PartidoBuenosAires.Necochea },
                    { 90, PartidoBuenosAires.NuevedeJulio },
                    { 91, PartidoBuenosAires.Olavarria },
                    { 92, PartidoBuenosAires.Patagones },
                    { 93, PartidoBuenosAires.Pehuajo },
                    { 94, PartidoBuenosAires.Pellegrini },
                    { 95, PartidoBuenosAires.Pergamino },
                    { 96, PartidoBuenosAires.Pila },
                    { 97, PartidoBuenosAires.Pilar },
                    { 98, PartidoBuenosAires.Pinamar },
                    { 99, PartidoBuenosAires.PresidentePeron },
                    { 100, PartidoBuenosAires.Puan },
                    { 101, PartidoBuenosAires.PuntaIndio },
                    { 102, PartidoBuenosAires.Quilmes },
                    { 103, PartidoBuenosAires.Ramallo },
                    { 104, PartidoBuenosAires.Rauch },
                    { 105, PartidoBuenosAires.Rivadavia },
                    { 106, PartidoBuenosAires.Rojas },
                    { 107, PartidoBuenosAires.RoquePerez },
                    { 108, PartidoBuenosAires.Saavedra },
                    { 109, PartidoBuenosAires.Saladillo },
                    { 110, PartidoBuenosAires.Salliquelo },
                    { 111, PartidoBuenosAires.Salto },
                    { 112, PartidoBuenosAires.SanAndresDeGiles },
                    { 113, PartidoBuenosAires.SanAntonioDeAreco },
                    { 114, PartidoBuenosAires.SanCayetano },
                    { 115, PartidoBuenosAires.SanFernando },
                    { 116, PartidoBuenosAires.SanIsidro },
                    { 117, PartidoBuenosAires.SanMiguel },
                    { 118, PartidoBuenosAires.SanNicolas },
                    { 119, PartidoBuenosAires.SanPedro },
                    { 120, PartidoBuenosAires.SanVicente },
                    { 121, PartidoBuenosAires.Suipacha },
                    { 122, PartidoBuenosAires.Tandil },
                    { 123, PartidoBuenosAires.Tapalque },
                    { 124, PartidoBuenosAires.Tigre },
                    { 125, PartidoBuenosAires.Tordillo },
                    { 126, PartidoBuenosAires.Tornquist },
                    { 127, PartidoBuenosAires.TrenqueLauquen },
                    { 128, PartidoBuenosAires.TresArroyos },
                    { 129, PartidoBuenosAires.TresDeFebrero },
                    { 130, PartidoBuenosAires.TresLomas },
                    { 131, PartidoBuenosAires.VeinticincoDeMayo },
                    { 132, PartidoBuenosAires.VicenteLopez },
                    { 133, PartidoBuenosAires.VillaGesell },
                    { 134, PartidoBuenosAires.Villarino },
                    { 135, PartidoBuenosAires.Zarate }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Catamarca).Value.Key, new Dictionary<long, string>
                {
                    { 136, PartidoCatamarca.Ambato },
                    { 137, PartidoCatamarca.Ancasti },
                    { 138, PartidoCatamarca.Andalgal },
                    { 139, PartidoCatamarca.AntofagastaDeLaSierra },
                    { 140, PartidoCatamarca.Belen },
                    { 141, PartidoCatamarca.Capayan },
                    { 142, PartidoCatamarca.Capital },
                    { 143, PartidoCatamarca.ElAlto },
                    { 144, PartidoCatamarca.FrayMamertoEsquiu },
                    { 145, PartidoCatamarca.LaPaz },
                    { 146, PartidoCatamarca.Paclin },
                    { 147, PartidoCatamarca.Poman },
                    { 148, PartidoCatamarca.SantaMaria },
                    { 149, PartidoCatamarca.SantaRosa },
                    { 150, PartidoCatamarca.Tinogasta },
                    { 151, PartidoCatamarca.ValleViejo }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Chaco).Value.Key, new Dictionary<long, string>
                {
                    { 152, PartidoChaco.AlmiranteBrown },
                    { 153, PartidoChaco.Bermejo },
                    { 154, PartidoChaco.Chacabuco },
                    { 155, PartidoChaco.ComandanteFernandez },
                    { 156, PartidoChaco.DoceDeOctubre },
                    { 157, PartidoChaco.DosDeAbril },
                    { 158, PartidoChaco.FrayJustoSantaMariaDeOro },
                    { 159, PartidoChaco.GeneralBelgrano },
                    { 160, PartidoChaco.GeneralDonovan },
                    { 161, PartidoChaco.GeneralGuemes },
                    { 162, PartidoChaco.Independencia },
                    { 163, PartidoChaco.Libertad },
                    { 164, PartidoChaco.LibertadorGeneralSanMartín },
                    { 165, PartidoChaco.Maipu },
                    { 166, PartidoChaco.MayorLuisJorgeFontana },
                    { 167, PartidoChaco.NuevedeJulio },
                    { 168, PartidoChaco.OHiggins },
                    { 169, PartidoChaco.PresidenciaDeLaPlaza },
                    { 170, PartidoChaco.PrimeroDeMayo },
                    { 171, PartidoChaco.Quitilipi },
                    { 172, PartidoChaco.SanFernando },
                    { 173, PartidoChaco.SanLorenzo },
                    { 174, PartidoChaco.SargentoCabral },
                    { 175, PartidoChaco.Tapenaga },
                    { 176, PartidoChaco.VeinticincoDeMayo }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Chubut).Value.Key, new Dictionary<long, string>
                {

                    { 177, PartidoChubut.Biedma },
                    { 178, PartidoChubut.Cushamen },
                    { 179, PartidoChubut.Escalante },
                    { 180, PartidoChubut.FlorentinoAmeghino },
                    { 181, PartidoChubut.Futaleufu },
                    { 182, PartidoChubut.Gaiman },
                    { 183, PartidoChubut.Gastre },
                    { 184, PartidoChubut.Languineo },
                    { 185, PartidoChubut.Martires },
                    { 186, PartidoChubut.PasoDeIndios },
                    { 187, PartidoChubut.Rawson },
                    { 188, PartidoChubut.RioSenguer },
                    { 189, PartidoChubut.Sarmiento },
                    { 190, PartidoChubut.Tehuelches },
                    { 191, PartidoChubut.Telsen }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Cordoba).Value.Key, new Dictionary<long, string>
                {
                    { 191, PartidoCordoba.Calamuchita },
                    { 192, PartidoCordoba.Capital },
                    { 193, PartidoCordoba.Colon },
                    { 194, PartidoCordoba.CruzDelEje },
                    { 195, PartidoCordoba.GeneralRoca },
                    { 196, PartidoCordoba.GeneralSanMartin },
                    { 197, PartidoCordoba.Ischilin },
                    { 198, PartidoCordoba.JuarezCelman },
                    { 199, PartidoCordoba.MarcosJuarez },
                    { 200, PartidoCordoba.Minas },
                    { 201, PartidoCordoba.Pocho },
                    { 202, PartidoCordoba.PresidenteRoqueSaenzPena },
                    { 203, PartidoCordoba.Punilla },
                    { 204, PartidoCordoba.RioCuarto },
                    { 205, PartidoCordoba.RioPrimero },
                    { 206, PartidoCordoba.RioSeco },
                    { 207, PartidoCordoba.RioSegundo },
                    { 208, PartidoCordoba.SanAlberto },
                    { 209, PartidoCordoba.SanJavier },
                    { 210, PartidoCordoba.SanJusto },
                    { 211, PartidoCordoba.SantaMaria },
                    { 212, PartidoCordoba.Sobremonte },
                    { 213, PartidoCordoba.TerceroArriba },
                    { 214, PartidoCordoba.Totoral },
                    { 215, PartidoCordoba.Tulumba },
                    { 216, PartidoCordoba.Union }
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
