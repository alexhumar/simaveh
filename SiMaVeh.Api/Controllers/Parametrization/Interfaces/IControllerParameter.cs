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
        /// RelatedEntityChanger
        /// </summary>
        IODataRelatedEntityChanger RelatedEntityChanger { get; }

        /// <summary>
        /// RelatedEntityAdder
        /// </summary>
        IODataRelatedEntityAdder RelatedEntityAdder { get; }

        /// <summary>
        /// RelatedEntityRemover
        /// </summary>
        IODataRelatedEntityRemover RelatedEntityRemover { get; }

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