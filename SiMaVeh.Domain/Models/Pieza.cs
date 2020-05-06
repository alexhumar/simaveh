using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Pieza
    /// </summary>
    public class Pieza : TargetMantenimiento, IEntityChanger<UbicacionPieza, string>
    {
        /// <summary>
        /// Ubicacion
        /// </summary>
        public virtual UbicacionPieza UbicacionPieza { get; set; }

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
        public void Cambiar(UbicacionPieza entity)
        {
            if (entity != null)
                UbicacionPieza = entity;
        }

        /// <summary>
        /// Agregar ubicacion pieza
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(UbicacionPieza entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar ubicacion pieza
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(UbicacionPieza entity)
        {
            throw new System.NotSupportedException();
        }

        #endregion
    }
}
