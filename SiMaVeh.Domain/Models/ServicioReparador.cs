using SiMaVeh.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Servicio Reparador
    /// </summary>
    public class ServicioReparador : DomainMember<long>,
        ICollectionManager<Mantenimiento, long, ServicioReparador, long>,
        IEntityChanger<EntidadReparadora, long, ServicioReparador, long>,
        IEntityChanger<Vehiculo, long, ServicioReparador, long>,
        IEntityChanger<Moneda, string, ServicioReparador, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ServicioReparador()
        {
            Mantenimientos = new HashSet<Mantenimiento>();
        }

        /// <summary>
        /// Mantenimientos
        /// </summary>
        public virtual ISet<Mantenimiento> Mantenimientos { get; init; }

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
        public virtual EntidadReparadora EntidadReparadora { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Vehiculo
        /// </summary>
        public virtual Vehiculo Vehiculo { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Monto de Mano de Obra
        /// </summary>
        public virtual decimal MontoManoObra { get; set; }

        /// <summary>
        /// Moneda del Monto de Mano de Obra
        /// </summary>
        public virtual Moneda MonedaMontoManoObra { get; set; /*el set no puede ser protected porque rompe OData*/ }

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
            return string.Concat("Servicio ", Vehiculo?.ToString(), " ",
                EntidadReparadora?.ToString(), " ", FechaInicio.ToString(), " ", FechaFin.ToString());
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ServicioReparador Cambiar(EntidadReparadora entity)
        {
            if (EntidadReparadora != entity)
            {
                EntidadReparadora?.Quitar(this);
                EntidadReparadora = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        /// <summary>
        /// Cambiar vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ServicioReparador Cambiar(Vehiculo entity)
        {
            if (Vehiculo != entity)
            {
                Vehiculo?.Quitar(this);
                Vehiculo = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        /// <summary>
        /// Cambiar moneda
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ServicioReparador Cambiar(Moneda entity)
        {
            if (entity != null)
            {
                MonedaMontoManoObra = entity;
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ServicioReparador Agregar(Mantenimiento entity)
        {
            if ((entity != null) && !Mantenimientos.Contains(entity))
            {
                Mantenimientos.Add(entity);
                entity.Cambiar(this);
            }

            return this;
        }

        /// <summary>
        /// Quitar mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ServicioReparador Quitar(Mantenimiento entity)
        {
            if ((entity != null) && Mantenimientos.Contains(entity))
            {
                Mantenimientos.Remove(entity);
                if (Equals(entity.ServicioReparador, this))
                {
                    entity.Cambiar((ServicioReparador)null);
                }
            }

            return this;
        }

        #endregion
    }
}
