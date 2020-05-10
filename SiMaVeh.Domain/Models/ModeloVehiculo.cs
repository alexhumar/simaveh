using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Modelo Vehiculo
    /// </summary>
    public class ModeloVehiculo : DomainMember<long>,
        IEntityChanger<GrupoModelo, long, ModeloVehiculo, long>,
        IEntityChanger<Aceite, long, ModeloVehiculo, long>,
        IEntityChanger<EquipamientoAirbags, long, ModeloVehiculo, long>,
        IEntityChanger<TipoFuenteEnergia, long, ModeloVehiculo, long>,
        IEntityChanger<FuenteEnergia, long, ModeloVehiculo, long>,
        ICollectionManager<Repuesto, long, ModeloVehiculo, long>,
        ICollectionManager<PresionNeumatico, long, ModeloVehiculo, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ModeloVehiculo()
        {
            RepuestosRecomendados = new HashSet<Repuesto>();
            PresionesNeumaticosRecomendadas = new HashSet<PresionNeumatico>();
        }

        /// <summary>
        /// Grupo Modelo
        /// </summary>
        public virtual GrupoModelo GrupoModelo { get; protected set; }

        /// <summary>
        /// Version
        /// </summary>
        public virtual string Version { get; set; }

        /// <summary>
        /// Aceite Recomendado
        /// </summary>
        public virtual Aceite AceiteRecomendado { get; protected set; }

        /// <summary>
        /// Airbags
        /// </summary>
        public virtual EquipamientoAirbags Airbags { get; protected set; }

        /// <summary>
        /// Tipo de Fuente de Energia
        /// </summary>
        public virtual TipoFuenteEnergia TipoFuenteEnergia { get; protected set; }

        /// <summary>
        /// Fuente Energia Recomendada
        /// </summary>
        public virtual FuenteEnergia FuenteEnergiaRecomendada { get; protected set; }

        /// <summary>
        /// Repuestos Recomendados
        /// </summary>
        public virtual ISet<Repuesto> RepuestosRecomendados { get; protected set; }

        /// <summary>
        /// Presiones de Neumaticos Recomendadas
        /// </summary>
        public virtual ISet<PresionNeumatico> PresionesNeumaticosRecomendadas { get; protected set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(GrupoModelo?.ToString(), " ", Version);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is ModeloVehiculo item))
            {
                return false;
            }
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) ||
                        (GrupoModelo.Equals(item.GrupoModelo) && Version.ToUpper() == item.Version.ToUpper());
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(ModeloVehiculo).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar grupo modelo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Cambiar(GrupoModelo entity)
        {
            if (entity != null)
            {
                GrupoModelo = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar aceite recomendado
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Cambiar(Aceite entity)
        {
            if (entity != null)
            {
                AceiteRecomendado = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar equipamiento airbags
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Cambiar(EquipamientoAirbags entity)
        {
            if (entity != null)
            {
                Airbags = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar tipo fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Cambiar(TipoFuenteEnergia entity)
        {
            if (entity != null)
            {
                TipoFuenteEnergia = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Cambiar(FuenteEnergia entity)
        {
            if (entity != null)
            {
                FuenteEnergiaRecomendada = entity;
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar presion neumatico recomendada
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Agregar(PresionNeumatico entity)
        {
            if ((entity != null) && !PresionesNeumaticosRecomendadas.Contains(entity))
            {
                PresionesNeumaticosRecomendadas.Add(entity);
                entity.Cambiar(this);
            }

            return this;
        }

        /// <summary>
        /// Quitar presion neumatico recomendada
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Quitar(PresionNeumatico entity)
        {
            if ((entity != null) && PresionesNeumaticosRecomendadas.Contains(entity))
            {
                PresionesNeumaticosRecomendadas.Remove(entity);
                if ((bool)entity.ModeloVehiculo?.Equals(this))
                {
                    entity.Cambiar((ModeloVehiculo)null);
                }
            }

            return this;
        }

        /// <summary>
        /// Agregar repuesto recomendado
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Agregar(Repuesto entity)
        {
            if (entity != null)
            {
                RepuestosRecomendados?.Add(entity);
            }

            return this;
        }

        /// <summary>
        /// Quitar repuesto recomendado
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Quitar(Repuesto entity)
        {
            if (entity != null)
            {
                RepuestosRecomendados?.Remove(entity);
            }

            return this;
        }

        #endregion
    }
}
