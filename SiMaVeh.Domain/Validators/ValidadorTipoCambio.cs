using FluentValidation;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.Domain.Validators
{
	/// <summary>
    /// ValidadorTipoCambio
    /// </summary>
    public class ValidadorTipoCambio : AbstractValidator<TipoCambio>
	{
        /// <summary>
        /// Constructor
        /// </summary>
        public ValidadorTipoCambio()
        {
            RuleFor(x => x.CoeficienteCambio)
                .GreaterThan(0);
            RuleFor(x => x.Fecha)
                .NotNull();
            // RuleFor(x => x.MonedaOrigen)
            //     .NotNull()
            //     .NotEqual(y => y.MonedaDestino);
            // RuleFor(x => x.MonedaDestino)
            //     .NotNull()
            //     .NotEqual(y => y.MonedaOrigen);
        }
    }
}