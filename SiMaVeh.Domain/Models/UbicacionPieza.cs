using SiMaVeh.Domain.Models.Calculadores.UbicacionPieza;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Ubicacion Pieza
    /// </summary>
    public class UbicacionPieza : DomainMember<string>,
        IUbicacionPieza
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UbicacionPieza()
        {
            calculadorIdUbicacionPieza = new CalculadorIdUbicacionPieza();
        }

        private readonly CalculadorIdUbicacionPieza calculadorIdUbicacionPieza;

        /// <summary>
        /// Id
        /// </summary>
        public override string Id
        {
            get => calculadorIdUbicacionPieza.Calcular(this);
            set { }
        }

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
            return string.Concat(Superior ? "(Superior, " : "(Inferior, ", Izquierda ? "Izquierda)" : "Derecha)");
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is UbicacionPieza item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Izquierda == item.Izquierda && Superior == item.Superior));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(UbicacionPieza).FullName, Id).GetHashCode();
        }

        #endregion
    }
}
