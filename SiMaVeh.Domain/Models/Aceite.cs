using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Aceite
    /// </summary>
    public class Aceite : TargetMantenimiento,
        ICollectionManager<ModeloVehiculo, long, Aceite, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Aceite()
        {
            ModeloVehiculoAceite = new HashSet<ModeloVehiculoAceite>();
        }

        /// <summary>
        /// Viscosidad SAE Baja Temperatura
        /// </summary>
        public virtual int ViscosidadSAEBajaTemperatura { get; set; }

        /// <summary>
        /// Viscosidad SAE Alta Temperatura
        /// </summary>
        public virtual int ViscosidadSAEAltaTemperatura { get; set; }

        /// <summary>
        /// Recomendaciones Modelo Vehiculo
        /// </summary>
        public virtual ISet<ModeloVehiculo> RecomendacionesModeloVehiculo => ModeloVehiculoAceite.Select(m => m.ModeloVehiculo).ToHashSet();

        #region relations

        /// <summary>
        /// Relacion ModeloVehiculo-Aceite
        /// </summary>
        public virtual ISet<ModeloVehiculoAceite> ModeloVehiculoAceite { get; }

        #endregion

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(Aceite) ", Nombre);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Aceite item && (ReferenceEquals(this, item) || base.Equals(obj));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Aceite).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region ICollecionManager

        /// <summary>
        /// Agregar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Aceite Agregar(ModeloVehiculo entity)
        {
            if (entity != null)
            {
                ModeloVehiculoAceite?.Add(new ModeloVehiculoAceite
                {
                    Aceite = this,
                    ModeloVehiculo = entity
                });
            }

            return this;
        }

        /// <summary>
        /// Quitar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Aceite Quitar(ModeloVehiculo entity)
        {
            if (entity != null)
            {
                var toRemove = ModeloVehiculoAceite?
                    .FirstOrDefault(m => m.ModeloVehiculo == entity && m.Aceite == this);
                if (toRemove != null)
                {
                    ModeloVehiculoAceite.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
