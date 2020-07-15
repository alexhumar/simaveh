using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;

namespace SiMaVeh.Api.Controllers.Parametrization.Interfaces
{
    /// <summary>
    /// Interface IControllerParameter
    /// </summary>
    public interface IControllerParameter
    {
        /// <summary>
        /// Context
        /// </summary>
        SiMaVehContext Context { get; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        IRelatedEntityGetter RelatedEntityGetter { get; }
    }
}