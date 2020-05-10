using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Mantenimiento
    /// </summary>
    public class Mantenimiento : DomainMember<long>,
        IEntityChanger<Recambio, long, Mantenimiento, long>,
        IEntityChanger<Moneda, long, Mantenimiento, long>,
        IEntityChanger<ServicioReparador, long, Mantenimiento, long>,
        IEntityChanger<Reparador, long, Mantenimiento, long>
    {
        /// <summary>
        /// Accion
        /// </summary>
        public virtual EAccionMantenimiento Accion { get; set; }

        /// <summary>
        /// Recambio
        /// </summary>
        public virtual Recambio Recambio { get; protected set; }

        /// <summary>
        /// Monto Recambio
        /// </summary>
        public virtual decimal MontoRecambio { get; set; }

        /// <summary>
        /// Moneda Monto Recambio
        /// </summary>
        public virtual Moneda MonedaMontoRecambio { get; protected set; }

        /// <summary>
        /// Servicio Reparador
        /// </summary>
        public virtual ServicioReparador ServicioReparador { get; protected set; }

        /// <summary>
        /// Reparador
        /// </summary>
        public virtual Reparador Reparador { get; protected set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(", Accion.ToString(), ") ", Recambio?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Mantenimiento item))
            {
                return false;
            }
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) ||
                        (Accion.Equals(item.Accion) && Recambio.Equals(item.Recambio) && ServicioReparador.Equals(item.ServicioReparador) &&
                        Reparador.Equals(item.Reparador));
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Mantenimiento).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar recambio
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Mantenimiento Cambiar(Recambio entity)
        {
            if (entity != null)
            {
                Recambio = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar moneda
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Mantenimiento Cambiar(Moneda entity)
        {
            if (entity != null)
            {
                MonedaMontoRecambio = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Mantenimiento Cambiar(ServicioReparador entity)
        {
            if (ServicioReparador != entity)
            {
                ServicioReparador?.Quitar(this);
                ServicioReparador = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        /// <summary>
        /// Cambiar reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Mantenimiento Cambiar(Reparador entity)
        {
            if (entity != null)
            {
                Reparador = entity;
            }

            return this;
        }

        #endregion
    }
}
