using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Presion Neumaticos
    /// </summary>
    public class PresionNeumatico : DomainMember<long>,
        ICollectionManager<ModeloVehiculo, long, PresionNeumatico, long>,
        IEntityChanger<Neumatico, long, PresionNeumatico, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PresionNeumatico()
        {
            ModeloVehiculoPresionNeumatico = new HashSet<ModeloVehiculoPresionNeumatico>();
        }

        /// <summary>
        /// Presion en PSI de ruedas delanteras
        /// </summary>
        public virtual decimal RuedasDelanteras { get; set; }

        /// <summary>
        /// Presion en PSI de ruedas traseras
        /// </summary>
        public virtual decimal RuedasTraseras { get; set; }

        /// <summary>
        /// Es presion de vehículo cargado
        /// </summary>
        public virtual bool VehiculoCargado { get; set; }

        /// <summary>
        /// Especifica si la presión es independiente de un neumático en especial
        /// </summary>
        public virtual bool EsUniversal => Neumatico == null;

        /// <summary>
        /// Neumatico
        /// </summary>
        public virtual Neumatico Neumatico { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Recomendaciones Modelo Vehiculo
        /// </summary>
        public virtual ISet<ModeloVehiculo> RecomendacionesModeloVehiculo => ModeloVehiculoPresionNeumatico.Select(m => m.ModeloVehiculo).ToHashSet();

        #region relations

        /// <summary>
        /// Relacion ModeloVehiculo-PresionNeumatico
        /// </summary>
        public virtual ISet<ModeloVehiculoPresionNeumatico> ModeloVehiculoPresionNeumatico { get; }

        #endregion

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(D", RuedasDelanteras, ", T", RuedasTraseras, ") ", RecomendacionesModeloVehiculo?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is PresionNeumatico item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Neumatico.Equals(item.Neumatico) && RecomendacionesModeloVehiculo.Equals(item.RecomendacionesModeloVehiculo) && VehiculoCargado == item.VehiculoCargado));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(PresionNeumatico).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar neumatico
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public PresionNeumatico Cambiar(Neumatico entity)
        {
            if (entity != null)
            {
                Neumatico = entity;
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar modelo de vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public PresionNeumatico Agregar(ModeloVehiculo entity)
        {
            if (entity != null)
            {
                ModeloVehiculoPresionNeumatico?.Add(new ModeloVehiculoPresionNeumatico
                {
                    ModeloVehiculo = entity,
                    PresionNeumatico = this
                });
            }

            return this;
        }

        /// <summary>
        /// Quitar modelo de vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public PresionNeumatico Quitar(ModeloVehiculo entity)
        {
            if (entity != null)
            {
                var toRemove = ModeloVehiculoPresionNeumatico?
                    .FirstOrDefault(m => m.PresionNeumatico == this && m.ModeloVehiculo == entity);
                if (toRemove != null)
                {
                    ModeloVehiculoPresionNeumatico.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
