using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Telefono
    /// </summary>
    public class Telefono : DomainMember<long>, IEntityChanger<TipoTelefono, long>, IEntityChanger<Persona, long>
    {
        /// <summary>
        /// Numero
        /// </summary>
        public virtual int Numero { get; set; }

        /// <summary>
        /// Tipo
        /// </summary>
        public virtual TipoTelefono TipoTelefono { get; set; }

        /// <summary>
        /// Persona
        /// </summary>
        public virtual Persona Persona { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(", TipoTelefono?.ToString(), ") ", Numero);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Telefono;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) || (Numero == item.Numero && TipoTelefono.Equals(item.TipoTelefono));
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Telefono).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar tipo telefono
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(TipoTelefono entity)
        {
            if (entity != null)
                TipoTelefono = entity;
        }

        /// <summary>
        /// Agregar tipo telefono
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(TipoTelefono entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar tipo telefono
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(TipoTelefono entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar persona
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Persona entity)
        {
            Persona?.Quitar(this);
            entity?.Agregar(this);
        }

        /// <summary>
        /// Agregar persona
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Persona entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar persona
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Persona entity)
        {
            throw new System.NotSupportedException();
        }

        #endregion
    }
}
