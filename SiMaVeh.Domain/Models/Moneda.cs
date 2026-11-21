namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Moneda - su ID almacena el código ISO alfabético de la moneda
    /// </summary>
    public class Moneda : DomainMember<string>
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public virtual string Nombre { get; set; }

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
    }
}
