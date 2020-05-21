﻿using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class BuenosAiresLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public BuenosAiresLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.BuenosAires).Value.Key, new Dictionary<long, string>
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
                { 23, PartidoBuenosAires.CarmenDeAreco },
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
                { 53, PartidoBuenosAires.GeneralPueyrredon },
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
                { 75, PartidoBuenosAires.LomasDeZamora },
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
                { 90, PartidoBuenosAires.NueveDeJulio },
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
            });
        }
    }
}
