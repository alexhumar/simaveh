using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorTipoEntidadReparadora
    /// </summary>
    public class ValidadorTipoEntidadReparadora : AbstractValidator<TipoEntidadReparadora>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorTipoEntidadReparadora()
        {
            RuleFor(x => x.Nombre)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.Descripcion)
                .MaximumLength(100);
        }
    }
}