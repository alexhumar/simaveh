using SiMaVeh.Domain.Models.Interfaces;
using SiMaVeh.Domain.Models.Relations;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Kit
    /// </summary>
    public class Kit : Recambio,
        ICollectionManager<Recambio, long, Kit, long>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public virtual string Descripcion { get; set; }

        //TODO: el get/expand de esta relacion no esta funcionando. Debe haber un problema con que se trate de una clase abstracta
        //ya que cuando realizo las modificaciones para que esta coleccion devuelva repuestos, funciona bien.
        //El EntitySet KitRecambio viene sin registros.
        /// <summary>
        /// Recambios
        /// </summary>
        public virtual ISet<Recambio> Recambios => KitRecambio.Select(k => k.Recambio).ToHashSet();

        #region overrides

        /// <summary>
        /// GetRepuestos
        /// </summary>
        /// <returns>Repuesto o Lista de repuestos para el caso de los kits</returns>
        public override ISet<Repuesto> GetRepuestos()
        {
            var repuestos = new HashSet<Repuesto>();

            foreach (Recambio recambio in Recambios)
            {
                repuestos = repuestos.Concat(recambio.GetRepuestos()).ToHashSet();
            }

            return repuestos;
        }

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
            var item = obj as Kit;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) || (Nombre.ToUpper() == item.Nombre.ToUpper());
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Kit).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Agregar recambio
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Kit Agregar(Recambio entity)
        {
            if (entity != null)
            {
                KitRecambio?.Add(new KitRecambio
                {
                    Recambio = entity,
                    Kit = this
                });
            }

            return this;
        }

        /// <summary>
        /// Quitar recambio
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Kit Quitar(Recambio entity)
        {
            if (entity != null)
            {
                var toRemove = KitRecambio?
                    .FirstOrDefault(r => r.Recambio == entity && r.Kit == this);
                if (toRemove != null)
                {
                    KitRecambio.Remove(toRemove);
                }
            }

            return this;
        }

        #endregion
    }
}
