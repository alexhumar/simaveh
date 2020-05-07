using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Grupo Modelo
    /// </summary>
    public class GrupoModelo : DomainMember<long>, IEntityChanger<Marca, long>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Marca?.ToString(), " ", Nombre);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as GrupoModelo;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                    return (Id == item.Id) || (Nombre == item.Nombre && Marca.Equals(item.Marca));
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(GrupoModelo).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar marca
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Marca entity)
        {
            if (entity != null)
                Marca = entity;
        }

        #endregion
    }
}
