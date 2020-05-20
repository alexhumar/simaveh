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
            });
        }
    }
}
