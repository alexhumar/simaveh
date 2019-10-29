using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorPais
    /// </summary>
    public class ValidadorPais : AbstractValidator<Pais>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorPais() => RuleFor(x => x.Nombre).NotNull().NotEqual(string.Empty);
    }
}