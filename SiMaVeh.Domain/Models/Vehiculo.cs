using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Vehiculo
    /// </summary>
    public abstract class Vehiculo : DomainMember<long>, IEntityChanger<ModeloVehiculo, long>, IEntityChanger<ServicioReparador, long>,
        IEntityChanger<Usuario, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Vehiculo()
        {
            ServiciosReparadores = new List<ServicioReparador>();
        }

        /// <summary>
        /// Modelo
        /// </summary>
        public virtual ModeloVehiculo ModeloVehiculo { get; set; }

        /// <summary>
        /// Kilometraje
        /// </summary>
        public virtual decimal Kilometraje { get; set; }

        /// <summary>
        /// Anio de fabricacion
        /// </summary>
        public virtual int AnioFabricacion { get; set; }

        /// <summary>
        /// Usuario al que pertenece
        /// </summary>
        public virtual Usuario Usuario { get; set; }

        /// <summary>
        /// Servicios Reparadores
        /// </summary>
        public virtual IList<ServicioReparador> ServiciosReparadores { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public abstract override bool Equals(object obj);

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public abstract override int GetHashCode();

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(ServicioReparador entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Agregar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(ServicioReparador entity)
        {
            if (entity != null)
            {
                ServiciosReparadores?.Add(entity);
                entity.Vehiculo = this;
            }
        }

        /// <summary>
        /// Quitar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(ServicioReparador entity)
        {
            if (entity != null)
            {
                ServiciosReparadores?.Remove(entity);
                if ((bool)entity.Vehiculo?.Equals(this))
                    entity.Vehiculo = null;
            }
        }

        /// <summary>
        /// Cambiar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(ModeloVehiculo entity)
        {
            if (ModeloVehiculo != null)
                ModeloVehiculo = entity;
        }

        /// <summary>
        /// Agregar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(ModeloVehiculo entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(ModeloVehiculo entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar usuario
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Usuario entity)
        {
            Usuario?.Quitar(this);
            entity?.Agregar(this);
        }

        /// <summary>
        /// Agregar usuario
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Usuario entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar usuario
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Usuario entity)
        {
            throw new System.NotSupportedException();
        }

        #endregion
    }
}
