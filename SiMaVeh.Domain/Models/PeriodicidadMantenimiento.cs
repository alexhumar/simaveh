using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Periodicidad Mantenimiento
    /// </summary>
    public class PeriodicidadMantenimiento : DomainMember<long>,
        IEntityChanger<ModeloVehiculo, long, PeriodicidadMantenimiento, long>,
        IEntityChanger<Repuesto, long, PeriodicidadMantenimiento, long>
    {
        /// <summary>
        /// Kilometros
        /// </summary>
        public virtual long Kilometros { get; set; }

        /// <summary>
        /// Dias
        /// </summary>
        public virtual int Dias { get; set; }

        /// <summary>
        /// Meses
        /// </summary>
        public virtual int Meses { get; set; }

        /// <summary>
        /// Anios
        /// </summary>
        public virtual int Anios { get; set; }

        /// <summary>
        /// Modelo Vehiculo
        /// </summary>
        public virtual ModeloVehiculo ModeloVehiculo { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Repuesto
        /// </summary>
        public virtual Repuesto Repuesto { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Es periodicidad default (independiente del modelo vehiculo)
        /// </summary>
        public virtual bool EsDefault { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("Periodicidad ", Repuesto?.ToString(), " - ", ModeloVehiculo?.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is PeriodicidadMantenimiento item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Repuesto.Equals(item.Repuesto) && ModeloVehiculo.Equals(item.ModeloVehiculo) && EsDefault == item.EsDefault));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(PeriodicidadMantenimiento).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public PeriodicidadMantenimiento Cambiar(ModeloVehiculo entity)
        {
            if (entity != null)
            {
                ModeloVehiculo = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar repuesto
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public PeriodicidadMantenimiento Cambiar(Repuesto entity)
        {
            if (Repuesto != entity)
            {
                Repuesto?.Quitar(this);
                Repuesto = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        #endregion
    }
}
