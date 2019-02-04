using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorTipoFuenteEnergia
    /// </summary>
    public class ValidadorTipoFuenteEnergia : AbstractValidator<TipoFuenteEnergia>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorTipoFuenteEnergia()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.Descripcion)
                .MaximumLength(100);
        }
    }
}