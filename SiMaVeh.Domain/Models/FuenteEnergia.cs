using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
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
            ModeloVehiculoFuenteEnergia = new HashSet<ModeloVehiculoFuenteEnergia>();
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
        public virtual ISet<ModeloVehiculo> RecomendacionesModeloVehiculo => ModeloVehiculoFuenteEnergia.Select(m => m.ModeloVehiculo).ToHashSet();

        #region relations

        /// <summary>
        /// Relacion ModeloVehiculo-FuenteEnergia
        /// </summary>
        public virtual ISet<ModeloVehiculoFuenteEnergia> ModeloVehiculoFuenteEnergia { get; }

        #endregion

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
                ModeloVehiculoFuenteEnergia?.Add(new ModeloVehiculoFuenteEnergia
                {
                    FuenteEnergia = this,
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
        public FuenteEnergia Quitar(ModeloVehiculo entity)
        {
            if (entity != null)
            {
                var toRemove = ModeloVehiculoFuenteEnergia?
                    .FirstOrDefault(m => m.ModeloVehiculo == entity && m.FuenteEnergia == this);
                if (toRemove != null)
                {
                    ModeloVehiculoFuenteEnergia.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
