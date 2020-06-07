using SiMaVeh.Domain.Enums;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Marca
    /// </summary>
    public class Marca : DomainMember<long>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public virtual string Descripcion { get; set; }

        /// <summary>
        /// Categoría
        /// </summary>
        public virtual CategoriaMarca Categoria { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nombre;
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Marca item))
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper() && Categoria == item.Categoria);
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Marca).FullName, Id.ToString()).GetHashCode();
        }

        #endregion
    }
}
