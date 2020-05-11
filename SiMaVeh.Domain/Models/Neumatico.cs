using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Neumatico
    /// </summary>
    public class Neumatico : DomainMember<long>,
        IEntityChanger<Marca, long, Neumatico, long>
    {
        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; /*el set no puede ser protected porque rompe OData*/ }

        /// <summary>
        /// Modelo
        /// </summary>
        public virtual string Modelo { get; set; }

        /// <summary>
        /// Tipo
        /// </summary>
        public virtual ETipoVehiculoNeumatico Tipo { get; set; }

        /// <summary>
        /// Construccion Carcasa
        /// </summary>
        public virtual EConstruccionCarcasaNeumatico ConstruccionCarcasa { get; set; }

        /// <summary>
        /// Relación de aspecto entre la altura del perfil y la anchura del neumático como porcentaje
        /// Si no esta presente, por defecto es 82.
        /// Si supera los 200, entonces es el diámetro total del neumático en milímetros.
        /// </summary>
        public virtual int? RelacionAnchoAlto { get; set; }

        /// <summary>
        /// Diámetro en pulgadas de la llanta para la que el neumático está diseñado específicamente
        /// </summary>
        public virtual int DiametroLLanta { get; set; }

        /// <summary>
        /// Anchura Seccional Nominal en mm
        /// </summary>
        public virtual int AnchuraSeccionalNominal { get; set; }

        /// <summary>
        /// Indice de Carga
        /// </summary>
        public virtual int IndiceCarga { get; set; }

        /// <summary>
        /// Indice Velocidad
        /// </summary>
        public virtual string IndiceVelocidad { get; set; }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Marca?.ToString(), Modelo, TipoVehiculoNeumaticoParser.ToString(Tipo),
                AnchuraSeccionalNominal, "/", RelacionAnchoAlto?.ToString(), ConstruccionCarcasaNeumaticoParser.ToString(ConstruccionCarcasa),
                DiametroLLanta, " ", IndiceCarga, IndiceVelocidad);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Neumatico;

            if (item == null)
                return false;
            else
            {
                if (ReferenceEquals(this, item))
                    return true;
                else
                {
                    return (Id == item.Id) ||
                        (Marca.Equals(Marca) && Modelo.ToUpper() == item.Modelo.ToUpper());
                }
            }
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return string.Concat(typeof(Neumatico).FullName, Id.ToString()).GetHashCode();
        }

        #endregion

        #region IEntityChanger

        /// <summary>
        /// Cambiar marca
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Neumatico Cambiar(Marca entity)
        {
            if (entity != null)
            {
                Marca = entity;
            }

            return this;
        }

        #endregion
    }
}
