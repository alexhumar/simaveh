using System.Text;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Ubicacion Pieza
    /// </summary>
    public class UbicacionPieza : DomainMember<long>
    {
        /// <summary>
        /// True -> Izquierda. False -> Derecha.
        /// </summary>
        public virtual bool Izquierda { get; set; }

        /// <summary>
        /// True -> Superior. False -> Inferior.
        /// </summary>
        public virtual bool Superior { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(Superior ? "(Superior, " : "(Inferior, ");
            sb.Append(Izquierda ? "Izquierda)" : "Derecha)");

            return sb.ToString();
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as UbicacionPieza;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) || (Izquierda == item.Izquierda && Superior == item.Superior);
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(UbicacionPieza).FullName, Id.ToString()).GetHashCode();
        }

        #endregion
    }
}
