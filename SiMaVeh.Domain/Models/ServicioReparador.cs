using SiMaVeh.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Servicio Reparador
    /// </summary>
    public class ServicioReparador : DomainMember<long>, IEntityChanger<Mantenimiento, long>, IEntityChanger<EntidadReparadora, long>,
        IEntityChanger<Vehiculo, long>, IEntityChanger<Moneda, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ServicioReparador()
        {
            Mantenimientos = new List<Mantenimiento>();
        }

        /// <summary>
        /// Mantenimientos
        /// </summary>
        public virtual IList<Mantenimiento> Mantenimientos { get; set; }

        /// <summary>
        /// Fecha Inicio
        /// </summary>
        public virtual DateTime FechaInicio { get; set; }

        /// <summary>
        /// Fecha Fin
        /// </summary>
        public virtual DateTime FechaFin { get; set; }

        /// <summary>
        /// Entidad Reparadora
        /// </summary>
        public virtual EntidadReparadora EntidadReparadora { get; set; }

        /// <summary>
        /// Vehiculo
        /// </summary>
        public virtual Vehiculo Vehiculo { get; set; }

        /// <summary>
        /// Monto de Mano de Obra
        /// </summary>
        public virtual decimal MontoManoObra { get; set; }

        /// <summary>
        /// Moneda del Monto de Mano de Obra
        /// </summary>
        public virtual Moneda MonedaMontoManoObra { get; set; }

        /// <summary>
        /// Kilometraje del vehiculo al momento del servicio
        /// </summary>
        public virtual decimal KilometrajeVehiculo { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("Servicio ", Vehiculo.ToString(), " ",
                EntidadReparadora.ToString(), " ", FechaInicio.ToString(), " ", FechaFin.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as ServicioReparador;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) || 
                        (Vehiculo.Equals(item.Vehiculo) && EntidadReparadora.Equals(item.EntidadReparadora) &&
                        FechaInicio == item.FechaInicio && FechaFin == item.FechaFin && 
                        MontoManoObra == item.MontoManoObra && MonedaMontoManoObra.Equals(item.MonedaMontoManoObra) &&
                        KilometrajeVehiculo == item.KilometrajeVehiculo);
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(ServicioReparador).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Mantenimiento entity)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Agregar mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Mantenimiento entity)
        {
            if (entity != null)
            {
                Mantenimientos?.Add(entity);
                entity.ServicioReparador = this;
            }
        }

        /// <summary>
        /// Quitar mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Mantenimiento entity)
        {
            if (entity != null)
            {
                Mantenimientos?.Remove(entity);
                if ((bool)entity.ServicioReparador?.Equals(this))
                    entity.ServicioReparador = null;
            }
        }

        /// <summary>
        /// Cambiar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(EntidadReparadora entity)
        {
            EntidadReparadora?.Quitar(this);
            entity?.Agregar(this);
        }

        /// <summary>
        /// Agregar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(EntidadReparadora entity)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Quitar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(EntidadReparadora entity)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Cambiar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Vehiculo entity)
        {
            Vehiculo?.Quitar(this);
            entity?.Agregar(this);
        }

        /// <summary>
        /// Agregar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Vehiculo entity)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Quitar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Vehiculo entity)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Cambiar moneda
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Moneda entity)
        {
            if (entity != null)
                MonedaMontoManoObra = entity;
        }

        /// <summary>
        /// Agregar moneda
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Moneda entity)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Quitar moneda
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Moneda entity)
        {
            throw new NotSupportedException();
        }

        #endregion
    }
}
