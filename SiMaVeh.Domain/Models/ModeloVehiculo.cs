using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Modelo Vehiculo
    /// </summary>
    public class ModeloVehiculo : DomainMember<long>, IEntityChanger<GrupoModelo, long>, IEntityChanger<Aceite, long>,
        IEntityChanger<EquipamientoAirbags, long>, IEntityChanger<TipoFuenteEnergia, long>, IEntityChanger<FuenteEnergia, long>,
        IEntityChanger<Repuesto, long>, IEntityChanger<PresionNeumatico, long>
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
        public virtual IList<Repuesto> RepuestosRecomendados { get; set; }

        /// <summary>
        /// Presiones de Neumaticos Recomendadas
        /// </summary>
        public virtual IList<PresionNeumatico> PresionesNeumaticosRecomendadas { get; set; }

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
        /// Cambiar presion neumatico recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(PresionNeumatico entity)
        {
            throw new System.NotSupportedException();
        }

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
        /// Cambiar grupo modelo
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(GrupoModelo entity)
        {
            if (entity != null)
                GrupoModelo = entity;
        }

        /// <summary>
        /// Agregar grupo modelo
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(GrupoModelo entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar grupo modelo
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(GrupoModelo entity)
        {
            throw new System.NotSupportedException();
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
        /// Agregar aceite recomendado
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Aceite entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar aceite recomendado
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Aceite entity)
        {
            throw new System.NotSupportedException();
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
        /// Agregar equipamiento airbags
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(EquipamientoAirbags entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar equipamiento airbags
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(EquipamientoAirbags entity)
        {
            throw new System.NotSupportedException();
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
        /// Agregar tipo fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(TipoFuenteEnergia entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar tipo fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(TipoFuenteEnergia entity)
        {
            throw new System.NotSupportedException();
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

        /// <summary>
        /// Agregar fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(FuenteEnergia entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(FuenteEnergia entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar repuesto recomendado
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Repuesto entity)
        {
            throw new System.NotSupportedException();
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
