using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Repuesto
    /// </summary>
    public class Repuesto : Recambio,
        IEntityChanger<TargetMantenimiento, long, Repuesto, long>,
        ICollectionManager<Kit, long, Repuesto, long>,
        ICollectionManager<PeriodicidadMantenimiento, long, Repuesto, long>,
        ICollectionManager<ModeloVehiculo, long, Repuesto, long>
    {
        /// <summary>
        /// Repuesto
        /// </summary>
        public Repuesto()
        {
            Kits = new HashSet<Kit>();
            RecomendacionesModeloVehiculo = new HashSet<ModeloVehiculo>();
            PeriodicidadesMantenimiento = new HashSet<PeriodicidadMantenimiento>();
        }

        /// <summary>
        /// Codigo Identificador
        /// </summary>
        public virtual string CodigoIdentificador { get; set; }

        /// <summary>
        /// Target Mantenimiento
        /// </summary>
        public virtual TargetMantenimiento TargetMantenimiento { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Periodicidades Mantenimiento
        /// </summary>
        public virtual ISet<PeriodicidadMantenimiento> PeriodicidadesMantenimiento { get; init; }

        /// <summary>
        /// Kits
        /// </summary>
        public virtual ISet<Kit> Kits { get; init; }

        /// <summary>
        /// Recomendaciones Modelo Vehiculo
        /// </summary>
        public virtual ISet<ModeloVehiculo> RecomendacionesModeloVehiculo { get; init; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(", CodigoIdentificador, ") ", TargetMantenimiento?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Repuesto item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (CodigoIdentificador == item.CodigoIdentificador && TargetMantenimiento.Equals(item.TargetMantenimiento)));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Repuesto).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar target mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Repuesto Cambiar(TargetMantenimiento entity)
        {
            if (entity != null)
            {
                TargetMantenimiento = entity;
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar kit
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Repuesto Agregar(Kit entity)
        {
            if (entity != null)
            {
                Kits.Add(entity);
            }

            return this;
        }

        /// <summary>
        /// Quitar Kit
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Repuesto Quitar(Kit entity)
        {
            if (entity != null)
            {
                var toRemove = Kits.FirstOrDefault(k => k == entity);
                if (toRemove != null)
                {
                    Kits.Remove(toRemove);
                }
            }

            return this;
        }

        /// <summary>
        /// Agregar periodicidad mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Repuesto Agregar(PeriodicidadMantenimiento entity)
        {
            if ((entity != null) && !PeriodicidadesMantenimiento.Contains(entity))
            {
                PeriodicidadesMantenimiento.Add(entity);
                entity.Cambiar(this);
            }

            return this;
        }

        /// <summary>
        /// Quitar periodicidad mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Repuesto Quitar(PeriodicidadMantenimiento entity)
        {
            if ((entity != null) && PeriodicidadesMantenimiento.Contains(entity))
            {
                PeriodicidadesMantenimiento.Remove(entity);
                if ((bool)entity.Repuesto?.Equals(this))
                {
                    entity.Cambiar((Repuesto)null);
                }
            }

            return this;
        }

        /// <summary>
        /// Agregar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Repuesto Agregar(ModeloVehiculo entity)
        {
            if (entity != null)
            {
                RecomendacionesModeloVehiculo.Add(entity);
            }

            return this;
        }

        /// <summary>
        /// Quitar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Repuesto Quitar(ModeloVehiculo entity)
        {
            if (entity != null)
            {
                var toRemove = RecomendacionesModeloVehiculo.FirstOrDefault(m => m == entity);
                if (toRemove != null)
                {
                    RecomendacionesModeloVehiculo.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
