using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorTipoDocumento
    /// </summary>
    public class ValidadorTipoDocumento : AbstractValidator<TipoDocumento>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorTipoDocumento()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.Descripcion)
                .MaximumLength(100);
        }
    }
}