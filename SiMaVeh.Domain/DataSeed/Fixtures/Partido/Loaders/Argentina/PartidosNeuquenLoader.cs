using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosNeuquenLoader : PartidosLoader
    {
        public PartidosNeuquenLoader(IProvinciasLoader<long, long, string> provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Neuquen).Key, new Dictionary<long, string>
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
