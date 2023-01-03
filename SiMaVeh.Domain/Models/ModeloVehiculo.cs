﻿using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Modelo Vehiculo
    /// </summary>
    public class ModeloVehiculo : DomainMember<long>,
        IEntityChanger<GrupoModelo, long, ModeloVehiculo, long>,
        IEntityChanger<EquipamientoAirbags, string, ModeloVehiculo, long>,
        IEntityChanger<TipoFuenteEnergia, long, ModeloVehiculo, long>,
        ICollectionManager<Aceite, long, ModeloVehiculo, long>,
        ICollectionManager<FuenteEnergia, long, ModeloVehiculo, long>,
        ICollectionManager<Repuesto, long, ModeloVehiculo, long>,
        ICollectionManager<PresionNeumatico, long, ModeloVehiculo, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ModeloVehiculo()
        {
            RepuestosRecomendados = new HashSet<Repuesto>();
            PresionesNeumaticoRecomendadas = new HashSet<PresionNeumatico>();
            FuentesEnergiaRecomendadas = new HashSet<FuenteEnergia>();
            AceitesRecomendados = new HashSet<Aceite>();
        }

        /// <summary>
        /// Grupo Modelo
        /// </summary>
        public virtual GrupoModelo GrupoModelo { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Version
        /// </summary>
        public virtual string Version { get; set; }

        /// <summary>
        /// Airbags
        /// </summary>
        public virtual EquipamientoAirbags Airbags { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Tipo de Fuente de Energia
        /// </summary>
        public virtual TipoFuenteEnergia TipoFuenteEnergia { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Aceites Recomendados
        /// </summary>
        public virtual ISet<Aceite> AceitesRecomendados { get; init; }

        /// <summary>
        /// Fuentes Energia Recomendadas
        /// </summary>
        public virtual ISet<FuenteEnergia> FuentesEnergiaRecomendadas { get; init; }

        /// <summary>
        /// Repuestos Recomendados
        /// </summary>
        public virtual ISet<Repuesto> RepuestosRecomendados { get; init; }

        /// <summary>
        /// Presiones de Neumatico Recomendadas
        /// </summary>
        public virtual ISet<PresionNeumatico> PresionesNeumaticoRecomendadas { get; init; }

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
            return obj is ModeloVehiculo item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (GrupoModelo.Equals(item.GrupoModelo) && Version.ToUpper() == item.Version.ToUpper()));
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

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar presion neumatico recomendada
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Agregar(PresionNeumatico entity)
        {
            if (entity != null)
            {
                PresionesNeumaticoRecomendadas.Add(entity);
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
            if (entity != null)
            {
                var toRemove = PresionesNeumaticoRecomendadas.FirstOrDefault(p => p == entity);
                if (toRemove != null)
                {
                    PresionesNeumaticoRecomendadas.Remove(toRemove);
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
                RepuestosRecomendados.Add(entity);
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
                var toRemove = RepuestosRecomendados.FirstOrDefault(r => r == entity);
                if (toRemove != null)
                {
                    RepuestosRecomendados.Remove(toRemove);
                }
            }

            return this;
        }

        /// <summary>
        /// Agregar fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Agregar(FuenteEnergia entity)
        {
            if (entity != null)
            {
                FuentesEnergiaRecomendadas.Add(entity);
            }

            return this;
        }

        /// <summary>
        /// Quitar fuente energia recomendada
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Quitar(FuenteEnergia entity)
        {
            if (entity != null)
            {
                var toRemove = FuentesEnergiaRecomendadas.FirstOrDefault(f => f == entity);
                if (toRemove != null)
                {
                    FuentesEnergiaRecomendadas.Remove(toRemove);
                }
            }

            return this;
        }

        /// <summary>
        /// Agregar aceite recomendado
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Agregar(Aceite entity)
        {
            if (entity != null)
            {
                AceitesRecomendados.Add(entity);
            }

            return this;
        }

        /// <summary>
        /// Quitar aceite recomendado
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ModeloVehiculo Quitar(Aceite entity)
        {
            if (entity != null)
            {
                var toRemove = AceitesRecomendados.FirstOrDefault(a => a == entity);
                if (toRemove != null)
                {
                    AceitesRecomendados.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
