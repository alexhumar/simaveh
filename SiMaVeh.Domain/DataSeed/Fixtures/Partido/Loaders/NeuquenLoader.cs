using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders
{
    class NeuquenLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixtureProvincia fixtureProvincia;

        public NeuquenLoader(IFixtureProvincia fixtureProvincia)
        {
            this.fixtureProvincia = fixtureProvincia;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixtureProvincia.FindByNombre(ProvinciaArgentina.Neuquen).Value.Key, new Dictionary<long, string>
            {
                { 360, PartidoNeuquen.Alumine },
                { 361, PartidoNeuquen.Anelo },
                { 362, PartidoNeuquen.CatanLil },
                { 363, PartidoNeuquen.ChosMalal },
                { 364, PartidoNeuquen.CollonCura },
                { 365, PartidoNeuquen.Confluencia },
                { 366, PartidoNeuquen.Huiliches },
                { 367, PartidoNeuquen.Lacar },
                { 368, PartidoNeuquen.Loncopue },
                { 369, PartidoNeuquen.LosLagos },
                { 370, PartidoNeuquen.Minas },
                { 371, PartidoNeuquen.Norquin },
                { 372, PartidoNeuquen.Pehuenches },
                { 373, PartidoNeuquen.PicunLeufu },
                { 374, PartidoNeuquen.Picunches },
                { 375, PartidoNeuquen.Zapala }
            });
        }
    }
}
