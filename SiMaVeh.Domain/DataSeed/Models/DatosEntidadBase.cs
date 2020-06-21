namespace SiMaVeh.Domain.DataSeed.Models
{
    /// <summary>
    /// Datos generales de entidades
    /// </summary>
    public abstract class DatosEntidadBase<T>
    {
        /// <summary>
        /// Id
        /// </summary>
        public T Id { get; set; }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion { get; set; }
    }
}
