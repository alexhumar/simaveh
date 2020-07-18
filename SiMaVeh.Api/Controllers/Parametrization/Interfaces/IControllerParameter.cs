using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Api.Controllers.Parametrization.Interfaces
{
    /// <summary>
    /// Interface IControllerParameter
    /// </summary>
    internal interface IControllerParameter
    {
        /// <summary>
        /// Context
        /// </summary>
        SiMaVehContext Context { get; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        IRelatedEntityGetter RelatedEntityGetter { get; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        IEntityTypeGetter EntityTypeGetter { get; }
    }
}