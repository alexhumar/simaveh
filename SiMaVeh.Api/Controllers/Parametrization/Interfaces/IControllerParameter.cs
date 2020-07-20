using SiMaVeh.Api.ErrorManagement.Interfaces;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

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

        /// <summary>
        /// RelatedEntityChanger
        /// </summary>
        IRelatedEntityChanger RelatedEntityChanger { get; }

        /// <summary>
        /// RelatedEntityAdder
        /// </summary>
        IRelatedEntityAdder RelatedEntityAdder { get; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        IEntityTypeGetter EntityTypeGetter { get; }

        /// <summary>
        /// ErrorsBuilder
        /// </summary>
        IErrorsBuilder ErrorsBuilder { get; }
    }
}