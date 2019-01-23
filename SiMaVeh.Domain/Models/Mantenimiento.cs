using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Mantenimiento
    /// </summary>
    public class Mantenimiento : DomainMember<long>, IEntityChanger<Recambio, long>, IEntityChanger<Moneda, long>,
        IEntityChanger<ServicioReparador, long>, IEntityChanger<Reparador, long>
    {
        /// <summary>
        /// Accion
        /// </summary>
        public virtual EAccionMantenimiento Accion { get; set; }

        /// <summary>
        /// Recambio
        /// </summary>
        public virtual Recambio Recambio { get; set; }

        /// <summary>
        /// Monto Recambio
        /// </summary>
        public virtual decimal MontoRecambio { get; set; }

        /// <summary>
        /// Moneda Monto Recambio
        /// </summary>
        public virtual Moneda MonedaMontoRecambio { get; set; }

        /// <summary>
        /// Servicio Reparador
        /// </summary>
        public virtual ServicioReparador ServicioReparador { get; set; }

        /// <summary>
        /// Reparador
        /// </summary>
        public virtual Reparador Reparador { get; set; }

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
            var item = obj as Mantenimiento;

            if (item == null)
                return false;
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
        public void Cambiar(Recambio entity)
        {
            if (entity != null)
                Recambio = entity;
        }

        /// <summary>
        /// Agregar recambio
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Recambio entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar recambio
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Recambio entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar moneda
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Moneda entity)
        {
            if (entity != null)
                MonedaMontoRecambio = entity;
        }

        /// <summary>
        /// Agregar moneda
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Moneda entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar moneda
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Moneda entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(ServicioReparador entity)
        {
            ServicioReparador?.Quitar(this);
            entity?.Agregar(this);
        }

        /// <summary>
        /// Agregar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(ServicioReparador entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(ServicioReparador entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Reparador entity)
        {
            if (entity != null)
                Reparador = entity;
        }

        /// <summary>
        /// Agregar reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Reparador entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Reparador entity)
        {
            throw new System.NotSupportedException();
        }

        #endregion
    }
}
