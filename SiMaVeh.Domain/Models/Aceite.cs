using SiMaVeh.Domain.Models.Interfaces;
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
            RecomendacionesModeloVehiculo = new HashSet<ModeloVehiculo>();
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
        public virtual ISet<ModeloVehiculo> RecomendacionesModeloVehiculo { get; init; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(Aceite) ", Nombre);
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
            //TODO: evaluar hacer una extension de HashSet para generalizar este comportamiento.
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
        public Aceite Quitar(ModeloVehiculo entity)
        {
            //TODO: evaluar hacer una extension de HashSet para generalizar este comportamiento.
            //Y en este caso alcanzaria con invocar al remove de la coleccion me parece.
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
