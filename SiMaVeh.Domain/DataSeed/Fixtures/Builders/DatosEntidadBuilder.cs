using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Builders
{
    /// <summary>
    /// Builder de Datos Entidad
    /// </summary>
    public class DatosEntidadBuilder : IDatosEntidadBuilder
    {
        /// <summary>
        /// Build datos entidad general
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

        /// <summary>
        /// Build datos ubicacion pieza
        /// </summary>
        /// <param name="izquierda"></param>
        /// <param name="superior"></param>
        /// <returns></returns>
        public DatosUbicacionPieza Build(bool izquierda, bool superior)
        {
            return new DatosUbicacionPieza
            {
                Izquierda = izquierda,
                Superior = superior
            };
        }
    }
}
