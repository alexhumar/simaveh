using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Entidad Reparadora
    /// </summary>
    public class EntidadReparadora : DomainMember<long>,
        IEntityChanger<TipoEntidadReparadora, long, EntidadReparadora, long>,
        IEntityChanger<Direccion, long, EntidadReparadora, long>,
        ICollectionManager<ServicioReparador, long, EntidadReparadora, long>,
        ICollectionManager<Reparador, long, EntidadReparadora, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EntidadReparadora()
        {
            ServiciosReparadores = new HashSet<ServicioReparador>();
            ReparadorEntidadReparadora = new HashSet<ReparadorEntidadReparadora>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Tipo Entidad
        /// </summary>
        public virtual TipoEntidadReparadora TipoEntidadReparadora { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Servicios Mecanicos
        /// </summary>
        public virtual ISet<ServicioReparador> ServiciosReparadores { get; protected set; }

        /// <summary>
        /// Mecanicos
        /// </summary>
        public virtual ISet<Reparador> Reparadores
        {
            get { return ReparadorEntidadReparadora.Select(r => r.Reparador).ToHashSet(); }
        }

        /// <summary>
        /// Direccion
        /// </summary>
        public virtual Direccion Direccion { get; set; /*el set no puede ser protected porque rompe OData*/ }

        #region relations

        //PRUEBA ARH - PROBAR PROTECTED!
        /// <summary>
        /// Relacion Reparador-EntidadReparadora
        /// </summary>
        public virtual ISet<ReparadorEntidadReparadora> ReparadorEntidadReparadora { get; }

        #endregion

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(", TipoEntidadReparadora?.ToString(), ") ", Nombre);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is EntidadReparadora item))
            {
                return false;
            }
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                    return (Id == item.Id) || (Nombre == item.Nombre && TipoEntidadReparadora.Equals(item.TipoEntidadReparadora));
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(EntidadReparadora).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar tipo entidad reparadora
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public EntidadReparadora Cambiar(TipoEntidadReparadora entity)
        {
            if (entity != null)
            {
                TipoEntidadReparadora = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar direccion
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public EntidadReparadora Cambiar(Direccion entity)
        {
            if (entity != null)
            {
                Direccion = entity;
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public EntidadReparadora Agregar(ServicioReparador entity)
        {
            if ((entity != null) && !ServiciosReparadores.Contains(entity))
            {
                ServiciosReparadores.Add(entity);
                entity.Cambiar(this);
            }

            return this;
        }

        /// <summary>
        /// Quitar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public EntidadReparadora Quitar(ServicioReparador entity)
        {
            if ((entity != null) && ServiciosReparadores.Contains(entity))
            {
                ServiciosReparadores.Remove(entity);
                if ((bool)entity.EntidadReparadora?.Equals(this))
                {
                    entity.Cambiar((EntidadReparadora)null);
                }
            }

            return this;
        }

        /// <summary>
        /// Agregar reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public EntidadReparadora Agregar(Reparador entity)
        {
            if (entity != null)
            {
                ReparadorEntidadReparadora?.Add(new ReparadorEntidadReparadora
                {
                    Reparador = entity,
                    EntidadReparadora = this
                });
            }

            return this;
        }

        /// <summary>
        /// Quitar reparador
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public EntidadReparadora Quitar(Reparador entity)
        {
            if (entity != null)
            {
                var toRemove = ReparadorEntidadReparadora?
                    .FirstOrDefault(r => r.Reparador == entity && r.EntidadReparadora == this);
                if (toRemove != null)
                {
                    ReparadorEntidadReparadora.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
