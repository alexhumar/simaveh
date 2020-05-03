using System.Text;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Equipamiento Airbags
    /// </summary>
    public class EquipamientoAirbags : DomainMember<long>
    {
        /// <summary>
        /// Airbag en Volante
        /// </summary>
        public virtual bool Volante { get; set; }

        /// <summary>
        /// Airbag en Guantera
        /// </summary>
        public virtual bool Guantera { get; set; }

        /// <summary>
        /// Delantero Izquierdo
        /// </summary>
        public virtual bool DelanteroIzquierdo { get; set; }

        /// <summary>
        /// Delantero Derecho
        /// </summary>
        public virtual bool DelanteroDerecho { get; set; }

        /// <summary>
        /// Trasero Izquierdo
        /// </summary>
        public virtual bool TraseroIzquierdo { get; set; }

        /// <summary>
        /// Trasero Derecho
        /// </summary>
        public virtual bool TraseroDerecho { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var ubicaciones = "(V,G,DI,DD,TI,TD)";
            var sb = new StringBuilder();

            sb.Append(Volante ? "(S," : "(N,");
            sb.Append(Guantera ? "S," : "N,");
            sb.Append(DelanteroIzquierdo ? "S," : "N,");
            sb.Append(DelanteroDerecho ? "S," : "N,");
            sb.Append(TraseroIzquierdo ? "S," : "N,");
            sb.Append(TraseroDerecho ? "S)" : "N)");

            return string.Concat(ubicaciones, " - ", sb.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as EquipamientoAirbags;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                    return (Id == item.Id) ||
                        (Volante == item.Volante && Guantera == item.Guantera && DelanteroIzquierdo == item.DelanteroIzquierdo &&
                        DelanteroDerecho == item.DelanteroDerecho && TraseroIzquierdo == item.TraseroIzquierdo &&
                        TraseroDerecho == item.TraseroDerecho);
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(EquipamientoAirbags).FullName, Id.ToString()).GetHashCode();
        }

        #endregion
    }
}
