using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
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
            MarcaCategoriaMarca = new HashSet<MarcaCategoriaMarca>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Marcas
        /// </summary>
        public virtual ISet<Marca> Marcas => MarcaCategoriaMarca.Select(m => m.Marca).ToHashSet();

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
            return obj is CategoriaMarca item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper()));
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(CategoriaMarca).FullName, Id.ToString()).GetHashCode();
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
                MarcaCategoriaMarca?.Add(new MarcaCategoriaMarca
                {
                    Marca = entity,
                    CategoriaMarca = this
                });
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
                var toRemove = MarcaCategoriaMarca?
                    .FirstOrDefault(r => r.CategoriaMarca == this && r.Marca == entity);
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
