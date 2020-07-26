using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
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
        ICollectionManager<PeriodicidadMantenimiento, long, Repuesto, long>
    {
        /// <summary>
        /// Repuesto
        /// </summary>
        public Repuesto()
        {
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
        public virtual ISet<PeriodicidadMantenimiento> PeriodicidadesMantenimiento { get; protected set; }

        /// <summary>
        /// Kits
        /// </summary>
        public virtual ISet<Kit> Kits => KitRepuesto.Select(k => k.Kit).ToHashSet();

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
                KitRepuesto?.Add(new KitRepuesto
                {
                    Repuesto = this,
                    Kit = entity
                });
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
                var toRemove = KitRepuesto?
                    .FirstOrDefault(r => r.Repuesto == this && r.Kit == entity);
                if (toRemove != null)
                {
                    KitRepuesto.Remove(toRemove);
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

        #endregion
    }
}
