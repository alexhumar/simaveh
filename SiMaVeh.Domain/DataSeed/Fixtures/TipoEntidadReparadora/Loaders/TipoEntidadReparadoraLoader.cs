using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Loaders
{
    class TipoEntidadReparadoraLoader : ITipoEntidadReparadoraLoader
    {
        private readonly IDictionary<long, string> tiposEntidadesReparadoras;

        public TipoEntidadReparadoraLoader()
        {
            tiposEntidadesReparadoras = new Dictionary<long, string>();

            Initialize();
        }

        public IDictionary<long, string> Get()
        {
            return tiposEntidadesReparadoras;
        }

        public KeyValuePair<long, string> FindByNombre(string nombre)
        {
            return tiposEntidadesReparadoras.FirstOrDefault(p => p.Value == nombre);
        }

        private void Initialize()
        {
            tiposEntidadesReparadoras.Add(1, Constants.TipoEntidadReparadora.MecanicoParticular);
            tiposEntidadesReparadoras.Add(2, Constants.TipoEntidadReparadora.TallerMecanico);
            tiposEntidadesReparadoras.Add(3, Constants.TipoEntidadReparadora.EstacionDeServicio);
            tiposEntidadesReparadoras.Add(4, Constants.TipoEntidadReparadora.Lubricentro);
            tiposEntidadesReparadoras.Add(5, Constants.TipoEntidadReparadora.Hogar);
        }
    }
}
