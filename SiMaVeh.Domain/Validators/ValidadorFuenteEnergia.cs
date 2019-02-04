
using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorFuenteEnergia
    /// </summary>
    public class ValidadorFuenteEnergia : AbstractValidator<FuenteEnergia>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorFuenteEnergia()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            // RuleFor(x => x.Marca)
            //     .NotNull();
            // RuleFor(x => x.TipoFuenteEnergia)
            //     .NotNull();
        }
    }
}