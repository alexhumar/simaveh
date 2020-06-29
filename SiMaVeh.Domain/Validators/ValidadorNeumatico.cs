using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
    /// <summary>
    /// ValidadorNeumatico
    /// </summary>
    public class ValidadorNeumatico : AbstractValidator<Neumatico>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorNeumatico()
        {
            //El resto de las properties son nullables
            RuleFor(x => x.AnchuraSeccionalNominal)
                .GreaterThan(0);
            RuleFor(x => x.ConstruccionCarcasa)
                .NotNull()
                .IsInEnum();
            RuleFor(x => x.DiametroLLanta)
                .GreaterThan(0);
            RuleFor(x => x.IndiceCarga)
                .GreaterThan(0);
            RuleFor(x => x.IndiceVelocidad)
                .NotNull()
                .NotEqual(string.Empty);
            // RuleFor(x => x.Marca)
            //     .NotNull();
            RuleFor(x => x.Modelo)
                .NotNull()
                .NotEqual(string.Empty);
            RuleFor(x => x.Tipo)
                .NotNull()
                .IsInEnum();
        }
    }
}