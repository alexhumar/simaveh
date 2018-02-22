using SiMaVeh.Domain.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Presion Neumaticos
    /// </summary>
    public class PresionNeumatico : DomainMember<long>, IEntityChanger<ModeloVehiculo, long>, IEntityChanger<Neumatico, long>
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
        public virtual ModeloVehiculo ModeloVehiculo { get; set; }

        /// <summary>
        /// Neumatico
        /// </summary>
        public virtual Neumatico Neumatico { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(D", RuedasDelanteras, ", T", RuedasTraseras, ") ", ModeloVehiculo.ToString());
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as PresionNeumatico;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) || 
                        (Neumatico.Equals(item.Neumatico) && ModeloVehiculo.Equals(item.ModeloVehiculo) && EsDefault == item.EsDefault);
                }
            }
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
        public void Cambiar(ModeloVehiculo entity)
        {
            ModeloVehiculo?.Quitar(this);
            entity?.Agregar(this);
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
        /// Cambiar neumatico
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Neumatico entity)
        {
            if (entity != null)
                Neumatico = entity;
        }

        /// <summary>
        /// Agregar neumatico
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Neumatico entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar neumatico
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Neumatico entity)
        {
            throw new System.NotSupportedException();
        }

        #endregion
    }
}
