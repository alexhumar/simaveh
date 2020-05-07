using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Modelo Vehiculo
    /// </summary>
    public class ModeloVehiculo : DomainMember<long>, IEntityChanger<GrupoModelo, long>, IEntityChanger<Aceite, long>,
        IEntityChanger<EquipamientoAirbags, long>, IEntityChanger<TipoFuenteEnergia, long>, IEntityChanger<FuenteEnergia, long>,
        ICollectionManager<Repuesto, long>, ICollectionManager<PresionNeumatico, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ModeloVehiculo()
        {
            RepuestosRecomendados = new List<Repuesto>();
            PresionesNeumaticosRecomendadas = new List<PresionNeumatico>();
        }

        /// <summary>
        /// Grupo Modelo
        /// </summary>
        public virtual GrupoModelo GrupoModelo { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public virtual string Version { get; set; }

        /// <summary>
        /// Aceite Recomendado
        /// </summary>
        public virtual Aceite AceiteRecomendado { get; set; }

        /// <summary>
        /// Airbags
        /// </summary>
        public virtual EquipamientoAirbags Airbags { get; set; }

        /// <summary>
        /// Tipo de Fuente de Energia
        /// </summary>
        public virtual TipoFuenteEnergia TipoFuenteEnergia { get; set; }

        /// <summary>
        /// Fuente Energia Recomendada
        /// </summary>
        public virtual FuenteEnergia FuenteEnergiaRecomendada { get; set; }

        /// <summary>
        /// Repuestos Recomendados
        /// </summary>
        public virtual IList<Repuesto> RepuestosRecomendados { get; protected set; }

        /// <summary>
        /// Presiones de Neumaticos Recomendadas
        /// </summary>
        public virtual IList<PresionNeumatico> PresionesNeumaticosRecomendadas { get; protected set; }

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
            var item = obj as ModeloVehiculo;

            if (item == null)
                return false;
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
        public void Cambiar(GrupoModelo entity)
        {
            if (entity != null)
                GrupoModelo = entity;
        }

        /// <summary>
        /// Cambiar aceite recomendado
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Aceite entity)
        {
            if (entity != null)
                AceiteRecomendado = entity;
        }

        /// <summary>
        /// Cambiar equipamiento airbags
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(EquipamientoAirbags entity)
        {
            if (entity != null)
                Airbags = entity;
        }

        /// <summary>
        /// Cambiar tipo fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(TipoFuenteEnergia entity)
        {
            if (entity != null)
                TipoFuenteEnergia = entity;
        }

        /// <summary>
        /// Cambiar fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(FuenteEnergia entity)
        {
            if (entity != null)
                FuenteEnergiaRecomendada = entity;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar presion neumatico recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(PresionNeumatico entity)
        {
            if (entity != null)
            {
                PresionesNeumaticosRecomendadas?.Add(entity);
                entity.ModeloVehiculo = this;
            }
        }

        /// <summary>
        /// Quitar presion neumatico recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(PresionNeumatico entity)
        {
            if (entity != null)
            {
                PresionesNeumaticosRecomendadas?.Remove(entity);
                if ((bool)entity.ModeloVehiculo?.Equals(this))
                    entity.ModeloVehiculo = null;
            }
        }

        /// <summary>
        /// Agregar repuesto recomendado
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Repuesto entity)
        {
            if (entity != null)
                RepuestosRecomendados?.Add(entity);
        }

        /// <summary>
        /// Quitar repuesto recomendado
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Repuesto entity)
        {
            if (entity != null)
                RepuestosRecomendados?.Remove(entity);
        }

        #endregion
    }
}
