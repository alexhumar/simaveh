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

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar moneda origen
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TipoCambio CambiarMonedaOrigen(Moneda entity)
        {
            if (entity != null)
            {
                MonedaOrigen = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar moneda destino
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TipoCambio CambiarMonedaDestino(Moneda entity)
        {
            if (entity != null)
            {
                MonedaDestino = entity;
            }

            return this;
        }

        #endregion
    }
}
