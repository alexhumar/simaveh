using SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.TipoEntidadReparadora.Loaders
{
    class TipoEntidadReparadoraLoader : ITipoEntidadReparadoraLoader
    {
        private readonly IDictionary<long, DatosEntidad> tiposEntidadesReparadoras;

        public TipoEntidadReparadoraLoader()
        {
            tiposEntidadesReparadoras = new Dictionary<long, DatosEntidad>();

            Initialize();
        }

        public IDictionary<long, DatosEntidad> Get()
        {
            return tiposEntidadesReparadoras;
        }

        private void Initialize()
        {
            //TODO: analizar utilizar un builder para datos entidad, y considerar agregar el Id a dicho objeto,
            //y reemplazar el dictionary. ESTO SERIA A NIVEL GENERAL, PARA TODAS LAS ENTIDADES.
            tiposEntidadesReparadoras.Add(1, new DatosEntidad
            {
                Descripcion = Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.MecanicoParticular,
                Nombre = Constants.TiposEntidadReparadora.TipoEntidadReparadora.MecanicoParticular
            });
            tiposEntidadesReparadoras.Add(2, new DatosEntidad
            {
                Descripcion = Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.TallerMecanico,
                Nombre = Constants.TiposEntidadReparadora.TipoEntidadReparadora.TallerMecanico
            });
            tiposEntidadesReparadoras.Add(3, new DatosEntidad
            {
                Descripcion = Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.EstacionDeServicio,
                Nombre = Constants.TiposEntidadReparadora.TipoEntidadReparadora.EstacionDeServicio
            });
            tiposEntidadesReparadoras.Add(4, new DatosEntidad
            {
                Descripcion = Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.Lubricentro,
                Nombre = Constants.TiposEntidadReparadora.TipoEntidadReparadora.Lubricentro
            });
            tiposEntidadesReparadoras.Add(5, new DatosEntidad
            {
                Descripcion = Constants.TiposEntidadReparadora.DescripcionEntidadReparadora.Hogar,
                Nombre = Constants.TiposEntidadReparadora.TipoEntidadReparadora.Hogar
            });
        }
    }
}
