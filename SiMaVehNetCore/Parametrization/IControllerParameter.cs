using SiMaVeh.DataAccess;
using SiMaVeh.Helpers;

namespace SiMaVeh.Parametrization
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