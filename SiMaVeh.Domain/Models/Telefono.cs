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
        public virtual TipoTelefono TipoTelefono { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Persona
        /// </summary>
        public virtual Persona Persona { get; set; /*el set no puede ser protected porque rompe OData*/ }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(", TipoTelefono?.ToString(), ") ", Numero);
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
            if (Persona != entity)
            {
                Persona?.Quitar(this);
                Persona = entity;
                entity?.Agregar(this);
            }

            return this;
        }

        #endregion
    }
}
