using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Entidad Reparadora
    /// </summary>
    public class EntidadReparadora : DomainMember<long>, IEntityChanger<TipoEntidadReparadora, long>, ICollectionManager<ServicioReparador, long>,
        ICollectionManager<Reparador, long>, IEntityChanger<Direccion, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EntidadReparadora()
        {
            ServiciosReparadores = new List<ServicioReparador>();
            // Reparadores = new List<Reparador>();
            ReparadorEntidadReparadora = new List<ReparadorEntidadReparadora>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Tipo Entidad
        /// </summary>
        public virtual TipoEntidadReparadora TipoEntidadReparadora { get; protected set; }

        /// <summary>
        /// Servicios Mecanicos
        /// </summary>
        public virtual IList<ServicioReparador> ServiciosReparadores { get; protected set; }

        /// <summary>
        /// Mecanicos
        /// </summary>
        public virtual IList<Reparador> Reparadores
        {
            get { return ReparadorEntidadReparadora.Select(r => r.Reparador).ToList(); }
        }

        /// <summary>
        /// Direccion
        /// </summary>
        public virtual Direccion Direccion { get; set; }

        #region relations

        /// <summary>
        /// Relacion Reparador-EntidadReparadora
        /// </summary>
        public virtual IList<ReparadorEntidadReparadora> ReparadorEntidadReparadora { get; }

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
            var item = obj as EntidadReparadora;

            if (item == null)
                return false;
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
        public void Cambiar(TipoEntidadReparadora entity)
        {
            if (entity != null)
                TipoEntidadReparadora = entity;
        }

        /// <summary>
        /// Cambiar direccion
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Direccion entity)
        {
            if (entity != null)
                Direccion = entity;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(ServicioReparador entity)
        {
            if (entity != null)
            {
                ServiciosReparadores?.Add(entity);
                entity.EntidadReparadora = this;
            }
        }

        /// <summary>
        /// Quitar servicio reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(ServicioReparador entity)
        {
            if (entity != null)
            {
                ServiciosReparadores?.Remove(entity);
                if ((bool)entity.EntidadReparadora?.Equals(this))
                    entity.EntidadReparadora = null;
            }
        }

        /// <summary>
        /// Agregar reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Reparador entity)
        {
            if (entity != null)
            {
                // Reparadores?.Add(entity);
                // entity.EntidadesReparadoras?.Add(this);
                ReparadorEntidadReparadora?.Add(new ReparadorEntidadReparadora
                {
                    Reparador = entity,
                    EntidadReparadora = this
                });
            }
        }

        /// <summary>
        /// Quitar reparador
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Reparador entity)
        {
            if (entity != null)
            {
                // Reparadores?.Remove(entity);
                // entity.EntidadesReparadoras?.Remove(this);
                var toRemove = ReparadorEntidadReparadora?
                    .Where(r => r.Reparador == entity && r.EntidadReparadora == this)
                    .FirstOrDefault();
                if (toRemove != null)
                    ReparadorEntidadReparadora.Remove(toRemove);
            }
        }

        #endregion
    }
}
