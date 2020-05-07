using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Vehiculo
    /// </summary>
    public abstract class Vehiculo : DomainMember<long>, IEntityChanger<ModeloVehiculo, long>, ICollectionManager<ServicioReparador, long>,
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
        public virtual IList<ServicioReparador> ServiciosReparadores { get; protected set; }

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
        /// Cambiar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(ModeloVehiculo entity)
        {
            if (ModeloVehiculo != null)
                ModeloVehiculo = entity;
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

        #endregion

        #region ICollectionManager

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

        #endregion
    }
}
