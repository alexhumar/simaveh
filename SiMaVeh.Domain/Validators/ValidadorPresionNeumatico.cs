using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorPresionNeumatico
    /// </summary>
    public class ValidadorPresionNeumatico : AbstractValidator<PresionNeumatico>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorPresionNeumatico()
        {
            // RuleFor(x => x.ModeloVehiculo)
            //     .NotNull();
            // RuleFor(x => x.Neumatico)
            //     .NotNull();
            RuleFor(x => x.RuedasDelanteras)
                .GreaterThan(0);
            RuleFor(x => x.RuedasTraseras)
                .GreaterThan(0);
        }
    }
}