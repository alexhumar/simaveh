namespace SiMaVeh.Domain.Models.Relations
{
    /// <summary>
    /// Relacion many-to-many Marca-CategoriaMarca
    /// </summary>
    public class MarcaCategoriaMarca
    {
        /// <summary>
        /// Id. Categoria Marca
        /// </summary>
        public virtual long CategoriaMarcaId { get; set; }

        /// <summary>
        /// CategoriaMarca
        /// </summary>
        public virtual CategoriaMarca CategoriaMarca { get; set; }

        /// <summary>
        /// Id. Marca
        /// </summary>
        public virtual long MarcaId { get; set; }

        /// <summary>
        /// Marca
        /// </summary>
        public virtual Marca Marca { get; set; }
    }
}
