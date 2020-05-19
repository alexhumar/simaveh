using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class SantaFeLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public SantaFeLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.SantaFe).Value.Key, new Dictionary<long, string>
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
            });
        }
    }
}
