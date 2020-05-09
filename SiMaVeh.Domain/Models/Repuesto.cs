using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Repuesto
    /// </summary>
    public class Repuesto : Recambio,
        IEntityChanger<TargetMantenimiento, long, Repuesto, long>,
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
        public virtual TargetMantenimiento TargetMantenimiento { get; set; }

        /// <summary>
        /// Periodicidades Mantenimiento
        /// </summary>
        public virtual ISet<PeriodicidadMantenimiento> PeriodicidadesMantenimiento { get; protected set; }

        #region overrides

        /// <summary>
        /// GetRepuestos
        /// </summary>
        /// <returns>Repuesto o Lista de repuestos para el caso de los kits</returns>
        public override ISet<Repuesto> GetRepuestos()
        {
            var repuestos = new HashSet<Repuesto>
            {
                this
            };

            return repuestos;
        }

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
            var item = obj as Repuesto;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) ||
                        (CodigoIdentificador == item.CodigoIdentificador && TargetMantenimiento.Equals(item.TargetMantenimiento));
                }
            }
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
                TargetMantenimiento = entity;

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar periodicidad mantenimiento
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Repuesto Agregar(PeriodicidadMantenimiento entity)
        {
            if (entity != null)
            {
                PeriodicidadesMantenimiento?.Add(entity);
                entity.TargetMantenimiento = this;
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
            if (entity != null)
            {
                PeriodicidadesMantenimiento?.Remove(entity);
                if ((bool)entity.TargetMantenimiento?.Equals(this))
                    entity.TargetMantenimiento = null;
            }

            return this;
        }

        #endregion
    }
}
