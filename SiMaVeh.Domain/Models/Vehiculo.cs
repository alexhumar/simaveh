using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Vehiculo
    /// </summary>
    public abstract class Vehiculo : DomainMember<long>,
        IEntityChanger<ModeloVehiculo, long, Vehiculo, long>,
        ICollectionManager<ServicioReparador, long, Vehiculo, long>,
        IEntityChanger<Usuario, long, Vehiculo, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Vehiculo()
        {
            ServiciosReparadores = new HashSet<ServicioReparador>();
        }

        /// <summary>
        /// Modelo
        /// </summary>
        public virtual ModeloVehiculo ModeloVehiculo { get; set; /*el set no puede ser protected porque rompe OData*/ }

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
        public virtual Usuario Usuario { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Servicios Reparadores
        /// </summary>
        public virtual ISet<ServicioReparador> ServiciosReparadores { get; init; }

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
        /// <returns></returns>
        public Vehiculo Cambiar(ModeloVehiculo entity)
        {
            if (ModeloVehiculo != null)
            {
                ModeloVehiculo = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar usuario
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Vehiculo Cambiar(Usuario entity)
        {
            if (Usuario != entity)
            {
                Usuario?.Quitar(this);
                Usuario = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Vehiculo Agregar(ServicioReparador entity)
        {
            if ((entity != null) && !ServiciosReparadores.Contains(entity))
            {
                ServiciosReparadores.Add(entity);
                entity.Cambiar(this);
            }

            return this;
        }

        /// <summary>
        /// Quitar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Vehiculo Quitar(ServicioReparador entity)
        {
            if ((entity != null) && ServiciosReparadores.Contains(entity))
            {
                ServiciosReparadores.Remove(entity);
                if ((bool)entity.Vehiculo?.Equals(this))
                {
                    entity.Cambiar((Vehiculo)null);
                }
            }

            return this;
        }

        #endregion
    }
}
