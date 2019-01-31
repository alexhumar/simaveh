using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorProvincia
    /// </summary>
    public class ValidadorProvincia : AbstractValidator<Provincia>
	{

        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorProvincia() => RuleFor(x => x.Nombre).NotNull().NotEqual(string.Empty);
    }
}