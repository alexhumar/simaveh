
using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorPersona
    /// </summary>
    public class ValidadorPersona : AbstractValidator<Persona>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorPersona()
        {
            RuleFor(x => x.Apellido)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.NumeroDocumento)
                .NotNull()
                .NotEqual(string.Empty);
            // RuleFor(x => x.TipoDocumento)
            //     .NotNull();
            // RuleFor(x => x.Telefonos)
            //     .Must(x => x.Count > 0);
        }
    }
}