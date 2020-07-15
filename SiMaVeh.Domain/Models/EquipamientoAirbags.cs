using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models.Calculadores.EquipamientoAirbags;
using SiMaVeh.Domain.Models.Interfaces;
using System.Text;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Equipamiento Airbags
    /// </summary>
    public class EquipamientoAirbags : DomainMember<string>,
        IEquipamientoAirbags
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EquipamientoAirbags()
        {
            calculadorIdEquipamientoAirbags = new CalculadorIdEquipamientoAirbags();
        }

        private readonly CalculadorIdEquipamientoAirbags calculadorIdEquipamientoAirbags;

        /// <summary>
        /// Id
        /// </summary>
        public override string Id
        {
            get => calculadorIdEquipamientoAirbags.Calcular(this);
            set { }
        }

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
        public virtual TipoAirbagLateral DelanteroIzquierdo { get; set; }

        /// <summary>
        /// Delantero Derecho
        /// </summary>
        public virtual TipoAirbagLateral DelanteroDerecho { get; set; }

        /// <summary>
        /// Trasero Izquierdo
        /// </summary>
        public virtual TipoAirbagLateral TraseroIzquierdo { get; set; }

        /// <summary>
        /// Trasero Derecho
        /// </summary>
        public virtual TipoAirbagLateral TraseroDerecho { get; set; }

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
            return obj is EquipamientoAirbags item &&
                (ReferenceEquals(this, item) ||
                (Id == item.Id) ||
                (Conductor == item.Conductor && Acompanante == item.Acompanante &&
                DelanteroIzquierdo == item.DelanteroIzquierdo && DelanteroDerecho == item.DelanteroDerecho &&
                TraseroIzquierdo == item.TraseroIzquierdo && TraseroDerecho == item.TraseroDerecho));
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
