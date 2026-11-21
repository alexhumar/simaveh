using SiMaVeh.Domain.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Categoria Marca
    /// </summary>
    public class CategoriaMarca : DomainMember<long>,
        ICollectionManager<Marca, long, CategoriaMarca, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CategoriaMarca()
        {
            Marcas = new HashSet<Marca>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Marcas
        /// </summary>
        public virtual ISet<Marca> Marcas { get; init; }

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
        /// Agregar marca
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public CategoriaMarca Agregar(Marca entity)
        {
            if (entity != null)
            {
                Marcas.Add(entity);
            }

            return this;
        }

        /// <summary>
        /// Quitar marca
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public CategoriaMarca Quitar(Marca entity)
        {
            if (entity != null)
            {
                var toRemove = Marcas.FirstOrDefault(m => m == entity);
                if (toRemove != null)
                {
                    Marcas.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
