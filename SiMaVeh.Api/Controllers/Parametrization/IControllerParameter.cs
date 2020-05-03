using SiMaVeh.DataAcces.Model;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Api.Controllers.Parametrization
{
    /// <summary>
    /// Interface IControllerParameter
    /// </summary>
    public interface IControllerParameter
    {
        /// <summary>
        /// Context
        /// </summary>
        SiMaVehContext Context { get; set; }

        /// <summary>
        /// EntityGetter
        /// </summary>
        IEntityGetter EntityGetter { get; set; }
    }
}