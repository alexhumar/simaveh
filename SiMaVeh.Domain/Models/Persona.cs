using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Persona
    /// </summary>
    public abstract class Persona : DomainMember<long>, IEntityChanger<TipoDocumento, long>, IEntityChanger<Telefono, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Persona()
        {
            Telefonos = new List<Telefono>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Apellido
        /// </summary>
        public virtual string Apellido { get; set; }

        /// <summary>
        /// Numero Documento
        /// </summary>
        public virtual string NumeroDocumento { get; set; }

        /// <summary>
        /// Tipo Documento
        /// </summary>
        public virtual TipoDocumento TipoDocumento { get; set; }

        /// <summary>
        /// Telefonos
        /// </summary>
        public virtual IList<Telefono> Telefonos { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Apellido, ", ", Nombre);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Persona;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) || (NumeroDocumento == item.NumeroDocumento);
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public abstract override int GetHashCode();

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar tipo documento
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(TipoDocumento entity)
        {
            if (entity != null)
                TipoDocumento = entity;
        }

        /// <summary>
        /// Agregar tipo documento
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(TipoDocumento entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar tipo documento
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(TipoDocumento entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar telefono
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Telefono entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Agregar telefono
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Telefono entity)
        {
            if (entity != null)
            {
                Telefonos?.Add(entity);
                entity.Persona = this;
            }
        }

        /// <summary>
        /// Quitar telefono
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Telefono entity)
        {
            if (entity != null)
            {
                Telefonos?.Remove(entity);
                if ((bool)entity.Persona?.Equals(this))
                    entity.Persona = null;
            }
        }

        #endregion
    }
}
