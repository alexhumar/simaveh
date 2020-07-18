using SiMaVeh.Domain.Enums;
using SiMaVeh.Domain.Enums.Parsers;
using SiMaVeh.Domain.Enums.Parsers.Interfaces;
using SiMaVeh.Domain.Models.Interfaces;

namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Neumatico
    /// </summary>
    public class Neumatico : DomainMember<long>,
        IEntityChanger<Marca, long, Neumatico, long>
    {
        private readonly IEnumParser<TipoVehiculoNeumatico> tipoVehiculoNeumaticoParser;
        private readonly IEnumParser<ConstruccionCarcasaNeumatico> construccionCarcasaNeumaticoParser;

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
        public virtual TipoVehiculoNeumatico Tipo { get; set; }

        /// <summary>
        /// Construccion Carcasa
        /// </summary>
        public virtual ConstruccionCarcasaNeumatico ConstruccionCarcasa { get; set; }

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

        /// <summary>
        /// Constructor
        /// </summary>
        public Neumatico()
        {
            tipoVehiculoNeumaticoParser = new TipoVehiculoNeumaticoParser();
            construccionCarcasaNeumaticoParser = new ConstruccionCarcasaNeumaticoParser();
        }

        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat(Marca?.ToString(), Modelo, tipoVehiculoNeumaticoParser.ToString(Tipo),
                AnchuraSeccionalNominal, "/", RelacionAnchoAlto?.ToString(), construccionCarcasaNeumaticoParser.ToString(ConstruccionCarcasa),
                DiametroLLanta, " ", IndiceCarga, IndiceVelocidad);
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Neumatico item &&
                (ReferenceEquals(this, item) || (Id == item.Id) || (Marca.Equals(Marca) && Modelo.ToUpper() == item.Modelo.ToUpper()));
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
