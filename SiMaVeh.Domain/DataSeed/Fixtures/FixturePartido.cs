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
                    { 514, PartidoCordoba.Calamuchita },
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
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Corrientes).Value.Key, new Dictionary<long, string>
                {
                    { 217, PartidoCorientes.Capital },
                    { 218, PartidoCorientes.Goya },
                    { 219, PartidoCorientes.SantoTome },
                    { 220, PartidoCorientes.PasoDeLosLibres },
                    { 221, PartidoCorientes.CuruzuCuatia },
                    { 222, PartidoCorientes.Mercedes },
                    { 223, PartidoCorientes.BellaVista },
                    { 224, PartidoCorientes.MonteCaseros },
                    { 225, PartidoCorientes.Ituzaingo },
                    { 226, PartidoCorientes.Esquina },
                    { 227, PartidoCorientes.Lavalle },
                    { 228, PartidoCorientes.Saladas },
                    { 229, PartidoCorientes.Concepcion },
                    { 230, PartidoCorientes.SanRoque },
                    { 231, PartidoCorientes.SanLuisDelPalmar },
                    { 232, PartidoCorientes.Empedrado },
                    { 233, PartidoCorientes.GeneralPaz },
                    { 234, PartidoCorientes.SanCosme },
                    { 235, PartidoCorientes.SanMartin },
                    { 236, PartidoCorientes.SanMiguel },
                    { 237, PartidoCorientes.Mburucuya },
                    { 238, PartidoCorientes.Itati },
                    { 239, PartidoCorientes.Sauce },
                    { 240, PartidoCorientes.GeneralAlvear },
                    { 241, PartidoCorientes.BeronDeAstrada }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.EntreRios).Value.Key, new Dictionary<long, string>
                {
                    { 242, PartidoEntreRios.Colon },
                    { 243, PartidoEntreRios.Concordia },
                    { 244, PartidoEntreRios.Diamante },
                    { 245, PartidoEntreRios.Federacion },
                    { 246, PartidoEntreRios.Federal },
                    { 247, PartidoEntreRios.Feliciano },
                    { 248, PartidoEntreRios.Gualeguay },
                    { 249, PartidoEntreRios.Gualeguaychu },
                    { 250, PartidoEntreRios.IslasDelIbicuy },
                    { 251, PartidoEntreRios.LaPaz },
                    { 252, PartidoEntreRios.Nogoya },
                    { 253, PartidoEntreRios.Parana },
                    { 254, PartidoEntreRios.SanSalvador },
                    { 255, PartidoEntreRios.Tala },
                    { 256, PartidoEntreRios.Uruguay },
                    { 257, PartidoEntreRios.Victoria },
                    { 258, PartidoEntreRios.Villaguay }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Formosa).Value.Key, new Dictionary<long, string>
                {
                    { 259, PartidoFormosa.Bermejo },
                    { 260, PartidoFormosa.Formosa },
                    { 261, PartidoFormosa.Laishi },
                    { 262, PartidoFormosa.Matacos },
                    { 263, PartidoFormosa.Patino },
                    { 264, PartidoFormosa.Pilagas },
                    { 265, PartidoFormosa.Pilcomayo },
                    { 266, PartidoFormosa.Pirane },
                    { 267, PartidoFormosa.RamonLista }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Jujuy).Value.Key, new Dictionary<long, string>
                {
                    { 268, PartidoJujuy.Cochinoca },
                    { 269, PartidoJujuy.DrManuelBelgrano },
                    { 270, PartidoJujuy.ElCarmen },
                    { 271, PartidoJujuy.Humahuaca },
                    { 272, PartidoJujuy.Ledesma },
                    { 273, PartidoJujuy.Palpala },
                    { 274, PartidoJujuy.Rinconada },
                    { 275, PartidoJujuy.SanAntonio },
                    { 276, PartidoJujuy.SanPedro },
                    { 277, PartidoJujuy.SantaBarbara },
                    { 278, PartidoJujuy.SantaCatalina },
                    { 279, PartidoJujuy.Susques },
                    { 280, PartidoJujuy.Tilcara },
                    { 281, PartidoJujuy.Tumbaya },
                    { 282, PartidoJujuy.ValleGrande },
                    { 283, PartidoJujuy.Yavi }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.LaPampa).Value.Key, new Dictionary<long, string>
                {
                    { 284, PartidoLaPampa.Atreuco },
                    { 285, PartidoLaPampa.CaleuCaleu },
                    { 286, PartidoLaPampa.Capital },
                    { 287, PartidoLaPampa.Catrilo },
                    { 288, PartidoLaPampa.Chalileo },
                    { 289, PartidoLaPampa.Chapaleufu },
                    { 290, PartidoLaPampa.ChicalCo },
                    { 291, PartidoLaPampa.Conhelo },
                    { 292, PartidoLaPampa.Curaco },
                    { 293, PartidoLaPampa.Guatrache },
                    { 294, PartidoLaPampa.Hucal },
                    { 295, PartidoLaPampa.LihuelCalel },
                    { 296, PartidoLaPampa.LimayMahuida },
                    { 297, PartidoLaPampa.Loventue },
                    { 298, PartidoLaPampa.Maraco },
                    { 299, PartidoLaPampa.Puelen },
                    { 300, PartidoLaPampa.QuemuQuemu },
                    { 301, PartidoLaPampa.Rancul },
                    { 302, PartidoLaPampa.Realico },
                    { 303, PartidoLaPampa.Toay },
                    { 304, PartidoLaPampa.Trenel },
                    { 305, PartidoLaPampa.Utracan }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.LaRioja).Value.Key, new Dictionary<long, string>
                {
                    { 306, PartidoLaRioja.Arauco },
                    { 307, PartidoLaRioja.Capital },
                    { 308, PartidoLaRioja.CastroBarros },
                    { 309, PartidoLaRioja.Chamical },
                    { 310, PartidoLaRioja.Chilecito },
                    { 311, PartidoLaRioja.CoronelFelipeVarela },
                    { 312, PartidoLaRioja.Famatina },
                    { 313, PartidoLaRioja.GeneralAngelVPenaloza },
                    { 314, PartidoLaRioja.GeneralBelgrano },
                    { 315, PartidoLaRioja.GeneralJuanFacundoQuiroga },
                    { 316, PartidoLaRioja.GeneralLamadrid },
                    { 317, PartidoLaRioja.GeneralOcampo },
                    { 318, PartidoLaRioja.GeneralSanMartin },
                    { 319, PartidoLaRioja.Independencia },
                    { 320, PartidoLaRioja.RosarioVeraPenaloza },
                    { 321, PartidoLaRioja.SanBlasDeLosSauces },
                    { 322, PartidoLaRioja.Sanagasta },
                    { 323, PartidoLaRioja.Vinchina }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Mendoza).Value.Key, new Dictionary<long, string>
                {
                    { 324, PartidoMendoza.Capital },
                    { 325, PartidoMendoza.GeneralAlvear },
                    { 326, PartidoMendoza.GodoyCruz },
                    { 327, PartidoMendoza.Guaymallen },
                    { 328, PartidoMendoza.Junin },
                    { 329, PartidoMendoza.LaPaz },
                    { 330, PartidoMendoza.LasHeras },
                    { 331, PartidoMendoza.Lavalle },
                    { 332, PartidoMendoza.LujanDeCuyo },
                    { 333, PartidoMendoza.Maipu },
                    { 334, PartidoMendoza.Malargue },
                    { 335, PartidoMendoza.Rivadavia },
                    { 336, PartidoMendoza.SanCarlos },
                    { 337, PartidoMendoza.GeneralSanMartin },
                    { 338, PartidoMendoza.SanRafael },
                    { 339, PartidoMendoza.SantaRosa },
                    { 340, PartidoMendoza.Tunuyan },
                    { 341, PartidoMendoza.Tupungato }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Misiones).Value.Key, new Dictionary<long, string>
                {
                    { 342, PartidoMisiones.Apostoles },
                    { 343, PartidoMisiones.Cainguas },
                    { 344, PartidoMisiones.Candelaria },
                    { 345, PartidoMisiones.Capital },
                    { 346, PartidoMisiones.Concepcion },
                    { 347, PartidoMisiones.Eldorado },
                    { 348, PartidoMisiones.GeneralManuelBelgrano },
                    { 349, PartidoMisiones.Guarani },
                    { 350, PartidoMisiones.Iguazu },
                    { 351, PartidoMisiones.LeandroNAlem },
                    { 352, PartidoMisiones.LibertadorGeneralSanMartin },
                    { 353, PartidoMisiones.Montecarlo },
                    { 354, PartidoMisiones.Obera },
                    { 355, PartidoMisiones.SanIgnacio },
                    { 356, PartidoMisiones.SanJavier },
                    { 357, PartidoMisiones.SanPedro },
                    { 358, PartidoMisiones.VeinticincoDeMayo }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Neuquen).Value.Key, new Dictionary<long, string>
                {
                    { 359, PartidoNeuquen.Alumine },
                    { 360, PartidoNeuquen.Anelo },
                    { 361, PartidoNeuquen.CatanLil },
                    { 362, PartidoNeuquen.ChosMalal },
                    { 363, PartidoNeuquen.CollonCura },
                    { 364, PartidoNeuquen.Confluencia },
                    { 365, PartidoNeuquen.Huiliches },
                    { 366, PartidoNeuquen.Lacar },
                    { 367, PartidoNeuquen.Loncopue },
                    { 368, PartidoNeuquen.LosLagos },
                    { 369, PartidoNeuquen.Minas },
                    { 370, PartidoNeuquen.Norquin },
                    { 371, PartidoNeuquen.Pehuenches },
                    { 372, PartidoNeuquen.PicunLeufu },
                    { 373, PartidoNeuquen.Picunches },
                    { 374, PartidoNeuquen.Zapala }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.RioNegro).Value.Key, new Dictionary<long, string>
                {
                    { 375, PartidoRioNegro.AdolfoAlsina },
                    { 376, PartidoRioNegro.Avellaneda },
                    { 377, PartidoRioNegro.Bariloche },
                    { 378, PartidoRioNegro.Conesa },
                    { 379, PartidoRioNegro.ElCuy },
                    { 380, PartidoRioNegro.GeneralRoca },
                    { 381, PartidoRioNegro.NueveDeJulio },
                    { 382, PartidoRioNegro.Norquinco },
                    { 383, PartidoRioNegro.PichiMahuida },
                    { 384, PartidoRioNegro.Pilcaniyeu },
                    { 385, PartidoRioNegro.SanAntonio },
                    { 386, PartidoRioNegro.Valcheta },
                    { 387, PartidoRioNegro.VeinticincoDeMayo }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Salta).Value.Key, new Dictionary<long, string>
                {
                    { 388, PartidoSalta.Anta },
                    { 389, PartidoSalta.Cachi },
                    { 390, PartidoSalta.Cafayate },
                    { 391, PartidoSalta.Capital },
                    { 392, PartidoSalta.Cerrillos },
                    { 393, PartidoSalta.Chicoana },
                    { 394, PartidoSalta.GeneralGuemes },
                    { 395, PartidoSalta.GeneralJoseDeSanMartin },
                    { 396, PartidoSalta.Guachipas },
                    { 397, PartidoSalta.Iruya },
                    { 398, PartidoSalta.LaCaldera },
                    { 399, PartidoSalta.LaCandelaria },
                    { 400, PartidoSalta.LaPoma },
                    { 401, PartidoSalta.LaVina },
                    { 402, PartidoSalta.LosAndes },
                    { 403, PartidoSalta.Metan },
                    { 404, PartidoSalta.Molinos },
                    { 405, PartidoSalta.Oran },
                    { 406, PartidoSalta.Rivadavia },
                    { 407, PartidoSalta.RosarioDeLaFrontera },
                    { 408, PartidoSalta.RosarioDeLerma },
                    { 409, PartidoSalta.SanCarlos },
                    { 410, PartidoSalta.SantaVictoria }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.SanJuan).Value.Key, new Dictionary<long, string>
                {
                    { 411, PartidoSanJuan.Albardon },
                    { 412, PartidoSanJuan.Angaco },
                    { 413, PartidoSanJuan.Calingasta },
                    { 414, PartidoSanJuan.Capital },
                    { 415, PartidoSanJuan.Caucete },
                    { 416, PartidoSanJuan.Chimbas },
                    { 417, PartidoSanJuan.Iglesia },
                    { 418, PartidoSanJuan.Jachal },
                    { 419, PartidoSanJuan.NueveDeJulio },
                    { 420, PartidoSanJuan.Pocito },
                    { 421, PartidoSanJuan.Rawson },
                    { 422, PartidoSanJuan.Rivadavia },
                    { 423, PartidoSanJuan.SanMartin },
                    { 424, PartidoSanJuan.SantaLucia },
                    { 425, PartidoSanJuan.Sarmiento },
                    { 426, PartidoSanJuan.Ullum },
                    { 427, PartidoSanJuan.ValleFertil },
                    { 428, PartidoSanJuan.VeinticincoDeMayo },
                    { 429, PartidoSanJuan.Zonda }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.SanLuis).Value.Key, new Dictionary<long, string>
                {
                    { 430, PartidoSanLuis.Pueyrredon },
                    { 431, PartidoSanLuis.Pedernera },
                    { 432, PartidoSanLuis.Junin },
                    { 433, PartidoSanLuis.Chacabuco },
                    { 434, PartidoSanLuis.Ayacucho },
                    { 435, PartidoSanLuis.CoronelPringles },
                    { 436, PartidoSanLuis.GobernadorDupuy },
                    { 437, PartidoSanLuis.LibertadorGeneralSanMartin },
                    { 438, PartidoSanLuis.Belgrano }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.SantaCruz).Value.Key, new Dictionary<long, string>
                {
                    { 439, PartidoSantaCruz.Deseado },
                    { 440, PartidoSantaCruz.GuerAike },
                    { 441, PartidoSantaCruz.LagoArgentino },
                    { 442, PartidoSantaCruz.CorpenAike },
                    { 443, PartidoSantaCruz.Magallanes },
                    { 444, PartidoSantaCruz.LagoBuenosAires },
                    { 445, PartidoSantaCruz.RioChico }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.SantaFe).Value.Key, new Dictionary<long, string>
                {
                    { 446, PartidoSantaFe.Rosario },
                    { 447, PartidoSantaFe.LaCapital },
                    { 448, PartidoSantaFe.GeneralLopez },
                    { 449, PartidoSantaFe.Castellanos },
                    { 450, PartidoSantaFe.GeneralObligado },
                    { 451, PartidoSantaFe.SanLorenzo },
                    { 452, PartidoSantaFe.LasColonias },
                    { 453, PartidoSantaFe.Constitucion },
                    { 454, PartidoSantaFe.Caseros },
                    { 455, PartidoSantaFe.SanJeronimo },
                    { 456, PartidoSantaFe.SanCristobal },
                    { 457, PartidoSantaFe.Iriondo },
                    { 458, PartidoSantaFe.SanMartin },
                    { 459, PartidoSantaFe.Vera },
                    { 460, PartidoSantaFe.Belgrano },
                    { 461, PartidoSantaFe.SanJusto },
                    { 462, PartidoSantaFe.SanJavier },
                    { 463, PartidoSantaFe.NueveDeJulio },
                    { 464, PartidoSantaFe.Garay }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.SantiagoDelEstero).Value.Key, new Dictionary<long, string>
                {
                    { 465, PartidoSantiagoDelEstero.Aguirre },
                    { 466, PartidoSantiagoDelEstero.Alberdi },
                    { 467, PartidoSantiagoDelEstero.Atamisqui },
                    { 468, PartidoSantiagoDelEstero.Avellaneda },
                    { 469, PartidoSantiagoDelEstero.Banda },
                    { 470, PartidoSantiagoDelEstero.Belgrano },
                    { 471, PartidoSantiagoDelEstero.Capital },
                    { 472, PartidoSantiagoDelEstero.Choya },
                    { 473, PartidoSantiagoDelEstero.Copo },
                    { 474, PartidoSantiagoDelEstero.Figueroa },
                    { 475, PartidoSantiagoDelEstero.GeneralTaboada },
                    { 476, PartidoSantiagoDelEstero.Guasayan },
                    { 477, PartidoSantiagoDelEstero.Jimenez },
                    { 478, PartidoSantiagoDelEstero.JuanFelipeIbarra },
                    { 479, PartidoSantiagoDelEstero.Loreto },
                    { 480, PartidoSantiagoDelEstero.Mitre },
                    { 481, PartidoSantiagoDelEstero.Moreno },
                    { 482, PartidoSantiagoDelEstero.OjoDeAgua },
                    { 483, PartidoSantiagoDelEstero.Pellegrini },
                    { 484, PartidoSantiagoDelEstero.Quebrachos },
                    { 485, PartidoSantiagoDelEstero.RioHondo },
                    { 486, PartidoSantiagoDelEstero.Rivadavia },
                    { 487, PartidoSantiagoDelEstero.Robles },
                    { 488, PartidoSantiagoDelEstero.Salavina },
                    { 489, PartidoSantiagoDelEstero.SanMartin },
                    { 490, PartidoSantiagoDelEstero.Sarmiento },
                    { 491, PartidoSantiagoDelEstero.Silipica }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.TierraDelFuego).Value.Key, new Dictionary<long, string>
                {
                    { 492, PartidoTierraDelFuego.AntartidaArgentina },
                    { 493, PartidoTierraDelFuego.IslasDelAtlanticoSur },
                    { 494, PartidoTierraDelFuego.RioGrande },
                    { 495, PartidoTierraDelFuego.Tolhuin },
                    { 496, PartidoTierraDelFuego.Ushuaia }
                }
            },
            {
                fixtureProvincia.FindByNombre(ProvinciaArgentina.Tucuman).Value.Key, new Dictionary<long, string>
                {
                    { 497, PartidoTucuman.Burruyacu },
                    { 498, PartidoTucuman.Capital },
                    { 499, PartidoTucuman.Chicligasta },
                    { 500, PartidoTucuman.CruzAlta },
                    { 501, PartidoTucuman.Famailla },
                    { 502, PartidoTucuman.Graneros },
                    { 503, PartidoTucuman.JuanBautistaAlberdi },
                    { 504, PartidoTucuman.LaCocha },
                    { 505, PartidoTucuman.Leales },
                    { 506, PartidoTucuman.Lules },
                    { 507, PartidoTucuman.Monteros },
                    { 508, PartidoTucuman.RioChico },
                    { 509, PartidoTucuman.Simoca },
                    { 510, PartidoTucuman.TafiDelValle },
                    { 511, PartidoTucuman.TafiViejo },
                    { 512, PartidoTucuman.Trancas },
                    { 513, PartidoTucuman.YerbaBuena }
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
