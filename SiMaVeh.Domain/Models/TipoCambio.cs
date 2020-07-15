using System;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Tipo Cambio
    /// </summary>
    public class TipoCambio : DomainMember<long>
    {
        /// <summary>
        /// Valor
        /// </summary>
        public virtual decimal CoeficienteCambio { get; set; }

        /// <summary>
        /// Moneda Origen
        /// </summary>
        public virtual Moneda MonedaOrigen { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Moneda Destino
        /// </summary>
        public virtual Moneda MonedaDestino { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Fecha
        /// </summary>
        public virtual DateTime Fecha { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("MOR: ", MonedaOrigen?.ToString(), " MDEST: ", MonedaDestino?.ToString(), " ",
                CoeficienteCambio, " ", Fecha.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is TipoCambio item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (MonedaOrigen.Equals(item.MonedaOrigen) &&
                MonedaDestino.Equals(item.MonedaDestino) && Fecha == item.Fecha && CoeficienteCambio == item.CoeficienteCambio));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(TipoCambio).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar moneda origen
        /// </summary>
        /// <param name="entity"></param>
        public void CambiarMonedaOrigen(Moneda entity)
        {
            if (entity != null)
            {
                MonedaOrigen = entity;
            }
        }

        /// <summary>
        /// Cambiar moneda destino
        /// </summary>
        /// <param name="entity"></param>
        public void CambiarMonedaDestino(Moneda entity)
        {
            if (entity != null)
            {
                MonedaDestino = entity;
            }
        }

        #endregion
    }
}
