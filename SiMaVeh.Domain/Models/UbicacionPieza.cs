﻿using System.Text;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Ubicacion Pieza
    /// </summary>
    public class UbicacionPieza : DomainMember<string>
    {
        private bool _izquierda { get; set; }
        /// <summary>
        /// True -> Izquierda. False -> Derecha.
        /// </summary>
        public virtual bool Izquierda
        { 
            get { return _izquierda; }
            set 
            { 
                _izquierda = value;
                this.Id = this.CalcularId();
            }
        }

        private bool _superior { get; set; }
        /// <summary>
        /// True -> Superior. False -> Inferior.
        /// </summary>
        public virtual bool Superior
        { 
            get { return _superior; }
            set
            {
                _superior = value;
                this.Id = this.CalcularId();
            } 
        }

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

        #region private

        private string CalcularId()
        {
            return (this.Izquierda ? "I" : "D") + (this.Superior ? "S": "I");
        }

        #endregion
    }
}
