using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Telefono
    /// </summary>
    public class Telefono : DomainMember<long>,
        IEntityChanger<TipoTelefono, long, Telefono, long>,
        IEntityChanger<Persona, long, Telefono, long>
    {
        /// <summary>
        /// Numero
        /// </summary>
        public virtual int Numero { get; set; }

        /// <summary>
        /// Tipo
        /// </summary>
        public virtual TipoTelefono TipoTelefono { get; protected set; }

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
            if (!(obj is Telefono item))
            {
                return false;
            }
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
        /// <returns></returns>
        public Telefono Cambiar(TipoTelefono entity)
        {
            if (entity != null)
            {
                TipoTelefono = entity;
            }

            return this;
        }

        /// <summary>
        /// Cambiar persona
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Telefono Cambiar(Persona entity)
        {
            //PRUEBA ARH - REVISAR ESTO
            Persona?.Quitar(this);
            entity?.Agregar(this);

            return this;
        }

        #endregion
    }
}
