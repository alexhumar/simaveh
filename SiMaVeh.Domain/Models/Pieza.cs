using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Pieza
    /// </summary>
    public class Pieza : TargetMantenimiento,
        IEntityChanger<UbicacionPieza, string, Pieza, long>
    {
        /// <summary>
        /// Ubicacion
        /// </summary>
        public virtual UbicacionPieza UbicacionPieza { get; protected set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(Pieza) ", Nombre, UbicacionPieza?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Pieza;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                    return base.Equals(obj);
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Pieza).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar ubicacion pieza
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Pieza Cambiar(UbicacionPieza entity)
        {
            if (entity != null)
            {
                UbicacionPieza = entity;
            }

            return this;
        }

        #endregion
    }
}
