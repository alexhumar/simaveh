namespace SiMaVeh.Domain.Models
{
    /// <summary>
    /// Fluido
    /// </summary>
    public class Fluido : TargetMantenimiento
    {
        #region overrides

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Concat("(Fluido) ", Nombre);
        }

        #endregion
    }
}
