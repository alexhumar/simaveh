using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorTelefono
    /// </summary>
    public class ValidadorTelefono : AbstractValidator<Telefono>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorTelefono()
        {
            RuleFor(x => x.Numero)
                .GreaterThan(0); //ESTO HABRIA QUE MEJORARLO PARA QUE VALIDE FORMATOS DE TELEFONO.
            // RuleFor(x => x.Persona)
            //     .NotNull();
            // RuleFor(x => x.TipoTelefono)
            //     .NotNull();
        }
    }
}