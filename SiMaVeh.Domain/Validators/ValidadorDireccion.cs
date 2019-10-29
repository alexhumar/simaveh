
using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorDireccion
    /// </summary>
    public class ValidadorDireccion : AbstractValidator<Direccion>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorDireccion()
        {
            RuleFor(x => x.Calle)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.NumeroCalle)
                .GreaterThan(0);
            // RuleFor(x => x.Localidad)
            //     .NotNull();
        }
    }
}