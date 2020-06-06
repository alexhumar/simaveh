namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Ubicacion Pieza
    /// </summary>
    public class UbicacionPieza : DomainMember<string>
    {
        /// <summary>
        /// Id
        /// </summary>
        public override string Id
        {
            get => CalcularId();
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
            if (!(obj is UbicacionPieza item))
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
            return string.Concat(typeof(UbicacionPieza).FullName, Id).GetHashCode();
        }

        #endregion

        #region private

        private string CalcularId()
        {
            return string.Concat(Izquierda ? "I" : "D", Superior ? "S" : "I");
        }

        #endregion
    }
}
