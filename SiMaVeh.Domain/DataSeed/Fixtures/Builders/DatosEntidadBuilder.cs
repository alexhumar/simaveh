using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Builders
{
    /// <summary>
    /// Builder de Datos Entidad
    /// </summary>
    public class DatosEntidadBuilder
    {
        /// <summary>
        /// Build
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <returns></returns>
        public DatosEntidad Build(long id, string nombre, string descripcion = null)
        {
            return new DatosEntidad
            {
                Descripcion = descripcion,
                Id = id,
                Nombre = nombre
            };
        }
    }
}
