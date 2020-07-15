using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
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
            MarcaCategoriaMarca = new HashSet<MarcaCategoriaMarca>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Categorías
        /// </summary>
        public virtual ISet<CategoriaMarca> Categorias => MarcaCategoriaMarca.Select(m => m.CategoriaMarca).ToHashSet();

        #region relations

        /// <summary>
        /// Relacion Marca-CategoriaMarca
        /// </summary>
        public virtual ISet<MarcaCategoriaMarca> MarcaCategoriaMarca { get; }

        #endregion

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
            return obj is Marca item && (ReferenceEquals(this, item) || (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper()));
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
                MarcaCategoriaMarca?.Add(new MarcaCategoriaMarca
                {
                    Marca = this,
                    CategoriaMarca = entity
                });
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
                var toRemove = MarcaCategoriaMarca?
                    .FirstOrDefault(r => r.Marca == this && r.CategoriaMarca == entity);
                if (toRemove != null)
                {
                    MarcaCategoriaMarca.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
