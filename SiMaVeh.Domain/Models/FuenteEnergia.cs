using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Combustible
    /// </summary>
    public class FuenteEnergia : DomainMember<long>,
        IEntityChanger<Marca, long, FuenteEnergia, long>,
        IEntityChanger<TipoFuenteEnergia, long, FuenteEnergia, long>,
        ICollectionManager<ModeloVehiculo, long, FuenteEnergia, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FuenteEnergia()
        {
            RecomendacionesModeloVehiculo = new HashSet<ModeloVehiculo>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Tipo de Fuente de Energia
        /// </summary>
        public virtual TipoFuenteEnergia TipoFuenteEnergia { get; set; /*el set no puede ser protected porque rompe OData*/ }

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
            return string.Concat("(", TipoFuenteEnergia?.ToString(), ") ", Marca?.ToString(), " ", Nombre);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is FuenteEnergia item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Nombre == item.Nombre && Marca.Equals(item.Marca) && TipoFuenteEnergia.Equals(item.TipoFuenteEnergia)));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(FuenteEnergia).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar marca
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public FuenteEnergia Cambiar(Marca entity)
        {
            if (entity != null)
            {
                Marca = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar tipo fuente energia
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public FuenteEnergia Cambiar(TipoFuenteEnergia entity)
        {
            if (entity != null)
            {
                TipoFuenteEnergia = entity;
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar modelo vehiculo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public FuenteEnergia Agregar(ModeloVehiculo entity)
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
        public FuenteEnergia Quitar(ModeloVehiculo entity)
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
