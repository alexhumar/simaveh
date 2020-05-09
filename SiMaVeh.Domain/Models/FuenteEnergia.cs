using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Combustible
    /// </summary>
    public class FuenteEnergia : DomainMember<long>,
        IEntityChanger<Marca, long, FuenteEnergia, long>,
        IEntityChanger<TipoFuenteEnergia, long, FuenteEnergia, long>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; protected set; }

        /// <summary>
        /// Tipo de Fuente de Energia
        /// </summary>
        public virtual TipoFuenteEnergia TipoFuenteEnergia { get; protected set; }

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
        /// <returns></returns>
        public FuenteEnergia Cambiar(Marca entity)
        {
            if (entity != null)
                Marca = entity;

            return this;
        }

        /// <summary>
        /// Cambiar tipo fuente energia
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public FuenteEnergia Cambiar(TipoFuenteEnergia entity)
        {
            if (entity != null)
                TipoFuenteEnergia = entity;

            return this;
        }

        #endregion
    }
}
