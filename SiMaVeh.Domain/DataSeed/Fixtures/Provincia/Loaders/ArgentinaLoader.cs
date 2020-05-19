using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class ArgentinaLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePais fixturePais;

        public ArgentinaLoader(IFixturePais fixturePais)
        {
            this.fixturePais = fixturePais;
        }

        public void Add(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePais.FindByNombre(Pais.Argentina).Value.Key, new Dictionary<long, string>
            {
                { 1, ProvinciaArgentina.BuenosAires },
                { 2, ProvinciaArgentina.Catamarca },
                { 3, ProvinciaArgentina.Chaco },
                { 4, ProvinciaArgentina.Chubut },
                { 5, ProvinciaArgentina.Cordoba },
                { 6, ProvinciaArgentina.Corrientes },
                { 7, ProvinciaArgentina.EntreRios },
                { 8, ProvinciaArgentina.Formosa },
                { 9, ProvinciaArgentina.Jujuy },
                { 10, ProvinciaArgentina.LaPampa },
                { 11, ProvinciaArgentina.LaRioja },
                { 12, ProvinciaArgentina.Mendoza },
                { 13, ProvinciaArgentina.Misiones },
                { 14, ProvinciaArgentina.Neuquen },
                { 15, ProvinciaArgentina.RioNegro },
                { 16, ProvinciaArgentina.Salta },
                { 17, ProvinciaArgentina.SanJuan },
                { 18, ProvinciaArgentina.SanLuis },
                { 19, ProvinciaArgentina.SantaCruz },
                { 20, ProvinciaArgentina.SantaFe },
                { 21, ProvinciaArgentina.SantiagoDelEstero },
                { 22, ProvinciaArgentina.TierraDelFuego },
                { 23, ProvinciaArgentina.Tucuman }
            });
        }
    }
}
