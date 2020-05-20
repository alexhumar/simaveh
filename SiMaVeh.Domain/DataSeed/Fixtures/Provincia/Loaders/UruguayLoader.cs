using SiMaVeh.Domain.DataSeed.Constants;
using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class UruguayLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePais fixturePais;

        public UruguayLoader(IFixturePais fixturePais)
        {
            this.fixturePais = fixturePais;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePais.FindByNombre(Pais.Uruguay).Value.Key, new Dictionary<long, string>
            {
                { 24, ProvinciaUruguay.Artigas },
                { 25, ProvinciaUruguay.Canelones },
                { 26, ProvinciaUruguay.CerroLargo },
                { 27, ProvinciaUruguay.Colonia },
                { 28, ProvinciaUruguay.Durazno },
                { 29, ProvinciaUruguay.Flores },
                { 30, ProvinciaUruguay.Florida },
                { 31, ProvinciaUruguay.Lavalleja },
                { 32, ProvinciaUruguay.Maldonado },
                { 33, ProvinciaUruguay.Montevideo },
                { 34, ProvinciaUruguay.Paysandú },
                { 35, ProvinciaUruguay.RioNegro },
                { 36, ProvinciaUruguay.Rivera },
                { 37, ProvinciaUruguay.Rocha },
                { 38, ProvinciaUruguay.Salto },
                { 39, ProvinciaUruguay.SanJose },
                { 40, ProvinciaUruguay.Soriano },
                { 41, ProvinciaUruguay.Tacuarembó },
                { 42, ProvinciaUruguay.TreintaYTres }
            });
        }
    }
}
