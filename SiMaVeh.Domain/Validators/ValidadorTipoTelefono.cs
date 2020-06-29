using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorTipoTelefono
    /// </summary>
    public class ValidadorTipoTelefono : AbstractValidator<TipoTelefono>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorTipoTelefono()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.Descripcion)
                .MaximumLength(100);
        }
    }
}