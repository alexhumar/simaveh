using SiMaVeh.Domain.Enums;
using System.Text;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Equipamiento Airbags
    /// </summary>
    public class EquipamientoAirbags : DomainMember<long>
    {
        //TODO: cambiar a Id string, similar a UbicacionPieza, y hacer los ajustes pertinentes
        //respecto a los campos que ahora son de tipo Enum.

        /// <summary>
        /// Airbag de Conductor
        /// </summary>
        public virtual bool Conductor { get; set; }

        /// <summary>
        /// Airbag de Acompañante
        /// </summary>
        public virtual bool Acompanante { get; set; }

        /// <summary>
        /// Delantero Izquierdo
        /// </summary>
        public virtual ETipoAirbagLateral DelanteroIzquierdo { get; set; }

        /// <summary>
        /// Delantero Derecho
        /// </summary>
        public virtual ETipoAirbagLateral DelanteroDerecho { get; set; }

        /// <summary>
        /// Trasero Izquierdo
        /// </summary>
        public virtual ETipoAirbagLateral TraseroIzquierdo { get; set; }

        /// <summary>
        /// Trasero Derecho
        /// </summary>
        public virtual ETipoAirbagLateral TraseroDerecho { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var ubicaciones = "(V,G,DI,DD,TI,TD)";
            var sb = new StringBuilder();

            sb.Append(Conductor ? "(S," : "(N,");
            sb.Append(Acompanante ? "S," : "N,");
            sb.Append($"{ TipoAirbagLateralParser.ToString(DelanteroIzquierdo)},");
            sb.Append($"{ TipoAirbagLateralParser.ToString(DelanteroDerecho)},");
            sb.Append($"{ TipoAirbagLateralParser.ToString(TraseroIzquierdo)},");
            sb.Append($"{ TipoAirbagLateralParser.ToString(TraseroDerecho)},");

            return string.Concat(ubicaciones, " - ", sb.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is EquipamientoAirbags item))
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                    return (Id == item.Id) ||
                        (Conductor == item.Conductor && Acompanante == item.Acompanante && DelanteroIzquierdo == item.DelanteroIzquierdo &&
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
