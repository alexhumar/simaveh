using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorAceite
    /// </summary>
    public class ValidadorAceite : AbstractValidator<Aceite>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorAceite()
        {
            Include(new ValidadorTargetMantenimiento());

            RuleFor(x => x.ViscosidadSAEAltaTemperatura)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.ViscosidadSAEBajaTemperatura)
                .GreaterThanOrEqualTo(0);
        }
    }
}