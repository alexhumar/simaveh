using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Persona
    /// </summary>
    public abstract class Persona : DomainMember<long>,
        IEntityChanger<TipoDocumento, long, Persona, long>,
        ICollectionManager<Telefono, long, Persona, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Persona()
        {
            Telefonos = new HashSet<Telefono>();
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
        public virtual TipoDocumento TipoDocumento { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Telefonos
        /// </summary>
        public virtual ISet<Telefono> Telefonos { get; protected set; }

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
        /// <returns></returns>
        public Persona Cambiar(TipoDocumento entity)
        {
            if (entity != null)
            {
                TipoDocumento = entity;
            }

            return this;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar telefono
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Persona Agregar(Telefono entity)
        {
            if ((entity != null) && !Telefonos.Contains(entity))
            {
                Telefonos.Add(entity);
                entity.Cambiar(this);
            }


            return this;
        }

        /// <summary>
        /// Quitar telefono
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Persona Quitar(Telefono entity)
        {
            if ((entity != null) && Telefonos.Contains(entity))
            {
                Telefonos.Remove(entity);
                if ((bool)entity.Persona?.Equals(this))
                {
                    entity.Cambiar((Persona)null);
                }
            }

            return this;
        }

        #endregion
    }
}
