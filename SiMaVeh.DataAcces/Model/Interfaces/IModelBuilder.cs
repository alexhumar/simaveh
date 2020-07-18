using Microsoft.OData.Edm;

namespace SiMaVeh.DataAccess.Model.Interfaces
{
    public interface IModelBuilder
    {
        /// <summary>
        /// Obtiene el modelo Edm
        /// </summary>
        /// <returns></returns>
        IEdmModel GetEdmModel();
    }
}
