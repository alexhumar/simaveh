
using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorEntidadReparadora
    /// </summary>
    public class ValidadorEntidadReparadora : AbstractValidator<EntidadReparadora>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorEntidadReparadora()
        {
            // RuleFor(x => x.Direccion)
            //     .NotNull();
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            // RuleFor(x => x.ServiciosReparadores)
            //     .Must(y => y.Count > 0);
            // RuleFor(x => x.TipoEntidadReparadora)
            //     .NotNull();
        }
    }
}