using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Combustible
    /// </summary>
    public class FuenteEnergia : DomainMember<long>, IEntityChanger<Marca, long>, IEntityChanger<TipoFuenteEnergia, long>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; }

        /// <summary>
        /// Tipo de Fuente de Energia
        /// </summary>
        public virtual TipoFuenteEnergia TipoFuenteEnergia { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(", TipoFuenteEnergia?.ToString(), ") ", Marca?.ToString(), " ", Nombre);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as FuenteEnergia;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                    return (Id == item.Id) ||
                        (Nombre == item.Nombre && Marca.Equals(item.Marca) && TipoFuenteEnergia.Equals(item.TipoFuenteEnergia));
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(FuenteEnergia).FullName, Id.ToString()).GetHashCode();
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

        /// <summary>
        /// Agregar marca
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(Marca entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar marca
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(Marca entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Cambiar tipo fuente energia
        /// </summary>
        /// <param name="entity"></param>
        public void Cambiar(TipoFuenteEnergia entity)
        {
            if (entity != null)
                TipoFuenteEnergia = entity;
        }

        /// <summary>
        /// Agregar tipo fuente energia
        /// </summary>
        /// <param name="entity"></param>
        public void Agregar(TipoFuenteEnergia entity)
        {
            throw new System.NotSupportedException();
        }

        /// <summary>
        /// Quitar tipo fuente energia
        /// </summary>
        /// <param name="entity"></param>
        public void Quitar(TipoFuenteEnergia entity)
        {
            throw new System.NotSupportedException();
        }

        #endregion
    }
}
