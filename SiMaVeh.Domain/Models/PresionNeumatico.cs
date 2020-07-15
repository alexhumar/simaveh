﻿using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Presion Neumaticos
    /// </summary>
    public class PresionNeumatico : DomainMember<long>,
        IEntityChanger<ModeloVehiculo, long, PresionNeumatico, long>,
        IEntityChanger<Neumatico, long, PresionNeumatico, long>
    {
        /// <summary>
        /// Presion en PSI de ruedas delanteras
        /// </summary>
        public virtual decimal RuedasDelanteras { get; set; }

        /// <summary>
        /// Presion en PSI de ruedas traseras
        /// </summary>
        public virtual decimal RuedasTraseras { get; set; }

        /// <summary>
        /// Es presion default (para cualquier neumatico)
        /// </summary>
        public virtual bool EsDefault { get; set; }

        /// <summary>
        /// Modelo Vehiculo
        /// </summary>
        public virtual ModeloVehiculo ModeloVehiculo { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Neumatico
        /// </summary>
        public virtual Neumatico Neumatico { get; set; /*el set no puede ser protected porque rompe OData*/ }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(D", RuedasDelanteras, ", T", RuedasTraseras, ") ", ModeloVehiculo?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is PresionNeumatico item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Neumatico.Equals(item.Neumatico) && ModeloVehiculo.Equals(item.ModeloVehiculo) && EsDefault == item.EsDefault));
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
        /// Cambiar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public PresionNeumatico Cambiar(ModeloVehiculo entity)
        {
            if (ModeloVehiculo != entity)
            {
                ModeloVehiculo?.Quitar(this);
                ModeloVehiculo = entity;
                entity?.Agregar(this);
            }

            return this;
        }

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
    }
}
