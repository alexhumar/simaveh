using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces
{
    /// <summary>
    /// Interfaz de Datos Entidad Builder
    /// </summary>
    public interface IDatosEntidadBuilder
    {
        /// <summary>
        /// Build
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <returns></returns>
        DatosEntidad Build(long id, string nombre, string descripcion = null);
    }
}
