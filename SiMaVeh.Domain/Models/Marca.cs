using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Marca
    /// </summary>
    public class Marca : DomainMember<long>,
        ICollectionManager<CategoriaMarca, long, Marca, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Marca()
        {
            Categorias = new HashSet<CategoriaMarca>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Categorías
        /// </summary>
        public virtual ISet<CategoriaMarca> Categorias { get; init; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nombre;
        }

        #endregion

        #region ICollectionManager

        /// <summary>
        /// Agregar categoria
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Marca Agregar(CategoriaMarca entity)
        {
            if (entity != null)
            {
                Categorias.Add(entity);
            }

            return this;
        }

        /// <summary>
        /// Quitar categoria
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Marca Quitar(CategoriaMarca entity)
        {
            if (entity != null)
            {
                var toRemove = Categorias.FirstOrDefault(c => c == entity);
                if (toRemove != null)
                {
                    Categorias.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
