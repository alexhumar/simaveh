using SiMaVeh.Api.Controllers.Parametrization.Interfaces;
using SiMaVeh.Api.Model.Interfaces;
using SiMaVeh.DataAccess.Model;
using SiMaVeh.Domain.BusinessLogic.Entities.Interfaces;

namespace SiMaVeh.Api.Controllers.Parametrization
{
    /// <summary>
    /// Singleton que encapsula los objetos necesarios para inyectar en el GenericController
    /// </summary>
    internal class ControllerParameter : IControllerParameter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        /// <param name="relatedEntityGetter"></param>
        /// <param name="entityTypeGetter"></param>
        public ControllerParameter(SiMaVehContext context,
            IRelatedEntityGetter relatedEntityGetter,
            IEntityTypeGetter entityTypeGetter)
        {
            Context = context;
            RelatedEntityGetter = relatedEntityGetter;
            EntityTypeGetter = entityTypeGetter;
        }

        /// <summary>
        /// Context
        /// </summary>
        public SiMaVehContext Context { get; set; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        public IRelatedEntityGetter RelatedEntityGetter { get; set; }

        /// <summary>
        /// RelatedEntityGetter
        /// </summary>
        public IEntityTypeGetter EntityTypeGetter { get; set; }
    }
}