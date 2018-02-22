using SiMaVeh.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Kit
    /// </summary>
    public class Kit : Recambio, IEntityChanger<Recambio, long>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Kit()
        {
            Recambios = new List<Recambio>();
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        public virtual string Descripcion { get; set; }

        /// <summary>
        /// Recambios
        /// </summary>
        public virtual IList<Recambio> Recambios { get; set; }

        #region overrides

        /// <summary>
        /// GetRepuestos
        /// </summary>
        /// <returns>Repuesto o Lista de repuestos para el caso de los kits</returns>
        public override IList<Repuesto> GetRepuestos()
        {
            var repuestos = new List<Repuesto>();

            foreach (Recambio recambio in Recambios)
                repuestos = repuestos.Concat(recambio.GetRepuestos()).ToList();

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
        /// Cambiar recambio
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(Recambio entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Agregar recambio
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Recambio entity)
        {
            if (entity != null)
            {
                Recambios?.Add(entity);
                entity.Kits.Add(this);
            }
        }

        /// <summary>
        /// Quitar recambio
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Recambio entity)
        {
            if (entity != null)
            {
                Recambios?.Remove(entity);
                entity.Kits.Remove(this);
            }
        }

        

        #endregion
    }
}
